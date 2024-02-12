namespace BookLibrary
{
    partial class AddABook
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
            textBoxAddTitle = new TextBox();
            textBoxAddGenre = new TextBox();
            textBoxAddAuthor = new TextBox();
            textBoxAddYear = new TextBox();
            labelAddTitle = new Label();
            labelAddAuthor = new Label();
            labelAddGenre = new Label();
            labelAddYear = new Label();
            buttonAddExit = new Button();
            buttonAddAdd = new Button();
            SuspendLayout();
            // 
            // textBoxAddTitle
            // 
            textBoxAddTitle.Location = new Point(12, 57);
            textBoxAddTitle.Name = "textBoxAddTitle";
            textBoxAddTitle.Size = new Size(219, 23);
            textBoxAddTitle.TabIndex = 0;
            // 
            // textBoxAddGenre
            // 
            textBoxAddGenre.Location = new Point(12, 160);
            textBoxAddGenre.Name = "textBoxAddGenre";
            textBoxAddGenre.Size = new Size(219, 23);
            textBoxAddGenre.TabIndex = 1;
            // 
            // textBoxAddAuthor
            // 
            textBoxAddAuthor.Location = new Point(364, 57);
            textBoxAddAuthor.Name = "textBoxAddAuthor";
            textBoxAddAuthor.Size = new Size(219, 23);
            textBoxAddAuthor.TabIndex = 2;
            // 
            // textBoxAddYear
            // 
            textBoxAddYear.Location = new Point(364, 160);
            textBoxAddYear.Name = "textBoxAddYear";
            textBoxAddYear.Size = new Size(219, 23);
            textBoxAddYear.TabIndex = 3;
            // 
            // labelAddTitle
            // 
            labelAddTitle.AutoSize = true;
            labelAddTitle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAddTitle.Location = new Point(12, 35);
            labelAddTitle.Name = "labelAddTitle";
            labelAddTitle.Size = new Size(34, 19);
            labelAddTitle.TabIndex = 4;
            labelAddTitle.Text = "Title";
            // 
            // labelAddAuthor
            // 
            labelAddAuthor.AutoSize = true;
            labelAddAuthor.Font = new Font("Times New Roman", 12F);
            labelAddAuthor.Location = new Point(364, 35);
            labelAddAuthor.Name = "labelAddAuthor";
            labelAddAuthor.Size = new Size(51, 19);
            labelAddAuthor.TabIndex = 5;
            labelAddAuthor.Text = "Author";
            // 
            // labelAddGenre
            // 
            labelAddGenre.AutoSize = true;
            labelAddGenre.Font = new Font("Times New Roman", 12F);
            labelAddGenre.Location = new Point(12, 138);
            labelAddGenre.Name = "labelAddGenre";
            labelAddGenre.Size = new Size(46, 19);
            labelAddGenre.TabIndex = 6;
            labelAddGenre.Text = "Genre";
            // 
            // labelAddYear
            // 
            labelAddYear.AutoSize = true;
            labelAddYear.Font = new Font("Times New Roman", 12F);
            labelAddYear.Location = new Point(364, 138);
            labelAddYear.Name = "labelAddYear";
            labelAddYear.Size = new Size(37, 19);
            labelAddYear.TabIndex = 7;
            labelAddYear.Text = "Year";
            // 
            // buttonAddExit
            // 
            buttonAddExit.Font = new Font("Times New Roman", 12F);
            buttonAddExit.Location = new Point(56, 226);
            buttonAddExit.Name = "buttonAddExit";
            buttonAddExit.Size = new Size(175, 35);
            buttonAddExit.TabIndex = 8;
            buttonAddExit.Text = "Exit";
            buttonAddExit.UseVisualStyleBackColor = true;
            // 
            // buttonAddAdd
            // 
            buttonAddAdd.Font = new Font("Times New Roman", 12F);
            buttonAddAdd.Location = new Point(408, 226);
            buttonAddAdd.Name = "buttonAddAdd";
            buttonAddAdd.Size = new Size(175, 35);
            buttonAddAdd.TabIndex = 9;
            buttonAddAdd.Text = "Add";
            buttonAddAdd.UseVisualStyleBackColor = true;
            buttonAddAdd.Click += buttonAddAdd_Click;
            // 
            // AddABook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 290);
            Controls.Add(buttonAddAdd);
            Controls.Add(buttonAddExit);
            Controls.Add(labelAddYear);
            Controls.Add(labelAddGenre);
            Controls.Add(labelAddAuthor);
            Controls.Add(labelAddTitle);
            Controls.Add(textBoxAddYear);
            Controls.Add(textBoxAddAuthor);
            Controls.Add(textBoxAddGenre);
            Controls.Add(textBoxAddTitle);
            Name = "AddABook";
            Text = "Add_a_book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddTitle;
        private TextBox textBoxAddGenre;
        private TextBox textBoxAddAuthor;
        private TextBox textBoxAddYear;
        private Label labelAddTitle;
        private Label labelAddAuthor;
        private Label labelAddGenre;
        private Label labelAddYear;
        private Button buttonAddExit;
        private Button buttonAddAdd;
    }
}