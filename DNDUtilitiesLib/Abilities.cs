using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Abilities : DBTable_lookup
    {
        const string TABLE = "abilities";
        const string FIELD = "ability_id";
        private int ability_id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string abbreviation
        {
            get;
            set;
        }

        public Classes classes
        {
            get;
            set;
        }

        public Abilities ()
        {
            ability_id = -1;
            name = "";
            abbreviation = "";
        }

        public Abilities (int AbilityId, string Ability, string Abbreviation)
        {
            this.ability_id = AbilityId;
            this.name = Ability;
            this.abbreviation = Abbreviation;
        }

        public Abilities retrieveRecord(int Key)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "select ability_id, name, abbreviation from abilities where ability_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", Key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ability_id = read.GetInt32(0);
                        name = read.GetString(1);
                        abbreviation = read.GetString(2);
                    }
                    return this;
                }
            }
        }

        public List<NameKey> retrieveAll()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public override string ToString()
        {
            return "AbilityId: " + ability_id + " Ability: " + name + " Abbreviation: " + abbreviation;

        }


    }


}
