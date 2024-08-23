namespace _3___Vectores_constituidos_por_registros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxLoadClient = new GroupBox();
            buttonLoad = new Button();
            label4 = new Label();
            textBoxLimitCredit = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxDebt = new TextBox();
            label1 = new Label();
            textBoxCode = new TextBox();
            groupBox1 = new GroupBox();
            dataGridViewClients = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnDebt = new DataGridViewTextBoxColumn();
            ColumnLimitCredit = new DataGridViewTextBoxColumn();
            buttonListClients = new Button();
            groupBoxLoadClient.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // groupBoxLoadClient
            // 
            groupBoxLoadClient.Controls.Add(buttonLoad);
            groupBoxLoadClient.Controls.Add(label4);
            groupBoxLoadClient.Controls.Add(textBoxLimitCredit);
            groupBoxLoadClient.Controls.Add(label3);
            groupBoxLoadClient.Controls.Add(textBoxName);
            groupBoxLoadClient.Controls.Add(label2);
            groupBoxLoadClient.Controls.Add(textBoxDebt);
            groupBoxLoadClient.Controls.Add(label1);
            groupBoxLoadClient.Controls.Add(textBoxCode);
            groupBoxLoadClient.Location = new Point(12, 12);
            groupBoxLoadClient.Name = "groupBoxLoadClient";
            groupBoxLoadClient.Size = new Size(533, 198);
            groupBoxLoadClient.TabIndex = 0;
            groupBoxLoadClient.TabStop = false;
            groupBoxLoadClient.Text = "Carga de datos";
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(392, 153);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(121, 28);
            buttonLoad.TabIndex = 8;
            buttonLoad.Text = "Cargar";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 107);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Limite de credito";
            // 
            // textBoxLimitCredit
            // 
            textBoxLimitCredit.Location = new Point(358, 104);
            textBoxLimitCredit.Name = "textBoxLimitCredit";
            textBoxLimitCredit.Size = new Size(155, 23);
            textBoxLimitCredit.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 60);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre completo";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(358, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(155, 23);
            textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 107);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Deuda";
            // 
            // textBoxDebt
            // 
            textBoxDebt.Location = new Point(71, 104);
            textBoxDebt.Name = "textBoxDebt";
            textBoxDebt.Size = new Size(136, 23);
            textBoxDebt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(71, 57);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(136, 23);
            textBoxCode.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewClients);
            groupBox1.Controls.Add(buttonListClients);
            groupBox1.Location = new Point(12, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 305);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta de datos";
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnName, ColumnDebt, ColumnLimitCredit });
            dataGridViewClients.Location = new Point(19, 37);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(494, 210);
            dataGridViewClients.TabIndex = 9;
            // 
            // ColumnCode
            // 
            ColumnCode.HeaderText = "Codigo";
            ColumnCode.Name = "ColumnCode";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "ColumnName";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnDebt
            // 
            ColumnDebt.HeaderText = "Deuda";
            ColumnDebt.Name = "ColumnDebt";
            // 
            // ColumnLimitCredit
            // 
            ColumnLimitCredit.HeaderText = "Limite de crédito";
            ColumnLimitCredit.Name = "ColumnLimitCredit";
            // 
            // buttonListClients
            // 
            buttonListClients.Location = new Point(392, 262);
            buttonListClients.Name = "buttonListClients";
            buttonListClients.Size = new Size(121, 28);
            buttonListClients.TabIndex = 8;
            buttonListClients.Text = "Listar";
            buttonListClients.UseVisualStyleBackColor = true;
            buttonListClients.Click += buttonListClients_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 544);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxLoadClient);
            Name = "Form1";
            Text = "Gestion de clientes";
            groupBoxLoadClient.ResumeLayout(false);
            groupBoxLoadClient.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLoadClient;
        private Label label4;
        private TextBox textBoxLimitCredit;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxDebt;
        private Label label1;
        private TextBox textBoxCode;
        private Button buttonLoad;
        private GroupBox groupBox1;
        private DataGridView dataGridViewClients;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDebt;
        private DataGridViewTextBoxColumn ColumnLimitCredit;
        private Button buttonListClients;
    }
}
