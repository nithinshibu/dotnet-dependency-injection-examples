namespace DepInjectionExamplesApp.Examples.ExampleModels
{
    public class DBConsoleLogService : ILogService
    {
        public void Log(string message)
        {
            //This will write the log to a console
        }
    }
}
