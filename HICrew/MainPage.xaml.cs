using Syncfusion.Maui.DataForm;
using System.ComponentModel;
using System.Windows.Input;

namespace HICrew
{
    public partial class MainPage
    {
        private async void NavigateSignup(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        private async void NavigateForgotPassword(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }

        async void NavigateDatabaseView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DatabaseView());
        }

        public LoginFormModel LoginFormModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this.LoginFormModel = new LoginFormModel();
        }
    }
}
