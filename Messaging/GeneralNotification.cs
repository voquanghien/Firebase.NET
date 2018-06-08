using Newtonsoft.Json;

namespace FirebaseNet.Messaging
{
    public class GeneralNotification : INotification
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Indicates a sound to play when the device receives a notification.
        /// Supports default or the filename of a sound resource bundled in the app.
        /// Sound files must reside in /res/raw/.
        /// </summary>
        [JsonProperty(PropertyName = "sound")]
        public string Sound { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "click_action")]
        public string ClickAction { get; set; }

        /// <summary>
        /// Indicates the key to the body string for localization. Corresponds to "loc-key" in the APNs payload.
        /// </summary>
        [JsonProperty(PropertyName = "body_loc_key")]
        public string BodyLocKey { get; set; }

        /// <summary>
        /// Indicates the string value to replace format specifiers in the body string for localization. Corresponds to "loc-args" in the APNs payload.
        /// </summary>
        [JsonProperty(PropertyName = "body_loc_args")]
        public string BodyLocArgs { get; set; }

        /// <summary>
        /// Indicates the key to the title string for localization. Corresponds to "title-loc-key" in the APNs payload.
        /// </summary>
        [JsonProperty(PropertyName = "title_loc_key")]
        public string TitleLocKey { get; set; }

        /// <summary>
        /// Indicates the string value to replace format specifiers in the title string for localization.Corresponds to "title-loc-args" in the APNs payload.
        /// </summary>
        [JsonProperty(PropertyName = "title_loc_args")]
        public string TitleLocArgs { get; set; }
    }
}