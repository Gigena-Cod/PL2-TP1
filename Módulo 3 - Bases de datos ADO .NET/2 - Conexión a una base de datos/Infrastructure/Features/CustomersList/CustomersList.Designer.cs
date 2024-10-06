namespace Infrastructure.Features
{
    partial class CustomersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersList));
            dataGridViewCustomers = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnEmail, ColumnName, ColumnLastName });
            dataGridViewCustomers.Location = new Point(12, 101);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.Size = new Size(540, 337);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            // 
            // ColumnEmail
            // 
            ColumnEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnName.HeaderText = "Nombre";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnLastName
            // 
            ColumnLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLastName.HeaderText = "Apellido";
            ColumnLastName.Name = "ColumnLastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.MaximumSize = new Size(550, 0);
            label2.Name = "label2";
            label2.Size = new Size(540, 45);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // CustomersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(label2);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomersList";
            Text = "Listado de clientes";
            Load += CustomersList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
    }
}