namespace Trabajo_Práctico_1.Feature.ListSellers
{
    partial class ListSellers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSellers));
            label1 = new Label();
            comboBoxField = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxSortBy = new ComboBox();
            dataGridViewSellers = new DataGridView();
            labelResuelt = new Label();
            labelSalary = new Label();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnSalary = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSellers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.MaximumSize = new Size(500, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 45);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // comboBoxField
            // 
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Items.AddRange(new object[] { "Codigo", "Nombre", "Salario" });
            comboBoxField.Location = new Point(12, 105);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(176, 23);
            comboBoxField.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Seleccionar campo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 77);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Ordenar por";
            // 
            // comboBoxSortBy
            // 
            comboBoxSortBy.FormattingEnabled = true;
            comboBoxSortBy.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            comboBoxSortBy.Location = new Point(245, 105);
            comboBoxSortBy.Name = "comboBoxSortBy";
            comboBoxSortBy.Size = new Size(176, 23);
            comboBoxSortBy.TabIndex = 5;
            // 
            // dataGridViewSellers
            // 
            dataGridViewSellers.AllowUserToAddRows = false;
            dataGridViewSellers.AllowUserToDeleteRows = false;
            dataGridViewSellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSellers.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnName, ColumnSalary });
            dataGridViewSellers.Location = new Point(10, 185);
            dataGridViewSellers.Name = "dataGridViewSellers";
            dataGridViewSellers.ReadOnly = true;
            dataGridViewSellers.Size = new Size(500, 262);
            dataGridViewSellers.TabIndex = 6;
            // 
            // labelResuelt
            // 
            labelResuelt.AutoSize = true;
            labelResuelt.Location = new Point(12, 147);
            labelResuelt.Name = "labelResuelt";
            labelResuelt.Size = new Size(64, 15);
            labelResuelt.TabIndex = 7;
            labelResuelt.Text = "Resultados";
            labelResuelt.Click += label4_Click;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(141, 147);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(47, 15);
            labelSalary.TabIndex = 8;
            labelSalary.Text = "Salarios";
            // 
            // ColumnCode
            // 
            ColumnCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCode.HeaderText = "Codigo";
            ColumnCode.Name = "ColumnCode";
            ColumnCode.ReadOnly = true;
            ColumnCode.Resizable = DataGridViewTriState.False;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnName.HeaderText = "Nombre";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Resizable = DataGridViewTriState.False;
            // 
            // ColumnSalary
            // 
            ColumnSalary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnSalary.HeaderText = "Salario";
            ColumnSalary.Name = "ColumnSalary";
            ColumnSalary.ReadOnly = true;
            ColumnSalary.Resizable = DataGridViewTriState.False;
            // 
            // ListSellers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 463);
            Controls.Add(labelSalary);
            Controls.Add(labelResuelt);
            Controls.Add(dataGridViewSellers);
            Controls.Add(comboBoxSortBy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxField);
            Controls.Add(label1);
            Name = "ListSellers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de vendedores";
            Load += ListSellers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSellers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxField;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxSortBy;
        private DataGridView dataGridViewSellers;
        private Label labelResuelt;
        private Label labelSalary;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSalary;
    }
}