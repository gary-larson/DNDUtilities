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
    public partial class backstory : Form
    {
        public bool valid;

        public backstory()
        {
            InitializeComponent();
            valid = false;
        }
        public backstory(String story)
        {
            InitializeComponent();
            backstoryTextBox.Text = story;
            valid = false;
        }

        public string Story2
        {
            get
            {
                return backstoryTextBox.Text;
            }
        }

        private void submitBackstoryButton_Click(object sender, EventArgs e)
        {
            valid = true;
            this.Close();
        }
    }
}
