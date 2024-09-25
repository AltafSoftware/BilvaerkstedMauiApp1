using System;
using System.Collections.Generic;
using System.Linq;

namespace BilvaerkstedMauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnBookNewTaskClicked(object sender, EventArgs e)
	{
		// Navigate to the NewTaskPage
		await Navigation.PushAsync(new NewTaskPage());
	}
}
