namespace CalvaJLayouts;

public partial class GridPage : ContentPage
{
	public GridPage()
	{
		InitializeComponent();
	}

    private void BotonIrAStackLayoutPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StackLayoutPage());
    }
}