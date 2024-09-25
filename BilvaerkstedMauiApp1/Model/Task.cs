using SQLite;

namespace BilvaerkstedMauiApp1.Models
{
    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CarModel { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DropOffDate { get; set; }
        public TimeSpan DropOffTime { get; set; }
        public string WorkDescription { get; set; }
    }
}
