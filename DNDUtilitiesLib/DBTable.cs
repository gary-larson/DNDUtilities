using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace DNDUtilitiesLib
{
    public class DBTable
    {
        public const String CONNECTION_STR = "data source=DNDDatabase.db3";
        

        public virtual void Save(string Table, object Key, List<String> FieldList)
        {
            throw new System.NotImplementedException();
        }

     //   public virtual SQLiteDataReader retrieve(string table, int key, String fieldList, String field)
     //   {
            
                    
     //   }

        public virtual void delete(string Table, int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
