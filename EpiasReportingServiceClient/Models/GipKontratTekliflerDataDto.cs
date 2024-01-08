namespace EpiasReportingServiceClient.Models
{
    public partial class GipKontratTekliflerDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("islemTarihi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IslemTarihi { get; set; }

        /// <summary>
        /// Bölge
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bolge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bolge { get; set; }

        /// <summary>
        /// Kontrat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratAd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratAd { get; set; }

        /// <summary>
        /// Kontrat Tür
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratTur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratTur { get; set; }

        /// <summary>
        /// Teklif Yönü
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teklifYon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TeklifYon { get; set; }

        /// <summary>
        /// Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fiyat { get; set; }

        /// <summary>
        /// Miktar (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Miktar { get; set; }

        /// <summary>
        /// Kalan Miktar (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kalanMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? KalanMiktar { get; set; }

        /// <summary>
        /// Teklif Durumu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teklifDurum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TeklifDurum { get; set; }

        /// <summary>
        /// OEYE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oeye", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Oeye { get; set; }

        /// <summary>
        /// TEY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teye", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Teye { get; set; }

    }

}
