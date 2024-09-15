namespace Infrastructure.Features
{
    partial class ListArticles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListArticles));
            label1 = new Label();
            label2 = new Label();
            comboBoxCategories = new ComboBox();
            dataGridViewArticles = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnAmountStock = new DataGridViewTextBoxColumn();
            buttonExportArticles = new Button();
            labelResults = new Label();
            label3 = new Label();
            labelTotalAmounts = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.MaximumSize = new Size(600, 0);
            label1.Name = "label1";
            label1.Size = new Size(580, 45);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Rubro";
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(22, 121);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(186, 23);
            comboBoxCategories.TabIndex = 2;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
            // 
            // dataGridViewArticles
            // 
            dataGridViewArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArticles.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnDescription, ColumnPrice, ColumnStock, ColumnAmountStock });
            dataGridViewArticles.Location = new Point(24, 171);
            dataGridViewArticles.Name = "dataGridViewArticles";
            dataGridViewArticles.Size = new Size(579, 291);
            dataGridViewArticles.TabIndex = 3;
            // 
            // ColumnCode
            // 
            ColumnCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCode.FillWeight = 24.5901623F;
            ColumnCode.HeaderText = "Código";
            ColumnCode.Name = "ColumnCode";
            // 
            // ColumnDescription
            // 
            ColumnDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDescription.FillWeight = 24.5901623F;
            ColumnDescription.HeaderText = "Descripción";
            ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnPrice
            // 
            ColumnPrice.HeaderText = "Costo";
            ColumnPrice.Name = "ColumnPrice";
            ColumnPrice.Width = 80;
            // 
            // ColumnStock
            // 
            ColumnStock.HeaderText = "Stock";
            ColumnStock.Name = "ColumnStock";
            ColumnStock.Width = 56;
            // 
            // ColumnAmountStock
            // 
            ColumnAmountStock.FillWeight = 250.819672F;
            ColumnAmountStock.HeaderText = "Valor en Stock";
            ColumnAmountStock.Name = "ColumnAmountStock";
            ColumnAmountStock.Width = 80;
            // 
            // buttonExportArticles
            // 
            buttonExportArticles.Location = new Point(493, 121);
            buttonExportArticles.Name = "buttonExportArticles";
            buttonExportArticles.Size = new Size(108, 28);
            buttonExportArticles.TabIndex = 4;
            buttonExportArticles.Text = "Exportar articulos";
            buttonExportArticles.UseVisualStyleBackColor = true;
            buttonExportArticles.Click += buttonExportArticles_Click;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new Point(223, 124);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(0, 15);
            labelResults.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 478);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "Total:";
            // 
            // labelTotalAmounts
            // 
            labelTotalAmounts.AutoSize = true;
            labelTotalAmounts.Location = new Point(531, 478);
            labelTotalAmounts.Name = "labelTotalAmounts";
            labelTotalAmounts.Size = new Size(0, 15);
            labelTotalAmounts.TabIndex = 8;
            // 
            // ListArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 524);
            Controls.Add(labelTotalAmounts);
            Controls.Add(label3);
            Controls.Add(labelResults);
            Controls.Add(buttonExportArticles);
            Controls.Add(dataGridViewArticles);
            Controls.Add(comboBoxCategories);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ListArticles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Artículos por Rubro";
            Load += ListArticles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxCategories;
        private DataGridView dataGridViewArticles;
        private Button buttonExportArticles;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnAmountStock;
        private Label labelResults;
        private Label label3;
        private Label labelTotalAmounts;
    }
}