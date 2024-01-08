namespace EpiasReportingServiceClient.Models
{
    public partial class StsaDataDto
    {
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        [Newtonsoft.Json.JsonProperty("sayacAdedi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SayacAdedi { get; set; }

        [Newtonsoft.Json.JsonProperty("sayacArtisOrani", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SayacArtisOrani { get; set; }

    }
}
