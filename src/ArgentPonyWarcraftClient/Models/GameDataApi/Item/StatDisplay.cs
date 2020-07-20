﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// Display details for a stat modifier.
    /// </summary>
    public class StatDisplay
    {
        /// <summary>
        /// Gets the display string for the stat.
        /// </summary>
        [JsonPropertyName("display_string")]
        public string DisplayString { get; set; }

        /// <summary>
        /// Gets the color associated with the stat.
        /// </summary>
        [JsonPropertyName("color")]
        public ColorDetails Color { get; set; }
    }
}
