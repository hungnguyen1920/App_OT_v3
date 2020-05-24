﻿using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_OT_v3.ViewModels.CourseDetailViewModel
{
    public class PrivateCourseDetailViewModel : BaseViewModel
    {
        public Course Course { get; set; }

        public PrivateCourseDetailViewModel(Course course = null)
        {
            Title = course?.nameCourse;
            Course = course;
        }
    }
}
