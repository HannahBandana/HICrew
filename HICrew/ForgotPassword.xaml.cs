using System.Windows.Input;

namespace HICrew
{
    public partial class ForgotPassword
    {
        private async void NavigateMainPage(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        public ForgotPassword()
        {
            InitializeComponent();
        }
    }
}
