using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Character_classes : DBTable_bridge
    {
        private const string TABLE = "character_classes";
        private const string FIELD1 = "character_id";
        private const string FIELD2 = "class_id";
        
        public Character_classes ()
        {
            this.character_id = -1;
            this.class_id = -1;
            this.level = 0;
            this.caster_level = 0;
        }

        public Character_classes(int character_id, int class_id, int level, int caster_level)
        {
            this.character_id = character_id;
            this.class_id = class_id;
            this.level = level;
            this.caster_level = caster_level;
        }
        private int character_id
        {
            get;
            set;
        }

        private int class_id
        {
            get;
            set;
        }

        private int level
        {
            get;
            set;
        }

        private int caster_level
        {
            get;
            set;
        }

        private int deleted;
        

        public Characters characters
        {
            get;
            set;
        }

        public Classes Classes
        {
            get;
            set;
        }

        public void delete(int characterKey, int classKey)
        {
            delete(TABLE, FIELD1, FIELD2, characterKey, classKey);
        }

        public Character_classes retrieveRecord(int characterKey, int classKey)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, class_id, level, caster_level, deleted FROM character_classes " + 
                    "WHERE character_id = @id1 AND class_id = @id2 AND deleted = 0";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", characterKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("@id2", classKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        this.character_id = read.GetInt32(0);
                        this.class_id = read.GetInt32(1);
                        this.level = read.GetInt32(2);
                        this.caster_level = read.GetInt32(3);
                        this.deleted = read.GetInt32(4);
                    } else
                    {
                        this.character_id = -1;
                        this.class_id = -1;
                        this.level = 0;
                        this.caster_level = 0;
                        this.deleted = 0;
                    }
                }
                conn.Close();
                return this;
            }
        }

        public void save()
        {
            String sql;
            int i1 = this.character_id, i2 = this.class_id, i3 = this.level, i4 = this.caster_level;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                

                retrieveRecord(character_id, class_id);
                
                if (this.character_id == -1 || this.class_id == -1)
                {
                    sql = "INSERT INTO character_classes (character_id, class_id, level, caster_level, deleted)" +
                        " VALUES (@id1, @id2, @id3, @id4, 0)";
                } else
                {
                    sql = "UPDATE character_classes SET level = @id3, caster_level = @id4" +
                        " WHERE character_id = @id1 AND class_id = @id2";
                }
                int i = runSqlite(sql, i1, i2, i3, i4);
                if (i > 0)
                {
                    retrieveRecord(i1, i2);
                }
            }
        }

        private int runSqlite (String sql, int i1, int i2, int i3, int i4)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", i1);
                command.Parameters.AddWithValue("id2", i2);
                command.Parameters.AddWithValue("id3", i3);
                command.Parameters.AddWithValue("id4", i4);

                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        public override string ToString()
        {
            return "Character Key: " + character_id + " Class Key: " + class_id +
                " Level: " + level + " Caster Level: " + caster_level + " deleted: " +
                deleted;
        }
    }
}
