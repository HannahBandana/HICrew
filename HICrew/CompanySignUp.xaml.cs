using Syncfusion.Maui.DataForm;

namespace HICrew
{
    public partial class CompanySignUp : ContentPage
    {
        private async void NavigateMainPage(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public CompanySignUp()
        {
            InitializeComponent();
        }
    }
}