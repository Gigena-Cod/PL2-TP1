namespace Infrastructure.Features
{
    partial class ViewCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomers));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnDebts = new DataGridViewTextBoxColumn();
            ColumnLimitCredits = new DataGridViewTextBoxColumn();
            ColumnProvince = new DataGridViewTextBoxColumn();
            buttonGenerateReport = new Button();
            labelCountCustomers = new Label();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(610, 43);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLastName, ColumnDebts, ColumnLimitCredits, ColumnProvince });
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(588, 261);
            dataGridView1.TabIndex = 1;
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
            // ColumnDebts
            // 
            ColumnDebts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDebts.HeaderText = "Deuda";
            ColumnDebts.Name = "ColumnDebts";
            // 
            // ColumnLimitCredits
            // 
            ColumnLimitCredits.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLimitCredits.HeaderText = "Limite crediticio";
            ColumnLimitCredits.Name = "ColumnLimitCredits";
            // 
            // ColumnProvince
            // 
            ColumnProvince.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnProvince.HeaderText = "Provincia";
            ColumnProvince.Name = "ColumnProvince";
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(485, 67);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(115, 30);
            buttonGenerateReport.TabIndex = 2;
            buttonGenerateReport.Text = "Generar reporte";
            buttonGenerateReport.UseVisualStyleBackColor = true;
            // 
            // labelCountCustomers
            // 
            labelCountCustomers.AutoSize = true;
            labelCountCustomers.Location = new Point(20, 73);
            labelCountCustomers.Name = "labelCountCustomers";
            labelCountCustomers.Size = new Size(38, 15);
            labelCountCustomers.TabIndex = 3;
            labelCountCustomers.Text = "label2";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 408);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(115, 30);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Cancelar";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(buttonClose);
            Controls.Add(labelCountCustomers);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ViewCustomers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clientes";
            Load += ViewCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnDebts;
        private DataGridViewTextBoxColumn ColumnLimitCredits;
        private DataGridViewTextBoxColumn ColumnProvince;
        private Button buttonGenerateReport;
        private Label labelCountCustomers;
        private Button buttonClose;
    }
}