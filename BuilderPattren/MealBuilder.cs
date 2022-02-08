using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattren
{
   public abstract class MealBuilder
    {
        public abstract void AddSandwich();
        public abstract void AddFries();
        public abstract void AddDrink();
        public abstract Meal GetMeal();
       


    }
}
