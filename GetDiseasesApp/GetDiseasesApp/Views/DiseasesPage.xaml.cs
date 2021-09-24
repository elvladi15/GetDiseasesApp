using GetDiseasesApp.Services;
using GetDiseasesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GetDiseasesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiseasesPage : ContentPage
    {
        public DiseasesPage()
        {
            InitializeComponent();
            BindingContext = new DiseasesViewModel(new DiseaseApiService());
        }
    }
}