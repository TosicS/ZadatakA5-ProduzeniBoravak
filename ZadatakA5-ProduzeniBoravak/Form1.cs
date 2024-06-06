using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZadatakA5_ProduzeniBoravak
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA5-ProduzeniBoravak\ZadatakA5-ProduzeniBoravak\A5.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        public void prikaziLV()
        {
            string sqlUpit = "SELECT * FROM Aktivnost";
            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                listView1.Items.Clear();

                foreach(DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    item.SubItems.Add(row[1].ToString());
                    item.SubItems.Add(row[2].ToString());
                    item.SubItems.Add(row[3].ToString());
                    item.SubItems.Add(row[4].ToString());
                    /*
                    item.SubItems.Add(DateTime.Parse(red[3].ToString()).ToString ("hh:mm"));
                    item.SubItems.Add(DateTime.Parse(red[4].ToString()).ToString("hh:mm"));
                     */
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void popuniCB()
        {
            string sqlUpit = "SELECT  DISTINCT(Dan) as dan FROM Aktivnost";
            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                comboBoxDan.DataSource = dt;
                comboBoxDan.DisplayMember = "dan";
                comboBoxDan.ValueMember = "dan";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearControls()
        {
            textBoxSifra.Text = "";
            textBoxNaziv.Text = "";
            comboBoxDan.SelectedIndex = -1;
            textBoxVremePocetka.Text = "";
            textBoxVremeZavrsetak.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prikaziLV();
            popuniCB();
            comboBoxDan.SelectedIndex = -1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                return;
            }

            textBoxSifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxNaziv.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxDan.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxVremePocetka.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxVremeZavrsetak.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Statistika form = new Statistika();
            form.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            OAplikaciji form = new OAplikaciji();
            form.Show();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            object dan = DBNull.Value, pocetak = DBNull.Value, zavrsetak = DBNull.Value;

            if (textBoxSifra.Text == "" || textBoxNaziv.Text == "")
            {
                MessageBox.Show("Sifra i naziv moraju biti uneseni", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sifra = int.Parse(textBoxSifra.Text);
            if (textBoxVremePocetka.Text != "")
            {
                pocetak = DateTime.ParseExact(textBoxVremePocetka.Text, "HH:mm", null);

            }
            if (textBoxVremeZavrsetak.Text != "")
            {
                zavrsetak = DateTime.ParseExact(textBoxVremeZavrsetak.Text, "HH:mm", null);

            }
            if (comboBoxDan.Text != "")
            {
                dan = comboBoxDan.Text;
            }

            SqlCommand komanda = new SqlCommand("INSERT INTO Aktivnost(AktivnostID, NazivAktivnosti, Dan, Pocetak,Zavrsetak) VALUES(@AktivnostID, @NazivAktivnosti, @Dan, @Pocetak,@Zavrsetak)", konekcija);
            komanda.Parameters.AddWithValue("@AktivnostID", sifra);
            komanda.Parameters.AddWithValue("@NazivAktivnosti", textBoxNaziv.Text);
            komanda.Parameters.AddWithValue("@Dan", dan);
            komanda.Parameters.AddWithValue("@Pocetak", pocetak);
            komanda.Parameters.AddWithValue("@Zavrsetak", zavrsetak);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                prikaziLV();
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                konekcija.Close();
            }
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
