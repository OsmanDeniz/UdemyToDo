using System;
using System.Collections.Generic;
using System.Linq;
using deniz.Todo.DataAccess.EntityFrameworkCore.Context;
using deniz.Todo.DataAccess.Interface;
using deniz.Todo.Entities.Concrete;
/// <summary>
/// 2.2 = Interface kullanarak Repository olusturma
/// </summary>
namespace deniz.Todo.DataAccess.EntityFrameworkCore.Repositories
{
    public class WorkRepository_EntityFramework : IWorkDal
    {
        public void Delete(Work work)
        {
            using var context = new TodoContext();
            context.Entry(work).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //context.Works.Remove(work);
            context.SaveChanges();
        }

        public List<Work> GetAll()
        {
            // using kullanildiginda ıcerısındekı islem yapilir sonra garbage
            // collector a gonderilir.
            using (var context = new TodoContext())
            {
                return context.Works.ToList();
            }
        }

        public Work GetById(int id)
        {
            using var context = new TodoContext();
            return context.Works.Find(id);
        }

        public void Save(Work work)
        {
            using var context = new TodoContext();
            context.Entry(work).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            // ust satir ile alt satir alternatif farki ise alttaki tum alanlari kapsamaktadir.  
            // context.Works.Add(work);
            context.SaveChanges();
            
        }

        public void Update(Work work)
        {
            using var context = new TodoContext();
            context.Entry(work).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            // ust satir ile alt satir alternatif farki ise alttaki tum alanlari kapsamaktadir.  
            // ornek olarak sutun2=deger2 seklinde guncelleme yapmamiz gerekiyor
            // allttaki tum alanlari guncelleyerek yaparak ustteki ilgili yeri guncelleyerek
            // context.Works.Update(work);
            context.SaveChanges();
        }
    }
}
