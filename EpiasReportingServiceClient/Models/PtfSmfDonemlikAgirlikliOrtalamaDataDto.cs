namespace EpiasReportingServiceClient.Models
{
    public partial class PtfSmfDonemlikAgirlikliOrtalamaDataDto
    {
        /// <summary>
        /// PTF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

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
        [Newtonsoft.Json.JsonProperty("ortPtf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OrtPtf { get; set; }

        /// <summary>
        /// SMF Aritmetik Ortalama
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ortSmf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OrtSmf { get; set; }

    }


}
