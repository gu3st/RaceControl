﻿using Newtonsoft.Json;
using RaceControl.Common.Utils;
using System.Collections.Generic;

namespace RaceControl.Services.Interfaces.F1TV.Api
{
    public class Channel
    {
        [JsonProperty("uid")]
        public string UID { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("channel_type")]
        public string ChannelType { get; set; }

        [JsonProperty("driveroccurrence_urls")]
        public List<string> DriverOccurrenceUrls { get; set; }

        public static string UIDField => JsonUtils.GetJsonPropertyName<Channel>(c => c.UID);
        public static string SelfField => JsonUtils.GetJsonPropertyName<Channel>(c => c.Self);
        public static string NameField => JsonUtils.GetJsonPropertyName<Channel>(c => c.Name);
        public static string ChannelTypeField => JsonUtils.GetJsonPropertyName<Channel>(c => c.ChannelType);
        public static string DriverOccurrenceUrlsField => JsonUtils.GetJsonPropertyName<Channel>(c => c.DriverOccurrenceUrls);
    }
}