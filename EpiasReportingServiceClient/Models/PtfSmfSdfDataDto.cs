namespace EpiasReportingServiceClient.Models
{

    public partial class PtfSmfSdfDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// PTF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ptf { get; set; }

        /// <summary>
        /// SMF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Smf { get; set; }

        /// <summary>
        /// Pozitif Dengesizlik Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positiveImbalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PositiveImbalance { get; set; }

        /// <summary>
        /// Negatif Dengesizlik Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("negativeImbalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NegativeImbalance { get; set; }

        /// <summary>
        /// SMF Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("systemStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemStatus { get; set; }

    }


}
