namespace CalvaJLayouts;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

    private void BotonVolverAInicio_Clicked(object sender, EventArgs e)
    {
		Navigation.PopToRootAsync();
    }
}