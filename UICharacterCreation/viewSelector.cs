using DNDUtilitiesLib;
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
    public partial class viewSelector : Form
    {
        List<NameKey> potientialCharacters;
        List<int> idatPos;
        public viewSelector()
        {
            InitializeComponent();
            potientialCharacters = new List<NameKey>();
            potientialCharacters = Characters.retrieveAll();
            idatPos = new List<int>();
            foreach (NameKey pC in potientialCharacters)
            {
                characterList.Items.Add("ID: " + pC.key + ", Name: " + pC.name);
                idatPos.Add(pC.key);
            }
        }

        private void viewCharacterButton_Click(object sender, EventArgs e)
        {
            characterSheetForm viewForm = new characterSheetForm(idatPos[characterList.SelectedIndex]);
            viewForm.ShowDialog();
        }
    }
}
