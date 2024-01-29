using System;
using Microsoft.AspNetCore.Components.Forms;

namespace SupermarketWeb.Data.Services
{
	public class FileUploadService
	{
        public async Task UploadFileAsync(IBrowserFile file, string targetFolder, string newFileName)
        {
            var filePath = Path.Combine(targetFolder, newFileName);

            using (var fileStream = File.OpenWrite(filePath))
            {
                await file.OpenReadStream().CopyToAsync(fileStream);
                fileStream.Close();
            }
        }
    }
}

