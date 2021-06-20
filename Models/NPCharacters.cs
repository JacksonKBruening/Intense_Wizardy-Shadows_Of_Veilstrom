using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntenseWizardy_ShadowsOfVeilstorm.Models
{
    public class NPCharacters
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Race { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string Backstory { get; set; }

        public override string ToString() => JsonSerializer.Serialize<NPCharacters>(this);
    }
}
