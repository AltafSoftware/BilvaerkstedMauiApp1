using System;
using BilvaerkstedMauiApp1.Models;
using DatabaseService.Services;

namespace BilvaerkstedMauiApp1.Invoices
{
    public partial class InvoicePage : ContentPage
    {
        public InvoicePage()
        {
            InitializeComponent();
        }

        private async void OnSaveInvoiceClicked(object sender, EventArgs e)
        {
            var invoice = new Invoice
            {
                MechanicName = mechanicNameEntry.Text,
                MaterialsUsed = materialsUsedEntry.Text,
                MaterialsPrice = decimal.Parse(materialsPriceEntry.Text),
                HoursWorked = int.Parse(hoursWorkedEntry.Text),
                HourlyRate = decimal.Parse(hourlyRateEntry.Text)
            };

            await App.Database.SaveInvoiceAsync(invoice);
            await DisplayAlert("Success", "Faktura er gemt!", "OK");
            await Navigation.PopAsync();
        }
    }
}