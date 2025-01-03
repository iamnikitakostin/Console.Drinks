﻿using System.Reflection;
using Drinks.iamnikitakostin.Models;

namespace Drinks.iamnikitakostin;

internal class Validation
{
    public static Dictionary<string,string> Drink (DrinkDetail drinkItem)
    {
        Dictionary<string,string> validatedDrink = new Dictionary<string,string>();

        foreach (PropertyInfo property in typeof(DrinkDetail).GetProperties())
        {
            string name = property.Name;
            object value = property.GetValue(drinkItem) ?? null;

            if (value == null)
                continue;

            validatedDrink.Add(name, value.ToString());
        }

        return validatedDrink;
    }
}
