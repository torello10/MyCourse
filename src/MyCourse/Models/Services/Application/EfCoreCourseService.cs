using System.Collections.Generic;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    public class EfCoreCourseService : ICourseService
    {
        public Task<CourseDetailViewModel> GetCourseAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<CourseViewModel>> GetCoursesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}