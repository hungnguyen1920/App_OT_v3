using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_OT_v3.Models
{
    public class Lecture
    {
        public int idLecture { get; set; }
        public int idCourseRef { get; set; }
        public string nameLecture { get; set; }
        public List<Image> contentLecture { get; set; }
    }
}
