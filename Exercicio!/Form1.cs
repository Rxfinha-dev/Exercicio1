using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (cboTodos.SelectedItem.ToString() == "SP" ||
                cboTodos.SelectedItem.ToString() == "RJ" ||
                cboTodos.SelectedItem.ToString() == "MG" ||
                cboTodos.SelectedItem.ToString() == "ES")
            {

            }
            if (cboTodos.SelectedItem.ToString() == "PR" ||
                cboTodos.SelectedItem.ToString() == "RS" ||
                cboTodos.SelectedItem.ToString() == "SC")
            {

            }
            if (cboTodos.SelectedItem.ToString() == "MT" ||
                cboTodos.SelectedItem.ToString() == "MS" ||
                cboTodos.SelectedItem.ToString() == "GO" ||
                cboTodos.SelectedItem.ToString() == "DF")
            {

            }
            if (cboTodos.SelectedItem.ToString() == "BA" ||
               cboTodos.SelectedItem.ToString() == "SE" ||
               cboTodos.SelectedItem.ToString() == "AL" ||
               cboTodos.SelectedItem.ToString() == "PE" ||
               cboTodos.SelectedItem.ToString() == "PB" ||
               cboTodos.SelectedItem.ToString() == "RN" ||
               cboTodos.SelectedItem.ToString() == "CE" ||
               cboTodos.SelectedItem.ToString() == "PI" ||
               cboTodos.SelectedItem.ToString() == "MA")
            {

            }
            if (cboTodos.SelectedItem.ToString() == "AM" ||
               cboTodos.SelectedItem.ToString() == "RR" ||
               cboTodos.SelectedItem.ToString() == "AP" ||
               cboTodos.SelectedItem.ToString() == "PA" ||
               cboTodos.SelectedItem.ToString() == "TO" ||
               cboTodos.SelectedItem.ToString() == "RO" ||
               cboTodos.SelectedItem.ToString() == "AC")
            {

            }





        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
