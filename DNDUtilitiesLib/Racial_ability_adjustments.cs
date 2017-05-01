using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Racial_ability_adjustment : DBTable_bridge
    {
        public int race_id
        {
            get;
            private set;
        }

        public int ability_id
        {
            get;
            private set;
        }

        public int adjustment
        {
            get;
            set;
        }

        internal string FIELD
        {
            get;
            set;
        }

        internal string FIELD_LIST
        {
            get;
            set;
        }

        internal string TABLE
        {
            get;
            set;
        }

        /// <summary>
        /// Retrieves racial ability score adjustments
        /// </summary>
        /// <param name="raceKey">Race to get adjustments for</param>
        /// <returns>an int array of size 4 
        /// 0 = ability_id 1 = adj 2 = ability_id 3 = adj</returns>
        public static int[] retrieveRacialAdjustments(int raceKey)
        {
            int[] iReturn = { 0, 0, 0, 0, 0, 0 };

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT ability_id, adjustment " +
                    "FROM racial_ability_adjustments WHERE race_id = @id";
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id", raceKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        if (read[0].GetType() != typeof(DBNull))
                            iReturn[0] = read.GetInt32(0);
                        else
                            iReturn[0] = 0;
                        if (read[1].GetType() != typeof(DBNull))
                            iReturn[1] = read.GetInt32(1);
                        else
                            iReturn[1] = 0;
                        if (read.Read ())
                        {
                            if (read[0].GetType() != typeof(DBNull))
                                iReturn[2] = read.GetInt32(0);
                            else
                                iReturn[2] = 0;
                            if (read[1].GetType() != typeof(DBNull))
                                iReturn[3] = read.GetInt32(1);
                            else
                                iReturn[3] = 0;
                        }
                        if (read.Read())
                        {
                            if (read[0].GetType() != typeof(DBNull))
                                iReturn[4] = read.GetInt32(0);
                            else
                                iReturn[4] = 0;
                            if (read[1].GetType() != typeof(DBNull))
                                iReturn[5] = read.GetInt32(1);
                            else
                                iReturn[5] = 0;
                        }
                    }
                    
                    return iReturn;
                }
            }
        }


        public override string ToString()
        {
            return "race_id: " + race_id + " ability_id: " + ability_id + " adj: " + adjustment;
        }
    }
}
