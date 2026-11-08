namespace LayoutsDemoMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnViewProfileClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("Profile", "Unnathi Patil - Mobile App Developer", "OK");
    }
}
