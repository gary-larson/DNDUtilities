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
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = "data source=DNDDatabase.db3";
                //conn.ConnectionString = "data source=C:\\Users\\Gary\\Source\\Repos\\DNDUtilities\\DNDUtilities\\DNDDatabase.db3";
                conn.Open();

                int abilityId = 1;
                String sql;
                sql = "select ability_id, ability, abbreviation from abilities where ability_id = @id";
                    SQLiteCommand command = conn.CreateCommand();
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.Add(new SQLiteParameter("@id", abilityId.ToString()));
              //  using (SQLiteCommand command = new SQLiteCommand(sql, conn))
              //  {

                    using (SQLiteDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            int a = read.GetInt32(0);
                            string s1 = read.GetString(1);
                            string s2 = read.GetString(2);
                            label.Content = "Ability ID: " + a + " Ability: " + s1 + " Abbreviation: " + s2;
                        }
                      //  else
                      //  {
                     //       label.Content = "Something went wrong";
                     //   }
                    }
              //  }

            }
        }
    }
}
