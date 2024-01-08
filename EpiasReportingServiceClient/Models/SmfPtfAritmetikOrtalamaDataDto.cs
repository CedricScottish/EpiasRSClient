namespace EpiasReportingServiceClient.Models
{

    public partial class SmfPtfAritmetikOrtalamaDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tarih", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Tarih { get; set; }

        /// <summary>
        /// Maksimum Tarih
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minimumTarih", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? MinimumTarih { get; set; }

        /// <summary>
        /// Minimum Tarih
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maksimumTarih", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? MaksimumTarih { get; set; }

        /// <summary>
        /// SMF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfOrtalama { get; set; }

        /// <summary>
        /// PTF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfOrtalama { get; set; }

    }

}
