using System.Data;
using System.Data.SqlClient;
namespace OdemeFormApp
{
    public partial class Form1 : Form
    {
        public string tur = "";
        private OdemeIslemi odemeIslemi;
        private IOdemeTipi odemeTipi;

        //sql windows authentication 
        SqlConnection conn2 = new SqlConnection(@"Data Source=(localdb)\inveon;Initial Catalog=InveonDB;Integrated Security=True;Connect Timeout=30;Encrypt=False");

  
        public Form1()
        {
            InitializeComponent();

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            //convert, casting 
            if (txtTutar.Text.Trim().Length == 0)
            {
                MessageBox.Show("lütfen tutar yazýnýz...");
            }
            else
            {
                double tutar = Convert.ToDouble(txtTutar.Text);


                //if (tur == "Kredi Kartý")
                //{
                //    KrediKarti krediKarti = new KrediKarti();
                //    odemeIslemi = new OdemeIslemi(krediKarti);
                //    lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
                //}

                //else if (tur == "Mail Order")
                //{
                //    MailOrder mailOrder = new MailOrder();
                //    odemeIslemi = new OdemeIslemi(mailOrder);
                //    lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
                //}

                //else if (tur == "Sms Ödeme")
                //{
                //    SmsOdeme smsOdeme = new SmsOdeme();
                //    odemeIslemi = new OdemeIslemi(smsOdeme);
                //    lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
                //}

                OdemeIslemiFactory factory = new OdemeIslemiFactory();
                odemeTipi = factory.GetInstance(tur);
                odemeIslemi = new OdemeIslemi(odemeTipi);
                lblSonuc.Text = odemeIslemi.OdemeYap(tutar);



            }


        }

        private void cmbOdemeYontemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            tur = cmbOdemeYontemleri.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn2.Open();
            SqlCommand command = new SqlCommand("select * from OdemeYontemleri", conn2); // komutu yazıyoruz
            SqlDataReader reader = command.ExecuteReader();  // reader içine direkt kayıtlar gelir.bu metod execute butonuna basmışsın gibi davranır
            //while(reader.Read()) { }
            DataTable dt = new DataTable(); 
            dt.Load(reader);
            cmbOdemeYontemleri.DataSource = dt;
            cmbOdemeYontemleri.DisplayMember = "Display_member";
            cmbOdemeYontemleri.ValueMember = "Display_value";
            reader.Close();
            conn2.Close();


        }
    }
}