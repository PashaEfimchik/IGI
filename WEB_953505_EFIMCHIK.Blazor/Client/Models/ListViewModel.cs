using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WEB_953505_EFIMCHIK.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("autoId")]
        public int AutoId { get; set; }
        [JsonPropertyName("autoName")]
        public string AutoName { get; set; }
    }
}
