using System.IO;
using System.Threading.Tasks;
using BilvaerkstedMauiApp1.Models;
using SQLite;

namespace DatabaseService.Services
{
    public class DatabaseServiceClass
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseServiceClass(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<TaskClass>().Wait();
        }

        // Metoder til CRUD-operationer
        public Task<List<TaskClass>> GetTasksAsync()
        {
            return _database.Table<TaskClass>().ToListAsync();
        }

        public Task<int> SaveTaskAsync(TaskClass task)
        {
            if (task.Id != 0)
            {
                return _database.UpdateAsync(task);
            }
            else
            {
                return _database.InsertAsync(task);
            }
        }

        public Task<int> DeleteTaskAsync(TaskClass task)
        {
            return _database.DeleteAsync(task);
        }
    }
}
