using DatabaseService.Services;
using Microsoft.Maui.Controls;

namespace BilvaerkstedMauiApp1
{
    public partial class App : Application
    {
        static DatabaseServiceClass database = null!;

        public static DatabaseServiceClass Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseServiceClass(
                        Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData
                            ),
                            "Tasks.db3"
                        )
                    );
                }
                return database;
            }
        }

     public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new TasksPage());
    }
    }
}
