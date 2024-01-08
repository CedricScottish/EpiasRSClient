namespace EpiasReportingServiceClient.Models
{
    public partial class ModelAndView
    {
        [Newtonsoft.Json.JsonProperty("view", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public View View { get; set; }

        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, object> Model { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ModelAndViewStatus? Status { get; set; }

        [Newtonsoft.Json.JsonProperty("empty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Empty { get; set; }

        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Reference { get; set; }

        [Newtonsoft.Json.JsonProperty("viewName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ViewName { get; set; }

        [Newtonsoft.Json.JsonProperty("modelMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, object> ModelMap { get; set; }

    }
}
