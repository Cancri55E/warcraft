﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A reference to any achievement.
    /// </summary>
    public class AchievementReference
    {
        /// <summary>
        /// Gets the key for this achievement.
        /// </summary>
        [JsonPropertyName("key")]
        public Self Key { get; private set; }

        /// <summary>
        /// Gets the name of this achievement.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of this achievement.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; private set; }
    }
}
