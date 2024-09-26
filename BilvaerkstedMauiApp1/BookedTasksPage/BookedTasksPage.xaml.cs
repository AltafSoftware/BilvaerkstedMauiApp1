using System.Collections.ObjectModel;
using BilvaerkstedMauiApp1.Models;
using DatabaseService.Services;

namespace BilvaerkstedMauiApp1;

public partial class BookedTasksPage : ContentPage
{
    public ObservableCollection<TaskClass> BookedTasks { get; set; }
    private bool _isLoading;
    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            _isLoading = value;
            OnPropertyChanged(nameof(IsLoading));
        }
    }

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
        IsLoading = true;
        BookedTasks.Clear();
        var tasks = await App.Database.GetTasksAsync();
        foreach (var task in tasks)
        {
            if (task.DropOffDate.Date == date.Date)
            {
                BookedTasks.Add(task);
            }
        }
        IsLoading = false;
    }

    private async void OnLoadTasksClicked(object sender, EventArgs e)
    {
        IsLoading = true;
        var tasks = await App.Database.GetTasksAsync();
        BookedTasks.Clear();
        foreach (var task in tasks)
        {
            BookedTasks.Add(task);
        }
        IsLoading = false;
    }
}