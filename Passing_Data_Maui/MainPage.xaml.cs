namespace Passing_Data_Maui;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void GoToPage2_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page2(EntUserName.Text, EntPassword.Text));
	}
}

