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
    public class PrivateCourseViewModel : BaseViewModel
    {
        public ObservableCollection<Course> privateCourses { get; set; }
        public Command loadPrivateCoursesCommand { get; set; }

        public PrivateCourseViewModel()
        {
            Title = "KHÓA BẮT BUỘC";
            privateCourses = new ObservableCollection<Course>();
            loadPrivateCoursesCommand = new Command(async () => await ExecuteLoadPrivateCoursesCommand());
        }

        async Task ExecuteLoadPrivateCoursesCommand()
        {
            IsBusy = true;

            try
            {
                privateCourses.Clear();
                var courses = await DataStore.GetCoursesAsync(true);
                foreach (var course in courses)
                {
                    privateCourses.Add(course);
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
