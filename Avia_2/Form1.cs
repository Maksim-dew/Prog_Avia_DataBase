using Npgsql;

namespace Avia_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            String loginUser = textLogin.Text;
            String passUser = textPassword.Text;

            string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            try
            {
                //��������� ����������.
                nc.Open();
                MessageBox.Show("������� �����������");
            }
            catch
            {
                MessageBox.Show("�� ������� �����������");
                //��� ��������� ������
            }

            string sql = "SELECT * FROM public.\"User\" WHERE login = '" + loginUser + "' AND password = '" + passUser + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, nc);

            cmd.CommandText = "INSERT INTO public.\"User\"(login, password) VALUES(@lg, @ps)";
            cmd.Parameters.AddWithValue("@lg", loginUser);
            cmd.Parameters.AddWithValue("@ps", passUser);
            cmd.ExecuteNonQuery();
            MessageBox.Show("������� ����������� ");
            nc.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = textLogin.Text;
            String passUser = textPassword.Text; 

            string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            try
            {
                nc.Open();
                MessageBox.Show("������� �����������");
            }
            catch
            {
                MessageBox.Show("�� ������� �����������");
            }

            string sql = "SELECT * FROM public.\"User\" WHERE login = '" + loginUser + "' AND password = '" + passUser + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, nc);
            try
            {
                if (cmd.ExecuteScalar() != null)
                {
                    Osnova osnova = new Osnova();
                    osnova.Show();
                    this.Hide();
                    MessageBox.Show("������� �����������");
                }
                else MessageBox.Show("�� ������� �����������");

            }
            catch { MessageBox.Show("�� ������� �����������"); }
            nc.Close();
          
        }
       
        bool textLoginChange = true;

        private void textLogin_Click(object sender, EventArgs e)
        {

            if (textLoginChange)
            {
                textLogin.Text = null;
                textLogin.ForeColor = Color.Black;
                textLoginChange = false;
            }
        }
        bool textPasswordChange = true;

        private void textPassword_Click(object sender, EventArgs e)
        {
            if (textPasswordChange)
            {
                textPassword.Text = null;
                textPassword.ForeColor = Color.Black;
                textPasswordChange = false;
            }
        }
    }
}