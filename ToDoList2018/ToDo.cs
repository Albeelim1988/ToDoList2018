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
            status = "Not Done";
        }
        public int TaskID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreatedDate { get; set; }
<<<<<<< HEAD
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
=======
        public DateTime DueDate { get; set; }
        public string status { get; set; }
>>>>>>> 3abcb111ac3ddda55a2635581e555ee41e35cc30
    }
}
