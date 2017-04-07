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
        public const String CONNECTION_STR = "data source=DNDDatabase.db3";

        public void delete(String table, string field, int key)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "UPDATE " + table + " SET deleted = 1 where " + field + " = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", key);

                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<NameKey> retrieveAll(string table, string field)
        {
            List<NameKey> l = new List<NameKey>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT " + field + ", name FROM " + table;
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int key = read.GetInt32(0);
                        string name = read.GetString(1);
                        NameKey nk = new NameKey(key, name);
                        l.Add(nk);
                    }
                }
                conn.Close();
                return l;
            }
        }
    }
}
