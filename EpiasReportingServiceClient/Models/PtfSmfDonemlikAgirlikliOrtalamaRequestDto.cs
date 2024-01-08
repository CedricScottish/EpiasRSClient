namespace EpiasReportingServiceClient.Models
{
    public partial class PtfSmfDonemlikAgirlikliOrtalamaRequestDto
    {
        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

    }
}
