using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginOO
{
    public partial class Form1 : Form
    {
        public Usuario Usuario { get; set; }
        public Form1()
        {
            InitializeComponent();
            Usuario = new Usuario();
            Usuario.Id = 123;
            Usuario.Login = "admin";
            Usuario.Password = "admin";
            Usuario.Nome = "Administrador";
            Usuario.Nascimento = new DateTime(1990,12,01);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var pass = textBox2.Text;

            if (Usuario.Login.Equals(login) && Usuario.Password.Equals(pass))
            {
                MessageBox.Show("Login Liberado");
            }
            
        }
    }
}
