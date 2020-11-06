using System.Collections.Generic;
using deniz.Todo.Entities.Concrete;
/// <summary>
/// Step 2.1 = Dal Interface
/// </summary>
namespace deniz.Todo.DataAccess.Interface
{
    public interface IUserDal : IGenericDal<User>
    {
        //Kullaniciya ait ozel isler burada yazilacak





        // Generic interface yazildigindan dolayi bu kisimlara gerek kalmadi.
        //void Save(User user);
        //void Delete(User user);
        //void Update(User user);
        //User GetById(int id);
        //List<User> GetAll();
    }
}
