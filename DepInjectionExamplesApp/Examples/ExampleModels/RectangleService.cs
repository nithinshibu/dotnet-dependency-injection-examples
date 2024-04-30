namespace DepInjectionExamplesApp.Examples.ExampleModels
{
    public class RectangleService
    {
        #region GUID-Example
        private readonly Guid guid;

        public RectangleService()
        {
            guid = Guid.NewGuid();
        }

        public string GetGuidAsString()
        {
            return guid.ToString();
        } 
        #endregion

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

       

    }
}
