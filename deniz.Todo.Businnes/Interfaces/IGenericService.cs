using System;
using System.Collections.Generic;
using System.Text;
using deniz.Todo.Entities.Interfaces;

namespace deniz.Todo.Businnes.Interfaces
{
    public interface IUserService<MyTable> where MyTable : class, ITable, new()
    {
        void Save(MyTable myTable);
        void Delete(MyTable myTable);
        void Update(MyTable myTable);
        MyTable GetById(int id);
        List<MyTable> GetAll();
    }
}
