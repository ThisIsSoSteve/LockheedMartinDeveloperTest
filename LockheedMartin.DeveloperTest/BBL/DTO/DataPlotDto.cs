namespace LockheedMartin.DeveloperTest.BBL.DTO
{
    public class DataPlotDto
    {
        public string Name { get; set; }
        public string Color { get; set; } // has to be American for GUI
        public double[][] Data { get; set; }
    }
}
