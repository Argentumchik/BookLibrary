namespace BookLibrary
{
    partial class Take_a_book
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
            buttonTakeTake = new Button();
            buttonTakeExit = new Button();
            labelTakeYear = new Label();
            labelTakeGenre = new Label();
            labelTakeAuthor = new Label();
            labelTakeTitle = new Label();
            textBoxTakeYear = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxTakeGenre = new TextBox();
            textBoxTakeTitle = new TextBox();
            SuspendLayout();
            // 
            // buttonTakeTake
            // 
            buttonTakeTake.Font = new Font("Times New Roman", 12F);
            buttonTakeTake.Location = new Point(421, 219);
            buttonTakeTake.Name = "buttonTakeTake";
            buttonTakeTake.Size = new Size(175, 35);
            buttonTakeTake.TabIndex = 19;
            buttonTakeTake.Text = "Take";
            buttonTakeTake.UseVisualStyleBackColor = true;
            // 
            // buttonTakeExit
            // 
            buttonTakeExit.Font = new Font("Times New Roman", 12F);
            buttonTakeExit.Location = new Point(69, 219);
            buttonTakeExit.Name = "buttonTakeExit";
            buttonTakeExit.Size = new Size(175, 35);
            buttonTakeExit.TabIndex = 18;
            buttonTakeExit.Text = "Exit";
            buttonTakeExit.UseVisualStyleBackColor = true;
            // 
            // labelTakeYear
            // 
            labelTakeYear.AutoSize = true;
            labelTakeYear.Font = new Font("Times New Roman", 12F);
            labelTakeYear.Location = new Point(377, 131);
            labelTakeYear.Name = "labelTakeYear";
            labelTakeYear.Size = new Size(37, 19);
            labelTakeYear.TabIndex = 17;
            labelTakeYear.Text = "Year";
            // 
            // labelTakeGenre
            // 
            labelTakeGenre.AutoSize = true;
            labelTakeGenre.Font = new Font("Times New Roman", 12F);
            labelTakeGenre.Location = new Point(25, 131);
            labelTakeGenre.Name = "labelTakeGenre";
            labelTakeGenre.Size = new Size(46, 19);
            labelTakeGenre.TabIndex = 16;
            labelTakeGenre.Text = "Genre";
            // 
            // labelTakeAuthor
            // 
            labelTakeAuthor.AutoSize = true;
            labelTakeAuthor.Font = new Font("Times New Roman", 12F);
            labelTakeAuthor.Location = new Point(377, 28);
            labelTakeAuthor.Name = "labelTakeAuthor";
            labelTakeAuthor.Size = new Size(51, 19);
            labelTakeAuthor.TabIndex = 15;
            labelTakeAuthor.Text = "Author";
            // 
            // labelTakeTitle
            // 
            labelTakeTitle.AutoSize = true;
            labelTakeTitle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTakeTitle.Location = new Point(25, 28);
            labelTakeTitle.Name = "labelTakeTitle";
            labelTakeTitle.Size = new Size(34, 19);
            labelTakeTitle.TabIndex = 14;
            labelTakeTitle.Text = "Title";
            // 
            // textBoxTakeYear
            // 
            textBoxTakeYear.Location = new Point(377, 153);
            textBoxTakeYear.Name = "textBoxTakeYear";
            textBoxTakeYear.Size = new Size(219, 23);
            textBoxTakeYear.TabIndex = 13;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(377, 50);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(219, 23);
            textBoxAuthor.TabIndex = 12;
            // 
            // textBoxTakeGenre
            // 
            textBoxTakeGenre.Location = new Point(25, 153);
            textBoxTakeGenre.Name = "textBoxTakeGenre";
            textBoxTakeGenre.Size = new Size(219, 23);
            textBoxTakeGenre.TabIndex = 11;
            // 
            // textBoxTakeTitle
            // 
            textBoxTakeTitle.Location = new Point(25, 50);
            textBoxTakeTitle.Name = "textBoxTakeTitle";
            textBoxTakeTitle.Size = new Size(219, 23);
            textBoxTakeTitle.TabIndex = 10;
            // 
            // Take_a_book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 286);
            Controls.Add(buttonTakeTake);
            Controls.Add(buttonTakeExit);
            Controls.Add(labelTakeYear);
            Controls.Add(labelTakeGenre);
            Controls.Add(labelTakeAuthor);
            Controls.Add(labelTakeTitle);
            Controls.Add(textBoxTakeYear);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxTakeGenre);
            Controls.Add(textBoxTakeTitle);
            Name = "Take_a_book";
            Text = "Take_a_book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTakeTake;
        private Button buttonTakeExit;
        private Label labelTakeYear;
        private Label labelTakeGenre;
        private Label labelTakeAuthor;
        private Label labelTakeTitle;
        private TextBox textBoxTakeYear;
        private TextBox textBoxAuthor;
        private TextBox textBoxTakeGenre;
        private TextBox textBoxTakeTitle;
    }
}