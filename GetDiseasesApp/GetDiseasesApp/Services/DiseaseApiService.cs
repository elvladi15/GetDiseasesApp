using GetDiseasesApp.Models;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetDiseasesApp.Services
{
    public class DiseaseApiService : IDiseaseApiService
    {
        public async Task<DiseaseResponse> GetDiseasesAsync()
        {
            var api = RestService.For<IDiseaseApiService>("https://api.endlessmedical.com/");
            var response = await api.GetDiseasesAsync();
            return response;
        }
    }
}
