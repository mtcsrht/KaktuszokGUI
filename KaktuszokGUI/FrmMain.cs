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
                dgvCactus.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }

        }
    }
}
