using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Proficiencies : DBTable_bridge
    {
        public const string TABLE = "proficiencies";
        public const string FIELD = "weapon_proficiency_id";
        public int weapon_proficiency_id
        {
            get;
            private set;
        }

       public int equipment_id
        {
            get;
            private set;
        }

        public int category_id
        {
            get;
            private set;
        }

        public int subcategory_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
        }

        public String description
        {
            get;
            set;
        }

        
        public void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets this object to the record determined by character_id
        /// </summary>
        /// <param name="Key"></param>
        /// <returns> this object </returns>
        public Proficiencies retrieveRecord(int Key)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT weapon_proficiency_id, equipment_id, category_id, subcategory_id, class_id, description " +
                    "FROM proficiencies WHERE weapon_proficiency_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", Key.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        weapon_proficiency_id = read.GetInt32(0);
                        if (read[1].GetType() != typeof(DBNull))
                            equipment_id = read.GetInt32(1);
                        else
                            equipment_id = -1;
                        if (read[1].GetType() != typeof(DBNull))
                            category_id = read.GetInt32(1);
                        else
                            category_id = -1;
                        if (read[1].GetType() != typeof(DBNull))
                            subcategory_id = read.GetInt32(1);
                        else
                            subcategory_id = -1;
                        class_id = read.GetInt32(4);
                        description = read[5].ToString();
                    }
                    return this;
                }
            }
        }

        /// <summary>
        /// Get all proficiency names
        /// </summary>
        /// <returns>list of all proficiency names and weapon_proficiency_id</returns>
        public static List<NameKey> retrieveAllProficiencies(int classId)
        {
            List<NameKey> l = new List<NameKey>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT weapon_proficiency_id, " +                    
                    "(SELECT name FROM equipments WHERE equipments.equipment_id = proficiencies.equipment_id) " +
                    "FROM proficiencies WHERE class_id = @id1 AND equipment_id IS NOT NULL";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", classId.ToString()));

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
        /// Get all proficiency Category names
        /// </summary>
        /// <returns>list of all proficiency Category names and weapon_proficiency_id</returns>
        public static List<NameKey> retrieveAllProficienciesCategories(int classId)
        {
            List<NameKey> l = new List<NameKey>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT weapon_proficiency_id, " +
                    "(SELECT name FROM equipment_category WHERE equipment_category.category_id = proficiencies.category_id) " +
                    "FROM proficiencies WHERE class_id = @id1 AND category_id IS NOT NULL";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", classId.ToString()));

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
        /// Get all proficiency Category names
        /// </summary>
        /// <returns>list of all proficiency Category names and weapon_proficiency_id</returns>
        public static List<NameKey> retrieveAllProficienciesSubcategories(int classId)
        {
            List<NameKey> l = new List<NameKey>();
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT weapon_proficiency_id, " +
                    "(SELECT name FROM equipment_subcategory WHERE equipment_subcategory.subcategory_id = proficiencies.subcategory_id) " +
                    "FROM proficiencies WHERE class_id = @id1 AND subcategory_id IS NOT NULL";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", classId.ToString()));

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

        public void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Weapon_proficiency_id: " + weapon_proficiency_id + " Equipment_id: " + equipment_id +
                " category_id: " + category_id + " subcategory_id: " + subcategory_id +
                " class_id: " + class_id + " description: " + description;
        }
    }
}
