
namespace theOfficeAI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Character = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.numericUpDown_NumWordsSpoken = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumWordsSpoken)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of words spoken by:";
            // 
            // comboBox_Character
            // 
            this.comboBox_Character.FormattingEnabled = true;
            this.comboBox_Character.Items.AddRange(new object[] {
            "Dwight"});
            this.comboBox_Character.Location = new System.Drawing.Point(390, 12);
            this.comboBox_Character.Name = "comboBox_Character";
            this.comboBox_Character.Size = new System.Drawing.Size(292, 39);
            this.comboBox_Character.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "is:";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(978, 900);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(241, 86);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.Update);
            // 
            // numericUpDown_NumWordsSpoken
            // 
            this.numericUpDown_NumWordsSpoken.Location = new System.Drawing.Point(738, 13);
            this.numericUpDown_NumWordsSpoken.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDown_NumWordsSpoken.Name = "numericUpDown_NumWordsSpoken";
            this.numericUpDown_NumWordsSpoken.Size = new System.Drawing.Size(481, 38);
            this.numericUpDown_NumWordsSpoken.TabIndex = 4;
            this.numericUpDown_NumWordsSpoken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1231, 998);
            this.Controls.Add(this.numericUpDown_NumWordsSpoken);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Character);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumWordsSpoken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Character;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumWordsSpoken;
    }
}

