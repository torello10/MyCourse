using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyCourse.Models.Services.Infrastructure
{
    public interface IImagePersister
    {
         /// <returns>The image URL e.g.async /Courses/1.jpg</returns>
         Task<string> SaveCourseImageAsync(int courseId, IFormFile formFile);
    }
}