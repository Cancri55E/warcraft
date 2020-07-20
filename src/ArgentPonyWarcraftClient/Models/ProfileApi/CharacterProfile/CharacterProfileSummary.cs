﻿using System;
using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A World of Warcraft player character.
    /// </summary>
    public class CharacterProfileSummary
    {
        /// <summary>
        /// Gets links for the character.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the character.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the character.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the gender of the character.
        /// </summary>
        [JsonPropertyName("gender")]
        public EnumType Gender { get; set; }

        /// <summary>
        /// Gets the faction of the character (Alliance or Horde).
        /// </summary>
        [JsonPropertyName("faction")]
        public EnumType Faction { get; set; }

        /// <summary>
        /// Gets the race of the character.
        /// </summary>
        [JsonPropertyName("race")]
        public PlayableRaceReference Race { get; set; }

        /// <summary>
        /// Gets the class of the character.
        /// </summary>
        [JsonPropertyName("character_class")]
        public PlayableClassReference CharacterClass { get; set; }

        /// <summary>
        /// Gets the active spec for the character.
        /// </summary>
        [JsonPropertyName("active_spec")]
        public PlayableSpecializationReference ActiveSpec { get; set; }

        /// <summary>
        /// Gets a reference to the character's realm.
        /// </summary>
        [JsonPropertyName("realm")]
        public RealmReference Realm { get; set; }

        /// <summary>
        /// Gets a reference to the character's guild.
        /// </summary>
        [JsonPropertyName("guild")]
        public GuildReference Guild { get; set; }

        /// <summary>
        /// Gets the level of the character.
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets the character's experience points.
        /// </summary>
        [JsonPropertyName("experience")]
        public long Experience { get; set; }

        /// <summary>
        /// Gets the number of achievement points the character has earned.
        /// </summary>
        [JsonPropertyName("achievement_points")]
        public long AchievementPoints { get; set; }

        /// <summary>
        /// Gets a link to the character's achievements.
        /// </summary>
        [JsonPropertyName("achievements")]
        public Self Achievements { get; set; }

        /// <summary>
        /// Gets a link to the character's titles.
        /// </summary>
        [JsonPropertyName("titles")]
        public Self Titles { get; set; }

        /// <summary>
        /// Gets a link to the character's PVP summary.
        /// </summary>
        [JsonPropertyName("pvp_summary")]
        public Self PvpSummary { get; set; }

        /// <summary>
        /// Gets a link to the character's encounters.
        /// </summary>
        [JsonPropertyName("encounters")]
        public Self Encounters { get; set; }

        /// <summary>
        /// Gets a link to the media for this character.
        /// </summary>
        [JsonPropertyName("media")]
        public Self Media { get; set; }

        /// <summary>
        /// Gets the last login timestamp for the character.
        /// </summary>
        [JsonPropertyName("last_login_timestamp")]
        public DateTime LastLoginTimestamp { get; set; }

        /// <summary>
        /// Gets the character's average item level.
        /// </summary>
        [JsonPropertyName("average_item_level")]
        public long AverageItemLevel { get; set; }

        /// <summary>
        /// Gets the character's equipped item level.
        /// </summary>
        [JsonPropertyName("equipped_item_level")]
        public long EquippedItemLevel { get; set; }

        /// <summary>
        /// Gets a link to the character's specializations.
        /// </summary>
        [JsonPropertyName("specializations")]
        public Self Specializations { get; set; }

        /// <summary>
        /// Gets a link to the character's statistics.
        /// </summary>
        [JsonPropertyName("statistics")]
        public Self Statistics { get; set; }

        /// <summary>
        /// Gets a link to the character's mythic keystone profile.
        /// </summary>
        [JsonPropertyName("mythic_keystone_profile")]
        public Self MythicKeystoneProfile { get; set; }

        /// <summary>
        /// Gets a link to the character's equipment.
        /// </summary>
        [JsonPropertyName("equipment")]
        public Self Equipment { get; set; }

        /// <summary>
        /// Gets a link to the character's appearance.
        /// </summary>
        [JsonPropertyName("appearance")]
        public Self Appearance { get; set; }

        /// <summary>
        /// Gets a link to the character's collections.
        /// </summary>
        [JsonPropertyName("collections")]
        public Self Collections { get; set; }

        /// <summary>
        /// Gets a reference to the active title for the character.
        /// </summary>
        [JsonPropertyName("active_title")]
        public TitleReferenceWithDisplayString ActiveTitle { get; set; }

        /// <summary>
        /// Gets a link to the character's reputations.
        /// </summary>
        [JsonPropertyName("reputations")]
        public Self Reputations { get; set; }

        /// <summary>
        /// Gets a link to the character's quests.
        /// </summary>
        [JsonPropertyName("quests")]
        public Self Quests { get; set; }

        /// <summary>
        /// Gets a link to the character's achievement statistics.
        /// </summary>
        [JsonPropertyName("achievements_statistics")]
        public Self AchievementsStatistics { get; set; }

        /// <summary>
        /// Gets a link to the character's professions.
        /// </summary>
        [JsonPropertyName("professions")]
        public Self Professions { get; set; }
    }
}
