namespace HICrew
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Signup), typeof(Signup));
            Routing.RegisterRoute(nameof(CompanySignUp), typeof(CompanySignUp));
            Routing.RegisterRoute(nameof(ForgotPassword), typeof(ForgotPassword));
            Routing.RegisterRoute(nameof(DatabaseView), typeof(DatabaseView));
        }
    }
}
