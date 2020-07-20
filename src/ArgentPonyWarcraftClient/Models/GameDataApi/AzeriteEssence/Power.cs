﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A power associated with an azerite essence.
    /// </summary>
    public class Power
    {
        /// <summary>
        /// Gets the ID of the azerite essence power.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the rank of the azerite essence power.
        /// </summary>
        [JsonPropertyName("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Gets a reference to the spell that is the main power for this azerite essence.
        /// </summary>
        [JsonPropertyName("main_power_spell")]
        public SpellReference MainPowerSpell { get; set; }

        /// <summary>
        /// Gets a reference to the spell that is the passive power for this azerite essence.
        /// </summary>
        [JsonPropertyName("passive_power_spell")]
        public SpellReference PassivePowerSpell { get; set; }
    }
}
