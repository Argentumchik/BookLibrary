namespace BookLibrary
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            buttonEnter = new Button();
            labelFirstName = new Label();
            labelLastName = new Label();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxFirstName.ForeColor = SystemColors.WindowText;
            textBoxFirstName.Location = new Point(38, 45);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(213, 25);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxLastName.ForeColor = SystemColors.WindowText;
            textBoxLastName.Location = new Point(367, 45);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(213, 25);
            textBoxLastName.TabIndex = 1;
            // 
            // buttonEnter
            // 
            buttonEnter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEnter.Location = new Point(171, 113);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(258, 45);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(38, 21);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(62, 15);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(367, 21);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(61, 15);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 182);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Button buttonEnter;
        private Label labelFirstName;
        private Label labelLastName;
    }
}
