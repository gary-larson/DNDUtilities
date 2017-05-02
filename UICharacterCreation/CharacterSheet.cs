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

        public Characters charInfo;                         // this works!
        public List<Character_abilities> abilityScores;     // this works!
        public List<Character_classes> classLevels;         // this kinda works!
        public Character_feats charFeats;                   // no
        public Character_hit_points HP;                     // this kinda works!
        public Character_languages languages;               // no
        public Character_possessions possessions;           // no
        public List<Character_skills> skills;               // this BETTER work!
        public Character_spells spells;                     // no
        public Character_stats stats;                       // HAHAHAH no
        public Character_wounds wounds;                     // why was this made

        public int ID
        {
            get
            {
                return charInfo.character_id;
            }
        }

        public CharacterSheet()
        {
            initComponenants();

        }

        public CharacterSheet(int ID)
        {

            // This populates a CharacterSheet with the proper character information
            // this also isnt implemented yet so just.... 
            // ignore me for now
            // lets DO THIS. 
            initComponenants();
            retrieveAll(ID);
            // turns out you can make your life a lot easier with properly implemented rfunctions lmao
        }
        public void initComponenants()
        {
            charInfo = new Characters();
            abilityScores = new List<Character_abilities>();
            classLevels = new List<Character_classes>();
            charFeats = new Character_feats();
            HP = new Character_hit_points();
            languages = new Character_languages();
            possessions = new Character_possessions();
            skills = new List<Character_skills>();
            spells = new Character_spells();
            stats = new Character_stats();
            wounds = new Character_wounds();
        }
        public void saveSkills()
        {
            foreach (Character_skills skill in skills)
            {
                /// int character_id, int skill_id, int skill_rank, int skill_modifier, int ability_modifier, int misc_modifier)
                skill.save(ID, skill.skill_id);
            }
        }

        public void saveAbilities()
        {
            foreach (Character_abilities a in abilityScores)
            {
                a.save();
            }
        }

        public List<int> getAbilityScores()
        {
            // currently returns last ability score in all 6 positions
            List<int> result = new List<int>();
            foreach (Character_abilities cab in abilityScores)
            {
                result.Add(cab.temp);               // this is in line with prior functionality that was brute forced. 
            }
            return result;
        }

        public void retrieveAll(int charID)
        {
            // update this function withthe functional bits!
            charInfo.retrieveRecord(charID);
            Character_abilities bob = new Character_abilities();
            for (int i = 1; i <= 6; i++)
            {
                bob.retrieveRecord(charID, i);
                abilityScores.Add(bob);
            }
            classLevels = Character_classes.retrieveAllClasses(ID);             // assuming this function is implemented, this should work... 
            HP.retrieveRecord(charID, charInfo.career_level);
            Character_skills billy = new Character_skills();
            List<NameKey> characterSkills = Character_skills.retrieveAllSkills(ID);
            Character_skills Beep = new Character_skills();
            foreach (NameKey n in characterSkills)
            {
                Beep.retrieveRecord(charID, n.key);
                skills.Add(Beep);
            }
        }
    }
}
