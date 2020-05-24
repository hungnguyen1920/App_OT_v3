using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_OT_v3.Services
{
    public class MockDataPublicCourse : IDataCourseStore<Course>
    {
        readonly List<Course> publicCourses;

        public MockDataPublicCourse()
        {
            // data public course
            publicCourses = new List<Course>()
            {
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
                }
            };
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(publicCourses);
        }
    }
}
