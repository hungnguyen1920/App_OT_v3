using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_OT_v3.Services
{
    public class MockDataLecture : IDataLectureStore<Lecture>
    {
        readonly List<Lecture> lectures;

        public MockDataLecture()
        {
            lectures = new List<Lecture>()
            {
                new Lecture
                {
                    idLecture = 1,
                    idCourseRef = 1,
                    nameLecture = "Bai hoc A",
                    contentLecture = new List<Image>()
                    {
                        new Image
                        {
                            Source = "images.jpg"
                        },
                        new Image
                        {
                            Source = "images_1.jpg"
                        },
                        new Image
                        {
                            Source = "images_2.jpg"
                        },
                        new Image
                        {
                            Source = "images_3.jpg"
                        },
                        new Image
                        {
                            Source = "images_4.jpg"
                        },
                        new Image
                        {
                            Source = "images_5.jpg"
                        },
                        new Image
                        {
                            Source = "images_6.jpg"
                        },
                        new Image
                        {
                            Source = "images_7.jpg"
                        }
                    }
                }
            };    
        }
        
        public async Task<IEnumerable<Lecture>> GetLecturesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(lectures);
        }
    }
}
