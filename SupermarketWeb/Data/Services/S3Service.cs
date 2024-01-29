using Amazon.S3.Model;
using Amazon.S3;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Amazon;
using Amazon.S3.Transfer;

namespace SupermarketWeb.Data.Services
{
    public class S3Service
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;

        public S3Service(IConfiguration configuration)
        {
            var accessKey = configuration["AWS:AccessKey"];
            var secretKey = configuration["AWS:SecretKey"];
            var region = RegionEndpoint.GetBySystemName(configuration["AWS:Region"]);
            _bucketName = "supermarketbacket";

            _s3Client = new AmazonS3Client(accessKey, secretKey, region);
        }

        public async Task<string> UploadImageAsync1(Stream imageStream, string fileName)
        {
            var request = new PutObjectRequest
            {
                BucketName = "supermarketbacket",
                Key = fileName,
                InputStream = imageStream,
                ContentType = "image/jpeg", // Adjust content type based on your image type
                CannedACL = S3CannedACL.PublicRead // Adjust ACL as needed
            };

            await _s3Client.PutObjectAsync(request);
            var imageUrl = $"https://supermarketbacket.s3.eu-north-1.amazonaws.com/{fileName}";
            return imageUrl;
        }

        public async Task<string> UploadImageAsync(Stream stream, string fileName)
        {
            var fileTransferUtility = new TransferUtility(_s3Client);
            var objectKey = fileName; // Generate a unique object key

            await fileTransferUtility.UploadAsync(stream, _bucketName, objectKey);

            // Construct and return the URL of the uploaded image
            var imageUrl = $"https://{_bucketName}.s3.eu-north-1.amazonaws.com/{objectKey}";
            return imageUrl;
        }
    }
}
