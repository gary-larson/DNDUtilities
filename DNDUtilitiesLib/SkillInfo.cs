using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class SkillInfo
    {
        public SkillInfo(int skill_id, string name, int adjustment,
            string subType, int ability_id, string ability)
        {
            this.skill_id = skill_id;
            this.name = name;
            this.adjustment = adjustment;
            this.subType = subType;
            this.ability_id = ability_id;
            this.ability = ability;
        }

        public string ability { get; private set; }
        public int ability_id { get; private set; }
        public int adjustment { get; private set; }
        public string name { get; private set; }
        public int skill_id { get; private set; }
        public string subType { get; private set; }

        /// <summary>
        /// outputs object as a string
        /// </summary>
        /// <returns>String representing object</returns>
        public override string ToString()
        {
            return "skill_id: " + skill_id + " name: " + name + " Adj: " + adjustment +
                " SubType: " + subType + " ability_id: " + ability_id + " Ability Name: " +
                ability;

        }

    }

    
}