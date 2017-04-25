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
            /*           Characters c = new Characters();
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
                       c.deleted = 0; */
            /*         Character_stats cs = new Character_stats();
                     cs.total = 1;
                     cs.armor_bonus = 2;
                     cs.shield_bonus = 3;
                     cs.dex_modifier = 4;
                     cs.size_modifier = 5;
                     cs.natural_armor = 5;
                     cs.deflection_modifier = 6;
                     cs.misc_modifier = 7;
                     cs.damage_reduction = 8;
                     cs.touch = 9;
                     cs.flat_footed = 10;
                     cs.initiative_total = 11;
                     cs.initiative_dex_modifier = 12;
                     cs.initiative_misc_modifier = 13;
                     cs.fortitude = 14;
                     cs.fortitude_base_save = 15;
                     cs.fortitude_ability_modifier = 16;
                     cs.fortitude_magic_modifier = 17;
                     cs.fortitude_misc_modifier = 18;
                     cs.fortitude_temp_modifier = 19;
                     cs.fortitude_conditions = "all";
                     cs.reflex = 20;
                     cs.reflex_base_save = 21;
                     cs.reflex_ability_modifier = 22;
                     cs.reflex_magic_modifier = 23;
                     cs.reflex_misc_modifier = 24;
                     cs.reflex_temp_modifier = 25;
                     cs.reflex_conditions = "or nothing";
                     cs.will = 26;
                     cs.will_base_save = 27;
                     cs.will_ability_modifier = 28;
                     cs.will_magic_modifier = 29;
                     cs.will_misc_modifier = 30;
                     cs.will_temp_modifier = 31;
                     cs.will_conditions = "i think";
                     cs.base_attack_bonus = 32;
                     cs.spell_resistance = 33;
                     cs.grapple = 34;
                     cs.grapple_base_attack_bonus = 35;
                     cs.grapple_str_modifier = 36;
                     cs.grapple_size_modifier = 37;
                     cs.grapple_misc_modifier = 38;
                     cs.save(1);
                     cs.retrieveRecord(1); */
            //   Character_spells c = new Character_spells();
            //    c.skill_rank = 1;
            //     c.skill_modifier = 2;
            //     c.ability_modifier = 3;
            //     c.misc_modifier = 4;

            //   c.save();
            //     c.save(1, 9);
            //      c.save(1, 16);
            //     List<NameKey> nk = Character_spells.retrieveAllSpells(1);
            //Character_spells.delete(1,5);
            //Character_wounds cw = new Character_wounds(-1,1,100,true);
            //cw.save();
            // int result = Character_wounds.GetTotalWounds(1);
            //Character_wounds.deleteAllRecords();
            //s = cw.ToString();
            //s = cw.ToString();
            // s = id.ToString(); 
            // Character_skills a = new Character_skills();
            Proficiencies p = new Proficiencies();
            p.retrieveRecord(1);
            s = p.ToString();
            //bool b = Character_hit_points.delete(2, 6);
            //int result = Character_hit_points.GetTotalHitPoints(1);
            //          a.modifier = 1;
            //          a.temp = 2;
            //          a.temp_modifier = 3;
            //          a.save();
            //  bool b = a.delete(1, 1);
   /*             List<NameKey> nk = Spells.retrieveAllSpells();
            foreach (NameKey n in nk)
             {
                   s += n.ToString();
             } */
            // a.player_name = "Keith";
            // a.save();
            //s = result.ToString();
            // label.Content = a.ToString();
            // label.Content = b + " " + s;
           //label.Content = result.ToString();
            label.Content = s;

        }
    }
}
