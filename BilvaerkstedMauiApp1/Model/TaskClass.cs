using SQLite;

namespace BilvaerkstedMauiApp1.Models
{
    public class TaskClass
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerAdress { get; set; } = string.Empty;
        public string CarBrand { get; set; } = string.Empty;
        public string CarModel { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public DateTime DropOffDate { get; set; }
        public string WorkDescription { get; set; } = string.Empty;
    }
}
