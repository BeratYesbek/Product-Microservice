using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Core.Utilities.Abstracts;
using Core.Utilities.Cloud.Entities;
using Core.Utilities.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Core.Utilities.Cloud.AwsService
{
    public class S3AwsManager : IS3AwsService
    {
        private readonly IAmazonS3 _s3;
        private readonly AwsServiceConfiguration _awsSettings;
        public S3AwsManager(IAmazonS3 s3, IConfiguration configuration)
        {
            _s3 = s3;
            _awsSettings = new AwsServiceConfiguration();
            configuration.GetSection("AwsS3Configuration").Bind(_awsSettings);
        }
        public S3File Upload(S3File cloudEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<S3File>> UploadAsync(S3File cloudEntity)
        {
            using var newMemoryStream = new MemoryStream();
            cloudEntity.File?.CopyTo(newMemoryStream);
            var dictionary = Path.GetExtension(cloudEntity.FileName);
            var key = Guid.NewGuid() + cloudEntity.FileName;

            var uploadRequest = new PutObjectRequest
            {
                InputStream = newMemoryStream,
                Key = key,
                BucketName = _awsSettings.BucketName,
                ContentType = cloudEntity.File?.ContentType
            };
            var url = $"https://{_awsSettings.BucketName}.s3.{_awsSettings.Region}.{_awsSettings.AwsUrl}/{key}";
            cloudEntity.Url = url;
            var response = await _s3.PutObjectAsync(uploadRequest);

            if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
                return new SuccessDataResult<S3File>(cloudEntity);
            return new ErrorDataResult<S3File>(null!);
        }
    }
}
