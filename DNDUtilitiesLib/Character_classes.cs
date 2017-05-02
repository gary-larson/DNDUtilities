using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_classes
    /// </summary>
    public class Character_classes : DBTable_bridge
    {
        // Declares constants
        private const string TABLE = "character_classes";
        private const string FIELD1 = "character_id";
        private const string FIELD2 = "class_id";
        
        /// <summary>
        /// Constructor to initialize fileds
        /// </summary>
        public Character_classes ()
        {
            character_id = -1;
            class_id = -1;
            level = 0;
            caster_level = 0;
        }

        /// <summary>
        /// Constructor to populate all native fields
        /// </summary>
        /// <param name="character_id">primary key</param>
        /// <param name="class_id">primary key</param>
        /// <param name="level"> level of class</param>
        /// <param name="caster_level">spell caster level</param>
        public Character_classes(int character_id, int class_id, int level, int caster_level)
        {
            this.character_id = character_id;
            this.class_id = class_id;
            this.level = level;
            this.caster_level = caster_level;
        }

        /// <summary>
        /// Constructor to populate all fields
        /// </summary>
        /// <param name="character_id">primary key</param>
        /// <param name="class_id">primary key</param>
        /// <param name="level"> level of class</param>
        /// <param name="caster_level">spell caster level</param>
        /// <param name="className">Name of the class</param>
        public Character_classes(int character_id, int class_id, string classname, int level, int caster_level)
        {
            this.character_id = character_id;
            this.class_id = class_id;
            this.level = level;
            this.caster_level = caster_level;
            this.className = classname;
        }

        // setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
        }

        public string className
        {
            get;
            set;
        }

        public int level
        {
            get;
            set;
        }

        public int caster_level
        {
            get;
            set;
        }

        private int deleted;
        
        /// <summary>
        /// Deletes record indicated by primary key
        /// </summary>
        /// <param name="characterKey">part of primary key</param>
        /// <param name="classKey">part of primary key</param>
        public void delete(int characterKey, int classKey)
        {
            delete(TABLE, FIELD1, FIELD2, characterKey, classKey);
        }

        /// <summary>
        /// Gets record indicated by primary key
        /// </summary>
        /// <param name="characterKey">part of primary key</param>
        /// <param name="classKey">part of primary key</param>
        public void retrieveRecord(int characterKey, int classKey)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, class_id, (SELECT name FROM classes WHERE class_id = @id2), level, caster_level, deleted " +
                    "FROM character_classes " +
                    "WHERE character_id = @id1 AND class_id = @id2 AND deleted = 0";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", characterKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("id2", classKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        character_id = read.GetInt32(0);
                        class_id = read.GetInt32(1);
                        className = read.GetString(2);
                        level = read.GetInt32(3);
                        caster_level = read.GetInt32(4);
                        deleted = read.GetInt32(5);
                    } else
                    {
                        character_id = -1;
                        class_id = -1;
                        className = null;
                        level = 0;
                        caster_level = 0;
                        deleted = 0;
                    }
                }
                conn.Close();
               // return this;
            }
        }

        /// <summary>
        /// Gets all class records indicated by character key
        /// </summary>
        /// <param name="characterKey">part of primary key</param>
        /// <param name="classKey">part of primary key</param>
        /// <returns>a List of character classes</returns>
        public static List<Character_classes> retrieveAllClasses(int characterKey)
        {
            // declare variables
            List<Character_classes> l = new List<Character_classes>();

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, class_id, (SELECT name FROM classes WHERE class_id = character_classes.class_id), level, caster_level " +
                    "FROM character_classes " +
                    "WHERE character_id = @id1 AND deleted = 0";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("id1", characterKey.ToString()));
                

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int character_id = read.GetInt32(0);
                        int class_id = read.GetInt32(1);
                        string className = read.GetString(2);
                        int level = read.GetInt32(3);
                        int caster_level = read.GetInt32(4);
                        Character_classes cc = new Character_classes(character_id,
                            class_id, className, level, caster_level);
                        l.Add(cc);
                    }
                }
                conn.Close();
                return l;
            }
        }

        /// <summary>
        /// Inserts record if primary key does not exists otherwise updates record
        /// </summary>
        /// <param name="characterKey">character key if included it is used else uses character_id</param>
        /// <param name=classKey">class key if included it is used else uses class_id</param>
        public void save(int characterKey = -1, int classKey = -1)
        {
            String sql;

            if (characterKey > 0)
            {
                character_id = characterKey;
            }
            if (classKey > 0)
            {
                class_id = classKey;
            }
            if (!keyExists(TABLE, FIELD1, FIELD2, character_id, class_id))
            {
                sql = "INSERT INTO character_classes (character_id, class_id, level, caster_level, deleted)" +
                    " VALUES (@id1, @id2, @id3, @id4, 0)";
            } else
            {
                sql = "UPDATE character_classes SET level = @id3, caster_level = @id4" +
                    " WHERE character_id = @id1 AND class_id = @id2";
            }
            int i = runSqlite(sql);
            
       }

        /// <summary>
        /// Helper method to process Sql command
        /// </summary>
        /// <param name="sql">Sql command to process</param>
        /// <returns>number of records affected</returns>
        private int runSqlite(String sql)
        {
            int i;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;

                command.Parameters.AddWithValue("id1", character_id);
                command.Parameters.AddWithValue("id2", class_id);
                command.Parameters.AddWithValue("id3", level);
                command.Parameters.AddWithValue("id4", caster_level);

                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        /// <summary>
        /// String representation of the record in this object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Character Key: " + character_id + " Class Name: " + className +
                " Level: " + level + " Caster Level: " + caster_level + " deleted: " +
                deleted;
        }
    }
}
