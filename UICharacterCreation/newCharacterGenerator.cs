using DNDUtilitiesLib;
using DNDUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UICharacterCreation
{
    public partial class newCharacterGenerator : Form
    {
        CharacterSheet PC;
        List<NameKey> PotientialClasses;
        List<NameKey> PotientialRaces;
        List<NameKey> PotientialAlignments;
        List<NameKey> CharacterAttributes;
        List<CheckBox> swapBoxes;

        public newCharacterGenerator()
        {
            InitializeComponent();
            populateDropdowns();
        }
        public void populateDropdowns()
        {
            // query for Class and Race options, 
            this.PC = new CharacterSheet();             // to hold all the data
            
            //------------------------Temp Object Creation----------------------------------------//
            Classes tClasses = new Classes();           // When the functions become static i'll fix this
            List<Label> abilityLabels = new List<Label>()
            {
                abilityLabel1, abilityLabel2, abilityLabel3,
                abilityLabel4, abilityLabel5, abilityLabel6
            };
            swapBoxes = new List<CheckBox>()
            {
                swapBox1, swapBox2, swapBox3,
                swapBox4, swapBox5, swapBox6
            };

            //------------------------Storage of possible-----------------------------------------//
            this.PotientialClasses = tClasses.retrieveAllNames();   // to generate 
            this.PotientialRaces = Races.retrieveAll();            // to generate
            this.PotientialAlignments = Alignments.retrieveAll();
            this.CharacterAttributes = Abilities.retrieveAll();     // these dont go in a dropdown but this way we have the information

            //------------------------pushing list->combobox--------------------------------------//
            foreach (NameKey pClass in PotientialClasses)
            {
                classComboBox.Items.Add(pClass);
            }
            foreach (NameKey pRace in PotientialRaces)
            {
                raceComboBox.Items.Add(pRace);
            }
            foreach (NameKey pAlign in PotientialAlignments)
            {
                alignmentComboBox.Items.Add(pAlign);
            }
            for(int i = 0; i < abilityLabels.Count; i++) { 
                abilityLabels[i].Text = CharacterAttributes[i].ToString();
                swapBoxes[i].Text = "Swap " + CharacterAttributes[i].ToString();
            }   // sets the text of abiulity labels to the right name. 

            //-----------------------Setting Default Combobox Data--------------------------------//
            classComboBox.SelectedIndex = 0;
            raceComboBox.SelectedIndex = 0;
            alignmentComboBox.SelectedIndex = 0;
            abilityGenerationSelector.SelectedIndex = 0;

            // all the other values should be calculates off these values, hoepfully. 
        }

        private void subitGeneralInfo_Click(object sender, EventArgs e)
        {
            // These are all currently Seperate If-Statements 
            // so i can go back in alter and give more precise declarations of bad
            List<TextBox> Verifications = new List<TextBox>() {
                playerNameTextBox, pcNameTextBox, genderTextBox,
                heightTextBox, weightTextBox, dietyTextBox,
                ageTextBox, eyesTextBox, hairTextBox, skinTextBox
            };
            bool invalid = false;

            // Does Data Exist? 
            foreach(TextBox textField in Verifications)
            {
                textField.BackColor = Color.Empty;      // resets the color of a field

                String temp = textField.Text;
                bool tValid = (String.IsNullOrEmpty(temp) || String.IsNullOrWhiteSpace(temp));

                invalid = (invalid || tValid);          // if it isnt valid now, or wasnt valid earlier, its bad!

                if (tValid)
                {
                    textField.BackColor = Color.Red;    // if 't ain't valid, background to red
                }
                // MessageBox.Show(textField.Text);
                // This Works!
                // Might not be efficient TBH because we're moving shit around for Reading efficiency here
                // but premature optimization si the root of all evil. 
            }

            // is it Numbers?
            int Height, Weight, Age;
            invalid = (invalid || !int.TryParse(heightTextBox.Text, out Height));
            invalid = (invalid || !int.TryParse(weightTextBox.Text, out Weight));
            invalid = (invalid || !int.TryParse(ageTextBox.Text, out Age));

            if (invalid)
            {
                MessageBox.Show("YA DONE F UP");
            }
            else
            {
                // save the man
                MessageBox.Show("SUCC sesss");
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Random seed = new Random();         // to avoid issues
            List<TextBox> scoreBoxes = new List<TextBox>()
            {
                abilityTextBox1, abilityTextBox2, abilityTextBox3,
                abilityTextBox4, abilityTextBox5, abilityTextBox6
            };
            // Calls disable editing first
            setScoreEdits(scoreBoxes, false);
            // Determine Method used to roll dice
            // apply "reroll 1 option" if valid

            if (abilityGenerationSelector.Text == "4d6 Drop Lowest")
            {
                // Roll 1d6 4 times
                // add the highest 3 values
                // repeat six times
                foreach (TextBox aBox in scoreBoxes)
                {
                    List<int> values = new List<int>()
                    {
                        rollXdY(1,6, seed), rollXdY(1,6, seed), rollXdY(1,6, seed), rollXdY(1,6, seed)
                    };
                    values.Sort();      // Values is now sorted least to greatest
                    aBox.Text = (values[1] + values[2] + values[3]).ToString();
                    // Value[0] discarded due to being the lowest
                }

            }
            else if (abilityGenerationSelector.Text == "1d8 + 10")
            {
                foreach (TextBox aBox in scoreBoxes)
                {
                    // simple. not often good stats, but rarely bad ones
                    aBox.Text = (rollXdY(1, 8, seed) + 10).ToString();
                }
            }
            else if (abilityGenerationSelector.Text == "Manual Input")
            {
                // needs to enable editing on the stat boxes
                setScoreEdits(scoreBoxes, true);
            }
            else
            {
                MessageBox.Show("Hopefully this Isn't a live demo, this is an error!\nDice option not found!");
            }
        }
        
        private void setScoreEdits(List<TextBox> fields, bool value)
        {
            foreach (TextBox box in fields)
            {
                box.Enabled = value;
            }
        }

        private int rollXdY(int X, int Y, Random seed)
        {
            // THIS FUNCTION IS EXPRESSLY FOR ABILITY SCORES
            // DO NOT USE THIS FOR HP OR OTHER THINGS
            // this is, notibly, designed to be expanded to toher stat generation systems tho
            int result = 0;
            int min;

            if (reRollOneBox.Checked)
            {
                // if 1's are reolled, we just consider it a D-1 that starts at 2
                min = 2;
            }
            else
            {
                // normal dice
                min = 1;
            }

            for (int i = 0; i < X; i++)
            {
                // DIE = RANOM (min <= DIE < Y)
                result += seed.Next(min, Y + 1);
            }

            return result;
        }
    }
}
