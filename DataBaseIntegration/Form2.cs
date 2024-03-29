﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseIntegration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CountProducts();
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.name = txtName.Text;
            product.model = txtModel.Text;
            product.quantity = Convert.ToInt32(txtQuantity.Text);
            product.value = float.Parse(txtValue.Text);

            bool response = product.Add(product);

            if (!response)
                MessageBox.Show("Erro ao tentar gravar o produto");
            else
            {
                CountProducts();
                ClearForm();
                LoadProducts();
            }

        }
        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtModel.Clear();
            txtQuantity.Clear();
            txtValue.Clear();

            txtName.Focus();
        }

        private void LoadProducts()
        {
            Product product = new Product();
            dgvProdutos.DataSource = product.GetAll();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Product product = new Product();
                int id = Convert.ToInt32(dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value);

                product = product.Get(id);

                txtId.Text = product.id.ToString();
                txtName.Text = product.name.ToString();
                txtModel.Text = product.model.ToString();
                txtQuantity.Text = product.quantity.ToString();
                txtValue.Text = product.value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao tentar carregar os dados do produto");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma excluir", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Product product = new Product();
                    int id = Convert.ToInt32(txtId.Text);
                    bool response = product.Delete(id);

                    if (!response)
                    {
                        MessageBox.Show("Erro ao tentar excluir");
                    }
                    else
                    {
                        CountProducts();
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma alterar", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)

                {
                    Product product = new Product();

                    product.id = Convert.ToInt32(txtId.Text);
                    product.name = txtName.Text;
                    product.model = txtModel.Text;
                    product.quantity = Convert.ToInt32(txtQuantity.Text);
                    product.value = float.Parse(txtValue.Text);

                    bool response = product.Update(product);

                    if (!response)
                    {
                        MessageBox.Show("Erro ao tentar alterar");
                    }
                    else
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void CountProducts()
        {
            Product product = new Product();
            lblCount.Text = product.Count().ToString();
        }
    }
}
