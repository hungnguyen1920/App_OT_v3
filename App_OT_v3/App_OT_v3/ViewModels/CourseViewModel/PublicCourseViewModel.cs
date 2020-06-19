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
    public class PublicCourseViewModel : BaseViewModel
    {
        public ObservableCollection<Course> publicCourses { get; set; }
        public Command loadPublicCoursesCommand { get; set; }

        public PublicCourseViewModel()
        {
            Title = "KHÓA HỌC KHÁC";
            publicCourses = new ObservableCollection<Course>();
            loadPublicCoursesCommand = new Command(async () => await ExecuteLoadPublicCoursesCommand());
        }

        async Task ExecuteLoadPublicCoursesCommand()
        {
            IsBusy = true;

            try
            {
                publicCourses.Clear();
                var courses = await DataCourseStore.GetCoursesAsync(true);
                foreach (var course in courses)
                {
                    // typePublicCourse == 2
                    if (course.typeCourse == 2)
                    {
                        publicCourses.Add(course);
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
