using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class DBTable
    {
        public DBTable ()
        {
            connection = "DNDDatabase\\bin\\Debug\\DNDDatabase.db3";
        }
        private string connection
        {
            get;
        }

        public virtual void Save()
        {
            throw new System.NotImplementedException();
        }

        public virtual void get()
        {
            throw new System.NotImplementedException();
        }

        public virtual void delete()
        {
            throw new System.NotImplementedException();
        }

    }
}
