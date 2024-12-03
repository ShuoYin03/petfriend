using petfriend_api.Database;
using petfriend_api.Options;
using petfriend_api.Database.MongoDatabaseClient;

var startup = new Startup();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton(startup.Configuration);
builder.Services.AddSingleton<IMongoDatabaseClient, MongoDatabaseClient>();
builder.Services.AddSingleton<OwnerProfileCollection>();
builder.Services.AddControllers();
builder.Services.AddOptions();
builder.Services.Configure<DatabaseOptions>(builder.Configuration.GetSection(DatabaseOptions.SectionName));
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", x =>
    {
        x.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
builder.Logging.AddConsole();

var app = builder.Build();
app.UseCors("CorsPolicy");
app.MapControllers();
app.Run();