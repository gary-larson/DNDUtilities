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

    public partial class skillSelection : Form
    {
        public skillSelection(string typing)
        {
            InitializeComponent();

            // typing = view:       Disable controls and just allow viewing. 
            // typing = editable:   enable conrt5olls, have a policy of "spend all skillpoints, or void changes"
            // typing = new:        Editable, But point calculations are different. 

            // ------------------Free point Calculations-----------------//
            // if a character doesnt have attribute scores yet, throw an error
            // Main page will have to check if attribute scores still support skills chosen, if not, throw an error
            // also if race changes to/from human, throw an error
            // just throw a shitton of errors. 
            // as for point calculation, Compare old level to new level, grant ClassSkillPoints+int Mod (minimum 1) + race modifier
            // for new characters, provide (class Skillpoints+int mod (minimum 1) + race Modifier) * 4

            // ------------------ List Population -----------------------//
            // if Subtyping == "NO" then only print the skill once
            // if Subtyping == "Yes" then print the skill 4 times, with a dropdown for subSkills
            //      if Skill = "Speak language" give it a special interface cause it's fucking dumb. 
            // 52 total entry blips
        }
    }
}
