namespace EpiasReportingServiceClient.Models
{

    public partial class GunlukFiyatDataDto
    {
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
        /// 1 Ay Önceki PTF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birAyOncekiPtf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BirAyOncekiPtf { get; set; }

        /// <summary>
        /// SMF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Smf { get; set; }

        /// <summary>
        /// 1 Ay Önceki SMF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birAyOncekiSmf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BirAyOncekiSmf { get; set; }

        /// <summary>
        /// SMF Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sistemYon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SistemYon { get; set; }

        [Newtonsoft.Json.JsonProperty("sistemYonId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SistemYonId { get; set; }

    }

}
