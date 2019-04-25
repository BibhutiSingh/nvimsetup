using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
namespace DeltaX.App.DAL
{
    
    public class DALTest
    {
        public bool TestConnection()
        {
            try
            {
                var res=false;
            using(SQLiteConnection conn=new SQLiteConnection("Data Source=Main.db"))
            {
                conn.Open();
                res=true;


            }
            return res;
            }
            catch(Exception ){
                throw;

            }
            

            
        }


    }
}
