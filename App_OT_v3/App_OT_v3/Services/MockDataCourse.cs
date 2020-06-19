using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_OT_v3.Services
{
    public class MockDataCourse : IDataCourseStore<Course>
    {
        readonly List<Course> courses;

        public MockDataCourse()
        {
            // data all courses
            courses = new List<Course>()
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
                },
                new Course {
                    idCourse = 4,
                    typeCourse = 2,
                    nameCourse = "Khoá học FHJ",
                    status = "Đang diễn ra",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm FHJ"
                },
                new Course {
                    idCourse = 5,
                    typeCourse = 2,
                    nameCourse = "Khoá học QWER",
                    status = "Đang diễn ra",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm QEWR"
                },
                new Course {
                    idCourse = 6,
                    typeCourse = 2,
                    nameCourse = "Khoá học QWERY",
                    status = "Đang diễn ra",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm QEWRY"
                },
                new Course {
                    idCourse = 7,
                    typeCourse = 2,
                    nameCourse = "Khoá học QWERIUY",
                    status = "Đã đóng",
                    startDate = "15/2/2020",
                    endDate = "15/4/2020",
                    description = "Cung cấp kiến thức về sản phẩm QEWRIUY"
                },
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
            return await Task.FromResult(courses);
        }
    }
}
