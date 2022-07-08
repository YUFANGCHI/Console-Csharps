using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    partial class MyFirstClass
    {
        public void Method06()
        {
            MessageBox.Show("Method06 Partial Class");
        }
    }

    public class Member
    {
        public string Name = "";
        public int Age;

        public static string StaticGlobal = "static";
    }

    public class UseStatic
    {
        public int InstanceCount;
        public static int StaticCount;
    }

    public enum UserRole : byte
    {
        Admin  ,
        User = 2 ,
        User2
    }

    public struct Product
    {
        //public string ProductName;
        //public decimal ProductPrice;

        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }


        public Product(string Name , decimal Price)
        {
            ProductName = Name;
            ProductPrice = Price;
            //a = 100;
        }


    }

    public struct Employee
    {
        public string Name;
        public int Age;
    }


}
