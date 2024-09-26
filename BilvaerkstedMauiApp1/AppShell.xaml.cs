using BilvaerkstedMauiApp1.Views;

namespace BilvaerkstedMauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("NewTaskPage", typeof(NewTaskPage));
        Routing.RegisterRoute("BookedTasksPage", typeof(BookedTasksPage));
        Routing.RegisterRoute("InvoicePage", typeof(Views.InvoicePage));
    }
}