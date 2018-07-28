using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Types
{
    /// <summary>
    /// Represents a video to be sent
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InputMediaVideo : InputMediaBase, IInputMediaWithThumb
    {
        /// <summary>
        /// Optional. Video width
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Width { get; set; }

        /// <summary>
        /// Optional. Video height
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Height { get; set; }

        /// <summary>
        /// Optional. Video duration
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Duration { get; set; }

        /// <summary>
        /// Optional. Thumbnail to send
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Thumb { get; set; }

        /// <summary>
        /// Optional. Pass True, if the uploaded video is suitable for streaming
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupportsStreaming { get; set; }

        /// <summary>
        /// Initializes a new video media to send
        /// </summary>
        public InputMediaVideo()
        {
            Type = "video";
        }

        /// <summary>
        /// Initializes a new video media to send with an <see cref="InputMedia"/>
        /// </summary>
        public InputMediaVideo(InputMedia media)
            : this()
        {
            Media = media;
        }
    }
}
