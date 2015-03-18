namespace RandomQuantityProject
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShot = new System.Windows.Forms.TextBox();
            this.textBoxShoter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxCountOfIter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 249);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Location = new System.Drawing.Point(448, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество стрелков:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество выстрелов:";
            // 
            // textBoxShot
            // 
            this.textBoxShot.Location = new System.Drawing.Point(182, 82);
            this.textBoxShot.Name = "textBoxShot";
            this.textBoxShot.Size = new System.Drawing.Size(100, 20);
            this.textBoxShot.TabIndex = 4;
            // 
            // textBoxShoter
            // 
            this.textBoxShoter.Location = new System.Drawing.Point(182, 35);
            this.textBoxShoter.Name = "textBoxShoter";
            this.textBoxShoter.Size = new System.Drawing.Size(100, 20);
            this.textBoxShoter.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxCountOfIter
            // 
            this.TextBoxCountOfIter.Location = new System.Drawing.Point(438, 35);
            this.TextBoxCountOfIter.Name = "TextBoxCountOfIter";
            this.TextBoxCountOfIter.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCountOfIter.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кол-во итераций:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxCountOfIter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxShoter);
            this.Controls.Add(this.textBoxShot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShot;
        private System.Windows.Forms.TextBox textBoxShoter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxCountOfIter;
        private System.Windows.Forms.Label label3;
    }
}

