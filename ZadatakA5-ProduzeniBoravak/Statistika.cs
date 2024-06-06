using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZadatakA5_ProduzeniBoravak
{
    public partial class Statistika : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA5-ProduzeniBoravak\ZadatakA5-ProduzeniBoravak\A5.mdf;Integrated Security=True;");

        public Statistika()
        {
            InitializeComponent();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrikaziF2_Click(object sender, EventArgs e)
        {
            string sqlUpit = "SELECT Aktivnost.Dan as Dan, (COUNT(Registar_Aktivnosti.DeteID) - COUNT (CASE WHEN Registar_Aktivnosti.Prisustvo = 0 THEN 1 ELSE NULL END)) AS 'Broj dece' " +
                "from Aktivnost " +
                "inner join Registar_Aktivnosti on Registar_Aktivnosti.AktivnostID = Aktivnost.AktivnostID " +
                "group by Dan order by Dan";
            SqlCommand cmd = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                chart1.DataSource = dt;
                chart1.Series[0].XValueMember = "Dan";
                chart1.Series[0].YValueMembers = "Broj dece";
                chart1.Series[0].IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
