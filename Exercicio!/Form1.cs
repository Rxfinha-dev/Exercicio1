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
                cboSudeste.Items.Add(cboTodos.SelectedItem.ToString());
                cboTodos.Items.Remove(cboTodos.SelectedItem.ToString());
            }
            else if (cboTodos.SelectedItem.ToString() == "PR" ||
                cboTodos.SelectedItem.ToString() == "RS" ||
                cboTodos.SelectedItem.ToString() == "SC")
            {
                cboSul.Items.Add(cboTodos.SelectedItem.ToString());
                cboTodos.Items.Remove(cboTodos.SelectedItem.ToString());
            }
            else if (cboTodos.SelectedItem.ToString() == "MT" ||
                cboTodos.SelectedItem.ToString() == "MS" ||
                cboTodos.SelectedItem.ToString() == "GO" ||
                cboTodos.SelectedItem.ToString() == "DF")
            {
                cboCentroOeste.Items.Add(cboTodos.SelectedItem.ToString());
                cboTodos.Items.Remove(cboTodos.SelectedItem.ToString());
            }
            else if (cboTodos.SelectedItem.ToString() == "BA" ||
               cboTodos.SelectedItem.ToString() == "SE" ||
               cboTodos.SelectedItem.ToString() == "AL" ||
               cboTodos.SelectedItem.ToString() == "PE" ||
               cboTodos.SelectedItem.ToString() == "PB" ||
               cboTodos.SelectedItem.ToString() == "RN" ||
               cboTodos.SelectedItem.ToString() == "CE" ||
               cboTodos.SelectedItem.ToString() == "PI" ||
               cboTodos.SelectedItem.ToString() == "MA")
            {
                cboNordeste.Items.Add(cboTodos.SelectedItem.ToString());
                cboTodos.Items.Remove(cboTodos.SelectedItem.ToString());
            }
            else if (cboTodos.SelectedItem.ToString() == "AM" ||
               cboTodos.SelectedItem.ToString() == "RR" ||
               cboTodos.SelectedItem.ToString() == "AP" ||
               cboTodos.SelectedItem.ToString() == "PA" ||
               cboTodos.SelectedItem.ToString() == "TO" ||
               cboTodos.SelectedItem.ToString() == "RO" ||
               cboTodos.SelectedItem.ToString() == "AC")
            {
                cboNorte.Items.Add(cboTodos.SelectedItem.ToString());
                cboTodos.Items.Remove(cboTodos.SelectedItem.ToString());
            }



            lblTeste.Text = cboTodos.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();


        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            cboTodos.Items.Add(cboNorte.SelectedItem.ToString());
            cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
            lblTeste.Text = cboTodos.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            cboTodos.Items.Add(cboNordeste.SelectedItem.ToString());
            cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());

            lblTeste.Text = cboTodos.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
        }

        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            cboTodos.Items.Add(cboCentroOeste.SelectedItem.ToString());
            cboCentroOeste.Items.Remove(cboCentroOeste.SelectedItem.ToString());

            lblTeste.Text = cboTodos.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
        }

        private void BtnSudeste_Click(object sender, EventArgs e)
        {
            cboTodos.Items.Add(cboSudeste.SelectedItem.ToString());
            cboSudeste.Items.Remove(cboSudeste.SelectedItem.ToString());

            lblTeste.Text = cboTodos.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            cboTodos.Items.Add(cboSul.SelectedItem.ToString());
            cboSul.Items.Remove(cboSul.SelectedItem.ToString());

            lblTeste.Text = cboTodos.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            lblCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
        }
    }
}
