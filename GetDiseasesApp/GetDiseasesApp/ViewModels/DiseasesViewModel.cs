using GetDiseasesApp.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace GetDiseasesApp.ViewModels
{
    public class DiseasesViewModel:BaseViewModel
    {
        private IDiseaseApiService _diseaseApiService;
        
        public ICommand GetDiseasesCommand { get; }
        public bool Loading { get; set; }
        public int Height { get; set; }
        public ObservableCollection<string> Data { get; set; } = new ObservableCollection<string>();
        public DiseasesViewModel(IDiseaseApiService diseaseApiService)
        {
            _diseaseApiService = diseaseApiService;
            GetDiseasesCommand = new Command(GetDiseases);
        }
        private async void GetDiseases()
        {
            Height = 50;
            Loading = true;
            try
            {
                var diseaseResponse = await _diseaseApiService.GetDiseasesAsync();
                Data = diseaseResponse.Data;
            }
            catch
            {
                Data.Add("There is no internet connection");
            }
            Loading = false;
            Height = 0;
        }
    }
}
