using System;
using System.Collections.Generic;

namespace SportsArchiveBL.Model
{
    [Serializable]
    public class Exercise
    {
        /// <summary>
        /// Название упражнения
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вес снаряда
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// Список подходов (элемент списка - число повторений в подходе)
        /// </summary>
        public List<decimal> Sets { get; set; }

        public Exercise() : this("", 0) { }

        public Exercise(string name, decimal weight)
        {
            Name = name;
            Weight = weight;
            Sets = new List<decimal>();
        }

        public override string ToString()
        {
            return Name + ' ' + Weight.ToString() + " кг. " + String.Join("-", Sets);
        }
    }
}
