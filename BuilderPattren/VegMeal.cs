using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattren
{
    class VegMeal : MealBuilder
    {
        private Meal meal = new Meal();

        public override void AddDrink()
        {
            meal.Drink = "Soda Can";
        }

        public override void AddFries()
        {
            meal.Fries = "French Fries";
        }

        public override void AddSandwich()
        {
            meal.Sandwich = "Mixed Vegetable";

        }

        public override Meal GetMeal()
        {
            return meal;
        }
    }
}
