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
    public partial class FormHistoricoSaida : Form
    {
        public FormHistoricoSaida()
        {
            InitializeComponent();
        }
        SaidaBLL saidaBLL = new SaidaBLL();
        FormaPagamentoBLL formaPagamentoBLL = new FormaPagamentoBLL();
        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopEntradas.Controls.Add(childForm);
            panelDesktopEntradas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FormHistoricoSaida_Load(object sender, EventArgs e)
        {
            DataResponse<Saida> dataResponse = saidaBLL.GetAll();
            for (int i = 0; i < dataResponse.Dados.Count; i++)
            {
                dgvSaidas.Rows.Add();
                dgvSaidas.Rows[i].Cells["SaidaID"].Value = dataResponse.Dados[i].ID;
                dgvSaidas.Rows[i].Cells["SaidaCliente"].Value = clienteBLL.GetByID(dataResponse.Dados[i].ClienteId).Item.Nome;
                dgvSaidas.Rows[i].Cells["SaidaFuncionario"].Value = funcionarioBLL.GetByID(dataResponse.Dados[i].FuncionarioId).Item.Nome;
                dgvSaidas.Rows[i].Cells["SaidaData"].Value = dataResponse.Dados[i].DataSaida;
                dgvSaidas.Rows[i].Cells["SaidaValor"].Value = dataResponse.Dados[i].Valor;
                dgvSaidas.Rows[i].Cells["SaidaFormaPagamento"].Value = formaPagamentoBLL.GetById(dataResponse.Dados[i].FormaPagamento).Item.Nome;
                dgvSaidas.Rows[i].Cells["SaidaValorTotal"].Value = dataResponse.Dados[i].ValorTotal;
                dgvSaidas.Rows[i].Cells["SaidaDesconto"].Value = dataResponse.Dados[i].Desconto;
            }
        }

        private void btnTabelaSaida_Click(object sender, EventArgs e)
        {

        }

        private void btnInformacoesSaida_Click(object sender, EventArgs e)
        {

        }
    }
}