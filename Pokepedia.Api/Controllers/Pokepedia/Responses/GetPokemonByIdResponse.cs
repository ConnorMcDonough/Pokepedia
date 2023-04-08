﻿namespace Pokepedia.Api.Controllers.Pokepedia.Responses
{
    public class GetPokemonByIdResponse
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public string SpriteImagePath { get; set; } = string.Empty;
    }
}
