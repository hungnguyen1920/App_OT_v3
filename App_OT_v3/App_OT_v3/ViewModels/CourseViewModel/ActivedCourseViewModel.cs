using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_OT_v3.ViewModels.CourseDetailViewModel
{
    public class ActivedCourseViewModel : BaseViewModel
    {
        public ObservableCollection<Course> activedCourses { get; set; }
        public Command loadActivedCoursesCommand { get; set; }

        public ActivedCourseViewModel()
        {
            Title = "KHÓA ĐÃ ĐĂNG KÝ";
            activedCourses = new ObservableCollection<Course>();
            loadActivedCoursesCommand = new Command(async () => await ExecuteLoadActivedCoursesCommand());
        }

        async Task ExecuteLoadActivedCoursesCommand()
        {
            IsBusy = true;

            try
            {
                activedCourses.Clear();
                var courses = await DataCourseStore.GetCoursesAsync(true);
                foreach (var course in courses)
                {
                    //typeActivedCourse == 3
                    if (course.typeCourse == 3)
                    {
                        activedCourses.Add(course);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
