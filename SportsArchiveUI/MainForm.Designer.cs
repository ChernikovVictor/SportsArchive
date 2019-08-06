namespace SportsArchiveUI
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTrainings = new System.Windows.Forms.ListBox();
            this.buttonAddTraining = new System.Windows.Forms.Button();
            this.buttonDeleteTraining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTrainings
            // 
            this.listBoxTrainings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTrainings.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxTrainings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTrainings.FormattingEnabled = true;
            this.listBoxTrainings.ItemHeight = 24;
            this.listBoxTrainings.Location = new System.Drawing.Point(31, 11);
            this.listBoxTrainings.Name = "listBoxTrainings";
            this.listBoxTrainings.Size = new System.Drawing.Size(442, 892);
            this.listBoxTrainings.TabIndex = 0;
            this.listBoxTrainings.Click += new System.EventHandler(this.listBoxTrainings_Click);
            this.listBoxTrainings.DoubleClick += new System.EventHandler(this.listBoxTrainings_DoubleClick);
            // 
            // buttonAddTraining
            // 
            this.buttonAddTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTraining.Location = new System.Drawing.Point(505, 810);
            this.buttonAddTraining.Name = "buttonAddTraining";
            this.buttonAddTraining.Size = new System.Drawing.Size(234, 38);
            this.buttonAddTraining.TabIndex = 1;
            this.buttonAddTraining.Text = "Добавить тренировку";
            this.buttonAddTraining.UseVisualStyleBackColor = true;
            this.buttonAddTraining.Click += new System.EventHandler(this.buttonAddTraining_Click);
            // 
            // buttonDeleteTraining
            // 
            this.buttonDeleteTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteTraining.Location = new System.Drawing.Point(505, 865);
            this.buttonDeleteTraining.Name = "buttonDeleteTraining";
            this.buttonDeleteTraining.Size = new System.Drawing.Size(234, 38);
            this.buttonDeleteTraining.TabIndex = 2;
            this.buttonDeleteTraining.Text = "Удалить тренировку";
            this.buttonDeleteTraining.UseVisualStyleBackColor = true;
            this.buttonDeleteTraining.Click += new System.EventHandler(this.buttonDeleteTraining_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(765, 917);
            this.Controls.Add(this.buttonDeleteTraining);
            this.Controls.Add(this.buttonAddTraining);
            this.Controls.Add(this.listBoxTrainings);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Архив тренировок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Список тренировок
        /// </summary>
        private System.Windows.Forms.ListBox listBoxTrainings;
        /// <summary>
        /// Добавить тренировку
        /// </summary>
        private System.Windows.Forms.Button buttonAddTraining;
        /// <summary>
        /// Удалить тренировку
        /// </summary>
        private System.Windows.Forms.Button buttonDeleteTraining;
    }
}

