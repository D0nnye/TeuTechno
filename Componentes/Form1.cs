using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string frutas = "";

            operador = int.Parse(txtSelecione.Text);

            switch (operador)
            {
                case 1: frutas = "Banana";
                    break;

                case 2:
                    frutas = "Maçã";
                    break;

                case 3:
                    frutas = "Pêra";
                    break;

                case 4:
                    frutas = "Melancia";
                    break;

                default: frutas = "Nenhum fruta selecionada.";
                    break;
            }
            txtFrutasselecionada1.Text = frutas;
            txtFrutasselecionada1.Text = "";
            txtFrutasselecionada1.Focus();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        public void limparCampos()
            {
            txtFrutasselecionada1.Clear();
            ltbFrutas.Items.Clear();
            cbbFrutaslistadas.Items.Clear();
            txtSelecione.Text = "";
            txtSelecione.Focus();
            cbbFrutaslistadas.Text = "";
            }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            cbbFrutaslistadas.Items.Clear();
            ltbFrutas.Items.Add(txtFrutasselecionada1.Text);
            cbbFrutaslistadas.Items.Add(txtFrutasselecionada1.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Deseja sair?", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button3);
            if (res == DialogResult.Yes)
            {
               Application.Exit();
            }
            else
            {
                limparCampos();
            }
        }

        private void txtSelecione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.Focus();
            }
        }
    }
}
