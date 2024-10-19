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
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnDebt = new DataGridViewTextBoxColumn();
            label2 = new Label();
            labelTotalCustomers = new Label();
            labelTotalDebts = new Label();
            labelAverageDebts = new Label();
            buttonGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnName, ColumnLastName, ColumnEmail, ColumnDebt });
            dataGridViewCustomers.Location = new Point(12, 144);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.Size = new Size(540, 337);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnId.FillWeight = 225.3807F;
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 30;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnName.FillWeight = 58.2064323F;
            ColumnName.HeaderText = "Nombre";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnLastName
            // 
            ColumnLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnLastName.FillWeight = 58.2064323F;
            ColumnLastName.HeaderText = "Apellido";
            ColumnLastName.Name = "ColumnLastName";
            // 
            // ColumnEmail
            // 
            ColumnEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnEmail.FillWeight = 58.2064323F;
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnDebt
            // 
            ColumnDebt.HeaderText = "Deuda";
            ColumnDebt.Name = "ColumnDebt";
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
            // labelTotalCustomers
            // 
            labelTotalCustomers.AutoSize = true;
            labelTotalCustomers.Location = new Point(12, 106);
            labelTotalCustomers.MaximumSize = new Size(550, 0);
            labelTotalCustomers.Name = "labelTotalCustomers";
            labelTotalCustomers.Size = new Size(58, 15);
            labelTotalCustomers.TabIndex = 3;
            labelTotalCustomers.Text = "0 Clientes";
            // 
            // labelTotalDebts
            // 
            labelTotalDebts.AutoSize = true;
            labelTotalDebts.Location = new Point(105, 106);
            labelTotalDebts.MaximumSize = new Size(550, 0);
            labelTotalDebts.Name = "labelTotalDebts";
            labelTotalDebts.Size = new Size(87, 15);
            labelTotalDebts.TabIndex = 4;
            labelTotalDebts.Text = "Total de deuda:";
            // 
            // labelAverageDebts
            // 
            labelAverageDebts.AutoSize = true;
            labelAverageDebts.Location = new Point(248, 106);
            labelAverageDebts.MaximumSize = new Size(550, 0);
            labelAverageDebts.Name = "labelAverageDebts";
            labelAverageDebts.Size = new Size(114, 15);
            labelAverageDebts.TabIndex = 5;
            labelAverageDebts.Text = "Promedio de deuda:";
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(441, 88);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(111, 33);
            buttonGenerateReport.TabIndex = 6;
            buttonGenerateReport.Text = "Generar reporte";
            buttonGenerateReport.UseVisualStyleBackColor = true;
            buttonGenerateReport.Click += buttonGenerateReport_Click;
            // 
            // CustomersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 493);
            Controls.Add(buttonGenerateReport);
            Controls.Add(labelAverageDebts);
            Controls.Add(labelTotalDebts);
            Controls.Add(labelTotalCustomers);
            Controls.Add(label2);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomersList";
            StartPosition = FormStartPosition.CenterScreen;
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
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnDebt;
        private Label labelTotalCustomers;
        private Label labelTotalDebts;
        private Label labelAverageDebts;
        private Button buttonGenerateReport;
    }
}