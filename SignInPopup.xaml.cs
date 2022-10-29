using MauiPopup.Views;

namespace iStore;

public partial class SignInPopup : BasePopupPage
{
	public SignInPopup()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MauiPopup.PopupAction.ClosePopup();
	}
}