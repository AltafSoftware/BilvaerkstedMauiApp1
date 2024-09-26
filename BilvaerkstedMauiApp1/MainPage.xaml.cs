using System;
using Microsoft.Maui.Controls;
using BilvaerkstedMauiApp1.Invoices;

namespace BilvaerkstedMauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNewTaskClicked(object sender, EventArgs e)
        {
            // Naviger til siden for at booke tid
            await Navigation.PushAsync(new NewTaskPage());
        }

        private async void OnBookedTasksClicked(object sender, EventArgs e)
        {
            // Naviger til siden for at se bookede tider
            await Navigation.PushAsync(new BookedTasksPage());
        }

        private async void NavigateToInvoicePageClicked(object sender, EventArgs e)
        {
            // Naviger til fakturasiden
            await Navigation.PushAsync(new InvoicePage());
        }
    }
}