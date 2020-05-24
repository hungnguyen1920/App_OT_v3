using System;
using System.Collections.Generic;
using System.Text;

namespace App_OT_v3.Models
{
    public class Course
    {
        public int idCourse { get; set; }
        public int typeCourse { get; set; }
        public string nameCourse { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string status { get; set; }
        public string description { get; set; }
    }
}
