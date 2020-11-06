using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using deniz.Todo.DataAccess.EntityFrameworkCore.Context;
using deniz.Todo.DataAccess.Interface;
using deniz.Todo.Entities.Interfaces;

namespace deniz.Todo.DataAccess.EntityFrameworkCore.Repositories
{
  public class GenericRepository_EntityFramework<MyTable> : IGenericDal<MyTable> where MyTable : class, ITable, new()
    {
        public void Delete(MyTable myTable)
        {
            using var context = new TodoContext();
            context.Entry(myTable).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //context.MyTables.Remove(work);
            context.SaveChanges();
        }

        public List<MyTable> GetAll()
        {
            // using kullanildiginda ıcerısındekı islem yapilir sonra garbage
            // collector a gonderilir.
            using (var context = new TodoContext())
            {
                return context.Set<MyTable>().ToList();
            }
        }

        public MyTable GetById(int id)
        {
            using var context = new TodoContext();
            return context.Set<MyTable>().Find(id);
        }

        public void Save(MyTable myTable)
        {
            using var context = new TodoContext();
            context.Entry(myTable).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            // ust satir ile alt satir alternatif farki ise alttaki tum alanlari kapsamaktadir.  
            // context.MyTables.Add(work);
            context.SaveChanges();

        }

        public void Update(MyTable myTable)
        {
            using var context = new TodoContext();
            context.Entry(myTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            // ust satir ile alt satir alternatif farki ise alttaki tum alanlari kapsamaktadir.  
            // ornek olarak sutun2=deger2 seklinde guncelleme yapmamiz gerekiyor
            // allttaki tum alanlari guncelleyerek yaparak ustteki ilgili yeri guncelleyerek
            // context.MyTables.Update(work);
            context.SaveChanges();
        }
    }
}
