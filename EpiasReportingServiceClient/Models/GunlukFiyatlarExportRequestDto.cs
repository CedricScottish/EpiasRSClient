namespace EpiasReportingServiceClient.Models
{
    public partial class GunlukFiyatlarExportRequestDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Date { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

        /// <summary>
        /// XLSX, CSV ya da PDF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exportType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GunlukFiyatlarExportRequestDtoExportType ExportType { get; set; }

    }
}
