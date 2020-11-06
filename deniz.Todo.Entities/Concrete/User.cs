using System.Collections.Generic;
using deniz.Todo.Entities.Interfaces;
/// <summary>
/// Step 1.2 = Tablo tasarimi
/// </summary>
namespace deniz.Todo.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<Work> WorkList { get; set; }
    }
}
