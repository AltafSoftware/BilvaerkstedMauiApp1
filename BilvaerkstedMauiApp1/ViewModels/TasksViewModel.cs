using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BilvaerkstedMauiApp1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BilvaerkstedMauiApp1.ViewModels
{
    public partial class TasksViewModel : ObservableObject
    {
        public ObservableCollection<TaskClass> Tasks { get; } = new();

        public TasksViewModel() { }

        [RelayCommand]
        public async Task LoadTasksAsync()
        {
            var tasks = await App.Database.GetTasksAsync();
            Tasks.Clear();
            foreach (var task in tasks)
            {
                Tasks.Add(task);
            }
        }

        [RelayCommand]
        public async Task AddTaskAsync(TaskClass task)
        {
            await App.Database.SaveTaskAsync(task);
            await LoadTasksAsync();
        }
    }
}