namespace EpiasReportingServiceClient.Models
{
    public partial class GunlukFiyatlarMinMaksDataDto
    {
        /// <summary>
        /// Tarih
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tarih", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tarih { get; set; }

        /// <summary>
        /// Başlık
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baslik", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Baslik { get; set; }

        /// <summary>
        /// Fiyat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fiyat { get; set; }

        /// <summary>
        /// Saat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("saat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Saat { get; set; }

    }

}
