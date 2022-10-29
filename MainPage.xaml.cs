using System.Windows.Input;

namespace iStore;

public partial class MainPage : ContentPage
{
    #region fields
    private string loginResult;
	private bool loginButtonVisibility;
	private string displayName;
	private bool displayNameVisibility;
	#endregion

	#region Properties
	public bool LoginButtonVisibility { get => loginButtonVisibility; set { loginButtonVisibility = value; OnPropertyChanged(); } }
	public string DisplayName { get => displayName; set { displayName = value; OnPropertyChanged(); } }
	public bool DisplayNameVisibility { get => displayNameVisibility; set { displayNameVisibility = value; OnPropertyChanged(); } }

	#endregion

	public MainPage()
	{
		InitializeComponent();
		//MauiPopup.PopupAction.DisplayPopup(new SignInPopup());
		LoginButtonVisibility = true;
		loginResult = string.Empty;
		DisplayName = string.Empty;
		BindingContext = this;
		DisplayNameVisibility = false;
	}

	public ICommand RegisterCommand => new Command<string>(async (parameter) => await Launcher.OpenAsync(parameter));

	public ICommand LoginButtonCommand => new Command<string>(async (parameter) => { 
		loginResult = await MauiPopup.PopupAction.DisplayPopup(new SignInPopup());
        if (!string.IsNullOrEmpty(loginResult))
        {
			LoginButtonVisibility = false;
			DisplayNameVisibility = true;
			DisplayName = loginResult;
		}
	});
}

