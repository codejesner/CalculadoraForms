﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI;

namespace CalculadoraForms
{
    public partial class App : Form
    {
        bool Operador = true;
        int Calculo;
        public App()
        {
            InitializeComponent();
        }
        private void txtTela_TextChanged(object sender, EventArgs e)
        {
            if (txtTela.Text.Length > 5)
            {
                txtTela.Font = new Font(txtTela.Font.FontFamily, 17);
            }
        }
        private void numero_Click(object sender, EventArgs e)
        {
            var btnNumeroClicado = sender as Button;
            txtTela.Text += btnNumeroClicado.Text;
            Operador = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            var btnOperadorClicado = sender as Button;
            if (!Operador)
            {
                txtTela.Text += btnOperadorClicado.Text;
                Operador = true;
            }
        }
        private void apagar_Click(object sender, EventArgs e)
        {
            if (txtTela.Text.Length <= 0 )
            {
                MessageBox.Show("Existe valores a serem apagos!");
            } 
            else
            {
                txtTela.Text = txtTela.Text.Remove(txtTela.Text.Length - 1);
            }
        }
        private void limpar_Click(object sender, EventArgs e)
        {
            txtTela.Clear();
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            string expressao = txtTela.Text;

            for (int i = 0; i < expressao.Length; i++)
            {
                Calculo = expressao[i];
            }

            txtTela.Text = Calculo.ToString();



        }
    }
}