using System.Windows.Input;

namespace iStore;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
		//MauiPopup.PopupAction.DisplayPopup(new SignInPopup());
	}

	public ICommand RegisterCommand => new Command<string>(async (parameter) => await Launcher.OpenAsync(parameter));

	public ICommand LoginButtonCommand => new Command<string>((parameter) => MauiPopup.PopupAction.DisplayPopup(new SignInPopup()));
}

