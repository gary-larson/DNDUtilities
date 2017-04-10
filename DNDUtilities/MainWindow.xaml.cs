using DNDUtilitiesLib;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DNDUtilities
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String s = "";
            Characters c = new Characters();
            c.retrieveRecord(1);
            
            //Character_hit_points a = new Character_hit_points();
            //bool b = Character_hit_points.delete(2, 6);
            //int result = Character_hit_points.GetTotalHitPoints(1);
            //          a.modifier = 1;
            //          a.temp = 2;
            //          a.temp_modifier = 3;
            //          a.save();
          //  bool b = a.delete(1, 1);
          //  List<NameKey> nk = Abilities.retrieveAll();
           //    foreach (NameKey n in nk)
           //   {
         //       s += n.ToString();
          //    }
            // a.player_name = "Keith";
            // a.save();
            //s = result.ToString();
            label.Content = s;
            // label.Content = b + " " + s;
            // label.Content = result.ToString();

        }
    }
}
