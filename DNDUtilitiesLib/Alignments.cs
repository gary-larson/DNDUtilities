using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Alignments : DBTable_lookup
    {
        const string TABLE = "alignments";
        const string FIELD = "alignment_id";
        private int alignment_id
        {
            get;
            set;
        }

        private string name
        {
            get;
            set;
        }

        public List<NameKey> retrieveAll()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public Alignments retrieveRecord(int Key)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "select alignment_id, name from alignments where alignment_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", Key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        alignment_id = read.GetInt32(0);
                        name = read.GetString(1);
                    }
                    return this;
                }
            }
        }

        public override string ToString()
        {
            return "Alignment " + name + " alignment_id: " + alignment_id;
        }

    }

}
