namespace EpiasReportingServiceClient.Models
{

    public partial class DgpTalimatAgrOrtDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında başlangıç tarihi bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// Net Talimat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("netTalimat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NetTalimat { get; set; }

        /// <summary>
        /// YAL 0 Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalSifirMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalSifirMiktar { get; set; }

        /// <summary>
        /// YAL 0 Ağırlıklı Ort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalSifirAgrOrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalSifirAgrOrt { get; set; }

        /// <summary>
        /// YAL 1 Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalBirMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalBirMiktar { get; set; }

        /// <summary>
        /// YAL 1 Ağırlıklı Ort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalBirAgrOrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalBirAgrOrt { get; set; }

        /// <summary>
        /// YAL 2 Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalIkiMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalIkiMiktar { get; set; }

        /// <summary>
        /// YAL 2 Ağırlıklı Ort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yalIkiAgrOrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YalIkiAgrOrt { get; set; }

        /// <summary>
        /// YAT 0 Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatSifirMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatSifirMiktar { get; set; }

        /// <summary>
        /// YAT 0 Ağırlıklı Ort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatSifirAgrOrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatSifirAgrOrt { get; set; }

        /// <summary>
        /// YAT 1 Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatBirMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatBirMiktar { get; set; }

        /// <summary>
        /// YAT 1 Ağırlıklı Ort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatBirAgrOrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatBirAgrOrt { get; set; }

        /// <summary>
        /// YAT 2 Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatIkiMiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatIkiMiktar { get; set; }

        /// <summary>
        /// YAT 2 Ağırlıklı Ort.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yatIkiAgrOrt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YatIkiAgrOrt { get; set; }

        /// <summary>
        /// Yerine Getirilen YAL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ygYal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YgYal { get; set; }

        /// <summary>
        /// Yerine Getirilen YAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ygYat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YgYat { get; set; }

        /// <summary>
        /// SMF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Smf { get; set; }

        /// <summary>
        /// PTF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ptf { get; set; }

    }

}
