﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of mythic keystone seasons.
    /// </summary>
    public class MythicKeystoneSeasonsIndex
    {
        /// <summary>
        /// Gets links for the index of mythic keystone seasons.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets references to the mythic keystone seasons.
        /// </summary>
        [JsonPropertyName("seasons")]
        public MythicKeystoneSeasonReference[] Seasons { get; set; }

        /// <summary>
        /// Gets a reference to the current mythic keystone season.
        /// </summary>
        [JsonPropertyName("current_season")]
        public MythicKeystoneSeasonReference CurrentSeason { get; set; }
    }
}
