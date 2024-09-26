using SQLite;

namespace BilvaerkstedMauiApp1.Models
{
    public class Invoice
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string MechanicName { get; set; } = null!;
        public string MaterialsUsed { get; set; } = null!;
        public decimal MaterialsPrice { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
    }
}