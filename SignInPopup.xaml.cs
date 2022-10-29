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

	#region fields
	private string userName;
	private string password;
	#endregion

	#region Properties
	public string UserName { get => userName; set { userName = value; OnPropertyChanged(); } }
	public string Password { get => password; set { password = value; OnPropertyChanged(); } }
	#endregion

	public ICommand LoginButtonCommand => new Command<string>((parameter) => {
		//TODO: Validate credentials and send it caller.
		if (UserName == "ns" && Password == "ns")
		{
			MauiPopup.PopupAction.ClosePopup(UserName);
		}
		else
        {
			MauiPopup.PopupAction.ClosePopup();
		}
		});
	public ICommand CloseButtonCommand => new Command<string>((parameter) => MauiPopup.PopupAction.ClosePopup());

    
}