using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    /// <summary>
    /// Class that represents a record of the database table character_stats
    /// </summary>
    public class Character_stats : DBTable
    {
        //Declare constants
        const string TABLE = "character_stats";
        const string FIELD = "character_id";
        bool isInsert = false;

        // Setup fields with properties
        public int character_id
        {
            get;
            private set;
        }

        public int total
        {
            get;
            set;
        }

        public int armor_bonus
        {
            get;
            set;
        }

        public int shield_bonus
        {
            get;
            set;
        }

        public int dex_modifier
        {
            get;
            set;
        }

        public int size_modifier
        {
            get;
            set;
        }

        public int natural_armor
        {
            get;
            set;
        }

        public int deflection_modifier
        {
            get;
            set;
        }

        public int misc_modifier
        {
            get;
            set;
        }

        public int damage_reduction
        {
            get;
            set;
        }

        public int touch
        {
            get;
            set;
        }

        public int flat_footed
        {
            get;
            set;
        }

        public int initiative_total
        {
            get;
            set;
        }

        public int initiative_dex_modifier
	    {
		    get;
		    set;
	    }

        public int initiative_misc_modifier
	    {
		    get;
		    set;
	    }

        public int fortitude
        {
            get;
            set;
        }

        public int fortitude_base_save
        {
            get;
            set;
        }

        public int fortitude_ability_modifier
        {
            get;
            set;
        }

        public int fortitude_magic_modifier
        {
            get;
            set;
        }

        public int fortitude_misc_modifier
        {
            get;
            set;
        }

        public int fortitude_temp_modifier
        {
            get;
            set;
        }

        public string fortitude_conditions
        {
            get;
            set;
        }

        public int reflex
        {
            get;
            set;
        }

        public int reflex_base_save
        {
            get;
            set;
        }

        public int reflex_ability_modifier
        {
            get;
            set;
        }

        public int reflex_magic_modifier
        {
            get;
            set;
        }

        public int reflex_misc_modifier
        {
            get;
            set;
        }

        public int reflex_temp_modifier
        {
            get;
            set;
        }

        public string reflex_conditions
        {
            get;
            set;
        }

        public int will
        {
            get;
            set;
        }

        public int will_base_save
        {
            get;
            set;
        }

        public int will_ability_modifier
        {
            get;
            set;
        }

        public int will_magic_modifier
        {
            get;
            set;
        }

        public int will_misc_modifier
        {
            get;
            set;
        }

        public int will_temp_modifier
        {
            get;
            set;
        }

        public string will_conditions
        {
            get;
            set;
        }

        public int base_attack_bonus
        {
            get;
            set;
        }

        public int spell_resistance
        {
            get;
            set;
        }

        public int grapple
        {
            get;
            set;
        }

        public int grapple_base_attack_bonus
        {
            get;
            set;
        }

        public int grapple_str_modifier
        {
            get;
            set;
        }

        public int grapple_size_modifier
        {
            get;
            set;
        }

        public int grapple_misc_modifier
        {
            get;
            set;
        }

        private int deleted
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor to initialize member variables
        /// </summary>
        public Character_stats()
        {
            character_id = -1;
            total = 0;
            armor_bonus = 0;
            shield_bonus = 0;
            dex_modifier = 0;
            natural_armor = 0;
            deflection_modifier = 0;
            misc_modifier = 0;
            damage_reduction = 0;
            touch = 0;
            flat_footed = 0;
            initiative_total = 0;
            initiative_dex_modifier = 0;
            initiative_misc_modifier = 0;
            fortitude = 0;
            fortitude_base_save = 0;
            fortitude_ability_modifier = 0;
            fortitude_magic_modifier = 0;
            fortitude_misc_modifier = 0;
            fortitude_temp_modifier = 0;
            fortitude_conditions = null;
            reflex = 0;
            reflex_base_save = 0;
            reflex_ability_modifier = 0;
            reflex_magic_modifier = 0;
            reflex_misc_modifier = 0;
            reflex_temp_modifier = 0;
            reflex_conditions = null;
            will = 0;
            will_base_save = 0;
            will_ability_modifier = 0;
            will_magic_modifier = 0;
            will_misc_modifier = 0;
            will_temp_modifier = 0;
            will_conditions = null;
            base_attack_bonus = 0;
            spell_resistance = 0;
            grapple = 0;
            grapple_base_attack_bonus = 0;
            grapple_str_modifier = 0;
            grapple_size_modifier = 0;
            grapple_misc_modifier = 0;
            deleted = 0;
        }

        /// <summary>
        /// Retrieve record from database
        /// </summary>
        /// <param name="characterKey">To determine record to get</param>
        /// <returns>this object populated from database if record exists</returns>
        public Character_stats retrieveRecord(int characterKey)
        {

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = CONNECTION_STR;
                conn.Open();

                String sql = "SELECT character_id, total, armor_bonus, shield_bonus, size_modifier, dex_modifier, natural_armor, deflection_modifier, " +
                    "misc_modifier, damage_reduction, touch, flat_footed, initiative_total, initiative_dex_modifier, initiative_misc_modifier, " +
                    "fortitude, fortitude_base_save, fortitude_ability_modifier, fortitude_magic_modifier, fortitude_misc_modifier, " +
                    "fortitude_temp_modifier, fortitude_conditions, reflex, reflex_base_save, reflex_ability_modifier, reflex_magic_modifier, " +
                    "reflex_misc_modifier, reflex_temp_modifier, reflex_conditions, will, will_base_save, will_ability_modifier, will_magic_modifier, " +
                    "will_misc_modifier, will_temp_modifier, will_conditions, base_attack_bonus, spell_resistance, grapple, grapple_base_attack_bonus, " +
                    "grapple_str_modifier, grapple_size_modifier, grapple_misc_modifier FROM character_stats WHERE character_id = @id1 AND deleted = 0";

                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SQLiteParameter("@id1", characterKey.ToString()));

                using (SQLiteDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        character_id = read.GetInt32(0);
                        total = read.GetInt32(1);
                        armor_bonus = read.GetInt32(2);
                        shield_bonus = read.GetInt32(3);
                        size_modifier = read.GetInt32(4);
                        dex_modifier = read.GetInt32(5);
                        natural_armor = read.GetInt32(6);
                        deflection_modifier = read.GetInt32(7);
                        misc_modifier = read.GetInt32(8);
                        damage_reduction = read.GetInt32(9);
                        touch = read.GetInt32(10);
                        flat_footed = read.GetInt32(11);
                        initiative_total = read.GetInt32(12);
                        initiative_dex_modifier = read.GetInt32(13);
                        initiative_misc_modifier = read.GetInt32(14);
                        fortitude = read.GetInt32(15);
                        fortitude_base_save = read.GetInt32(16);
                        fortitude_ability_modifier = read.GetInt32(17);
                        fortitude_magic_modifier = read.GetInt32(18);
                        fortitude_misc_modifier = read.GetInt32(19);
                        fortitude_temp_modifier = read.GetInt32(20);
                        fortitude_conditions = read.GetString(21);
                        reflex = read.GetInt32(22);
                        reflex_base_save = read.GetInt32(23);
                        reflex_ability_modifier = read.GetInt32(24);
                        reflex_magic_modifier = read.GetInt32(25);
                        reflex_misc_modifier = read.GetInt32(26);
                        reflex_temp_modifier = read.GetInt32(27);
                        reflex_conditions = read.GetString(28);
                        will = read.GetInt32(29);
                        will_base_save = read.GetInt32(30);
                        will_ability_modifier = read.GetInt32(31);
                        will_magic_modifier = read.GetInt32(32);
                        will_misc_modifier = read.GetInt32(33);
                        will_temp_modifier = read.GetInt32(34);
                        will_conditions = read.GetString(35);
                        base_attack_bonus = read.GetInt32(36);
                        spell_resistance = read.GetInt32(37);
                        grapple = read.GetInt32(38);
                        grapple_base_attack_bonus = read.GetInt32(39);
                        grapple_str_modifier = read.GetInt32(40);
                        grapple_size_modifier = read.GetInt32(41);
                        grapple_misc_modifier = read.GetInt32(42);
                        deleted = 0;
                    }
                    else
                    {
                        character_id = -1;
                        total = 0;
                        armor_bonus = 0;
                        shield_bonus = 0;
                        size_modifier = 0;
                        dex_modifier = 0;
                        natural_armor = 0;
                        deflection_modifier = 0;
                        misc_modifier = 0;
                        damage_reduction = 0;
                        touch = 0;
                        flat_footed = 0;
                        initiative_total = 0;
                        initiative_dex_modifier = 0;
                        initiative_misc_modifier = 0;
                        fortitude = 0;
                        fortitude_base_save = 0;
                        fortitude_ability_modifier = 0;
                        fortitude_magic_modifier = 0;
                        fortitude_misc_modifier = 0;
                        fortitude_temp_modifier = 0;
                        fortitude_conditions = null;
                        reflex = 0;
                        reflex_base_save = 0;
                        reflex_ability_modifier = 0;
                        reflex_magic_modifier = 0;
                        reflex_misc_modifier = 0;
                        reflex_temp_modifier = 0;
                        reflex_conditions = null;
                        will = 0;
                        will_base_save = 0;
                        will_ability_modifier = 0;
                        will_magic_modifier = 0;
                        will_misc_modifier = 0;
                        will_temp_modifier = 0;
                        will_conditions = null;
                        base_attack_bonus = 0;
                        spell_resistance = 0;
                        grapple = 0;
                        grapple_base_attack_bonus = 0;
                        grapple_str_modifier = 0;
                        grapple_size_modifier = 0;
                        grapple_misc_modifier = 0;
                        deleted = 0;
                    }
                }
                conn.Close();
                return this;
            }
        }

        /// <summary>
        /// Get all character names
        /// </summary>
        /// <param name="characterKey">To determine record to get if passed in it is used otherwise it is ignored</param>
        /// <returns>list of all names</returns>
        public static List<NameKey> retrieveAll()
        {
            return retrieveAll(TABLE, FIELD);
        }

        /// <summary>
        /// Save record in database if does not exist Update existing record otherwise
        /// </summary>
        /// <returns>character_id is successful -1 otherwise</returns>
        public int save(int characterKey = -1)
        {
            int i;
            String sql;

            if (characterKey > 0)
            {
                character_id = characterKey;
            }

            using (SQLiteConnection conn = new SQLiteConnection())
            {
                // tests if record exists
                if (!keyExists(TABLE, FIELD, character_id))
                {
                    sql = "INSERT INTO character_stats (character_id, total, armor_bonus, shield_bonus, dex_modifier, size_modifier, natural_armor, deflection_modifier, " +
                        "misc_modifier, damage_reduction, touch, flat_footed, initiative_total, initiative_dex_modifier, initiative_misc_modifier, " +
                        "fortitude, fortitude_base_save, fortitude_ability_modifier, fortitude_magic_modifier, fortitude_misc_modifier, " +
                        "fortitude_temp_modifier, fortitude_conditions, reflex, reflex_base_save, reflex_ability_modifier, reflex_magic_modifier, " +
                        "reflex_misc_modifier, reflex_temp_modifier, reflex_conditions, will, will_base_save, will_ability_modifier, will_magic_modifier, " +
                        "will_misc_modifier, will_temp_modifier, will_conditions, base_attack_bonus, spell_resistance, grapple, grapple_base_attack_bonus, " +
                        "grapple_str_modifier, grapple_size_modifier, grapple_misc_modifier, deleted)" +
                        " VALUES (@id43, @id1, @id2, @id3, @id4, @id5, @id6, @id7, @id8, @id9, @id10, @id11, @id12, @id13, @id14, @id15, @id16, @id17, @id18, @id19, " +
                        "@id20, @id21, @id22, @id23, @id24, @id25, @id26, @id27, @id28, @id29, @id30, @id31, @id32, @id33, @id34, @id35, @id36, @id37, @id38, " +
                        "@id39, @id40, @id41, @id42, 0)";

                    i = runSqlite(sql);
                }
                else
                {
                    sql = "UPDATE character_stats SET total = @id1, armor_bonus = @id2, shield_bonus = @id3, dex_modifier = @id4, size_modifier = @id5, " +
                        "natural_armor = @id6, deflection_modifier = @id7, misc_modifier = @id8, damage_reduction = @id9, " +
                        "touch = @id10, flat_footed = @id11, initiative_total = @id12, initiative_dex_modifier = @id13, " +
                        "initiative_misc_modifier = @id14, fortitude = @id15, fortitude_base_save = @id16, fortitude_ability_modifier = @id17, " +
                        "fortitude_magic_modifier = @id18, fortitude_misc_modifier = @id19, fortitude_temp_modifier = @id20, fortitude_conditions = @id21, " +
                        "reflex = @id22, reflex_base_save = @id23, reflex_ability_modifier = @id24, reflex_magic_modifier = @id25, reflex_misc_modifier = @id26, " +
                        "reflex_temp_modifier = @id27, reflex_conditions = @id28, will = @id29, will_base_save = @id30, will_ability_modifier = @id31, " +
                        "will_magic_modifier = @id32, will_misc_modifier = @id33, will_temp_modifier = @id34, will_conditions = @id35, " +
                        "base_attack_bonus = @id36, spell_resistance = @id37, grapple = @id38, grapple_base_attack_bonus = @id39, " +
                        "grapple_str_modifier = @id40, grapple_size_modifier = @id41, grapple_misc_modifier = @id42, deleted = 0 " +
                        "WHERE character_id = @id43";

                    isInsert = false;

                    i = runSqlite(sql);
                }

                return i;
            }
        }

        /// <summary>
        /// Deletes the record represented by character_id
        /// </summary>
        public void delete()
        {
            delete(TABLE, FIELD, character_id);
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

                command.Parameters.AddWithValue("id1", total);
                command.Parameters.AddWithValue("id2", armor_bonus);
                command.Parameters.AddWithValue("id3", shield_bonus);
                command.Parameters.AddWithValue("id4", dex_modifier);
                command.Parameters.AddWithValue("id5", size_modifier);
                command.Parameters.AddWithValue("id6", natural_armor);
                command.Parameters.AddWithValue("id7", deflection_modifier);
                command.Parameters.AddWithValue("id8", misc_modifier);
                command.Parameters.AddWithValue("id9", damage_reduction);
                command.Parameters.AddWithValue("id10", touch);
                command.Parameters.AddWithValue("id11", flat_footed);
                command.Parameters.AddWithValue("id12", initiative_total);
                command.Parameters.AddWithValue("id13", initiative_dex_modifier);
                command.Parameters.AddWithValue("id14", initiative_misc_modifier);
                command.Parameters.AddWithValue("id15", fortitude);
                command.Parameters.AddWithValue("id16", fortitude_base_save);
                command.Parameters.AddWithValue("id17", fortitude_ability_modifier);
                command.Parameters.AddWithValue("id18", fortitude_magic_modifier);
                command.Parameters.AddWithValue("id19", fortitude_misc_modifier);
                command.Parameters.AddWithValue("id20", fortitude_temp_modifier);
                command.Parameters.AddWithValue("id21", fortitude_conditions);
                command.Parameters.AddWithValue("id22", reflex);
                command.Parameters.AddWithValue("id23", reflex_base_save);
                command.Parameters.AddWithValue("id24", reflex_ability_modifier);
                command.Parameters.AddWithValue("id25", reflex_magic_modifier);
                command.Parameters.AddWithValue("id26", reflex_misc_modifier);
                command.Parameters.AddWithValue("id27", reflex_temp_modifier);
                command.Parameters.AddWithValue("id28", reflex_conditions);
                command.Parameters.AddWithValue("id29", will);
                command.Parameters.AddWithValue("id30", will_base_save);
                command.Parameters.AddWithValue("id31", will_ability_modifier);
                command.Parameters.AddWithValue("id32", will_magic_modifier);
                command.Parameters.AddWithValue("id33", will_misc_modifier);
                command.Parameters.AddWithValue("id34", will_temp_modifier);
                command.Parameters.AddWithValue("id35", will_conditions);
                command.Parameters.AddWithValue("id36", base_attack_bonus);
                command.Parameters.AddWithValue("id37", spell_resistance);
                command.Parameters.AddWithValue("id38", grapple);
                command.Parameters.AddWithValue("id39", grapple_base_attack_bonus);
                command.Parameters.AddWithValue("id40", grapple_str_modifier);
                command.Parameters.AddWithValue("id41", grapple_size_modifier);
                command.Parameters.AddWithValue("id42", grapple_misc_modifier);
                command.Parameters.AddWithValue("id43", character_id);

                i = command.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }


        // Gives string representation of this object
        public override string ToString()
        {
            return "character_id: " + character_id + " Total: " + total;
        }
    }
}
