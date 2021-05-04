using LockheedMartin.DeveloperTest.BBL;
using LockheedMartin.DeveloperTest.BBL.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeekController : ControllerBase
    {
        private readonly ILogger<WeekController> _logger;
        private readonly IWeekService _weekService;

        public WeekController(ILogger<WeekController> logger, IWeekService weekService)
        {
            _logger = logger;
            _weekService = weekService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var weeks = await _weekService.GetAll();
                return Ok(weeks);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while trying to retrieving all weeks");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WeekAddDto week)
        {
            try
            {
                var id = await _weekService.AddAsync(week);
                var saveResult = await _weekService.SaveAsync();

                if (saveResult == 0)
                {
                    _logger.LogError("Unable to add a new week at this time");
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok(id);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while trying to add a new week");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] WeekUpdateDto week)
        {
            try
            {
                _weekService.Update(week);
                var saveResult = await _weekService.SaveAsync();

                if (saveResult == 0)
                {
                    _logger.LogError($"Unable to update a week at this time id: {week.Id}");
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return NoContent();

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"An error occurred while trying to update a week id: {week.Id}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
