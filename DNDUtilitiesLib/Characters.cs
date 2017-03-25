using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Characters : DBTable
    {
        private int character_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string player_name
        {
            get;
            set;
        }

        public virtual int number_of_classes
        {
            get;
            set;
        }

        private int race_id
        {
            get;
            set;
        }

        private int alignment_id
        {
            get;
            set;
        }

        public virtual string deity
        {
            get;
            set;
        }

        private int size_id
        {
            get;
            set;
        }

        public virtual int age
        {
            get;
            set;
        }

        public virtual string gender
        {
            get;
            set;
        }

        public virtual int height
        {
            get;
            set;
        }

        public virtual int weight
        {
            get;
            set;
        }

        public virtual string eyes
        {
            get;
            set;
        }

        public virtual string hair
        {
            get;
            set;
        }

        public virtual string skin
        {
            get;
            set;
        }

        public virtual string description
        {
            get;
            set;
        }

        internal virtual string FIELD
        {
            get;
            set;
        }

        internal virtual string FIELD_LIST
        {
            get;
            set;
        }

        internal virtual string TABLE
        {
            get;
            set;
        }

        public virtual Alignments Alignments
        {
            get;
            set;
        }

        public virtual Races races
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Domains retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
