using DepInjectionExamplesApp.Examples.ExampleModels;
using DepInjectionExamplesApp.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepInjectionExamplesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectangleController : ControllerBase
    {

        #region Without Dependency Injection

        //private readonly RectangleService _rectangleService;

        //public RectangleController()
        //{
        //    _rectangleService = new RectangleService();
        //}

        //[HttpGet]
        //public ActionResult<double> GetArea(double length, double width)
        //{
        //    double area = _rectangleService.CalculateArea(length, width);
        //    return Ok(area);
        //}



        #endregion


        #region With Dependency Injection (Constructor DI)

        private readonly RectangleService _rectangleService;

        public RectangleController(RectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }

        [HttpGet]
        public ActionResult<double> GetArea(double length, double width)
        {
            string a = "jerin";
            a.Print();
            double area = _rectangleService.CalculateArea(length, width);
            return Ok(area);
        }


        #endregion

        #region With Dependency Injection (Method DI)



        //[HttpGet]
        //public ActionResult<double> GetAreaWithDI([FromServices] RectangleService rectangleService, double length, double width)
        //{
        //    double area = rectangleService.CalculateArea(length, width);
        //    return Ok(area);
        //}


        #endregion



        #region With Dependency Injection (Property DI)

        //[FromServices]
        //public RectangleService RectangleService { get; set; }

        //[HttpGet]
        //public ActionResult<double> GetAreaWithPropertyDI(double length, double width)
        //{
        //    double area = RectangleService.CalculateArea(length, width);
        //    return Ok(area);
        //}


        #endregion


        #region DI - SingleTonExample



        //private readonly RectangleService _rectangleService;

        //public RectangleController(RectangleService rectangleService)
        //{
        //    _rectangleService = rectangleService;
        //}

        //[HttpGet("DisplayGUID")]
        //public ActionResult<string> DisplayGUID()
        //{
        //    string guidValue = _rectangleService.GetGuidAsString();
        //    return Ok(guidValue);
        //}


        #endregion

        #region DI - AddScoped-Example


        //[FromServices]
        //public RectangleService RectangleService { get; set; }
        //private readonly RectangleService _rectangleService;

        //public RectangleController(RectangleService rectangleService)
        //{
        //    _rectangleService = rectangleService;
        //}

        //[HttpGet("DisplayGUID")]
        //public ActionResult<string> DisplayGUID()
        //{
        //    string guidValue = _rectangleService.GetGuidAsString();
        //    string guidValue2 = RectangleService.GetGuidAsString();
        //    return Ok(new { guid1 = guidValue, guid2 = guidValue2 });
        //}


        #endregion

        #region DI - AddTransient-Example


        //[FromServices]
        //public RectangleService RectangleService { get; set; }
        //private readonly RectangleService _rectangleService;

        //public RectangleController(RectangleService rectangleService)
        //{
        //    _rectangleService = rectangleService;
        //}

        //[HttpGet("DisplayGUID")]
        //public ActionResult<string> DisplayGUID()
        //{
        //    string guidValue = _rectangleService.GetGuidAsString();
        //    string guidValue2 = RectangleService.GetGuidAsString();
        //    return Ok(new { guid1 = guidValue, guid2 = guidValue2 });
        //}


        #endregion



    }
}
