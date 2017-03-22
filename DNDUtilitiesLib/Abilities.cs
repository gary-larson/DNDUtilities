using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Abilities : DBTable
    {
        const String TABLE = "abilities";
        const String FIELD_LIST = "ability_id, ability, abbreviation";
        const String FIELD = "ability_id";
        private int ability_id
        {
            get;
            set;
        }

        public virtual string ability
        {
            get;
            set;
        }

        public virtual string abbreviation
        {
            get;
            set;
        }

        public virtual Classes classes
        {
            get;
            set;
        }

        public Abilities ()
        {
            ability_id = -1;
            ability = "";
            abbreviation = "";
        }

        public Abilities (int AbilityId, string Ability, string Abbreviation)
        {
            this.ability_id = AbilityId;
            this.ability = Ability;
            this.abbreviation = Abbreviation;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public Abilities retrieve(int Key)
        {
 
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                //conn.ConnectionString = "data source=C:\\Users\\Gary\\Source\\Repos\\DNDUtilities\\DNDUtilities\\DNDDatabase.db3";
                conn.Open();

                String sql = "select " + FIELD_LIST + " from " + TABLE + " where " + FIELD + " = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", Key.ToString()));
                //  using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                //  {

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ability_id = read.GetInt32(0);
                        ability = read.GetString(1);
                        abbreviation = read.GetString(2);
                    }
                    return this;
                }
            }
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "AbilityId: " + ability_id + " Ability: " + ability + " Abbreviation: " + abbreviation;

        }


    }


}
