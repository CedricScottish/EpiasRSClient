namespace EpiasReportingServiceClient.Models
{

    public partial class GipKontratOzetDataDto
    {
        /// <summary>
        /// Kontrat Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratAdi { get; set; }

        /// <summary>
        /// Kontrat Tür
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratTurAciklama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratTurAciklama { get; set; }

        /// <summary>
        /// Max Alış Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxAlisFiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxAlisFiyat { get; set; }

        /// <summary>
        /// Min Alış Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minAlisFiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinAlisFiyat { get; set; }

        /// <summary>
        /// Max Satış Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxSatisFiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxSatisFiyat { get; set; }

        /// <summary>
        /// Min Satış Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minSatisFiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinSatisFiyat { get; set; }

        /// <summary>
        /// Max Eşleşme Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxEslesmeFiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxEslesmeFiyat { get; set; }

        /// <summary>
        /// Min Eşleşme Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minEslesmeFiyat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinEslesmeFiyat { get; set; }

        /// <summary>
        /// Teklif Edilen Alış Miktar (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teklifAlisMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TeklifAlisMiktar { get; set; }

        /// <summary>
        /// Teklif Edilen Satış Miktar (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teklifSatisMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TeklifSatisMiktar { get; set; }

        /// <summary>
        /// Kabul Edilen Miktar (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eslesmeMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EslesmeMiktar { get; set; }

        /// <summary>
        /// İşlem Hacmi (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("islemHacmi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IslemHacmi { get; set; }

        /// <summary>
        /// Ağırlıklı Ortalama Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agirlikliOrtalama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AgirlikliOrtalama { get; set; }

    }

}
