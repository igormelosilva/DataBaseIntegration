namespace DataBaseIntegration
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            txtValue = new TextBox();
            lblValue = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtId = new TextBox();
            blId = new Label();
            dgvProdutos = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(133, 219);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 23);
            txtValue.TabIndex = 20;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(79, 222);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(35, 15);
            lblValue.TabIndex = 19;
            lblValue.Text = "Value";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(133, 173);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 18;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(61, 176);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 17;
            lblQuantity.Text = "Quantity";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(133, 127);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 16;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(73, 130);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 14;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(75, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // blId
            // 
            blId.AutoSize = true;
            blId.Location = new Point(96, 45);
            blId.Name = "blId";
            blId.Size = new Size(18, 15);
            blId.TabIndex = 11;
            blId.Text = "ID";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(252, 41);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(523, 201);
            dgvProdutos.TabIndex = 22;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(133, 277);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(234, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvProdutos);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Controls.Add(lblValue);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(blId);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtValue;
        private Label lblValue;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtModel;
        private Label lblModel;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtId;
        private Label blId;
        private DataGridView dgvProdutos;
        private Button btnDelete;
        private Button btnUpdate;
    }
}