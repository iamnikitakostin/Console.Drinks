﻿using Newtonsoft.Json;

namespace Drinks.iamnikitakostin.Models;

internal class DrinkDetailObject
{
    [JsonProperty("drinks")]
    public List<DrinkDetail> DrinkDetailList { get; set; }
}
internal class DrinkDetail
{
    public int Id { get; set; }
    public int IdInt { get; set; }
    public string IdDrink { get; set; }
    public string StrDrink { get; set; }
    public string? StrDrinkAlternate { get; set; } = "";
    public string? StrTags { get; set; } =  "";
    public string? StrVideo { get; set; } =  "";
    public string? StrCategory { get; set; } =  "";
    public string? StrIba { get; set; } =  "";
    public string? StrAlcoholic { get; set; } =  "";
    public string? StrGlass { get; set; } =  "";
    public string? StrInstructions { get; set; } =  "";
    public string? StrInstructionsEs { get; set; } =  "";
    public string? StrInstructionsDe { get; set; } =  "";
    public string? StrInstructionsFr { get; set; } =  "";
    public string? StrInstructionsIt { get; set; } =  "";
    public string? StrInstructionsZhhans { get; set; } =  "";
    public string? StrInstructionsZhhant { get; set; } =  "";
    public string? StrDrinkThumb { get; set; } = "";
    public string? StrIngredient1 { get; set; } = "";
    public string? StrIngredient2 { get; set; } = "";
    public string? StrIngredient3 { get; set; } = "";
    public string? StrIngredient4 { get; set; } = "";
    public string? StrIngredient5 { get; set; } = "";
    public string? StrIngredient6 { get; set; } = "";
    public string? StrIngredient7 { get; set; } = "";
    public string? StrIngredient8 { get; set; } = "";
    public string? StrIngredient9 { get; set; } = "";
    public string? StrIngredient10 { get; set; } = "";
    public string? StrIngredient11 { get; set; } = "";
    public string? StrIngredient12 { get; set; } = "";
    public string? StrIngredient13 { get; set; } = "";
    public string? StrIngredient14 { get; set; } = "";
    public string? StrIngredient15 { get; set; } = "";
    public string? StrMeasure1 { get; set; } = "";
    public string? StrMeasure2 { get; set; } = "";
    public string? StrMeasure3 { get; set; } = "";
    public string? StrMeasure4 { get; set; } = "";
    public string? StrMeasure5 { get; set; } = "";
    public string? StrMeasure6 { get; set; } = "";
    public string? StrMeasure7 { get; set; } = "";
    public string? StrMeasure8 { get; set; } = "";
    public string? StrMeasure9 { get; set; } = "";
    public string? StrMeasure10 { get; set; } = "";
    public string? StrMeasure11 { get; set; } = "";
    public string? StrMeasure12 { get; set; } = "";
    public string? StrMeasure13 { get; set; } = "";
    public string? StrMeasure14 { get; set; } = "";
    public string? StrMeasure15 { get; set; } = "";
    public string? StrImageSource { get; set; } = "";
    public string? StrImageAttribution { get; set; } = "";
    public string? StrCreativeCommonsConfirmed { get; set; } = "";
    public DateTime DateModified { get; set; }
}