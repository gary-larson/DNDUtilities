using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace DNDUtilitiesLib
{
    public class DBTable
    {
        public DBTable ()
        {
            connection = "DNDDatabase\\bin\\Debug\\DNDDatabase.db3";
        }
        private string connection
        {
            get;
        }

        public virtual void Save()
        {
            throw new System.NotImplementedException();
        }

        public void get()
        {

       /*     using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = connection;
                conn.Open();

                String sql;
                sql = "select sbility_id, ability, abbreviation from abilities where ability_id = @id";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("id", abilityId);

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.HasRows)
                    {
                        read.Read();
                        Abilities a = new Abilities(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2)
                        );
                        return a;
                    }
                    else
                    {
                        return null;
                    }
                }

            } */
                
        }

        public virtual void delete()
        {
            throw new System.NotImplementedException();
        }

    }
}
