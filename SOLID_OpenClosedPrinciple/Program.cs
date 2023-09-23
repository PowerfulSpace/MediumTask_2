

using SOLID_OpenClosedPrinciple.Models;

MealBase[] menu = new MealBase[] { new PotatoMeal(), new SaladMeal() };

Cook bob = new Cook("Bob");

bob.MakeDinner(menu);


Console.ReadLine();