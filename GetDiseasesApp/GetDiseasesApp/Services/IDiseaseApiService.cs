using GetDiseasesApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GetDiseasesApp.Services
{
    public interface IDiseaseApiService
    {
        [Get("/v1/dx/GetOutcomes")]
        Task<DiseaseResponse> GetDiseasesAsync();
    }
}
