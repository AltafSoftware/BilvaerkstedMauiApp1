using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BilvaerkstedMauiApp1.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateToNewTask()
        {
            await Shell.Current.GoToAsync("NewTaskPage");
        }

        [RelayCommand]
        private async Task NavigateToBookedTasks()
        {
            await Shell.Current.GoToAsync("BookedTasksPage");
        }

        [RelayCommand]
        private async Task NavigateToInvoice()
        {
            await Shell.Current.GoToAsync("InvoicePage");
        }
    }
}