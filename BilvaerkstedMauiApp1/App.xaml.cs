using DatabaseService.Services;

namespace BilvaerkstedMauiApp1;

public partial class App : Application
{
    public static DatabaseServiceClass Database { get; private set; } = null!;

    public App(DatabaseServiceClass database)
    {
        InitializeComponent();

        Database = database;

        MainPage = new AppShell();
    }
}