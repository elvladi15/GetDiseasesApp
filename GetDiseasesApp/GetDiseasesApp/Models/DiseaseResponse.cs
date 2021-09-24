using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GetDiseasesApp.Models
{
    public class DiseaseResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ObservableCollection<string> Data { get; set; }
    }
}
