namespace EpiasReportingServiceClient.Models
{
    public partial class DailyReportDataDto
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
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yukTahminPlani", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YukTahminPlani { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ikiliAnlasma", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IkiliAnlasma { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ptf { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Sam { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ssm { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kgup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Kgup { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Smf { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yal0", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yal0 { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yal1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yal1 { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yal2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yal2 { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalTeslimEdilmeyen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalTeslimEdilmeyen { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yat0", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yat0 { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yat1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yat1 { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yat2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yat2 { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatTeslimEdilmeyen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatTeslimEdilmeyen { get; set; }

    }

}
