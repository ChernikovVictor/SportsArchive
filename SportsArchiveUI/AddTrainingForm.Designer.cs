namespace SportsArchiveUI
{
    partial class AddTrainingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelKind = new System.Windows.Forms.Label();
            this.comboBoxKind1 = new System.Windows.Forms.ComboBox();
            this.comboBoxKind2 = new System.Windows.Forms.ComboBox();
            this.buttonAddExercise = new System.Windows.Forms.Button();
            this.labelExercises = new System.Windows.Forms.Label();
            this.listBoxExercises = new System.Windows.Forms.ListBox();
            this.labelExercise = new System.Windows.Forms.Label();
            this.textBoxExercise = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelReps = new System.Windows.Forms.Label();
            this.numericUpDownSet1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSet2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSet3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSet4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSet5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSet6 = new System.Windows.Forms.NumericUpDown();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.panelSets = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet6)).BeginInit();
            this.panelSets.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 24);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelKind
            // 
            this.labelKind.AutoSize = true;
            this.labelKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKind.Location = new System.Drawing.Point(315, 27);
            this.labelKind.Name = "labelKind";
            this.labelKind.Size = new System.Drawing.Size(176, 24);
            this.labelKind.TabIndex = 2;
            this.labelKind.Text = "Мышечная группа:";
            // 
            // comboBoxKind1
            // 
            this.comboBoxKind1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxKind1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKind1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxKind1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKind1.FormattingEnabled = true;
            this.comboBoxKind1.Items.AddRange(new object[] {
            "Бицепс",
            "Грудь",
            "Ноги",
            "Плечи",
            "Пресс",
            "Прочее",
            "Спина",
            "Трицепс"});
            this.comboBoxKind1.Location = new System.Drawing.Point(517, 19);
            this.comboBoxKind1.Name = "comboBoxKind1";
            this.comboBoxKind1.Size = new System.Drawing.Size(121, 32);
            this.comboBoxKind1.Sorted = true;
            this.comboBoxKind1.TabIndex = 3;
            // 
            // comboBoxKind2
            // 
            this.comboBoxKind2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxKind2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKind2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxKind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKind2.FormattingEnabled = true;
            this.comboBoxKind2.Items.AddRange(new object[] {
            "Бицепс",
            "Грудь",
            "Ноги",
            "Плечи",
            "Пресс",
            "Прочее",
            "Спина",
            "Трицепс"});
            this.comboBoxKind2.Location = new System.Drawing.Point(676, 19);
            this.comboBoxKind2.Name = "comboBoxKind2";
            this.comboBoxKind2.Size = new System.Drawing.Size(121, 32);
            this.comboBoxKind2.Sorted = true;
            this.comboBoxKind2.TabIndex = 4;
            // 
            // buttonAddExercise
            // 
            this.buttonAddExercise.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonAddExercise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddExercise.Location = new System.Drawing.Point(612, 529);
            this.buttonAddExercise.Name = "buttonAddExercise";
            this.buttonAddExercise.Size = new System.Drawing.Size(251, 36);
            this.buttonAddExercise.TabIndex = 5;
            this.buttonAddExercise.Text = "Добавить упражнение";
            this.buttonAddExercise.UseVisualStyleBackColor = false;
            this.buttonAddExercise.Click += new System.EventHandler(this.buttonAddExercise_Click);
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExercises.Location = new System.Drawing.Point(12, 66);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(127, 24);
            this.labelExercises.TabIndex = 6;
            this.labelExercises.Text = "Упражнения:";
            // 
            // listBoxExercises
            // 
            this.listBoxExercises.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxExercises.FormattingEnabled = true;
            this.listBoxExercises.ItemHeight = 24;
            this.listBoxExercises.Location = new System.Drawing.Point(16, 104);
            this.listBoxExercises.Name = "listBoxExercises";
            this.listBoxExercises.Size = new System.Drawing.Size(622, 364);
            this.listBoxExercises.TabIndex = 7;
            // 
            // labelExercise
            // 
            this.labelExercise.AutoSize = true;
            this.labelExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExercise.Location = new System.Drawing.Point(13, 495);
            this.labelExercise.Name = "labelExercise";
            this.labelExercise.Size = new System.Drawing.Size(128, 24);
            this.labelExercise.TabIndex = 8;
            this.labelExercise.Text = "Упражнение:";
            // 
            // textBoxExercise
            // 
            this.textBoxExercise.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExercise.Location = new System.Drawing.Point(147, 493);
            this.textBoxExercise.Name = "textBoxExercise";
            this.textBoxExercise.Size = new System.Drawing.Size(716, 26);
            this.textBoxExercise.TabIndex = 9;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.Location = new System.Drawing.Point(13, 535);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(48, 24);
            this.labelWeight.TabIndex = 10;
            this.labelWeight.Text = "Вес:";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWeight.Location = new System.Drawing.Point(67, 535);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownWeight.TabIndex = 11;
            // 
            // labelReps
            // 
            this.labelReps.AutoSize = true;
            this.labelReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReps.Location = new System.Drawing.Point(145, 535);
            this.labelReps.Name = "labelReps";
            this.labelReps.Size = new System.Drawing.Size(125, 24);
            this.labelReps.TabIndex = 12;
            this.labelReps.Text = "Повторения:";
            // 
            // numericUpDownSet1
            // 
            this.numericUpDownSet1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownSet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSet1.Location = new System.Drawing.Point(3, 1);
            this.numericUpDownSet1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSet1.Name = "numericUpDownSet1";
            this.numericUpDownSet1.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSet1.TabIndex = 13;
            // 
            // numericUpDownSet2
            // 
            this.numericUpDownSet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSet2.Location = new System.Drawing.Point(59, 1);
            this.numericUpDownSet2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSet2.Name = "numericUpDownSet2";
            this.numericUpDownSet2.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSet2.TabIndex = 14;
            // 
            // numericUpDownSet3
            // 
            this.numericUpDownSet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSet3.Location = new System.Drawing.Point(115, 1);
            this.numericUpDownSet3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSet3.Name = "numericUpDownSet3";
            this.numericUpDownSet3.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSet3.TabIndex = 15;
            // 
            // numericUpDownSet4
            // 
            this.numericUpDownSet4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSet4.Location = new System.Drawing.Point(171, 1);
            this.numericUpDownSet4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSet4.Name = "numericUpDownSet4";
            this.numericUpDownSet4.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSet4.TabIndex = 16;
            // 
            // numericUpDownSet5
            // 
            this.numericUpDownSet5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSet5.Location = new System.Drawing.Point(227, 1);
            this.numericUpDownSet5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSet5.Name = "numericUpDownSet5";
            this.numericUpDownSet5.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSet5.TabIndex = 17;
            // 
            // numericUpDownSet6
            // 
            this.numericUpDownSet6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSet6.Location = new System.Drawing.Point(283, 1);
            this.numericUpDownSet6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSet6.Name = "numericUpDownSet6";
            this.numericUpDownSet6.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSet6.TabIndex = 18;
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComment.Location = new System.Drawing.Point(676, 104);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(187, 364);
            this.textBoxComment.TabIndex = 19;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComment.Location = new System.Drawing.Point(674, 66);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(126, 24);
            this.labelComment.TabIndex = 20;
            this.labelComment.Text = "Примечания:";
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAndExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSaveAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveAndExit.Location = new System.Drawing.Point(330, 585);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(218, 32);
            this.buttonSaveAndExit.TabIndex = 21;
            this.buttonSaveAndExit.Text = "Сохранить и выйти";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.buttonSaveAndExit_Click);
            // 
            // panelSets
            // 
            this.panelSets.Controls.Add(this.numericUpDownSet1);
            this.panelSets.Controls.Add(this.numericUpDownSet2);
            this.panelSets.Controls.Add(this.numericUpDownSet3);
            this.panelSets.Controls.Add(this.numericUpDownSet4);
            this.panelSets.Controls.Add(this.numericUpDownSet6);
            this.panelSets.Controls.Add(this.numericUpDownSet5);
            this.panelSets.Location = new System.Drawing.Point(266, 535);
            this.panelSets.Name = "panelSets";
            this.panelSets.Size = new System.Drawing.Size(340, 28);
            this.panelSets.TabIndex = 22;
            // 
            // AddTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(890, 629);
            this.Controls.Add(this.panelSets);
            this.Controls.Add(this.buttonSaveAndExit);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelReps);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxExercise);
            this.Controls.Add(this.labelExercise);
            this.Controls.Add(this.listBoxExercises);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.buttonAddExercise);
            this.Controls.Add(this.comboBoxKind2);
            this.Controls.Add(this.comboBoxKind1);
            this.Controls.Add(this.labelKind);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.MaximizeBox = false;
            this.Name = "AddTrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление тренировки";
            this.Load += new System.EventHandler(this.AddTrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSet6)).EndInit();
            this.panelSets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelKind;
        private System.Windows.Forms.ComboBox comboBoxKind1;
        private System.Windows.Forms.ComboBox comboBoxKind2;
        private System.Windows.Forms.Button buttonAddExercise;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.ListBox listBoxExercises;
        private System.Windows.Forms.Label labelExercise;
        private System.Windows.Forms.TextBox textBoxExercise;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelReps;
        private System.Windows.Forms.NumericUpDown numericUpDownSet1;
        private System.Windows.Forms.NumericUpDown numericUpDownSet2;
        private System.Windows.Forms.NumericUpDown numericUpDownSet3;
        private System.Windows.Forms.NumericUpDown numericUpDownSet4;
        private System.Windows.Forms.NumericUpDown numericUpDownSet5;
        private System.Windows.Forms.NumericUpDown numericUpDownSet6;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.Panel panelSets;
    }
}