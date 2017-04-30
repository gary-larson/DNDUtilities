using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table abilities
    /// </summary>
    public class Abilities : DBTable_lookup
    {
        // Declare constants
        const string TABLE = "abilities";
        const string FIELD = "ability_id";

        // Declare fields with properties
        public int ability_id
        {
            get;
            private set;
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

        // Declare constructors
        public Abilities ()
        {
            ability_id = -1;
            name = "";
            abbreviation = "";
        }

        public Abilities (int AbilityId, string Ability, string Abbreviation)
        {
            ability_id = AbilityId;
            name = Ability;
            abbreviation = Abbreviation;
        }

        /// <summary>
        /// Gets this object to the record determined by character_id
        /// </summary>
        /// <param name="Key"></param>
        /// <returns> this object </returns>
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
        public static Abilities staticRetrieveRecord(int Key)
        {
            int ability_id = -1;
            string name = "-1";
            string abbreviation = "-1";
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
                    Abilities Result = new Abilities(ability_id, name, abbreviation);
                    return Result;
                }
            }
        }



        /// <summary>
        /// gets all records 
        /// </summary>
        /// <returns>returns a List with name and ability_id</returns>
        public static List<NameKey> retrieveAllAbilities()
        {
            return retrieveAll(TABLE, FIELD);
        }

        /// <summary>
        /// outputs object as a string
        /// </summary>
        /// <returns>String representing object</returns>
        public override string ToString()
        {
            return "AbilityId: " + ability_id + " Ability: " + name + " Abbreviation: " + abbreviation;

        }


    }


}
