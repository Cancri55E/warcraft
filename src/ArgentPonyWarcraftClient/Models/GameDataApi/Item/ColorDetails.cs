﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// RGBA color information.
    /// </summary>
    public class ColorDetails
    {
        /// <summary>
        /// Gets the red channel value for the color.
        /// </summary>
        [JsonPropertyName("r")]
        public long Red { get; set; }

        /// <summary>
        /// Gets the green channel value for the color.
        /// </summary>
        [JsonPropertyName("g")]
        public long Green { get; set; }

        /// <summary>
        /// Gets the blue channel value for the color.
        /// </summary>
        [JsonPropertyName("b")]
        public long Blue { get; set; }

        /// <summary>
        /// Gets the alpha (opacity) channel value for the color.
        /// </summary>
        [JsonPropertyName("a")]
        public long Alpha { get; set; }
    }
}
