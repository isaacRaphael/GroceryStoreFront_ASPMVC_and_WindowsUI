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
using Store.Core.Services;

namespace GroceryStoreFrront
{
    public partial class Form2 : Form 
    {
        private readonly IPopulateProductService _populate;
        private readonly ILoginService _loginService;
        private IAddProdToDbService _addProdToDbService1;
        public Form2(IPopulateProductService populate, ILoginService loginService, IAddProdToDbService addProdToDbService)
        {
            _populate = populate;
            _loginService = loginService;
            _addProdToDbService1 = addProdToDbService;
            InitializeComponent();
        }

       

        private void Log_In_Btn_Click(object sender, EventArgs e)
        {
            var userUsername = Username_TextBox.Text.Trim().ToLower();
            var userPassword = Password_TextBox.Text.ToString();
            var checker = _loginService.ValidateLogIn(userUsername,userPassword);
           


            if (checker)
            { 
                Grocery_store f2 = new Grocery_store(new Store.Core.Store(_populate), new User(userUsername), _addProdToDbService1);
                f2.Show();
                ClearFields();
            }   
            else
            {
                ClearFields();
                MessageBox.Show("Invalid Input");
            }
                

        }
        public void ClearFields()
        {
            Username_TextBox.Text = "";
            Password_TextBox.Text = "";
        }

        private void Val_Text_Click(object sender, EventArgs e)
        {

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
        //public static implicit operator Form2(Grocery_store v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
