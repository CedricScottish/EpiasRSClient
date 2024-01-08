namespace EpiasReportingServiceClient.Models
{
    public partial class Page
    {
        /// <summary>
        /// İlgili sayfanın numarası. Ör: 1,2. 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Number { get; set; }

        /// <summary>
        /// Her bir sayfada bulunacak eleman sayısı.Ör: 10,20,24,50,100.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// Sunucu taraflı hesaplanıp, önyüzde kullanılmak üzere dönülecek toplam satır sayısı.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Total { get; set; }

        /// <summary>
        /// Özel sıralama yapılmak istenilirse gönderilecek sıralama ayarlaması.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SortDTO Sort { get; set; }

    }
}
