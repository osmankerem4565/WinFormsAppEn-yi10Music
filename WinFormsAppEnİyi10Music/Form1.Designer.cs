namespace WinFormsAppEnİyi10Music
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
            lstAllSongs = new ListBox();
            lstFavorites = new ListBox();
            btnAddToFavorites = new Button();
            btnRemoveFromFavorites = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstAllSongs
            // 
            lstAllSongs.FormattingEnabled = true;
            lstAllSongs.ItemHeight = 15;
            lstAllSongs.Location = new Point(39, 213);
            lstAllSongs.Name = "lstAllSongs";
            lstAllSongs.Size = new Size(295, 289);
            lstAllSongs.TabIndex = 0;
            // 
            // lstFavorites
            // 
            lstFavorites.ItemHeight = 15;
            lstFavorites.Location = new Point(549, 213);
            lstFavorites.Name = "lstFavorites";
            lstFavorites.Size = new Size(287, 289);
            lstFavorites.TabIndex = 3;
            // 
            // btnAddToFavorites
            // 
            btnAddToFavorites.Location = new Point(373, 298);
            btnAddToFavorites.Name = "btnAddToFavorites";
            btnAddToFavorites.Size = new Size(125, 23);
            btnAddToFavorites.TabIndex = 1;
            btnAddToFavorites.Text = "Favorilere Ekle";
            btnAddToFavorites.UseVisualStyleBackColor = true;
            btnAddToFavorites.Click += btnAddToFavorites_Click;
            // 
            // btnRemoveFromFavorites
            // 
            btnRemoveFromFavorites.Location = new Point(373, 368);
            btnRemoveFromFavorites.Name = "btnRemoveFromFavorites";
            btnRemoveFromFavorites.Size = new Size(125, 23);
            btnRemoveFromFavorites.TabIndex = 2;
            btnRemoveFromFavorites.Text = "Favorilerden Kaldır";
            btnRemoveFromFavorites.UseVisualStyleBackColor = true;
            btnRemoveFromFavorites.Click += btnRemoveFromFavorites_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 155);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 4;
            label1.Text = "En İyi 10 Music";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(613, 155);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 5;
            label2.Text = "Favorilerim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(222, 32);
            label3.Name = "label3";
            label3.Size = new Size(410, 45);
            label3.TabIndex = 6;
            label3.Text = "TÜRKİYE EN İYİ 10 MUSİC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 515);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemoveFromFavorites);
            Controls.Add(btnAddToFavorites);
            Controls.Add(lstFavorites);
            Controls.Add(lstAllSongs);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAllSongs;
        private ListBox lstFavorites;
        private Button btnAddToFavorites;
        private Button btnRemoveFromFavorites;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
