using System.Collections.Generic;
using deniz.Todo.Entities.Concrete;
/// <summary>
/// Step 2.1 = Dal Interface
/// </summary>
namespace deniz.Todo.DataAccess.Interface
{
    public interface IWorkDal
    {
        void Save(Work work);
        void Delete(Work work);
        void Update(Work work);
        Work GetById(int id);
        List<Work> GetAll();
    }
}
