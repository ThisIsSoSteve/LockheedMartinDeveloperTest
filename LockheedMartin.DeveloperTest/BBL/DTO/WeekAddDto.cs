using System.ComponentModel.DataAnnotations;

namespace LockheedMartin.DeveloperTest.BBL.DTO
{
    public class WeekAddDto
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}
