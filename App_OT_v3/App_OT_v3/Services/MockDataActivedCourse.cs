using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_OT_v3.Services
{
    public class MockDataActivedCourse : IDataCourseStore<Course>
    {
        readonly List<Course> activedCourses;

        public MockDataActivedCourse()
        {
            // data actived course
            activedCourses = new List<Course>()
            {
                new Course {
                    idCourse = 8,
                    typeCourse = 3,
                    nameCourse = "Khoá học FJKUF",
                    status = "Đã đóng",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm ABC"
                },
                new Course {
                    idCourse = 9,
                    typeCourse = 3,
                    nameCourse = "Khoá học ABCVSC",
                    status = "Đang diễn ra",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm ABC"
                },
                new Course {
                    idCourse = 10,
                    typeCourse = 3,
                    nameCourse = "Khoá học DFGER",
                    status = "Đã đóng",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm ABC"
                }
            };
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(activedCourses);
        }
    }
}
