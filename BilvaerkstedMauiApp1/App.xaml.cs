using Microsoft.Maui.Controls;
using DatabaseService.Services;

namespace BilvaerkstedMauiApp1
{
    public partial class App : Application
    {
        private static DatabaseServiceClass? _database;
        
        public static DatabaseServiceClass Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new DatabaseServiceClass(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Tasks.db3"));
                }
                return _database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}