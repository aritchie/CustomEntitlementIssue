namespace CustomEntitlementIssue;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
			await SecureStorage.Default.SetAsync("Test", "Test Value");
            CounterBtn.Text = "SUCCESS";
        }
		catch (Exception ex)
		{
			CounterBtn.Text = ex.ToString();
		}
	}
}