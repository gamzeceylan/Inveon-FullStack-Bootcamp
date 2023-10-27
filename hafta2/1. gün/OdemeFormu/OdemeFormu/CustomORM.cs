using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class CustomORM
    {
        public void Orm()
        {
            string connectionString = @"Data Source=(localdb)\okul;Initial Catalog=TRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            string columnName = "Display_value";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT {columnName} FROM Combobax", connection);
                SqlDataReader reader = command.ExecuteReader();
                // runtime da class ı oluşturmak
                // ama programı kapatıp açmamız gerekiyor. rosalyn kütühanesi ile çözebilirsin.
                while (reader.Read())
                {
                    MyClass myClass = new MyClass();
                    myClass.MyProperty = reader.GetString(0);

                    string x = reader.GetString(0);
                    string fileName = x + ".cs";
                    using (StreamWriter writer = new StreamWriter($"C:/Users/Administrator/Desktop/EntityFrameworkOrnek/OdemeFormu/OdemeFormu/{fileName}"))
                    {
                        writer.WriteLine("using System;");
                        writer.WriteLine("using System.Collections.Generic;");
                        writer.WriteLine("using System.ComponentModel.DataAnnotations;");
                        writer.WriteLine("using System.Linq;");
                        writer.WriteLine("using System.Text;");
                        writer.WriteLine("using System.Threading.Tasks;");
                        writer.WriteLine("namespace OdemeFormu");  //namespace adını düzenlememiz lazım kendi namespacemize göre.
                        writer.WriteLine("{");
                        writer.WriteLine($"public class {x} : IOdemeTipi");
                        writer.WriteLine("{");
                        writer.WriteLine("public string OdemeYap(double tutar)");
                        writer.WriteLine("{");
                        writer.WriteLine($"return tutar + \" {x} ile ödendi\";");
                        writer.WriteLine("}");
                        //writer.WriteLine($"    public string MyProperty = \"{myClass.MyProperty}\";");     --> içine prop eklemek istersek bu yapıyı kullanırız.
                        writer.WriteLine("}");
                        writer.WriteLine("}");
                    }
                }
                reader.Close();
            }
        }


    }

    public class MyClass
    {
        public string MyProperty { get; set; }

    }
}
