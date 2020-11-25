﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Detail
    {
        

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
        public int TaskId { get; set; }
        public Tasks Task { get; set; }

        public Detail()
        {

        }

        public Detail(DateTime date, int time, int resourceId, int taskId)
        {
          
            Date = date;
            Time = time;
            ResourceId = resourceId;
            TaskId = taskId;
        }




       


    }
}
