using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Domain
{
    public abstract class SWResource
    {
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string ResourceUri { get; set; }
    }
}

