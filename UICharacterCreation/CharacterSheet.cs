using DNDUtilitiesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UICharacterCreation
{
    public class CharacterSheet
    {
        // ---------------------------Class Description----------------------------------------- //
        // This class will act as an intermediary between the forms and the database, mostly to unify DB functionality. 
        // the class diagram will be updated once this class actually knows what does in it
        // this class encapsulates the other Classes (detailed below)


        // ---------------------------database documentation------------------------------------ //
        // Characters has Mostly cosmetic information about a PC, and is Primary-keyed based on Character level
        // Character Abilities is Wherea Character's ability scores are stored, 
        // Character Classes is a Collection of All classes a particular Character has, adhering to the [Name]X [Name2]Y format
        // Character_feats is a collection of all feats a character has, classified by Character ID
        // Character_hit_points is the Total HP at each level, requireing careful calculations when Con modifers change
        // Character_Languages is just a collection of a character's languages
        // Character Possessions is a collection of a character's equipment, with space for equip position and quantity
        // Character Skills Stores how many _full_ ranks are allocated in each skill. Partial ranks are not supported. 
        // Character Spells is a listing of all Spells Known by a Character
        // Character Stats are combat statistics, saves, and the like.
        // Character Wounds are injuries incurred to characters.... Why are we tracking this. 

        public Characters charInfo;
        public Character_abilities abilityScores;
        public Character_classes classLevels;
        public Character_feats charFeats;
        public Character_hit_points HP;
        public Character_languages languages;
        public Character_possessions possessions;
        public List<Character_skills> skills;
        public Character_spells spells;
        public Character_stats stats;
        public Character_wounds wounds;

        public int ID
        {
            get
            {
                return charInfo.character_id;
            }
        }

        public CharacterSheet()
        {
            charInfo = new Characters();
            abilityScores = new Character_abilities();
            classLevels = new Character_classes();
            charFeats = new Character_feats();
            HP = new Character_hit_points();
            languages = new Character_languages();
            possessions = new Character_possessions();
            skills = new List<Character_skills>();
            spells = new Character_spells();
            stats = new Character_stats();
            wounds = new Character_wounds();
        }

        public CharacterSheet(int ID)
        {
            // This populates a CharacterSheet with the proper character information
            // this also isnt implemented yet so just.... 
            // ignore me for now
        }

        public void saveSkills()
        {
            foreach (Character_skills skill in skills)
            {
                /// int character_id, int skill_id, int skill_rank, int skill_modifier, int ability_modifier, int misc_modifier)
                skill.save(ID, skill.skill_id);
            }
        }
    }
}
