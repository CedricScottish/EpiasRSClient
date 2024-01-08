namespace EpiasReportingServiceClient.Models
{

    public partial class PtfSmfUcZamanliAgirlikliOrtalamaDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("donem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Donem { get; set; }

        /// <summary>
        /// PTF Gündüz Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfGunduzOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfGunduzOrtalama { get; set; }

        /// <summary>
        /// SMF Gündüz Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfGunduzOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfGunduzOrtalama { get; set; }

        /// <summary>
        /// PTF Puant Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfPuantOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfPuantOrtalama { get; set; }

        /// <summary>
        /// SMF Puant Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfPuantOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfPuantOrtalama { get; set; }

        /// <summary>
        /// PTF Gece Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptfGeceOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfGeceOrtalama { get; set; }

        /// <summary>
        /// SMF Gece Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smfGeceOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmfGeceOrtalama { get; set; }

    }


}
