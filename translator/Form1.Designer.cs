namespace translator
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
            SourceTextBox = new TextBox();
            OutputTextBox = new TextBox();
            Translatebutton = new Button();
            comboBoxSourceLang = new ComboBox();
            comboBoxOutLang = new ComboBox();
            SuspendLayout();
            // 
            // SourceTextBox
            // 
            SourceTextBox.Location = new Point(119, 42);
            SourceTextBox.Multiline = true;
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new Size(561, 117);
            SourceTextBox.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(119, 274);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new Size(561, 117);
            OutputTextBox.TabIndex = 1;
            // 
            // Translatebutton
            // 
            Translatebutton.Location = new Point(665, 205);
            Translatebutton.Name = "Translatebutton";
            Translatebutton.Size = new Size(94, 29);
            Translatebutton.TabIndex = 2;
            Translatebutton.Text = "translate";
            Translatebutton.UseVisualStyleBackColor = true;
            Translatebutton.Click += TranslateButton_Clicked;
            // 
            // comboBoxSourceLang
            // 
            comboBoxSourceLang.FormattingEnabled = true;
            comboBoxSourceLang.Location = new Point(10, 42);
            comboBoxSourceLang.Name = "comboBoxSourceLang";
            comboBoxSourceLang.Size = new Size(103, 28);
            comboBoxSourceLang.TabIndex = 3;
            // 
            // comboBoxOutLang
            // 
            comboBoxOutLang.FormattingEnabled = true;
            comboBoxOutLang.Location = new Point(12, 308);
            comboBoxOutLang.Name = "comboBoxOutLang";
            comboBoxOutLang.Size = new Size(103, 28);
            comboBoxOutLang.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxOutLang);
            Controls.Add(comboBoxSourceLang);
            Controls.Add(Translatebutton);
            Controls.Add(OutputTextBox);
            Controls.Add(SourceTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Translator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SourceTextBox;
        private TextBox OutputTextBox;
        private Button Translatebutton;
        private ComboBox comboBoxSourceLang;
        private ComboBox comboBoxOutLang;
    }
}
