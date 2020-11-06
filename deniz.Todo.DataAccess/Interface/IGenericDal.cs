using System;
using System.Collections.Generic;
using System.Text;
using deniz.Todo.Entities.Interfaces;

namespace deniz.Todo.DataAccess.Interface
{
    
    /// <summary>
    ///   Step2.4 = Tekrar eden kodlari engellemek icin yazilan generic interface
    ///   Buraya gonderilecek olan tablo ITable interface'inden turetilmis 
    ///   bir sinif olmak zorunda ve newlenebilir olmak zorunda diye
    ///   sart kosuyoruz. Bu sayede kendimizi tekrar etmekten kacinmis oluyoruz.
    /// </summary>
    public interface IGenericDal<MyTable> where MyTable: class, ITable , new()
    {
        void Save(MyTable myTable);
        void Delete(MyTable myTable);
        void Update(MyTable myTable);
        MyTable GetById(int id);
        List<MyTable> GetAll();
    }
}
