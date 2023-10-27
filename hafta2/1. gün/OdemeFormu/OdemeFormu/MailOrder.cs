using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OdemeFormu
{
public class MailOrder : IOdemeTipi
{
public string OdemeYap(double tutar)
{
return tutar + " MailOrder ile ödendi";
}
}
}
