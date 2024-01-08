namespace EpiasReportingServiceClient.Models
{
    public partial class GunlukFiyatlarOrtalamaDataDto
    {
        /// <summary>
        /// Başlık
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baslik", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Baslik { get; set; }

        /// <summary>
        /// PTF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfAritmetikOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfAritmetikOrtalama { get; set; }

        /// <summary>
        /// PTF Ağırlıklı Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfAgirlikliOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfAgirlikliOrtalama { get; set; }

        /// <summary>
        /// SMF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfAritmetikOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfAritmetikOrtalama { get; set; }

        /// <summary>
        /// SMF Ağırlıklı Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfAgirlikliOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfAgirlikliOrtalama { get; set; }

    }


}
