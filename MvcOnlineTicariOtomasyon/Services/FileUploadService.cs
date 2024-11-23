using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace MvcOnlineTicariOtomasyon.Services
{
    public class FileUploadService
    {
        public string UploadFile(IFormFile file, string relativePath)
        {
            if (file == null || file.Length == 0)
            {
                return null;
            }

            var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", relativePath);
            EnsureDirectoryExists(directoryPath);

            var sanitizedFileName = Path.GetFileName(file.FileName);
            var filePath = Path.Combine(directoryPath, sanitizedFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return $"/{relativePath}/{sanitizedFileName}".Replace("\\", "/");
        }

        private void EnsureDirectoryExists(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
