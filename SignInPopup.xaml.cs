using MauiPopup.Views;

namespace iStore;

public partial class SignInPopup : BasePopupPage
{
	public SignInPopup()
	{
		InitializeComponent();
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
		MauiPopup.PopupAction.ClosePopup();
	}

    private void CloseButton_Clicked(object sender, EventArgs e)
    {
		MauiPopup.PopupAction.ClosePopup();
	}
}