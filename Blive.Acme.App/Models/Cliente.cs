using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace Blive.Acme.App.Models
{
    [Serializable]
    [XmlRoot()]
    public class Cliente
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("cpf")]
        public string CPF { get; set; }

        [JsonProperty("endereco")]
        public Endereco Endereco { get; set; }
    }
}
