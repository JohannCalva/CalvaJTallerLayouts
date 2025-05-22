namespace CalvaJLayouts;

public partial class Demo : ContentPage
{
	public Demo()
	{
		InitializeComponent();
	}

    private void IrAMainPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}