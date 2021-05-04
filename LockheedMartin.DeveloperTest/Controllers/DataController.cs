using LockheedMartin.DeveloperTest.BBL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ILogger<WeekController> _logger;
        private readonly ITemperatureService _temperatureService;
        private readonly IDataService _dataService;

        public DataController(ILogger<WeekController> logger, ITemperatureService temperatureService, IDataService dataService)
        {
            _logger = logger;
            _temperatureService = temperatureService;
            _dataService = dataService;
        }

        [HttpGet("{weekId}")]
        public async Task<IActionResult> GetByWeekId(Guid weekId, DayOfWeek dayId)
        {
            try
            {
                var temperatures = await _temperatureService.GetAllByWeekIdAndDayIdAsync(weekId, dayId);

                var results = _dataService.GetDataForChart(temperatures, dayId);

                return Ok(results);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"An error occurred while trying to retrieving temperatures for week ${weekId}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
