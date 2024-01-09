namespace HomeAide.Pages;

public partial class Help : ContentPage
{
	public Help()
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

    private async void OnSendMessageClicked(object sender, EventArgs e)
    {
        string firstName = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;
        string email = emailEntry.Text;
        string message = messageEntry.Text;
        bool consentGiven = consentSwitch.IsToggled;

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
            string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
        {
            await DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }

        if (!IsValidEmail(email))
        {
            await DisplayAlert("Error", "Please enter a valid email address.", "OK");
            return;
        }

        // Backend
        // Send Message
        await SendEmail(firstName, lastName, email, message, consentGiven);
    }

    private bool IsValidEmail(string email)
    {
        return !string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains(".");
    }

    private async Task SendEmail(string firstName, string lastName, string email, string message, bool consentGiven)
    {
        // Reset the page
        firstNameEntry.Text = "";
        lastNameEntry.Text = "";
        emailEntry.Text = "";
        messageEntry.Text = "";
        consentSwitch.IsToggled = false;
        foreach (var child in radioGroup.Children)
        {
            if (child is RadioButton radioButton)
            {
                radioButton.IsChecked = false;
            }
        }

        await DisplayAlert("Success", "Message was sent.", "OK");
    }
}