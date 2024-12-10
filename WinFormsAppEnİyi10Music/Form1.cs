namespace WinFormsAppEnİyi10Music
{
    public partial class Form1 : Form
    {
        private List<string> allSongs;

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.MainForm_Load);
            InitializeSongList();
        }

        private void InitializeSongList()
        {
            // Şarkı listesini burada oluşturuyoruz
            allSongs = new List<string>
            {
                "1. Gülümse - Sezen Aksu",
                "2. Ah Bu Şarkıların Gözü Kör Olsun - Zeki Müren",
                "3. Şımarık - Tarkan",
                "4. Senden Daha Güzel - Duman",
                "5. Ölürüm Sana - Tarkan",
                "6. Delikanlım - Yıldız Tilbe",
                "7. Fikrimin İnce Gülü - Münir Nurettin Selçuk",
                "8. Sen Ağlama - Sezen Aksu",
                "9. Ele Güne Karşı - MFÖ",
                "10. Bir Başkadır Benim Memleketim - Ayten Alpman"
            };
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Şarkı listesini ListBox'a ekliyoruz
            lstAllSongs.Items.AddRange(allSongs.ToArray());
        }


        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            // Favori şarkı ekleme sınırını kontrol et
            if (lstFavorites.Items.Count >= 5)
            {
                MessageBox.Show("En fazla 5 şarkı favorilere ekleyebilirsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            // Seçili şarkıyı favorilere ekleme
            if (lstAllSongs.SelectedItem != null)
            {
                string selectedSong = lstAllSongs.SelectedItem.ToString();
                if (!lstFavorites.Items.Contains(selectedSong))
                {
                    lstFavorites.Items.Add(selectedSong);
                }
                else
                {
                    MessageBox.Show("Bu şarkı zaten favorilerde!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir şarkı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnRemoveFromFavorites_Click(object sender, EventArgs e)
        {
            {
                // Seçili şarkıyı favorilerden kaldırma
                if (lstFavorites.SelectedItem != null)
                {
                    lstFavorites.Items.Remove(lstFavorites.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Lütfen favorilerden bir şarkı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
       
    }
}
    

