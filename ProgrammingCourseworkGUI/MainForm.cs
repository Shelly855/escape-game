using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ProgrammingCourseworkGUI
{
    // Review: 'mainForm' doesn't follow standard naming conventions for classes (should be 'MainForm')
    public partial class mainForm : Form
    {
        // Other forms
        private tutorialForm tutorialForm;
        private arcadeForm arcadeForm;

        // To track status of puzzles and events
        private bool arcadePuzzleSolved = false;
        private bool fortuneTold = false; //for PickUpBox
        private bool padlockUnlocked = false;

        // List to contain items collected by player
        private List<Inventory> inventory = new List<Inventory>();

        // Holds health and energy stats
        private PlayerStats playerOne = new PlayerStats();

        // For the 3-digit padlock code
        private int padlockCodeOne, padlockCodeTwo, padlockCodeThree;

        // Declaring items
        private Inventory torch, bronzeKey, goldenBell, redCoin, orangeJewel, blueJewel, blackJewel, extractOfText,
                         greatMisfortuneSlip, misfortuneSlip, goodFortuneSlip, greatFortuneSlip, emptyPaperSlip;

        public mainForm()
        {
            InitializeComponent();
            UserStats();
            inventoryListBox.SelectedIndexChanged += InventoryListBox_SelectedIndexChanged;

            tutorialForm = new tutorialForm();
            arcadeForm = new arcadeForm(this);
            choiceComboBox.SelectedIndexChanged += choiceComboBox_SelectedIndexChanged;
            PopulateChoices("Room");

            // Initialising items and setting their properties
            Inventory CreateInventoryItem(string name, string description, string rarity, string locationFound)
            {
                Inventory item = new Inventory();
                item.name = name;
                item.description = description;
                item.rarity = rarity;
                item.locationFound = locationFound;
                return item;
            }

            torch = CreateInventoryItem("Torch", "A torch with some battery.", "Common", "Cabinet Drawer");
            redCoin = CreateInventoryItem("Red Coin", "A shiny red coin.", "Rare", "Cabinet Drawer");
            orangeJewel = CreateInventoryItem("Orange Jewel", "An orange jewel.", "Super Rare", "Arcade Machine");
            bronzeKey = CreateInventoryItem("Bronze Key", "A small bronze key.", "Common", "Window");
            goldenBell = CreateInventoryItem("Golden Bell", "A bell with a distorted tune.", "Rare", "Picture Frame");
            blueJewel = CreateInventoryItem("Blue Jewel", "A jewel with a dark blue light.", "Super Rare", "Arcade Machine");
            blackJewel = CreateInventoryItem("Black Jewel", "An obsidian jewel.", "Super Rare", "Right Curtain");
            extractOfText = CreateInventoryItem("Piece of Paper", "Text about runes.", "Common", "Bed");
            greatMisfortuneSlip = CreateInventoryItem("Great Misfortune Slip", "A fortune slip with Great Misfortune.", "Rare", "Fortune Box");
            misfortuneSlip = CreateInventoryItem("Misfortune Slip", "A fortune slip with Misfortune.", "Common", "Fortune Box");
            goodFortuneSlip = CreateInventoryItem("Good Fortune Slip", "A fortune slip with Good Fortune.", "Common", "Fortune Box");
            greatFortuneSlip = CreateInventoryItem("Great Fortune Slip", "A fortune slip with Great Fortune.", "Rare", "Fortune Box");
            emptyPaperSlip = CreateInventoryItem("Empty Paper Slip", "An empty fortune slip.", "Common", "Fortune Box");

            // Generates random padlock code with three digits
            Random random = new Random();
            padlockCodeOne = random.Next(1, 9);
            padlockCodeTwo = random.Next(1, 9);
            padlockCodeThree = random.Next(1, 9);

            // Sets form to open in maximized window state
            this.WindowState = FormWindowState.Maximized;
        }

        private void PopulateChoices(string location)
        {
            subOptionLabel.Text = "";
            choiceComboBox.SelectedIndexChanged -= choiceComboBox_SelectedIndexChanged;
            choiceComboBox.Items.Clear();
            switch (location)
            {
                case "Room":
                    SetUpRoomOptions();
                    break;
                case "Cabinet":
                    SetUpCabinetOptions();
                    break;
                case "Window":
                    SetUpWindowOptions();
                    break;
                case "Left Curtain":
                    SetUpLeftCurtainOptions();
                    break;
            }

            if (choiceComboBox.Items.Count > 0)
                choiceComboBox.SelectedIndex = -1;

            choiceComboBox.SelectedIndexChanged += choiceComboBox_SelectedIndexChanged;

            locationLabel.Text = location;
        }

        private void SetUpRoomOptions()
        {
            choiceComboBox.Items.Add("Cabinet");
            choiceComboBox.Items.Add("Bed");
            choiceComboBox.Items.Add("Window");
            mainLabel.Text = "You are in the centre of the room.\n" +
                             "Choose an option from the dropdown.";
        }

        private void SetUpCabinetOptions()
        {
            choiceComboBox.Items.Add("Top drawer");
            choiceComboBox.Items.Add("Middle drawer");
            choiceComboBox.Items.Add("Bottom drawer");
            choiceComboBox.Items.Add("Box");
            choiceComboBox.Items.Add("Go back");
            mainLabel.Text = "You are at the Cabinet.\n" +
                             "You see a cabinet with three drawers and a box on top.\n" +
                             "Choose an option from the dropdown:";
        }

        private void SetUpWindowOptions()
        {
            choiceComboBox.Items.Add("Padlock");
            choiceComboBox.Items.Add("Picture");
            choiceComboBox.Items.Add("Left curtain");
            choiceComboBox.Items.Add("Right curtain");
            choiceComboBox.Items.Add("Go back");
            mainLabel.Text = "You are at the Window.\n" +
                             "The window is locked by a padlock with curtains draped on either side.\n" +
                             "A picture frame lies to the left.\n" +
                             "Choose an option from the dropdown:";
        }

        private void SetUpLeftCurtainOptions()
        {
            if (!arcadePuzzleSolved)
            {
                choiceComboBox.Items.Add("Yes");
                choiceComboBox.Items.Add("Go Back");
                mainLabel.Text = "Do you want to insert a coin and press the button on the arcade machine?";
            }
            else
            {
                PopulateChoices("Window");
            }
        }

        private void choiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChoice = choiceComboBox.SelectedItem.ToString();

            switch (selectedChoice)
            {
                case "Cabinet":
                    PopulateChoices("Cabinet");
                    break;
                case "Bed":
                    GoToBed();
                    break;
                case "Window":
                    PopulateChoices("Window");
                    break;
                case "Top drawer":
                    OpenTopDrawer();
                    break;
                case "Middle drawer":
                    OpenMiddleDrawer();
                    break;
                case "Bottom drawer":
                    OpenBottomDrawer();
                    break;
                case "Box":
                    PickUpBox();
                    break;
                case "Go back":
                    PopulateChoices("Room");
                    break;
                case "Padlock":
                    TryPadlock();
                    break;
                case "Picture":
                    ExaminePictureFrame();
                    break;
                case "Left curtain":
                    PopulateChoices("Left Curtain");
                    break;
                case "Right curtain":
                    ExamineRightCurtain();
                    break;
                case "Yes":
                    if (locationLabel.Text == "Left Curtain")
                    {
                        if (inventory.Contains(redCoin))
                        {
                            arcadeForm.Show();
                        }
                        else
                        {
                            subOptionLabel.Text = "You need a Red Coin to start the machine.";
                        }
                    }
                    break;
                case "Go Back":
                    if (locationLabel.Text == "Left Curtain")
                    {
                        subOptionLabel.Text = "You decide not to press the button.";
                        PopulateChoices("Window");
                    }
                    break;
            }
        }

        private void OpenTopDrawer()
        {
            subOptionLabel.Text = "";
            playerOne.health -= 90;
            CheckHealth();
            mainLabel.Text = "You open the Top Drawer.\n" +
                             "A red rune shines on the bottom.\n" +
                             "As you feel your health draining away from you, you quickly push it shut.\n" +
                             "Your health has decreased by 90.";
        }

        private void OpenMiddleDrawer()
        {
            subOptionLabel.Text = "";
            // Checks if orange jewel is already in player's inventory
            if (!inventory.Contains(orangeJewel))
            {
                // If player has bronze key, they can unlock middle drawer
                if (inventory.Contains(bronzeKey))
                {
                    mainLabel.Text = "You unlock the Middle Drawer with the Bronze Key and find an Orange Jewel!";

                    // Adds orange jewel to player's inventory
                    inventory.Add(orangeJewel);
                    inventoryListBox.Items.Add(orangeJewel.name);
                }
                else
                {
                    mainLabel.Text = "You try to open the Middle Drawer.\n" +
                                     "It is locked.";
                }
            }
            else
            {
                mainLabel.Text = "You open the Middle Drawer.\n" +
                                 "It is empty.";
            }
        }

        private void OpenBottomDrawer()
        {
            subOptionLabel.Text = "";
            if (!inventory.Contains(redCoin) && !inventory.Contains(torch))
            {
                mainLabel.Text = "You find a Red Coin and a Torch in the Bottom Drawer!";
                inventory.Add(redCoin);
                inventory.Add(torch);
                inventoryListBox.Items.Add(redCoin.name);
                inventoryListBox.Items.Add(torch.name);
            }
            else
            {
                mainLabel.Text = "The Bottom Drawer is empty.";
            }
        }

        private void PickUpBox()
        {
            subOptionLabel.Text = "";
            if (fortuneTold)
            {
                playerOne.energy -= 100;
                CheckEnergy();
            }
            else
            {

                mainLabel.Text = "You shake the Box on top of the cabinet.\n" +
                                 "A paper slip falls out.";

                Random random = new Random();
                int fortune = random.Next(1, 100);

                if (fortune <= 10)
                {
                    subOptionLabel.Text = "You receive a Great Misfortune Slip!\n" +
                                          "Your energy decreases by 50.";
                    inventory.Add(greatMisfortuneSlip);
                    inventoryListBox.Items.Add(greatMisfortuneSlip.name);
                    playerOne.energy -= 50;
                }
                else if (fortune <= 40)
                {
                    subOptionLabel.Text = "You receive a Misfortune Slip!\n" +
                                          "Your energy decreases by 30.";
                    inventory.Add(misfortuneSlip);
                    inventoryListBox.Items.Add(misfortuneSlip.name);
                    playerOne.energy -= 30;
                }
                else if (fortune <= 70)
                {
                    subOptionLabel.Text = "You receive a Good Fortune Slip!";
                    inventory.Add(goodFortuneSlip);
                    inventoryListBox.Items.Add(goodFortuneSlip.name);
                }
                else if (fortune <= 80)
                {
                    subOptionLabel.Text = "You receive a Great Fortune Slip!";
                    inventory.Add(greatFortuneSlip);
                    inventoryListBox.Items.Add(greatFortuneSlip.name);
                }
                else
                {
                    subOptionLabel.Text = "You receive an Empty Paper Slip!";
                    inventory.Add(emptyPaperSlip);
                    inventoryListBox.Items.Add(emptyPaperSlip.name);
                }
                UserStats();
                fortuneTold = true;
            }
        }

        // Reference: https://stackoverflow.com/questions/6666368/c-how-to-hide-one-form-and-show-another
        // Reference: https://stackoverflow.com/questions/1173973/passing-variables-into-another-form#:~:text=An%20easy%20way%20is%20to%20use%20properties.%20The,1%3B%20form2.ShowDialog%20%28%29%3B%20or%20something%20along%20those%20lines.
        void TryPadlock()
        {
            // Creates new instance of padlockForm
            padlockForm padlockForm = new padlockForm(this, padlockCodeOne, padlockCodeTwo, padlockCodeThree);

            // Displays padlock form
            padlockForm.Show();
        }

        // Reference: https://stackoverflow.com/questions/31302825/inaccessible-due-to-its-protection-level
        public void UnlockedPadlock()
        {
            subOptionLabel.Text = "";

            if (!inventory.Contains(bronzeKey))
            {
                if (inventory.Contains(torch))
                {
                    mainLabel.Text = "The padlock unlocks with a click.\n" +
                                     "You shine your Torch outside the window.\n" +
                                     "You find a Bronze Key!\n" +
                                     "As soon as you take it, the window closes and the padlock clicks shut.\n" +
                                     "A blue rune shines in front before fading away.";

                    inventory.Add(bronzeKey);
                    inventoryListBox.Items.Add(bronzeKey.name);

                }
                else
                {
                    mainLabel.Text = "The padlock unlocks with a click.\n" +
                                     "It is too dark to see outside the window.\n" +
                                     "Maybe a source of light would help.\n" +
                                     "As soon as you take a step back from the window, the padlock clicks shut.\n" +
                                     "A blue rune shines in front before fading away.";
                }
            }
            else
            {
                mainLabel.Text = "The padlock unlocks with a click.\n" +
                                 "It is too dark outside the window and you do not know how high up you are.\n" +
                                 "It is too risky to escape this way.";
            }
        }

        // Location where player can find out padlock code
        void ExaminePictureFrame()
        {
            subOptionLabel.Text = "";
            if (!inventory.Contains(goldenBell))
            {
                mainLabel.Text = "You pick up the Picture.\n" +
                                 "The edges of the frame are worn smooth, and the glass is clear and free of dust.\n" +
                                $"3 numbers are written neatly in the corner: {padlockCodeOne}{padlockCodeTwo}{padlockCodeThree}\n" +
                                 "You find a Golden Bell hanging on a hook!";

                inventory.Add(goldenBell);
                inventoryListBox.Items.Add(goldenBell.name);

            }
            else
            {
                mainLabel.Text = "You pick up the Picture.\n" +
                                 $"3 numbers are written neatly in the corner: {padlockCodeOne}{padlockCodeTwo}{padlockCodeThree}";
            }
        }
        private void ExamineRightCurtain()
        {
            subOptionLabel.Text = "";
            if (!inventory.Contains(blackJewel))
            {
                mainLabel.Text = "You find a Black Jewel behind the Right Curtain!";
                inventory.Add(blackJewel);
                inventoryListBox.Items.Add(blackJewel.name);
            }
            else
            {
                mainLabel.Text = "The Right Curtain reveals nothing new.";
            }
        }

        public void SolvedArcadePuzzle()
        {
            PopulateChoices("Window");
            subOptionLabel.Text = "";
            locationLabel.Text = "Window";

            mainLabel.Text = "The arcade machine lets out a ding!\n" +
                             "A small compartment embedded in the machine whirrs open.\n" +
                             "You find a Blue Jewel!\n" +
                             "The machine returns the Red Coin.";

            inventory.Add(blueJewel);
            inventoryListBox.Items.Add(blueJewel.name);

            arcadePuzzleSolved = true;
        }

        private void GoToBed()
        {
            subOptionLabel.Text = "";
            if (inventory.Contains(blackJewel) && inventory.Contains(blueJewel) && inventory.Contains(orangeJewel))
            {
                mainLabel.Text = "You place all jewels in the bed box. The door opens, and you've escaped!";
                MessageBox.Show("You have successfully escaped!");
                this.Close();
            }
            else
            {
                mainLabel.Text = "The bed box has three slots. You need all jewels to escape.";
            }

            if (!inventory.Contains(extractOfText))
            {
                CollectExtract();
            }
        }

        private void CollectExtract()
        {
            // Path to text file containing information about runes
            string path = "runes.txt";

            if (File.Exists(path))
            {
                // Reads content of file into a variable
                string text = File.ReadAllText(path);

                subOptionLabel.Text = "You find a Piece of Paper tucked under the pillow.\n" +
                                      $"The title catches your eye: {text}\n" +
                                      "But you scan through it and see nothing of importance.";

                inventory.Add(extractOfText);
                inventoryListBox.Items.Add(extractOfText.name);
            }
            else
            {
                subOptionLabel.Text = "You find a Piece of Paper tucked under the pillow.\n" +
                                      "As soon as you touch it, it crumbles to ashes.";
            }
        }

        private void UserStats()
        {
            healthLabel.Text = $"Health = {playerOne.health}";
            energyLabel.Text = $"Energy = {playerOne.energy}";
        }

        private void CheckHealth()
        {
            subOptionLabel.Text = "";
            UserStats();

            if (playerOne.health <= 0)
            {
                mainLabel.Text = "Your health has reached 0.";
                if (inventory.Contains(goldenBell))
                {
                    subOptionLabel.Text = "The Golden Bell has restored your health.";
                    playerOne.health = 100;
                    UserStats();
                }
                else
                {
                    MessageBox.Show("GAME OVER: Health has reached 0.");
                    this.Close();
                }
            }
        }

        private void CheckEnergy()
        {
            subOptionLabel.Text = "";
            UserStats();

            if (playerOne.energy <= 0)
            {
                if (inventory.Contains(goldenBell))
                {
                    subOptionLabel.Text = "The Golden Bell has restored your energy.";
                    playerOne.energy = 100;
                    UserStats();
                }
                else
                {
                    mainLabel.Text = "You hear a reprimanding voice in your head:\n" +
                                     "Your fortune has already been told today!\n" +
                                     "You suddenly feel your energy draining away.\n" +
                                     "Your energy has reached 0.";

                    MessageBox.Show("GAME OVER: Energy has reached 0.");
                    this.Close();
                }
            }
        }

        // For when an item in inventory listbox is selected
        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if an item is selected
            if (inventoryListBox.SelectedIndex != -1)
            {
                int selectedIndex = inventoryListBox.SelectedIndex; // gets index of selected item

                // Checks selected index is within valid range
                if (selectedIndex >= 0 && selectedIndex < inventory.Count)
                {
                    var selectedItem = inventory[selectedIndex]; // retrieves selected item from inventory

                    subOptionLabel.Text = $"Description: {selectedItem.description}\n" +
                                          $"Rarity: {selectedItem.rarity}\n" +
                                          $"Location found: {selectedItem.locationFound}";
                }
            }
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            // Displays tutorial form
            tutorialForm.Show();

            // Displays first page of tutorial
            tutorialForm.DisplayTutorialPageOne();
        }
    }
}

