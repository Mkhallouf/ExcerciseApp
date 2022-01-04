using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseApp
{
    public class WeightLifting : IExcercise
    {
        public int Reps { get; set; }
        public double Wieght { get; set; }
        public int Sets { get; set; }
        public ExcerciseType Type { get; set; }

        public double CalculateBurnedCalories()
        {
            return Reps * Sets * Wieght * 0.5;
        }
    }
}
