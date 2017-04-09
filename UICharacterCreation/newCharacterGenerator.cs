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
            
            //------------------------Storage of possible-----------------------------------------//
            this.PotientialClasses = tClasses.retrieveAllNames();   // to generate 
            this.PotientialRaces = Races.retrieveAll();            // to generate
            this.PotientialAlignments = Alignments.retrieveAll();

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

            //-----------------------Setting Default Combobox Data--------------------------------//
            classComboBox.SelectedIndex = 0;
            raceComboBox.SelectedIndex = 0;
            alignmentComboBox.SelectedIndex = 0;

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
                String temp = textField.Text;
                invalid = (invalid || (String.IsNullOrEmpty(temp)) || String.IsNullOrWhiteSpace(temp));
                // MessageBox.Show(textField.Text);
                // this should work but it presently isnt
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
    }
}
