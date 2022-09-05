using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.S3;
using Core.Utilities.Cloud.AwsService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class AwsInitializerExtensions
    {
        public static void AddAwsS3Service(this IServiceCollection service,IConfiguration configuration)
        {
            var awsConfiguration = new AwsServiceConfiguration();
            var awsSettingsSection = configuration.GetSection("AwsS3Configuration");
            awsSettingsSection.Bind(awsConfiguration);
            var awsOptions = new AWSOptions
            {
                Credentials = new BasicAWSCredentials(awsConfiguration.AccessKey, awsConfiguration.SecretKey),
                Region = RegionEndpoint.GetBySystemName(awsConfiguration.Region)
            };
            service.AddAWSService<IAmazonS3>(awsOptions);
            service.Configure<AwsServiceConfiguration>(t => awsSettingsSection.Bind(awsConfiguration));
        }
    }
}
