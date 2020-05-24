using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_OT_v3.ViewModels.CourseDetailViewModel
{
    public class ActivedCourseDetailViewModel : BaseViewModel
    {
        public Course Course { get; set; }

        public ActivedCourseDetailViewModel(Course course = null)
        {
            Title = course?.nameCourse;
            Course = course;
        }
    }
}
