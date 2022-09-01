namespace VisibilityTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void ShowHideClicked(object sender, EventArgs e)
    {
        this.HideableLabel.IsVisible = !this.HideableLabel.IsVisible;
    }
}

