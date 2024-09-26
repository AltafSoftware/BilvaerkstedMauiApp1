using System;
using System.Threading.Tasks;
using BilvaerkstedMauiApp1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BilvaerkstedMauiApp1.ViewModels
{
    public partial class InvoiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private string mechanicName = null!;

        [ObservableProperty]
        private string materialsUsed = null!;

        [ObservableProperty]
        private string materialsPrice = null!;

        [ObservableProperty]
        private string hoursWorked = null!;

        [ObservableProperty]
        private string hourlyRate = null!;

        [RelayCommand]
        private async Task SaveInvoice()
        {
            var invoice = new Invoice
            {
                MechanicName = MechanicName,
                MaterialsUsed = MaterialsUsed,
                MaterialsPrice = decimal.Parse(MaterialsPrice),
                HoursWorked = int.Parse(HoursWorked),
                HourlyRate = decimal.Parse(HourlyRate)
            };

            await App.Database.SaveInvoiceAsync(invoice);
            await Shell.Current.DisplayAlert("Success", "Faktura er gemt!", "OK");
            await Shell.Current.GoToAsync("..");
        }
    }
}