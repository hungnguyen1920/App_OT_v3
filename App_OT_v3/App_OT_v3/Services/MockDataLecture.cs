using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            // data Lecture
            lectures = new List<Lecture>()
            {
                new Lecture
                {
                    idLecture = 1,
                    idCourseRef = 1,
                    nameLecture = "Bai hoc 1.1",
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
                },
                new Lecture
                {
                    idLecture = 2,
                    idCourseRef = 1,
                    nameLecture = "Bai hoc 1.2",
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
                },
                new Lecture
                {
                    idLecture = 3,
                    idCourseRef = 2,
                    nameLecture = "Bai hoc 2.1",
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
                },
                new Lecture
                {
                    idLecture = 4,
                    idCourseRef = 3,
                    nameLecture = "Bai hoc 3.1",
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
                },
                new Lecture
                {
                    idLecture = 5,
                    idCourseRef = 4,
                    nameLecture = "Bai hoc 4.1",
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
                },
                new Lecture
                {
                    idLecture = 6,
                    idCourseRef = 4,
                    nameLecture = "Bai hoc 4.2",
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
                },
                new Lecture
                {
                    idLecture = 7,
                    idCourseRef = 5,
                    nameLecture = "Bai hoc 5.1",
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
                },
                new Lecture
                {
                    idLecture = 8,
                    idCourseRef = 6,
                    nameLecture = "Bai hoc 6.1",
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
                },
                new Lecture
                {
                    idLecture = 9,
                    idCourseRef = 7,
                    nameLecture = "Bai hoc 7.1",
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
                },
                new Lecture
                {
                    idLecture = 10,
                    idCourseRef = 8,
                    nameLecture = "Bai hoc 8.1",
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
                },
                new Lecture
                {
                    idLecture = 11,
                    idCourseRef = 9,
                    nameLecture = "Bai hoc 9.1",
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
                },
                new Lecture
                {
                    idLecture = 12,
                    idCourseRef = 10,
                    nameLecture = "Bai hoc 10.1",
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
