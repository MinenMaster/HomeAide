namespace HomeAide.Pages;

public partial class Overview : ContentPage
{
	public Overview()
	{
		InitializeComponent();
	}

    private async void OnOverviewClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Overview());
    }

    private async void OnLogbookClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Logbook());
    }

    private async void OnHistoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new History());
    }

    private async void OnEnergyClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Energy());
    }

    private async void OnPlantStatusClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlantStatus());
    }

    private async void OnDeveloperToolsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeveloperTools());
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Settings());
    }

    private async void OnHelpClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Help());
    }
}