﻿using DNDUtilitiesLib;
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
        List<int> AbilityModifiers;
        List<TextBox> scoreBoxes;

        public newCharacterGenerator()
        {
            InitializeComponent();
            populateDropdowns();
        }
        public void populateDropdowns()
        {
            // query for Class and Race options, 
            this.PC = new CharacterSheet();             // to hold all the data

            //-----------------------------Object Creation----------------------------------------//
            Classes tClasses = new Classes();           // When the functions become static i'll fix this
            List<Label> abilityLabels = new List<Label>()
            {
                abilityLabel1, abilityLabel2, abilityLabel3,
                abilityLabel4, abilityLabel5, abilityLabel6
            };
            scoreBoxes = new List<TextBox>()
            {
                abilityTextBox1, abilityTextBox2, abilityTextBox3,
                abilityTextBox4, abilityTextBox5, abilityTextBox6
            };
            swapBoxes = new List<CheckBox>()
            {
                swapBox1, swapBox2, swapBox3,
                swapBox4, swapBox5, swapBox6
            };
            AbilityModifiers = new List<int>();

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
            for (int i = 0; i < abilityLabels.Count; i++)
            {
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


        private void submitGeneralInfo_Click(object sender, EventArgs e)
        {
            // These are all currently Seperate If-Statements 
            // so i can go back in alter and give more precise declarations of bad
            List<TextBox> Verifications = new List<TextBox>() {
                playerNameTextBox, pcNameTextBox, genderTextBox,
                dietyTextBox, eyesTextBox, hairTextBox, skinTextBox
            };
            bool invalid = false;

            // Does Data Exist?  ( non-numberic validations )
            foreach(TextBox textField in Verifications)
            {
                textField.BackColor = Color.Empty;      // resets the color of a field
                if (String.IsNullOrEmpty(textField.Text) || String.IsNullOrWhiteSpace(textField.Text))
                {
                    textField.BackColor = Color.Red;    // if 't ain't valid, background to red
                    invalid = true;
                }
                // MessageBox.Show(textField.Text);
                // This Works!
                // Might not be efficient TBH because we're moving shit around for Reading efficiency here
                // but premature optimization si the root of all evil. 
            }

            // is it Numbers?

            List<TextBox> biometrics = new List<TextBox>()
            {
                heightTextBox, weightTextBox, ageTextBox
            };
            List<int> tBiomet = new List<int>();        // height, Weight, Age

            List<TextBox> scoreBoxes = new List<TextBox>()
            {
                abilityTextBox1, abilityTextBox2, abilityTextBox3,
                abilityTextBox4, abilityTextBox5, abilityTextBox6
            };
            List<int> tStats = new List<int>();         // in order based on the IDs

            invalid = (!validateIntFields(biometrics, out tBiomet) || invalid);
            invalid = ( !validateIntFields(scoreBoxes, out tStats) || invalid);

            if (invalid)
            {
                MessageBox.Show("Invalid Values Provided, Please Check the Red Feilds and Try again");
            }
            else
            {
                // save the man
                // MessageBox.Show("SUCC sesss");
                                PC.charInfo.name = pcNameTextBox.Text;
                PC.charInfo.player_name = playerNameTextBox.Text;
                PC.charInfo.number_of_classes = 1;  // because a level 1 PC only has this
                PC.charInfo.race = raceComboBox.SelectedItem.ToString();
                PC.charInfo.alignment = alignmentComboBox.SelectedItem.ToString();
                PC.charInfo.deity = dietyTextBox.Text;
                PC.charInfo.gender = genderTextBox.Text;
                PC.charInfo.height = tBiomet[0];
                PC.charInfo.weight = tBiomet[1];
                PC.charInfo.age = tBiomet[2];
                PC.charInfo.eyes = eyesTextBox.Text;
                PC.charInfo.hair = hairTextBox.Text;
                PC.charInfo.skin = skinTextBox.Text;
                // PC.charInfo.description // Autoset by the Description Dialgo Box
                if (PC.charInfo.save())
                {
                    MessageBox.Show("Characters: Saved successfully!");
                }
                else
                {
                    MessageBox.Show("Characters: Save failed Gracefully!");
                }
                // MessageBox.Show(PC.charInfo.ToString()); // not the best certification but hey it works.
                int classID = 0;
                foreach (NameKey pClass in PotientialClasses)
                {
                    if (pClass.ToString().Equals(classComboBox.SelectedItem.ToString()))
                    {
                        classID = pClass.key;
                    }
                }
                PC.classLevels = new Character_classes(PC.ID, classID, 1, 1);
                PC.classLevels.save();      // not a bool just hope it works
                Classes UsedClass = new Classes();
                UsedClass.retrieveRecord(classID);
                PC.HP = new Character_hit_points(PC.ID, 1, UsedClass.hit_die+AbilityModifiers[3]);
                                            // stores properly calculated HP in the box. 
                // Languages needs its own UI
                // Feats needs its own UI
                // Equipment needs its own UI
                // skills need their own UI
                // (combat) stats need their own UI (for display)
                    // dont do them until after the other things are tackled though. 

            }
        }

        private bool validateIntFields(List<TextBox> input, out List<int> output)
        {
            // chews through INPUT text boxes and attempts to extract the text as ints
            // which are then placed in the output list
            // returns true if successful, and false if not. 
            bool valid = true;
            int tempInt = 0;
            output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                input[i].BackColor = Color.Empty;
                if (int.TryParse(input[i].Text, out tempInt))
                {
                    output.Add(tempInt);
                    if (tempInt < 0)
                    {
                        // no, you cannot be negative height, mass, years old, or stats.
                        input[i].BackColor = Color.Red;
                        valid = false;
                    }
                }
                else
                {
                    input[i].BackColor = Color.Red;
                    valid = false;
                }
            }
            return valid;
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Random seed = new Random();         // to avoid issues
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
                generateAbilityModifiers(scoreBoxes);

            }
            else if (abilityGenerationSelector.Text == "1d8 + 10")
            {
                foreach (TextBox aBox in scoreBoxes)
                {
                    // simple. not often good stats, but rarely bad ones
                    aBox.Text = (rollXdY(1, 8, seed) + 10).ToString();
                }
                generateAbilityModifiers(scoreBoxes);
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
        
        private void generateAbilityModifiers(List<TextBox> AbilityScores)
        {
            // Always send this all six ability scoreboxes, please!
            int temp = 0;
            AbilityModifiers.Clear();       // helps ensure data integrity
            for (int i = 0; i < AbilityScores.Count(); i++)
            {
                if (int.TryParse(AbilityScores[i].Text, out temp))
                {
                    // FLOOR (stat/2 -5)
                    AbilityModifiers.Add((int)Math.Floor((double)temp / 2 - 5));
                }
                else
                {
                    AbilityModifiers.Add(0);        // in case of stupid, a dummy value
                                                    // also, an advantage in handling the undead
                }
            }
            updateModifierLabels();
        }
        private void updateModifierLabels()
        {
            List<Label> modLabels = new List<Label>()
            {
                modLabel1, modLabel2, modLabel3, 
                modLabel4, modLabel5, modLabel6
            };
            for (int i = 0; i < AbilityModifiers.Count(); i++)
            {
                if (AbilityModifiers[i] >= 0)
                {
                    // format with a preceding +
                    modLabels[i].Text = "+" + AbilityModifiers[i].ToString();
                }
                else
                {
                    // display it as is, which should include a -
                    modLabels[i].Text = AbilityModifiers[i].ToString();
                }
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

        private void swapBox_CheckedChanged(object sender, EventArgs e)
        {
            int numChecked = 0;
            List<int> trueBoxes = new List<int>(); // should contain the indexcies of the checked boxes
            foreach (CheckBox boxes in swapBoxes)
            {
                if (boxes.Checked)
                {
                    trueBoxes.Add(numChecked);
                }
                numChecked++;

            }
            if (trueBoxes.Count() == 2)
            {
                // i dont want to fuck with weird 3 way swaps
                // MessageBox.Show("2 boxes Checked!");
                // MessageBox.Show(trueBoxes[0].ToString());
                // MessageBox.Show(trueBoxes[1].ToString());
                string temp = (scoreBoxes[trueBoxes[0]].Text);
                // int-verify strings ~~when i care~~ at form submission

                scoreBoxes[trueBoxes[0]].Text = scoreBoxes[trueBoxes[1]].Text;
                scoreBoxes[trueBoxes[1]].Text = temp;
                swapBoxes[trueBoxes[0]].Checked = false;
                swapBoxes[trueBoxes[1]].Checked = false;    // reset these so that it is slightly more usable. 
            }
        }

        private void addBackstoryButton_Click(object sender, EventArgs e)
        {
            backstory bckStory;
            if (String.IsNullOrEmpty(PC.charInfo.description))
            {
                bckStory = new backstory();
            } else
            {
                bckStory = new backstory(PC.charInfo.description);
            }
            
            bckStory.ShowDialog();
            if (bckStory.valid == true)
            {
                PC.charInfo.description = bckStory.Story2;
            }

            //MessageBox.Show(PC.charInfo.description);
        }

        private void abilityTextBox_TextChanged(object sender, EventArgs e)
        {

            generateAbilityModifiers(scoreBoxes);
        }
    }
}
