namespace iStore;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		MauiPopup.PopupAction.DisplayPopup(new SignInPopup());
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//SemanticScreenReader.Announce(CounterLabel.Text);
		MauiPopup.PopupAction.DisplayPopup(new SignInPopup());
	}
}

