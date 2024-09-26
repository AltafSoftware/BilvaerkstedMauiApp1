using System.Collections.ObjectModel;
using BilvaerkstedMauiApp1.Models;

namespace BilvaerkstedMauiApp1;

public partial class BookedTasksPage : ContentPage
{
    public ObservableCollection<TaskClass> BookedTasks { get; set; }

    public BookedTasksPage()
    {
        InitializeComponent();
        BookedTasks = new ObservableCollection<TaskClass>();
        BindingContext = this;
    }

    private void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        LoadBookedTasks(e.NewDate);
    }

    private async void LoadBookedTasks(DateTime date)
    {
        BookedTasks.Clear();
        var tasks = await App.Database.GetTasksAsync();
        foreach (var task in tasks)
        {
            if (task.DropOffDate.Date == date.Date)
            {
                BookedTasks.Add(task);
            }
        }
    }
}