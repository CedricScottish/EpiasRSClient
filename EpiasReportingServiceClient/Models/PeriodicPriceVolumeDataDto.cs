namespace EpiasReportingServiceClient.Models
{

    public partial class PeriodicPriceVolumeDataDto
    {
        /// <summary>
        /// PTF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Sıfır Bakiye Düzeltme Tutarı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sbdt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Sbdt { get; set; }

        /// <summary>
        /// I.A. Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iaMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IaMiktar { get; set; }

        /// <summary>
        /// I.A. Kamu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iaKamu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IaKamu { get; set; }

        /// <summary>
        /// I.A. Özel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iaOzel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IaOzel { get; set; }

        /// <summary>
        /// UEVM (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uevm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Uevm { get; set; }

        /// <summary>
        /// UECM (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uecm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Uecm { get; set; }

        /// <summary>
        /// EDM Oran (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edmOran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EdmOran { get; set; }

        /// <summary>
        /// DGP Oran (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dgpOran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DgpOran { get; set; }

        /// <summary>
        /// GÖP Oran (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gopOran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GopOran { get; set; }

        /// <summary>
        /// OEDM Oran (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oedmOran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OedmOran { get; set; }

        /// <summary>
        /// Serbest Tüketici Çekiş Oran (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stCekisOran", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StCekisOran { get; set; }

    }

}
