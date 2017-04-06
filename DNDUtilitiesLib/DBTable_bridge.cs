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
        public void delete(String table, string field1, string field2, int key1, int key2)
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
    } 
}
