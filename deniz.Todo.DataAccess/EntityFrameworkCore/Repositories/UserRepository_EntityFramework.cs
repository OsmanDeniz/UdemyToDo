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
    class UserRepository_EntityFramework : IUserDal
    {
        public void Delete(User user)
        {
            using var context = new TodoContext();
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //context.Users.Remove(user);
            context.SaveChanges();
        }

        public List<User> GetAll()
        {
            // using kullanildiginda ıcerısındekı islem yapilir sonra garbage
            // collector a gonderilir.
            using (var context = new TodoContext())
            {
                return context.Users.ToList();
            }
        }

        public User GetById(int id)
        {
            using var context = new TodoContext();
            return context.Users.Find(id);
        }

        public void Save(User user)
        {
            using var context = new TodoContext();
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            // ust satir ile alt satir alternatif farki ise alttaki tum alanlari kapsamaktadir.  
            // context.Users.Add(user);
            context.SaveChanges();

        }

        public void Update(User user)
        {
            using var context = new TodoContext();
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            // ust satir ile alt satir alternatif farki ise alttaki tum alanlari kapsamaktadir.  
            // ornek olarak sutun2=deger2 seklinde guncelleme yapmamiz gerekiyor
            // allttaki tum alanlari guncelleyerek yaparak ustteki ilgili yeri guncelleyerek
            // context.Users.Update(user);
            context.SaveChanges();
        }
    }
}
