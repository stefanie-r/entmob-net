using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace StarwarsUniverse.Model
{
    public abstract class SWResource
    {
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        [Key]
        [JsonProperty(PropertyName = "url")]
        public string ResourceUri { get; set; }
    }
}
