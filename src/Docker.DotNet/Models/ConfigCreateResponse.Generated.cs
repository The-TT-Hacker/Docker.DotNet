using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class ConfigCreateResponse // (main.ConfigCreateResponse)
    {
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }
    }
}
