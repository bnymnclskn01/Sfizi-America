using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;
using System;

namespace SfiziAmerica.WebUIandUX.Areas.Admin.Helper
{
    public class ImageHelper
    {
        public static string CreateImage(IFormFile file, string Folder)
        {
            var extension = Path.GetExtension(file.FileName).Trim('.').ToLower();
            if (!(new[] { "jpg", "png", "jpeg", "webp" }.Contains(extension)))
                return string.Empty;

            var local_image_dir = $"wwwroot/Image/{Folder}/";
            var returnPath = Guid.NewGuid().ToString() + file.FileName;
            var local_image_path = $"{local_image_dir}/{returnPath}";
            if (!Directory.Exists(Path.Combine(local_image_dir)))
                Directory.CreateDirectory(Path.Combine(local_image_dir));
            using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return returnPath;
        }
    }
}
