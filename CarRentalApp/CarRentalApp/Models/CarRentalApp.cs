namespace CarRentalApp.Models
{
    public class RentCarViewModel
    {
        // Vehicle properties
        public int VehicleId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string Fueltype { get; set; }
        public string Status { get; set; }
        public int? Rentperday { get; set; }

        // Rental properties
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
