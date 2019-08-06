using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsArchiveBL.Model;

namespace SportsArchiveUI
{
    public partial class AddTrainingForm : Form
    {
        public AddTrainingForm()
        {
            InitializeComponent();
            IsReadOnly = false;
        }

        public Training Training { get; set; }

        // true => форма открыта только на чтение
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Добавить упражнения в тренировку, очистить поля ввода
        /// </summary>
        private void buttonAddExercise_Click(object sender, EventArgs e)
        {
            if (textBoxExercise.Text.Length > 0)
            {
                var exercise = new Exercise(textBoxExercise.Text, numericUpDownWeight.Value);
                foreach (NumericUpDown set in panelSets.Controls)
                {
                    if (set.Value != 0)
                    {
                        exercise.Sets.Add(set.Value);
                        set.Value = 0;
                    }
                }
                Training.Exercises.Add(exercise);
                listBoxExercises.Items.Add(exercise);
                textBoxExercise.Text = "";
                numericUpDownWeight.Value = 0;
            }
            else
            {
                MessageBox.Show("Введите упражнение");
            }
        }

        /// <summary>
        /// Сохранить тренировку, закрыть форму
        /// </summary>
        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            if (comboBoxKind1.Text.Length > 0 && comboBoxKind2.Text.Length > 0)
            {
                Training.Date = dateTimePicker1.Value;
                Training.Kind = comboBoxKind1.Text + '/' + comboBoxKind2.Text;
                Training.Comment = textBoxComment.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите вид тренировки");
            }
        }

        private void AddTrainingForm_Load(object sender, EventArgs e)
        {
            if (IsReadOnly)
                ReadOnly();
            if (Training != null)
            {
                // Заполнить форму данными из тренировки
                foreach (Exercise exercise in Training.Exercises)
                {
                    listBoxExercises.Items.Add(exercise);
                }
                textBoxComment.Text = Training.Comment;
                dateTimePicker1.Value = Training.Date;
                int slashPosition = Training.Kind.IndexOf('/');
                comboBoxKind1.Text = Training.Kind.Substring(0, slashPosition);
                comboBoxKind2.Text = Training.Kind.Substring(slashPosition + 1);
            }
            else
            {
                Training = new Training();
            }
        }

        /// <summary>
        /// Открыть форму только на чтение
        /// </summary>
        private void ReadOnly()
        {
            foreach (Control control in this.Controls)
            {
                if (!(control is Label))
                    control.Enabled = false;
            }
            textBoxComment.Enabled = true;
            listBoxExercises.Enabled = true;
        }
    }
}
