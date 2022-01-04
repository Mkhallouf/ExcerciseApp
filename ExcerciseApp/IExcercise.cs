using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseApp
{
    public interface IExcercise
    {
        public ExcerciseType Type { get; set; }
        double CalculateBurnedCalories();
    }
}
