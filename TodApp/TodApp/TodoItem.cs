using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodApp
{
    public class TodoItem
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Status { get; set; }
        private string DeadlineDate { get; set; }
    }
}
