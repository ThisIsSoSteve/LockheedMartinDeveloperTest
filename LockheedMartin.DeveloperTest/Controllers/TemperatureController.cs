using LockheedMartin.DeveloperTest.BBL;
using LockheedMartin.DeveloperTest.BBL.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly ILogger<WeekController> _logger;
        private readonly ITemperatureService _temperatureService;

        public TemperatureController(ILogger<WeekController> logger, ITemperatureService temperatureService)
        {
            _logger = logger;
            _temperatureService = temperatureService;
        }

        [HttpGet("{weekId}")]
        public async Task<IActionResult> GetByWeekId(Guid weekId, DayOfWeek dayId)
        {
            try
            {
                var temperatures = await _temperatureService.GetAllByWeekIdAndDayIdAsync(weekId, dayId);
                return Ok(temperatures);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"An error occurred while trying to retrieving temperatures for week ${weekId}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TemperatureAddDto temperature)
        {
            try
            {
                var id = await _temperatureService.AddAsync(temperature);
                var saveResult = await _temperatureService.SaveAsync();
                if (saveResult == 0)
                {
                    _logger.LogError("Unable to add a new temperature at this time");
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(id);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while trying to add a new temperature");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
