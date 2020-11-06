using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using deniz.Todo.Businnes.Interfaces;
using deniz.Todo.DataAccess.EntityFrameworkCore.Repositories;
using deniz.Todo.Entities.Concrete;
/// <summary>
/// Daha sonra refactor edilecek
/// </summary>
namespace deniz.Todo.Businnes.Concrete
{
    public class UserManager : IUserService
    {
        private readonly UserRepository_EntityFramework userRepository;
        public UserManager()
        {
            userRepository = new UserRepository_EntityFramework();
        }
        public void Delete(User myTable)
        {
            userRepository.Delete(myTable);
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        public void Save(User myTable)
        {
            userRepository.Save(myTable);
        }

        public void Update(User myTable)
        {
            userRepository.Update(myTable);
        }
    }
}
