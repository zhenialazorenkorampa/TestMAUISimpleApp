using TestMAUISimpleApp.Pages;

namespace TestMAUISimpleApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(UserListPage), typeof(UserListPage));
            Routing.RegisterRoute(nameof(EditUserPage), typeof(EditUserPage));
        }
    }
}
