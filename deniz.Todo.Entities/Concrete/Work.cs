using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using deniz.Todo.Entities.Interfaces;
/// <summary>
/// Step 1.2 = Tablo Tasarimi
/// </summary>
namespace deniz.Todo.Entities.Concrete
{
    public class Work : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool StatusCode { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
