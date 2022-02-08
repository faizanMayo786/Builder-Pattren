using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattren
{
    class NonVegMeal:MealBuilder
    {
        private Meal meal = new Meal();

        public override void AddDrink()
        {
            meal.Drink = "Sprite";
        }

        public override void AddFries()
        {
            meal.Fries = "Fries";
        }

        public override void AddSandwich()
        {
            meal.Sandwich = "Chicken Anda";

        }

        public override Meal GetMeal()
        {
            return meal;
        }

    }

}
