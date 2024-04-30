using DepInjectionExamplesApp.Examples.ExampleModels;
using DepInjectionExamplesApp.Extensions;

var builder = WebApplication.CreateBuilder(args);


#region AppSettings-Mapping

var configbuilder = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json");

var Configuration = configbuilder.Build();

builder.Services.Configure<AppSettings>(Configuration);

builder.Services.AddSingleton<AppSettings>();


#endregion


#region SingleTon-RectangleExample

//builder.Services.AddSingleton<RectangleService>();

#endregion

#region Scoped-RectangleExample

//builder.Services.AddScoped<RectangleService>();

#endregion


#region Transient-RectangleExample

//builder.Services.AddTransient<RectangleService>();

#endregion



#region ILoggerExample-For-Swapping

//builder.Services.AddSingleton<ILogService, FileLogService>();

#endregion

#region Using Extension Class for All Dependencies

builder.Services.AddMyServices();

#endregion


builder.Services.AddControllers();
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
