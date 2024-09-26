using System;
using BilvaerkstedMauiApp1.Models;
using DatabaseService.Services;

namespace BilvaerkstedMauiApp1;

public partial class NewTaskPage : ContentPage
{
    public NewTaskPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Capture the input from the user
        var task = new TaskClass
        {
            CustomerName = customerNameEntry.Text,
            CustomerAdress = customerAddressEntry.Text,
            CarBrand = carBrandEntry.Text,
            CarModel = carModelEntry.Text,
            RegistrationNumber = registrationNumberEntry.Text,
            DropOffDate = dropOffDatePicker.Date.Add(dropOffTimePicker.Time),
            WorkDescription = workDescriptionEditor.Text
        };

        // Save the task to the database
        await App.Database.SaveTaskAsync(task);

        // Display success message
        await DisplayAlert("Success", "Task has been booked successfully!", "OK");

        // Navigate back to the previous page
        await Navigation.PopAsync();
    }
}
