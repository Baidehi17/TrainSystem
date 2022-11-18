using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Security.Policy;
using TrainGR.Models;
using TrainGR.Repository;
using EntityState = System.Data.Entity.EntityState;

namespace TrainGR.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        

        private readonly TraininfoContext context;
        private readonly Microsoft.EntityFrameworkCore.DbSet<T> dbset;
        public Repository()
        {
            context = new TraininfoContext();
            dbset = context.Set<T>();
        }
        //get all data from respective table
        public IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable();
        }
        //get particular row data based on id(this id field should be the primary key field)
        public T GetByID(int id)
        {
            return dbset.Find(id);
        }
        // Add new record to respectiv table
        public T ADD(T ID)
        {
            dbset.Add(ID);
            Save();
            return ID;
        }
        // it 's to update the existing record
       

        // Delete respective record from respective table based on primarykey id

        public void Save()
        {
            context.SaveChanges();
        }

        //public T UPDATE(Train train)
          
       

        public T UPDATE(T id)
        {
            dbset.Attach(id);
            context.Entry(id).State = Microsoft.EntityFrameworkCore.EntityState.Modified;            
            Save();
            return id;
        }

        public T Deletes(T entityToDelete)
        {
          //  dbset.Find(entityToDelete);
            dbset.Remove(entityToDelete);
           return entityToDelete;
        }
    }
}
