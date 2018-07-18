using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList2018
{
    public class ToDo
    {
        public ToDo()
        {

        }
        public ToDo(string TID, string TaskDes)
        {
            TaskID = TID;
            TaskDescription = TaskDes;
            CreatedDate = DateTime.Now;
            Status = "Pending";
        }
        public string TaskID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }

    }
}
