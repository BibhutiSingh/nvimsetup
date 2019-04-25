using System;
using System.Collections.Generic;
using System.Linq;
namespace DeltaX.App.DAL
{
interface IUnitOfWork
{
    void BeginTransaction();
    void CommitTransaction();
    void RollbackTransaction();
    
}}