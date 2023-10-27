
using System.Data;
using System.Data.SqlClient;

namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi = "";
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\okul;Initial Catalog=TRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void button1_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(tbxTutar.Text);
            OdemeIslemiFactory odemeIslemi = new OdemeIslemiFactory();
            IOdemeTipi odemetipi = odemeIslemi.GetInstance(secilenOdemeTipi);
            OdemeIslemi odemeIslem = new OdemeIslemi(odemetipi);
            lblSonuc.Text = odemeIslem.Ode(tutar);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from Combobax", sqlConnection);


            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                cmbOdeme.DisplayMember = "Display_member";
                cmbOdeme.ValueMember = "Display_value";
                cmbOdeme.DataSource = dataTable;
            }

            //while (read.Read())
            //{
            //    cmbOdeme.ValueMember = (string)read["Display_member"];
            //    //cmbOdeme.DisplayMember = (string)read["Display_member"];
            //    cmbOdeme.Items.Add(read["Display_value"]);
            //}
            sqlConnection.Close();

            CustomORM customORM = new CustomORM();
            customORM.Orm();
            

        }
        private void cmbOdeme_SelectedIndexChanged(object sender, EventArgs e)
        {


            secilenOdemeTipi = cmbOdeme.SelectedValue as string;
        }

        private void lblOdemeTipi_Click(object sender, EventArgs e)
        {

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {
        }

        private void tbxTutar_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblTutar_Click(object sender, EventArgs e)
        {
        }


    }
}