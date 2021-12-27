using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WEB_953505_EFIMCHIK.Blazor.Client.Models
{
    public class DetailViewModel
    {
        [JsonPropertyName("autoName")]
        public string AutoName { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
