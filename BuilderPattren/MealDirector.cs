using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattren
{
    class MealDirector
    {

        public void MakeMeal(MealBuilder builder)
        {
            builder.AddSandwich();
            builder.AddFries();
            builder.AddDrink();


        }
    }
}
