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
            c.name = "Thalic";
            c.player_name = "Dude";
            c.number_of_classes = 1;
            c.career_level = 1;
            c.race = "Gnome";
            c.alignment = "Neutral good";
            c.deity = null;
            c.size = "Medium";
            c.age = 102;
            c.gender = "Male";
            c.height = 32;
            c.weight = 80;
            c.eyes = "Brown";
            c.hair = "Brown";
            c.skin = "Ruddy Brown";
            c.description = "Short happy go lucky halfling";
            c.speed = 20;
            c.experience_points = 105;
            c.money = 1500;
            c.deleted = 0;
            int id = c.save();
            c.player_name = "Dudette";
            id = c.save();
            s = id.ToString();
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
