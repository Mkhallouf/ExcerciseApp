using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcerciseApp
{
    public class Workout
    {
        private List<IExcercise> _excercises;

        public Workout()
        {
            this._excercises = new List<IExcercise>();
        }

        public void AddExcercise(IExcercise excercise)
        {
            _excercises.Add(excercise);
        }

        public bool RemoveExcercise(IExcercise excercise)
        {
            return _excercises.Remove(excercise);
        }

        public List<IExcercise> GetExcercises()
        {
            return this._excercises;
        }

        public void UpdateExcercise(int index, double? weight = null, int? reps = null, int? sets = null, TimeSpan? time = null, double? distance = null)
        {
            var excercise = _excercises[index];

            switch (excercise)
            {
                case Cardio c:
                    c.Time = time ?? c.Time;
                    c.Distance = distance ?? c.Distance;
                    break;
                case WeightLifting w:
                    w.Wieght = weight ?? w.Wieght;
                    w.Reps = reps ?? w.Reps;
                    w.Sets = sets ?? w.Sets;
                    break;
            }
        }
    }
}
