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

    private async void OnNewTaskClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewTaskPage());
    }

    private async void OnBookedTasksClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BookedTasksPage());
    }
}