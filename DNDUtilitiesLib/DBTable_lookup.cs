using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    
    public class DBTable_lookup : DBTable
    {
        /// <summary>
        /// Tests if primary key exists
        /// </summary>
        /// <param name="table">the table to test</param>
        /// <param name="field">the primary key field</param>
        /// <param name="key">the key to locate</param>
        /// <returns>true if key exists false otherwise</returns>
        public static bool keyExists(string table, string field1, string field2, int key1, int key2)
        {
            bool b = false;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT " + field1 +" FROM " + table +
                    " WHERE " + field1 + " = @id1 AND " + field2 + " = @id2";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", key1.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", key2.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        b = true;
                    }
                }
                conn.Close();
                return b;
            }
        }

        


         public static List<NameKey> retrieveAll(string table, string field, int key)
         {
             List<NameKey> l = new List<NameKey>();
             using (SQLiteConnection conn = new SQLiteConnection())
             {
                 conn.ConnectionString = CONNECTION_STR;
                 conn.Open();

                 String sql = "SELECT " + field + ", name FROM " + table + " WHERE skill_id = @id1";
                 SQLiteCommand command = conn.CreateCommand();
                 command.CommandText = sql;
                 command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", key);

                using (SQLiteDataReader read = command.ExecuteReader())
                 {
                     while (read.Read())
                     {
                         int iKey = read.GetInt32(0);
                         string name = read.GetString(1);
                         NameKey nk = new NameKey(iKey, name);
                         l.Add(nk);
                     }
                 }
                 conn.Close();
                 return l;
             }
         }
    }
}
