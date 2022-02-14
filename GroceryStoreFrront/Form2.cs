using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Core;

namespace GroceryStoreFrront
{
    public partial class Form2 : Form 
    {

        public Form2()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_In_Btn_Click(object sender, EventArgs e)
        {
            string ManagerPass = "access1";
            string staffPass = "access2";


            if (Username_TextBox.Text.ToLower() == "admin" && Password_TextBox.Text.ToString() == ManagerPass)
            {
                
                Grocery_store f2 = new Grocery_store(new Store.Core.Store(), new User("m"));
                f2.Show();
                Username_TextBox.Text = "";
                Password_TextBox.Text = "";
            }
               
            //Application.Run(new Grocery_store(new Store.Core.Store(), new User("m")));
            else if (Username_TextBox.Text.ToLower() == "admin" && Password_TextBox.Text.ToString() == staffPass)
            {
                
                Grocery_store f3 = new Grocery_store(new Store.Core.Store(), new User("f"));
                f3.Show();
                Username_TextBox.Text = "";
                Password_TextBox.Text = "";
            }
               
            else
            {
                Username_TextBox.Text = "";
                Password_TextBox.Text = "";
                Val_Text.Text = "Invalid Input";

            }
                

        }

        private void Val_Text_Click(object sender, EventArgs e)
        {

        }

        //public static implicit operator Form2(Grocery_store v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
