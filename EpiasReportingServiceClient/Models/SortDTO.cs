namespace EpiasReportingServiceClient.Models
{
    public partial class SortDTO
    {
        /// <summary>
        /// Sıralama yapılacak alanın adı.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// Sıralama tipi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SortDTODirection? Direction { get; set; }

    }
}
