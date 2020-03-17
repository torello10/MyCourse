using System.IO;
using System.Threading.Tasks;
using ImageMagick;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MyCourse.Models.Services.Infrastructure
{
    public class MagickNetImagePersister : IImagePersister
    {
        private readonly IWebHostEnvironment env;
        public MagickNetImagePersister(IWebHostEnvironment env)
        {
          this.env = env;
        }

    public async Task<string> SaveCourseImageAsync(int courseId, IFormFile formFile)
    {
        //TODO: Salvare il file
        string path = $"/Courses/{courseId}.jpg";
        string physicalPath = Path.Combine(env.WebRootPath, "Courses", $"{courseId}.jpg");
        
        using Stream inputStream = formFile.OpenReadStream();
        using MagickImage image =  new MagickImage(inputStream);

        //Manipolare l'immagine
        int width = 300;
        int height = 300;
        MagickGeometry resizeGeometry = new MagickGeometry(width, height)
        {
            FillArea = true
        };

        image.Resize(resizeGeometry);
        image.Crop(width, width, Gravity.Northwest);
         //Esercizio: ottenere questi valori della configurazione
        image.Quality = 70;
        image.Write(physicalPath, MagickFormat.Jpg);
            //TODO: Restituire il percorso del file
        return path;
    }
}
}