using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class DBTable_bridge : DBTable
    {
        /// <summary>
        /// Sets the delete flag to mark a record as deleted
        /// </summary>
        /// <param name="table">the table to test</param>
        /// <param name="field1">the first field of the primary key</param>
        /// <param name="field2">the second field in the primary key</param>
        /// <param name="key1">the key of the first primary key field</param>
        /// <param name="key2">the key of the second primary key field</param>
        public static void delete(String table, string field1, string field2, int key1, int key2)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "UPDATE " + table + " SET deleted = 1 where " + field1 + " = @id1 AND " + field2 + " = @id2";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", key1);
                command.Parameters.AddWithValue("id2", key2);

                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Tests to see if the primary key exists
        /// </summary>
        /// <param name="table">the table to test</param>
        /// <param name="field1">the first field of the primary key</param>
        /// <param name="field2">the second field in the primary key</param>
        /// <param name="key1">the key of the first primary key field</param>
        /// <param name="key2">the key of the second primary key field</param>
        /// <returns>true if exists false otherwise</returns>
        public static bool keyExists(string table, string field1, string field2, int key1, int key2)
        {
            bool b = false;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT " + field1 + ", " + field2 + " FROM " + table +
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

        /// <summary>
        /// Retrieves all names from table from field with key
        /// </summary>
        /// <param name="table">the table with the reference list</param>
        /// <param name="listTable">the table to retrieve the information from</param>
        /// <param name="listField">the field name to return with the name</param>
        /// <param name="selectField">the field name to test for the condition</param>
        /// <param name="fieldKey">the key to find</param>
        /// <returns>List of names </returns>
        public static List<NameKey> retrieveAll(string table, string listTable, string listField, string selectField, int fieldKey)
        {
            List<NameKey> l = new List<NameKey>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT " + listTable + "." + listField + ", name FROM " + table + ", " + listTable + 
                    " WHERE " + selectField + " = @id1 AND " + listTable + "." + listField + " = " + table + "." + listField;
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", fieldKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", selectField.ToString()));

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
