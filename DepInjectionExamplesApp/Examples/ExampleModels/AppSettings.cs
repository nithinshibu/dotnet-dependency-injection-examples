namespace DepInjectionExamplesApp.Examples.ExampleModels
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public SendGrid SendGrid { get; set; }
    }
    public class ConnectionStrings
    {
        public string DevConnection { get; set; }
    }

    public class SendGrid
    {
        public string Key { get; set; }
    }
}
