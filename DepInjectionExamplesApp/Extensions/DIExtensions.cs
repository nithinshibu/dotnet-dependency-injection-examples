using DepInjectionExamplesApp.Examples.ExampleModels;

namespace DepInjectionExamplesApp.Extensions
{
    public static class DIExtensions
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<RectangleService>();
            //services.AddSingleton<ILogService, DBConsoleLogService>();
            //services.AddScoped<ILogService, FileLogService>();
        }

        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }

    }
}
