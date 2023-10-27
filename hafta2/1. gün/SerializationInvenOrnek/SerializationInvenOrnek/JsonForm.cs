using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationInvenOrnek
{
    public partial class JsonForm : Form
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "Product1";
            product.ExpireDate = DateTime.Now;
            product.fiyat = 3.14;


            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("products.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
                MessageBox.Show("Serialize Edildİ");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText("products.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product product = (Product)serializer.Deserialize(reader, typeof(Product));
                MessageBox.Show(product.Name);

            }
        }

        private void JsonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
