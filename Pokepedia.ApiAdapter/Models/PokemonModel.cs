﻿namespace Pokepedia.ApiAdapter.Models
{
    public class PokemonModel
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public int Order { get; set; } = 0;
        public string LocationArea { get; set; } = string.Empty;
        public string LocationDetails { get; set; } = string.Empty;
    }
}
