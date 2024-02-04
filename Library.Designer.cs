namespace BookLibrary
{
    partial class Library
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
            dataGridViewLibrary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrary).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLibrary
            // 
            dataGridViewLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibrary.Location = new Point(12, 12);
            dataGridViewLibrary.Name = "dataGridViewLibrary";
            dataGridViewLibrary.Size = new Size(822, 426);
            dataGridViewLibrary.TabIndex = 0;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 450);
            Controls.Add(dataGridViewLibrary);
            Name = "Library";
            Text = "Library";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLibrary;
    }
}