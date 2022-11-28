namespace Passing_Data_Maui;

public partial class Page2 : ContentPage
{
	public Page2(string userName, string userPassword)
	{
		InitializeComponent();
		LblUserName.Text = userName;
		LblUserPassword.Text = userPassword;	
	}
}