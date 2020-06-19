using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_OT_v3.ViewModels
{
    public class LectureViewModel : BaseViewModel
    {
        public ObservableCollection<Lecture> lectures { get; set; }
        public Command loadLecturesCommand { get; set; }

        //public Course Course { get; set; }
        //public LectureViewModel(Course course = null)
        //{
        //    Title = course?.nameCourse;
        //    Course = course;
        //}


        public LectureViewModel()
        {
            lectures = new ObservableCollection<Lecture>();
            loadLecturesCommand = new Command(async () => await ExcuteLoadLecturesCommand());
        }

        async Task ExcuteLoadLecturesCommand()
        {
            
            IsBusy = true;
            try
            {
                lectures.Clear();
                var tempLectures = await DataLectureStore.GetLecturesAsync(true);
                foreach (var lecture in tempLectures)
                {
                    lectures.Add(lecture);
                    //if (lecture.idCourseRef == course.idCourse)
                    //{
                    //    lectures.Add(lecture);
                    //}
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
