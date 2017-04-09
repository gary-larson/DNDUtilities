using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNDUtilitiesLib;

namespace UICharacterCreation
{
    static class UISelection
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {


            // in the future, this will Figure if someone is trying to level up or make a new character
            // but time and functionality is limited




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectionForm());
        }
    }
}
