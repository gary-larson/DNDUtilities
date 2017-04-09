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
            Races tRaces = new Races();
            Alignments tAlignments = new Alignments();
            
            //------------------------Storage of possible-----------------------------------------//
            this.PotientialClasses = tClasses.retrieveAllNames();   // to generate 
            this.PotientialRaces = tRaces.retrieveAll();            // to generate
            this.PotientialAlignments = tRaces.retrieveAll();

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
    }
}
