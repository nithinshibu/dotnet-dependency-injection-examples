using DepInjectionExamplesApp.Examples.ExampleModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DepInjectionExamplesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {


        #region GUID-Example-For-SingleTon

        //private readonly RectangleService _rectangleService;

        //public ExampleController(RectangleService rectangleService)
        //{
        //    _rectangleService = rectangleService; // Dependency injected via constructor
        //}

        //[HttpGet]
        //public ActionResult<string> DisplayGUID()
        //{
        //    string guidValue = _rectangleService.GetGuidAsString();
        //    return Ok(guidValue);
        //}
        #endregion


        #region ILogService-Example

        //private readonly ILogService _logger;
        //public ExampleController(ILogService logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
        //public ActionResult<string> DisplayGUID()
        //{
        //    _logger.Log("I am logging this information");
        //    return Ok("Success");
        //}


        #endregion



        #region Configuration-Example

        //private readonly IConfiguration _configuration;

        //public ExampleController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //[HttpGet("ReadConfigurationValues")]
        //public ActionResult<string> ReadConfigurationValues()
        //{
        //    //string connectionString = _configuration.GetConnectionString("DevConnection");
        //    //return Ok(connectionString);
        //    string sendgridKey = _configuration["SendGrid:Key"];
        //    return Ok(sendgridKey);
        //}

        #endregion


        #region Configuration-Appsettings-Example

        //private readonly IConfiguration _configuration;
        //private readonly IOptions<AppSettings> _options;


        //public ExampleController(IConfiguration configuration, IOptions<AppSettings> options)
        //{
        //    _configuration = configuration;
        //    _options = options;
        //}

        //[HttpGet("ReadConfigurationValues")]
        //public ActionResult<string> ReadConfigurationValues()
        //{
        //    //return Ok(_options.Value.ConnectionStrings.DevConnection);
        //    return Ok(_options.Value.SendGrid.Key);

        //}



        #endregion
    }
}
