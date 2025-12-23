using TestMAUISimpleApp.Pages;

namespace TestMAUISimpleApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EditUserPage), typeof(EditUserPage));
            Routing.RegisterRoute(nameof(SomePage), typeof(SomePage));
            Routing.RegisterRoute(nameof(CreateUserPage), typeof(CreateUserPage));
        }
    }
}
