namespace ExamVanya
{
    partial class NewAnimal
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
            this.AddAnimal = new System.Windows.Forms.Button();
            this.NameIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfBirthIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FeedTypesList = new System.Windows.Forms.ComboBox();
            this.AnimalTypesList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddAnimal
            // 
            this.AddAnimal.Location = new System.Drawing.Point(12, 118);
            this.AddAnimal.Name = "AddAnimal";
            this.AddAnimal.Size = new System.Drawing.Size(88, 23);
            this.AddAnimal.TabIndex = 0;
            this.AddAnimal.Text = "Add animal";
            this.AddAnimal.UseVisualStyleBackColor = true;
            this.AddAnimal.Click += new System.EventHandler(this.AddAnimal_Click);
            // 
            // NameIn
            // 
            this.NameIn.Location = new System.Drawing.Point(86, 12);
            this.NameIn.Name = "NameIn";
            this.NameIn.Size = new System.Drawing.Size(137, 20);
            this.NameIn.TabIndex = 1;
            this.NameIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameIn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // DateOfBirthIn
            // 
            this.DateOfBirthIn.Location = new System.Drawing.Point(86, 38);
            this.DateOfBirthIn.Name = "DateOfBirthIn";
            this.DateOfBirthIn.Size = new System.Drawing.Size(137, 20);
            this.DateOfBirthIn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of birth:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(135, 118);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Feed type:";
            // 
            // FeedTypesList
            // 
            this.FeedTypesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeedTypesList.FormattingEnabled = true;
            this.FeedTypesList.Location = new System.Drawing.Point(86, 91);
            this.FeedTypesList.Name = "FeedTypesList";
            this.FeedTypesList.Size = new System.Drawing.Size(137, 21);
            this.FeedTypesList.TabIndex = 7;
            // 
            // AnimalTypesList
            // 
            this.AnimalTypesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimalTypesList.FormattingEnabled = true;
            this.AnimalTypesList.Location = new System.Drawing.Point(86, 64);
            this.AnimalTypesList.Name = "AnimalTypesList";
            this.AnimalTypesList.Size = new System.Drawing.Size(137, 21);
            this.AnimalTypesList.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animal type:";
            // 
            // NewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 150);
            this.Controls.Add(this.AnimalTypesList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FeedTypesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateOfBirthIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameIn);
            this.Controls.Add(this.AddAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAnimal";
            this.Text = "NewAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAnimal;
        private System.Windows.Forms.TextBox NameIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateOfBirthIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FeedTypesList;
        private System.Windows.Forms.ComboBox AnimalTypesList;
        private System.Windows.Forms.Label label4;
    }
}