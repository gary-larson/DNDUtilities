using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Races : DBTable
    {
        const string TABLE = "races";
        const string FIELD = "race_id";
        private int race_id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        private int size_id
        {
            get;
            set;
        }

        public int speed
        {
            get;
            set;
        }

        public int extra_feat
        {
            get;
            set;
        }

        public int extra_skill_points
        {
            get;
            set;
        }

        public string speed_condition
        {
            get;
            set;
        }

        public bool dark_vision
        {
            get;
            set;
        }

        public bool low_light_vision
        {
            get;
            set;
        }

        public bool stone_cunning
        {
            get;
            set;
        }

        
        public static List<NameKey> retrieveAllRaces()
        {
            return retrieveAll(TABLE, FIELD);
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
