using System;
using System.Collections.Generic;
using System.Text;
using deniz.Todo.Businnes.Interfaces;
using deniz.Todo.DataAccess.EntityFrameworkCore.Repositories;
using deniz.Todo.Entities.Concrete;

namespace deniz.Todo.Businnes.Concrete
{
    class WorkManager : IWorkService
    {
        private readonly WorkRepository_EntityFramework workRepository;
        public WorkManager()
        {
            workRepository = new WorkRepository_EntityFramework();
        }
        public void Delete(Work myTable)
        {
            workRepository.Delete(myTable);
        }

        public List<Work> GetAll()
        {
            return workRepository.GetAll();
        }

        public Work GetById(int id)
        {
            return workRepository.GetById(id);
        }

        public void Save(Work myTable)
        {
            workRepository.Save(myTable);
        }

        public void Update(Work myTable)
        {
            workRepository.Update(myTable);
        }
    }
}
