namespace EpiasReportingServiceClient.Models
{
    public partial class SerbestTuketiciSayacArtisExportRequestDto
    {
        /// <summary>
        /// XLSX, CSV ya da PDF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exportType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SerbestTuketiciSayacArtisExportRequestDtoExportType ExportType { get; set; }

    }
}
