namespace CalvaJLayouts;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private void BotonIrAAbsoluteLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}