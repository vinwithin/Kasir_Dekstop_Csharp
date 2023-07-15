using MySql.Data.MySqlClient;
using System.Data;

namespace Kasir
{
    public partial class Form_login : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter adapter;
        private MySqlDataReader reader;

        KoneksiDB konn = new KoneksiDB();
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            MySqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new MySqlCommand("Select * from kasir where Email='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    FormMenuUtama FrmUtama = new FormMenuUtama();
                    FrmUtama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email dan Password Salah");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}