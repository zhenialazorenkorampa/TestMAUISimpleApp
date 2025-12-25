namespace TestMAUISimpleApp.Pages
{
    public partial class SomePage : ContentPage
    {
        public SomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current?.MainPage != null && Application.Current?.MainPage is AppShell appShell)
            {
                appShell.Title = Constants.Headers.SomePage;
            }
        }
    }
}
