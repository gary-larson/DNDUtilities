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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            initializationTasks();
        }
        private void initializationTasks()
        {
            // do things we need to do when the form is created
            selectedFunction.SelectedIndex = 0;
        }

        private void CreationButton_Click(object sender, EventArgs e)
        {
            string selection = selectedFunction.SelectedItem.ToString();
            // MessageBox.Show(selection); // i am a message to test things
            if (selection == "New Character")
            {
                // Call form for new character Creation!
                newCharacterGenerator newPC = new newCharacterGenerator();
                newPC.Show();
                this.Hide();
            }
                else if (selection == "Edit Character")
            {
                // Call form for Character editing!
                MessageBox.Show("Coming soon!");
            }
        }
    }
}
