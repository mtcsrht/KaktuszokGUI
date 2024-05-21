using MySql.Data.MySqlClient;

namespace KaktuszokGUI
{
    public partial class FrmMain : Form
    {
        private string connString = "server=localhost;user=root;password=;database=dolgozat002";

        public FrmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;
            dgvCactus.CellClick += DgvCactus_CellClick;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvCactus.SelectedCells.Count > 0)
            {
                var valasz = MessageBox.Show("Biztos szeretnéd-e törölni?", "Törlés?", MessageBoxButtons.YesNo);
                if (valasz == DialogResult.Yes)
                {
                    using MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    string id = dgvCactus.SelectedRows[0].Cells[0].Value.ToString();
                    using MySqlCommand cmd = new MySqlCommand($"DELETE FROM kaktuszok WHERE id LIKE {id}", conn);
                    cmd.ExecuteNonQuery();
                    dgvCactus.Rows.Clear();
                    InitDgv();
                }

            }

        }

        private void DgvCactus_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            string id = dgvCactus.SelectedRows[0].Cells[0].Value.ToString();
            using MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using MySqlCommand cmd = new MySqlCommand($"SELECT tudomanyos_nev FROM kaktuszok WHERE id LIKE {id}", conn);
            var resp = cmd.ExecuteReader();
            string tudomanynev = "";
            while (resp.Read())
            {
                tudomanynev = resp.GetValue(0).ToString();
            }
            MessageBox.Show($"{tudomanynev}");
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {
            InitDgv();
        }

        private void InitDgv()
        {
            using MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using MySqlCommand cmd = new MySqlCommand("SELECT id,koznapi_nev,vizigeny,fenyigeny FROM kaktuszok", conn);

            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dgvCactus.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
            }

        }
    }
}
