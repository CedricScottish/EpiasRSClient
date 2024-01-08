namespace EpiasReportingServiceClient.Models
{
    public partial class PtfSmfGunlukAgirlikliOrtalamaDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tarih", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Tarih { get; set; }

        /// <summary>
        /// PTF Ağırlıklı Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfOrtalama { get; set; }

        /// <summary>
        /// SMF Ağırlıklı Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfOrtalama { get; set; }

        /// <summary>
        /// PTF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfAritmetikOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfAritmetikOrtalama { get; set; }

        /// <summary>
        /// SMF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfAritmetikOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfAritmetikOrtalama { get; set; }

    }

}
