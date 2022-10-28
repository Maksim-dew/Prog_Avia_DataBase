using System.Data;
using Npgsql;

namespace Avia_2
{
    public partial class Osnova : Form
    {
        bool textBox1Color = true;
        bool textBox2Color = true;
        bool textBox3Color = true;
        bool textBox4Color = true;
        bool textBox5Color = true;
        bool textBox6Color = true;

        int perec = 0;

        public Osnova()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            buttonInsert.Visible = false;
        }

        private void Osnova_Load(object sender, EventArgs e)
        {

        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            nc.Open();
            NpgsqlCommand cmd = nc.CreateCommand();
            cmd.Connection = nc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM public.\"Company\"";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView.DataSource = data;
            nc.Close();

            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            buttonInsert.Visible = true;

            textBox1.Text = "name";
            textBox1.ForeColor = Color.Gray;
            textBox1Color = true;

            perec = 0;


        }

        private void buttonPassenger_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            nc.Open();
            NpgsqlCommand cmd = nc.CreateCommand();
            cmd.Connection = nc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM public.\"Passenger\"";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView.DataSource = data;
            nc.Close();

            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            buttonInsert.Visible = true;

            textBox1.Text = "name";
            textBox1.ForeColor = Color.Gray;
            textBox1Color = true;

            perec = 1;
        }

        private void buttonPIT_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            nc.Open();
            NpgsqlCommand cmd = nc.CreateCommand();
            cmd.Connection = nc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM public.\"Pass_in_trip\"";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView.DataSource = data;
            nc.Close();

            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            buttonInsert.Visible = true;

            textBox1.Text = "trip";
            textBox1.ForeColor = Color.Gray;
            textBox1Color = true;

            textBox2.Text = "passenger";
            textBox2.ForeColor = Color.Gray;
            textBox2Color = true;
            textBox2.Visible = true;

            textBox3.Text = "place";
            textBox3.ForeColor = Color.Gray;
            textBox3Color = true;
            textBox3.Visible = true;

            perec = 2;
        }

        private void buttonTrip_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            nc.Open();
            NpgsqlCommand cmd = nc.CreateCommand();
            cmd.Connection = nc;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM public.\"Trip\"";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);
            dataGridView.DataSource = data;
            nc.Close();

            textBox1.Text = "company";
            textBox1.ForeColor = Color.Gray;
            textBox1Color = true;

            textBox2.Text = "plane";
            textBox2.ForeColor = Color.Gray;
            textBox2Color = true;
            textBox2.Visible = true;

            textBox3.Text = "town_from";
            textBox3.ForeColor = Color.Gray;
            textBox3Color = true;
            textBox3.Visible = true;

            textBox4.Text = "town_to";
            textBox4.ForeColor = Color.Gray;
            textBox4Color = true;
            textBox4.Visible = true;

            textBox5.Text = "time_out";
            textBox5.ForeColor = Color.Gray;
            textBox5Color = true;
            textBox5.Visible = true;

            textBox6.Text = "time_in";
            textBox6.ForeColor = Color.Gray;
            textBox6Color = true;
            textBox6.Visible = true;

            buttonInsert.Visible = true;

            perec = 3;
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {

            switch (perec)
            {
                case 0:
                    String compName = textBox1.Text;

                    string connString = "Host=localhost;Username=postgres;Password=root;Database=Avia";
                    NpgsqlConnection nc = new NpgsqlConnection(connString);
                    nc.Open();

                    string sql = "SELECT * FROM public.\"Company\" WHERE name = '" + compName + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, nc);

                    cmd.CommandText = "INSERT INTO public.\"Company\"(name) VALUES(@nm)";
                    cmd.Parameters.AddWithValue("@nm", compName);
                    cmd.ExecuteNonQuery();
                    nc.Close();
                    break;
                case 1:
                    String passName = textBox1.Text;

                    string connString2 = "Host=localhost;Username=postgres;Password=root;Database=Avia";
                    NpgsqlConnection nc2 = new NpgsqlConnection(connString2);
                    nc2.Open();

                    string sql2 = "SELECT * FROM public.\"Passenger\" WHERE name = '" + passName + "'";
                    NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, nc2);

                    cmd2.CommandText = "INSERT INTO public.\"Passenger\"(name) VALUES(@nm)";
                    cmd2.Parameters.AddWithValue("@nm", passName);
                    cmd2.ExecuteNonQuery();
                    nc2.Close();
                    break;
                case 2:
                    String tripName = textBox1.Text;
                    String pasName = textBox2.Text;
                    String placeName = textBox3.Text;

                    string connString3 = "Host=localhost;Username=postgres;Password=root;Database=Avia";
                    NpgsqlConnection nc3 = new NpgsqlConnection(connString3);
                    nc3.Open();

                    string sql3 = "SELECT * FROM public.\"Pass_in_trip\" WHERE trip = '" + tripName + 
                        "'AND passenger = '" + pasName + 
                        "' AND place = '" + placeName + "'";
                    NpgsqlCommand cmd3 = new NpgsqlCommand(sql3, nc3);

                    cmd3.CommandText = "INSERT INTO public.\"Pass_in_trip\"(trip, passenger, place) VALUES(@tr, @ps, @pl)";
                    cmd3.Parameters.AddWithValue("@tr", tripName);
                    cmd3.Parameters.AddWithValue("@ps", Convert.ToInt32(pasName));
                    cmd3.Parameters.AddWithValue("@pl", placeName);
                    cmd3.ExecuteNonQuery();
                    nc3.Close();
                    break;
                case 3:
                    String comName = textBox1.Text;
                    String planeName = textBox2.Text;
                    String tfromName = textBox3.Text;
                    String ttoname = textBox4.Text;
                    String toutName = textBox5.Text;
                    String tinName = textBox6.Text;

                    string connString4 = "Host=localhost;Username=postgres;Password=root;Database=Avia";
                    NpgsqlConnection nc4 = new NpgsqlConnection(connString4);
                    nc4.Open();

                    string sql4 = "SELECT * FROM public.\"Trip\" WHERE company = '" + comName +
                        "'AND plane = '" + planeName +
                        "'AND town_from = '" + tfromName +
                        "'AND town_to = '" + ttoname +
                        "'AND time_out = '" + toutName +
                        "'AND time_in = '" + tinName + "'";
                    NpgsqlCommand cmd4 = new NpgsqlCommand(sql4, nc4);

                    cmd4.CommandText = "INSERT INTO public.\"Trip\"(company, plane, town_from, town_to, time_out, time_in) " +
                        "VALUES(@com, @plane,@tfrom, @tto, @tout, @tin)";
                    cmd4.Parameters.AddWithValue("@com", Convert.ToInt32(comName));
                    cmd4.Parameters.AddWithValue("@plane", planeName);
                    cmd4.Parameters.AddWithValue("@tfrom", tfromName);
                    cmd4.Parameters.AddWithValue("@tto", ttoname);
                    cmd4.Parameters.AddWithValue("@tout", toutName);
                    cmd4.Parameters.AddWithValue("@tin", tinName);
                    cmd4.ExecuteNonQuery();
                    nc4.Close();
                    break;

            }
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1Color)
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
                textBox1Color = false;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2Color)
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
                textBox2Color = false;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3Color)
            {
                textBox3.Text = null;
                textBox3.ForeColor = Color.Black;
                textBox3Color = false;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4Color)
            {
                textBox4.Text = null;
                textBox4.ForeColor = Color.Black;
                textBox4Color = false;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5Color)
            {
                textBox5.Text = null;
                textBox5.ForeColor = Color.Black;
                textBox5Color = false;
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6Color)
            {
                textBox6.Text = null;
                textBox6.ForeColor = Color.Black;
                textBox6Color = false;
            }
        }

        private void Osnova_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}