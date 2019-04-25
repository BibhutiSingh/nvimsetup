using System;
using System.Collections.Generic;
using System.Linq;
namespace DeltaX.App.DAL
{
interface IRepository<T> where T:class
{
    void Add(T t);
    IEnumerable<T> GetAll();
    
}}