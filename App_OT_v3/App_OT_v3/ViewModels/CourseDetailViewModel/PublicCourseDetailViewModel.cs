using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_OT_v3.ViewModels.CourseDetailViewModel
{
    public class PublicCourseDetailViewModel : BaseViewModel
    {
        public Course Course { get; set; }

        public PublicCourseDetailViewModel (Course course = null)
        {
            Title = course?.nameCourse;
            Course = course;
        }
    }
}
