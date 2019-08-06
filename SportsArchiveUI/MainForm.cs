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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SportsArchiveUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Имя файла для загрузки/сохранения тренировок
        /// </summary>
        const string FILE_OF_TRAININGS = "Trainings.bin";
        /// <summary>
        /// Список тренировок из файла
        /// </summary>
        List<Training> trainings;

        public MainForm()
        {
            InitializeComponent();
            buttonDeleteTraining.Enabled = false;
            FileStream fs = new FileStream(FILE_OF_TRAININGS, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            trainings = fs.Length == 0 ? new List<Training>() : (List<Training>)bf.Deserialize(fs);
            fs.Close();
            foreach (Training training in trainings)
            {
                listBoxTrainings.Items.Add(training);
            }
        }

        private void buttonAddTraining_Click(object sender, EventArgs e)
        {
            var form = new AddTrainingForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                trainings.Insert(0, form.Training);
                listBoxTrainings.Items.Insert(0, form.Training);
            }
        }

        private void buttonDeleteTraining_Click(object sender, EventArgs e)
        {
            trainings.RemoveAt(listBoxTrainings.SelectedIndex);
            listBoxTrainings.Items.RemoveAt(listBoxTrainings.SelectedIndex);
            buttonDeleteTraining.Enabled = false;
        }

        /// <summary>
        /// Двойной клик по тренировке => открыть тренировку для просмотра
        /// </summary>
        private void listBoxTrainings_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTrainings.SelectedIndex > -1)
            {
                var form = new AddTrainingForm();
                form.Training = trainings[listBoxTrainings.SelectedIndex];
                form.IsReadOnly = true;
                form.Show();
            }
        }

        /// <summary>
        /// Сохранение данных при закрытии формы
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fs = new FileStream(FILE_OF_TRAININGS, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, trainings);
            fs.Close();
        }

        private void listBoxTrainings_Click(object sender, EventArgs e)
        {
            if (listBoxTrainings.SelectedIndex > -1)
                buttonDeleteTraining.Enabled = true;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxTrainings.SelectedIndex = -1;
            buttonDeleteTraining.Enabled = false;
        }
    }
}
