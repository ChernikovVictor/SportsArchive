using System;
using System.Collections.Generic;

namespace SportsArchiveBL.Model
{
    [Serializable]
    public class Training
    {
        /// <summary>
        /// Дата тренировки
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Вид тренировки (группы мышц)
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// Упражнения тренировки
        /// </summary>
        public List<Exercise> Exercises { get; set; }
        /// <summary>
        /// Примечание к тренировке
        /// </summary>
        public string Comment { get; set; }

        public Training() : this(DateTime.Now, "", "") { }

        public Training(DateTime date, string kind, string comment)
        {
            Date = date;
            Kind = kind;
            Comment = comment;
            Exercises = new List<Exercise>();
        }

        public override string ToString()
        {
            return Date.ToShortDateString() + ' ' + Kind;
        }
    }
}
