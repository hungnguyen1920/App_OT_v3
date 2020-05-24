using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_OT_v3.Services
{
    public class MockDataPrivateCourse : IDataCourseStore<Course>
    {
        readonly List<Course> privateCourses;

        public MockDataPrivateCourse()
        {
            // data private course
            privateCourses = new List<Course>()
            {
                new Course {
                    idCourse = 1,
                    typeCourse = 1,
                    nameCourse = "Khoá học ABC asdfe fads fadf asdfe afs fwefasdf sfaef asdfa adsf",
                    status = "Đang diễn ra",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm ABC"
                },
                new Course {
                    idCourse = 2,
                    typeCourse = 1,
                    nameCourse = "Khoá học ASD",
                    status = "Đang diễn ra",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm ASD"
                },
                new Course {
                    idCourse = 3,
                    typeCourse = 1,
                    nameCourse = "Khoá học ASDR",
                    status = "Đã đóng",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm ASDR"
                }
            };
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(privateCourses);
        }
    }
}
