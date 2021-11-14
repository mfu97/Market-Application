using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataTable satis_tablo = new DataTable();
        public int aranan_r = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            tablo.Columns.Add("BARCODE", typeof(int));
            tablo.Columns.Add("BRAND", typeof(string));
            tablo.Columns.Add("PRICE ($)", typeof(int));
            tablo.Columns.Add("PRODUCT NAME", typeof(string));
            tablo.Columns.Add("PIECE", typeof(int));

            satis_tablo.Columns.Add("BARCODE", typeof(string));
            satis_tablo.Columns.Add("BRAND", typeof(string));
            satis_tablo.Columns.Add("PRICE ($)", typeof(string));
            satis_tablo.Columns.Add("PIECE", typeof(string));
            satis_tablo.Columns.Add("TOTAL ($)", typeof(string));

            dataGridView1.DataSource = tablo;
            tablo.Rows.Add("147258", "PEPSİ","8", "COKE 1LT", "19");
            tablo.Rows.Add("236584", "ÜLKER", "2", "CHOCLATE BAR", "18");
            tablo.Rows.Add("135789", "ETİ", "3", "BISCUIT", "11");
            tablo.Rows.Add("142653", "LAYS", "9", "CRISPS 125GR", "16");
            tablo.Rows.Add("128467", "ALPELLA", "3", "CHOCLATE MILK", "17");
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aranan = urun_adi_satis.Text.Trim().ToUpper();

            

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                aranan_r = i;                                
                            }
                        }
                    }                    
                }                
            }
            barkod_satıs.Text = dataGridView1.Rows[aranan_r].Cells[0].Value.ToString();
            satıs_fiyat.Text = dataGridView1.Rows[aranan_r].Cells[2].Value.ToString();
            kalan_adet.Text = dataGridView1.Rows[aranan_r].Cells[4].Value.ToString();

        }

        private void satıs_btn_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = satis_tablo;
            double para = Convert.ToDouble(satıs_fiyat.Text) * Convert.ToDouble(satıs_adet.Text);
            satis_tablo.Rows.Add(barkod_satıs.Text, urun_adi_satis.Text, satıs_fiyat.Text, satıs_adet.Text, para);

            int stok = Convert.ToInt16(kalan_adet.Text) - Convert.ToInt16(satıs_adet.Text);
            kalan_adet.Text = Convert.ToString(stok);


            dataGridView1.Rows[aranan_r].Cells[4].Value = stok;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string urun_adi = urun_adi_satis.SelectedItem.ToString();
            

        }

        
    }
}
