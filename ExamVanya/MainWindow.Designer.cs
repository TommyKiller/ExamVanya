namespace ExamVanya
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddAnimal = new System.Windows.Forms.Button();
            this.AviariesList = new System.Windows.Forms.ComboBox();
            this.AnimalsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDIn = new System.Windows.Forms.TextBox();
            this.AddAviary = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAnimal
            // 
            this.AddAnimal.Location = new System.Drawing.Point(53, 91);
            this.AddAnimal.Name = "AddAnimal";
            this.AddAnimal.Size = new System.Drawing.Size(107, 20);
            this.AddAnimal.TabIndex = 11;
            this.AddAnimal.Text = "Add animal...";
            this.AddAnimal.UseVisualStyleBackColor = true;
            this.AddAnimal.Click += new System.EventHandler(this.AddAnimal_Click);
            // 
            // AviariesList
            // 
            this.AviariesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AviariesList.FormattingEnabled = true;
            this.AviariesList.Location = new System.Drawing.Point(53, 64);
            this.AviariesList.Name = "AviariesList";
            this.AviariesList.Size = new System.Drawing.Size(107, 21);
            this.AviariesList.TabIndex = 10;
            this.AviariesList.SelectedIndexChanged += new System.EventHandler(this.AviariesList_SelectedIndexChanged);
            // 
            // AnimalsList
            // 
            this.AnimalsList.FormattingEnabled = true;
            this.AnimalsList.Location = new System.Drawing.Point(166, 12);
            this.AnimalsList.Name = "AnimalsList";
            this.AnimalsList.Size = new System.Drawing.Size(101, 134);
            this.AnimalsList.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // IDIn
            // 
            this.IDIn.Location = new System.Drawing.Point(53, 12);
            this.IDIn.Name = "IDIn";
            this.IDIn.Size = new System.Drawing.Size(107, 20);
            this.IDIn.TabIndex = 7;
            this.IDIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDIn_KeyPress);
            // 
            // AddAviary
            // 
            this.AddAviary.Location = new System.Drawing.Point(53, 38);
            this.AddAviary.Name = "AddAviary";
            this.AddAviary.Size = new System.Drawing.Size(107, 20);
            this.AddAviary.TabIndex = 6;
            this.AddAviary.Text = "Add aviary";
            this.AddAviary.UseVisualStyleBackColor = true;
            this.AddAviary.Click += new System.EventHandler(this.AddAviary_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(53, 117);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 20);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddAnimal);
            this.Controls.Add(this.AviariesList);
            this.Controls.Add(this.AnimalsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDIn);
            this.Controls.Add(this.AddAviary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAnimal;
        private System.Windows.Forms.ComboBox AviariesList;
        private System.Windows.Forms.ListBox AnimalsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDIn;
        private System.Windows.Forms.Button AddAviary;
        private System.Windows.Forms.Button Exit;
    }
}

