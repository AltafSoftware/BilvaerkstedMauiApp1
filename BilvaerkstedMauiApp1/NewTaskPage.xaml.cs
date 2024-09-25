using System;

namespace BilvaerkstedMauiApp1;

public partial class NewTaskPage : ContentPage
{
	public NewTaskPage()
	{
		InitializeComponent();
	}

	private async void OnSubmitClicked(object sender, EventArgs e)
	{
		// Capture the input from the user and process it
		// Example: You can add data processing or validation here
		await DisplayAlert("Success", "Task has been booked successfully!", "OK");

		// Navigate back to the previous page
		await Navigation.PopAsync();
	}
}
