namespace DepInjectionExamplesApp.Examples.ExampleModels
{
    public class FileLogService : ILogService
    {
        public void Log(string message)
        {
            //This will write the  log to a file
        }
    }
}
