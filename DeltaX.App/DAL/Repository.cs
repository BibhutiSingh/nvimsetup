using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using Dapper;
namespace DeltaX.App.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        
        public void Add(T t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            string tblName= typeof(T).Name;
            using(UnitOfWork currUnit=new UnitOfWork())
            {
                string sql="select * from "+tblName;
                var dataList=currUnit.conn.Query<T>(sql).ToList();
                return dataList;
            }
        }
    }
}
