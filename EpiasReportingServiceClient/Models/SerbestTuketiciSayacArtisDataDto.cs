namespace EpiasReportingServiceClient.Models
{
    public partial class SerbestTuketiciSayacArtisDataDto
    {
        /// <summary>
        /// PTF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Sayaç Adedi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sayacAdedi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SayacAdedi { get; set; }

        /// <summary>
        /// Sayaç Artış Oranı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("artisOrani", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ArtisOrani { get; set; }

    }
}
