﻿using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormCadastroProduto : Form
    {
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        TipoUnidadeBLL tipoUnidadeBLL = new TipoUnidadeBLL();
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ProdutorBLL produtorBLL = new ProdutorBLL();
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            int laboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue);
            double Valor = (double)nudValor.Value;
            int unidade = Convert.ToInt32(cmbUnidade.SelectedValue);
            Produto produto = new Produto(nome, descricao, laboratorio, unidade, Valor);
            Response response = produtorBLL.Insert(produto);
            MessageBox.Show(response.Message);
        }

        private void btnCadastrarLaboratorio_Click(object sender, EventArgs e)
        {
            FormCadastroLaboratorio formCadastroLaboratorio = new FormCadastroLaboratorio();
            formCadastroLaboratorio.ShowDialog();
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            cmbLaboratorio.DataSource = laboratorioBLL.GetAll().Dados;
            cmbLaboratorio.DisplayMember = "Nome";
            cmbLaboratorio.ValueMember = "ID";
            cmbUnidade.DataSource = tipoUnidadeBLL.GetAll().Dados;
            cmbUnidade.DisplayMember = "Nome";
            cmbUnidade.ValueMember = "ID";
        }

    }
}
