namespace BookLibrary
{
    partial class Form2
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
            labelWelcome = new Label();
            buttonAdd = new Button();
            buttonTake = new Button();
            buttonLibrary = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(12, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(57, 15);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(12, 88);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(195, 38);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add a book";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonTake
            // 
            buttonTake.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTake.Location = new Point(12, 188);
            buttonTake.Name = "buttonTake";
            buttonTake.Size = new Size(195, 38);
            buttonTake.TabIndex = 2;
            buttonTake.Text = "Take a book";
            buttonTake.UseVisualStyleBackColor = true;
            // 
            // buttonLibrary
            // 
            buttonLibrary.Font = new Font("Segoe UI", 12F);
            buttonLibrary.Location = new Point(12, 282);
            buttonLibrary.Name = "buttonLibrary";
            buttonLibrary.Size = new Size(195, 38);
            buttonLibrary.TabIndex = 3;
            buttonLibrary.Text = "Library";
            buttonLibrary.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(12, 391);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(195, 38);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonLibrary);
            Controls.Add(buttonTake);
            Controls.Add(buttonAdd);
            Controls.Add(labelWelcome);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonAdd;
        private Button buttonTake;
        private Button buttonLibrary;
        private Button buttonExit;
    }
}