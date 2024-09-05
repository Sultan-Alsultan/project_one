namespace project_one.Models
{
    public class Package
    {
        public int PackageId { get; set; }
        public int OrderId { get; set; }
        public double Weight { get; set; }
        public string? Dimentions { get; set; }
        public bool IsFragile { get; set; }

    }
}
