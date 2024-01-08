namespace EpiasReportingServiceClient.Models
{
    public partial class ElektrikPiyasaHacimFizikselDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// İ.A. Hacmi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iaHacmi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IaHacmi { get; set; }

        /// <summary>
        /// Kamu İ.A. Hacmi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iaKamu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IaKamu { get; set; }

        /// <summary>
        /// Özel Sektör İ.A. Hacmi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iaOzel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IaOzel { get; set; }

        /// <summary>
        /// GöP Hacmi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gopHacmi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GopHacmi { get; set; }

        /// <summary>
        /// DGP Hacmi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dgpHacmi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DgpHacmi { get; set; }

        /// <summary>
        /// Toplam Piyasa Hacmi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toplamHacim", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ToplamHacim { get; set; }

    }


}
