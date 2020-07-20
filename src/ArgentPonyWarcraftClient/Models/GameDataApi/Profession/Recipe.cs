﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A recipe.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Gets links for the recipe.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the ID of the recipe.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets the name of the recipe.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the description of the recipe.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the media associated with the recipe.
        /// </summary>
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        /// <summary>
        /// Gets a reference to the item crafted by this recipe.
        /// </summary>
        [JsonPropertyName("crafted_item")]
        public ItemReference CraftedItem { get; set; }

        /// <summary>
        /// Gets the reagents required for the recipe.
        /// </summary>
        [JsonPropertyName("reagents")]
        public RecipeReagent[] Reagents { get; set; }

        /// <summary>
        /// Gets the range of item quantities produced by this recipe.
        /// </summary>
        [JsonPropertyName("crafted_quantity")]
        public CraftedQuantity CraftedQuantity { get; set; }
    }
}
