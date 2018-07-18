using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList2018
{
    public class ToDo
    {

        public ToDo(int TID, string TaskDes)
        {
            TaskID = TID;
            TaskDescription = TaskDes;
            CreatedDate = DateTime.Now;
        }
        public int TaskID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
