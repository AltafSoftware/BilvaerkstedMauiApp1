using System.Collections.Generic;
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
            _database.CreateTableAsync<Invoice>().Wait();
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

        // Metoder til fakturaoperationer
        public Task<int> SaveInvoiceAsync(Invoice invoice)
        {
            return _database.InsertAsync(invoice);
        }

        public Task<List<Invoice>> GetInvoicesAsync()
        {
            return _database.Table<Invoice>().ToListAsync();
        }
    }
}