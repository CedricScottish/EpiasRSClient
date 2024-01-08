namespace EpiasReportingServiceClient.Models
{
    public partial class GipKontratDataDto
    {
        /// <summary>
        /// Kontrat Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KontratId { get; set; }

        /// <summary>
        /// Kontrat Türü
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratTur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KontratTur { get; set; }

        /// <summary>
        /// Kontrat Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratAd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratAd { get; set; }

    }
}
