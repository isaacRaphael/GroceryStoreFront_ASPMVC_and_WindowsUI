using Store.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GroceryStoreFrront
{
    public partial class Grocery_store : Form
    {
        public  IStore _store;
        public User _user;

        public  int ProdCount { get; set; }
        public Grocery_store(IStore store, User user)
        {   
            InitializeComponent();
            _store = store;
            _user = user;
            ProdCount = 0;
            Product_Count.Text = ProdCount.ToString();
            Prod_Disp_Screen.Text = PrintProds(_store.Products);
            if (_user.UserRole == Role.Manager)
                panel2.Hide();


        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            ProdCount++;
            Product_Count.Text = ProdCount.ToString();
        }

        private void Product_textBox_TextChanged(object sender, EventArgs e)
        {   if (Product_textBox.Text.Length > 8)
            {
                ProdCount = 1;
                Product_Count.Text = ProdCount.ToString();
            }
            
        }

       

        private void Minus_Button_Click(object sender, EventArgs e)
        {   if (ProdCount > 0)
            ProdCount--;
            Product_Count.Text = ProdCount.ToString();
            Print_Status.Text = "";
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            string productId = Product_textBox.Text;
            Product product = _store.GetProduct(productId);
            if (product == null)
                return;

            decimal totalPrice = product.Price * ProdCount;
            Display_screen.Text += $"{product.Name} @ {product.Price} X {ProdCount} = {totalPrice}\n";

            Reset();
        }
        public void Reset()
        {
            ProdCount = 0;
            Product_Count.Text = ProdCount.ToString();
            Product_textBox.Text = "";
        }

        public string  PrintProds(List<Product> e)
        {
            var counter = 1;
            var outputString = "";
            foreach (var item in e)
            {
               outputString +=  counter +". "+"Name: "+item.Name +"\n" + "Id: " + item.Id.ToString() + "\n\n";
                counter++;
            }
            return outputString;
        }
        private void Add_New_Prod_Btn_Click(object sender, EventArgs e)
        {
            if (_user.UserRole == Role.Manager)
            {
                _store.Products.Add(new Product(New_ProdName_TextBox.Text) { Price = Convert.ToDecimal(New_ProdPrice_TextBox.Text) });
                Prod_Disp_Screen.Text = PrintProds(_store.Products);
                New_ProdName_TextBox.Text = "";
                New_ProdPrice_TextBox.Text = "";

            }
            else
            {
                Val2_Label.Text = "Access Denied";
                New_ProdName_TextBox.Text = "";
                New_ProdPrice_TextBox.Text = "";
            }
        }
        private void Grocery_store_Load(object sender, EventArgs e)
        {
            if (_user.UserRole == Role.Manager)
                Status.Text = "Signed in as Manager";
            else
                Status.Text = "Signed in as Staff";
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            FileHandler.PrintFile(Display_screen.Text);
            Display_screen.Text = "";
            Print_Status.Text = "Print Success";


            //Thread.Sleep(300);
            //Print_Status.Text = "";

        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            string prodRemId = RemoveProd_TextBox.Text;
            if (_user.UserRole == Role.Manager)
            {
                _store.DeleteProduct(prodRemId);
                RemoveProd_TextBox.Text = "";
                Prod_Disp_Screen.Text = PrintProds(_store.Products);
            }
            else
            {
                Val2_Label.Text = "Access Denied";
                RemoveProd_TextBox.Text = "";
            }
        }

        private void Available_Prod_Click(object sender, EventArgs e)
        {
            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Product_Count_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void Prod_Disp_Screen_TextChanged(object sender, EventArgs e)
        {

        }

       
      

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void New_ProdName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_ProdPrice_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Val2_Label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void Print_Status_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void RemoveProd_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
