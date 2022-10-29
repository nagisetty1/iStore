using MauiPopup.Views;
using System.Windows.Input;

namespace iStore;

public partial class SignInPopup : BasePopupPage
{
	public SignInPopup()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public ICommand LoginButtonCommand => new Command<string>((parameter) => MauiPopup.PopupAction.ClosePopup());
	public ICommand CloseButtonCommand => new Command<string>((parameter) => MauiPopup.PopupAction.ClosePopup());
}