using HICrew.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HICrew
{
    public partial class MainPage : ContentPage
    {
        private DatabaseService _dbService = new DatabaseService();
        public ObservableCollection<string> Seafarers { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            LoadSeafarers();
        }

        private async void LoadSeafarers()
        {
            var names = await _dbService.GetSeafarerNamesAsync();
            foreach (var name in names)
            {
                Seafarers.Add(name);
            }
            BindingContext = this;
        }
    }
}

