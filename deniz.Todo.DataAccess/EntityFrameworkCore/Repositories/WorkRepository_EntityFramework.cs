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
   public class WorkRepository_EntityFramework : GenericRepository_EntityFramework<Work>, IWorkDal
    {

    }
}
