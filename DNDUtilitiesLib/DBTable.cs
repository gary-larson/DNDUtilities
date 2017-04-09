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

        /// <summary>
        /// marks record as deleted
        /// </summary>
        /// <param name="table">the table the record is in</param>
        /// <param name="field">the name of the primary key field</param>
        /// <param name="key">the key of the record to be marked</param>
        public static void delete(String table, string field, int key)
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

        /// <summary>
        /// Get all records from a table
        /// </summary>
        /// <param name="table">The table to get the information from</param>
        /// <param name="field">the primary key field</param>
        /// <returns>list of names and their keys</returns>
        public static List<NameKey> retrieveAll(string table, string field)
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

        /// <summary>
        /// Tests if primary key exists
        /// </summary>
        /// <param name="table">the table to test</param>
        /// <param name="field">the primary key field</param>
        /// <param name="key">the key to locate</param>
        /// <returns>true if key exists false otherwise</returns>
        public static bool keyExists(string table, string field, int key)
        {
            bool b = false;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT " + field + " FROM " + table +
                    " WHERE " + field + " = @id1";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", key.ToString()));

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

    }
}
