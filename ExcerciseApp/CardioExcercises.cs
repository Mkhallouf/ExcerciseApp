using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseApp
{
    public class Cardio : IExcercise
    {
        public TimeSpan Time { get; set; }
        public double Distance { get; set; }
        public ExcerciseType Type { get; set; }

        public double CalculateBurnedCalories()
        {
            return Time.TotalSeconds / Distance * 0.5;
        }
    }
}
