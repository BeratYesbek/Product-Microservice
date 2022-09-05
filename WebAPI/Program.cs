using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolver;
using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.S3;
using Core.Extensions;
using Core.Utilities.Cloud.AwsService;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacDependencyResolver()));

/*
var awsConfiguration = new AwsServiceConfiguration();
var awsSettingsSection = builder.Configuration.GetSection("AwsS3Configuration");
awsSettingsSection.Bind(awsConfiguration);
var awsOptions = new AWSOptions
{
    Credentials = new BasicAWSCredentials(awsConfiguration.AccessKey, awsConfiguration.SecretKey),
    Region = RegionEndpoint.GetBySystemName(awsConfiguration.Region)
};
builder.Services.AddAWSService<IAmazonS3>(awsOptions);
builder.Services.Configure<AwsServiceConfiguration>(awsSettingsSection);
*/

builder.Services.AddAwsS3Service(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
