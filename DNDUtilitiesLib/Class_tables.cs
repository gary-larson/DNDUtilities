using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Class_tables : DBTable
    {
        public int class_table_id
        {
            get;
            private set;
        }

        public int class_id
        {
            get;
            private set;
        }

        public int level
        {
            get;
            set;
        }

        public string base_attack_bonus
        {
            get;
            set;
        }

        public int fort_save
        {
            get;
            set;
        }

        public int ref_save
        {
            get;
            set;
        }

        public int will_save
        {
            get;
            set;
        }

        public int ac_bonus
        {
            get;
            set;
        }

        public int flurry_of_blows
        {
            get;
            set;
        }

        public int unarmored_speed_bonus
        {
            get;
            set;
        }

        public string unarmed_damage
        {
            get;
            set;
        }

        public string special
        {
            get;
            set;
        }

        public int slots_0
        {
            get;
            set;
        }

        public int slots_1
        {
            get;
            set;
        }

        public int slots_2
        {
            get;
            set;
        }

        public int slots_3
        {
            get;
            set;
        }

        public int slots_4
        {
            get;
            set;
        }

        public int slots_5
        {
            get;
            set;
        }

        public int slots_6
        {
            get;
            set;
        }

        public int slots_7
        {
            get;
            set;
        }

        public int slots_8
        {
            get;
            set;
        }

        public int slots_9
        {
            get;
            set;
        }

        public int spells_known_0
        {
            get;
            set;
        }

        public int spells_known_1
        {
            get;
            set;
        }

        public int spells_known_2
        {
            get;
            set;
        }

        public int spells_known_3
        {
            get;
            set;
        }

        public int spells_known_4
        {
            get;
            set;
        }

        public int spells_known_5
        {
            get;
            set;
        }

        public int spells_known_6
        {
            get;
            set;
        }

        public int spells_known_7
        {
            get;
            set;
        }

        public int spells_known_8
        {
            get;
            set;
        }

        public int spells_known_9
        {
            get;
            set;
        }

        /// <summary>
        /// Retrieves record from the database and populates this object
        /// </summary>
        /// <param name="key">the class id to be returned</param>
        public void retrieveRecord(int classKey, int level)
        {
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT class_table_id, class_id, level, base_attack_bonus, " +
                    "fort_save, ref_save, will_save, ac_bonus, flurry_of_blows, unarmored_speed_bonus, " +
                    "unarmed_damage, special, slots_0, slots_1, slots_2, slots_3, slots_4, slots_5, " +
                    "slots_6, slots_7, slots_8, slots_9, spells_known_0, spells_known_1, spells_known_2, " +
                    "spells_known_3, spells_known_4, spells_known_5, spells_known_6, spells_known_7, " +
                    "spells_known_8, spells_known_9 " +
                    "FROM class_tables where class_id = @id1 and level = @id2";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", classKey.ToString()));
                command.Parameters.Add(new SQLiteParameter("@id2", level.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        class_table_id = read.GetInt32(0);
                        class_id = read.GetInt32(1);
                        level = read.GetInt32(2);
                        base_attack_bonus = read[3].ToString();
                        if (read[4].GetType() != typeof(DBNull))
                            fort_save = read.GetInt32(4);
                        else
                            fort_save = 0;
                        if (read[5].GetType() != typeof(DBNull))
                            ref_save = read.GetInt32(5);
                        else
                            ref_save = 0;
                        if (read[6].GetType() != typeof(DBNull))
                            will_save = read.GetInt32(6);
                        else
                            will_save = 0;
                        if (read[7].GetType() != typeof(DBNull))
                            ac_bonus = read.GetInt32(7);
                        else
                            ac_bonus = 0;
                        if (read[8].GetType() != typeof(DBNull))
                            flurry_of_blows = read.GetInt32(8);
                        else
                            flurry_of_blows = 0;
                        if (read[9].GetType() != typeof(DBNull))
                            unarmored_speed_bonus = read.GetInt32(9);
                        else
                            unarmored_speed_bonus = 0;
                        unarmed_damage = read[10].ToString();
                        special = read[11].ToString();
                        if (read[12].GetType() != typeof(DBNull))
                            slots_0 = read.GetInt32(12);
                        else
                            slots_0 = 0;
                        if (read[13].GetType() != typeof(DBNull))
                            slots_1 = read.GetInt32(13);
                        else
                            slots_1 = 0;
                        if (read[14].GetType() != typeof(DBNull))
                            slots_2 = read.GetInt32(14);
                        else
                            slots_2 = 0;
                        if (read[15].GetType() != typeof(DBNull))
                            slots_3 = read.GetInt32(15);
                        else
                            slots_3 = 0;
                        if (read[16].GetType() != typeof(DBNull))
                            slots_4 = read.GetInt32(16);
                        else
                            slots_4 = 0;
                        if (read[17].GetType() != typeof(DBNull))
                            slots_5 = read.GetInt32(17);
                        else
                            slots_5 = 0;
                        if (read[18].GetType() != typeof(DBNull))
                            slots_6 = read.GetInt32(18);
                        else
                            slots_6 = 0;
                        if (read[19].GetType() != typeof(DBNull))
                            slots_7 = read.GetInt32(19);
                        else
                            slots_7 = 0;
                        if (read[20].GetType() != typeof(DBNull))
                            spells_known_0 = read.GetInt32(20);
                        else
                            spells_known_0 = 0;
                        if (read[21].GetType() != typeof(DBNull))
                            spells_known_1 = read.GetInt32(21);
                        else
                            spells_known_1 = 0;
                        if (read[22].GetType() != typeof(DBNull))
                            spells_known_2 = read.GetInt32(22);
                        else
                            spells_known_2 = 0;
                        if (read[23].GetType() != typeof(DBNull))
                            spells_known_3 = read.GetInt32(23);
                        else
                            spells_known_3 = 0;
                        if (read[24].GetType() != typeof(DBNull))
                            spells_known_4 = read.GetInt32(24);
                        else
                            spells_known_4 = 0;
                        if (read[25].GetType() != typeof(DBNull))
                            spells_known_5 = read.GetInt32(25);
                        else
                            spells_known_5 = 0;
                        if (read[26].GetType() != typeof(DBNull))
                            spells_known_6 = read.GetInt32(26);
                        else
                            spells_known_6 = 0;
                        if (read[27].GetType() != typeof(DBNull))
                            spells_known_7 = read.GetInt32(27);
                        else
                            spells_known_7 = 0;
                    }
                    //return this;
                }
            }
        }

        public override string ToString()
        {
            return "class_id: " + class_id + " Level: " + level;
        }
    }
}
