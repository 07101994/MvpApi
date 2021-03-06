// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using Newtonsoft.Json;

namespace MvpApi.Common.Models
{
    public partial class ContentMetadata
    {
        /// <summary>
        /// Initializes a new instance of the ContentMetadata class.
        /// </summary>
        public ContentMetadata() { }

        /// <summary>
        /// Initializes a new instance of the ContentMetadata class.
        /// </summary>
        public ContentMetadata(string pageTitle = default(string), string templateName = default(string), string keywords = default(string), string description = default(string))
        {
            PageTitle = pageTitle;
            TemplateName = templateName;
            Keywords = keywords;
            Description = description;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageTitle")]
        public string PageTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TemplateName")]
        public string TemplateName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }
    }
}
