namespace CalvaJLayouts;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}

    private void BotonIrAFlexLayoutPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayoutPage());
    }
}