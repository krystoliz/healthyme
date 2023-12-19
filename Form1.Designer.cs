namespace HealthyME2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnLoad = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            btnSaves = new Button();
            btnLoads = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(527, 50);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 47);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(527, 163);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(132, 46);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 159);
            textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(142, 251);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(318, 250);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(515, 254);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnSaves
            // 
            btnSaves.Location = new Point(232, 313);
            btnSaves.Name = "btnSaves";
            btnSaves.Size = new Size(75, 23);
            btnSaves.TabIndex = 6;
            btnSaves.Text = "button1";
            btnSaves.UseVisualStyleBackColor = true;
            btnSaves.Click += btnSaves_Click_1;
            // 
            // btnLoads
            // 
            btnLoads.Location = new Point(449, 320);
            btnLoads.Name = "btnLoads";
            btnLoads.Size = new Size(75, 23);
            btnLoads.TabIndex = 7;
            btnLoads.Text = "button2";
            btnLoads.UseVisualStyleBackColor = true;
            btnLoads.Click += btnLoads_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoads);
            Controls.Add(btnSaves);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnLoad;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button btnSaves;
        private Button btnLoads;
    }
}