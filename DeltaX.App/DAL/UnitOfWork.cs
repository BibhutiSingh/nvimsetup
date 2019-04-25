using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Data.SQLite;
namespace DeltaX.App.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        internal SQLiteConnection conn;
        private IDbTransaction tr;
        public UnitOfWork()
        {
            conn=new SQLiteConnection("Data Source=Main.db");
            conn.Open();
        }
        public void BeginTransaction()
        {
           tr= conn.BeginTransaction();
        }

        public void CommitTransaction()
        {
            tr.Commit();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public void RollbackTransaction()
        {
            tr.Rollback();
        }
    }
}