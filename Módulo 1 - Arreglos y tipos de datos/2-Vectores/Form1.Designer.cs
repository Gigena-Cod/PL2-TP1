namespace Dos_Vectores
{
    partial class expenseManager
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
            groupBox1 = new GroupBox();
            saveAmount = new Button();
            comboBoxAmount = new ComboBox();
            textBoxAmount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridViewExpenses = new DataGridView();
            ColumnMonth = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            buttonListWithWhile = new Button();
            buttonListWithFor = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveAmount);
            groupBox1.Controls.Add(comboBoxAmount);
            groupBox1.Controls.Add(textBoxAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargar gasto";
            // 
            // saveAmount
            // 
            saveAmount.Location = new Point(225, 101);
            saveAmount.Name = "saveAmount";
            saveAmount.Size = new Size(84, 29);
            saveAmount.TabIndex = 4;
            saveAmount.Text = "Guardar";
            saveAmount.UseVisualStyleBackColor = true;
            saveAmount.Click += saveAmount_Click;
            // 
            // comboBoxAmount
            // 
            comboBoxAmount.FormattingEnabled = true;
            comboBoxAmount.Location = new Point(72, 27);
            comboBoxAmount.Name = "comboBoxAmount";
            comboBoxAmount.Size = new Size(237, 23);
            comboBoxAmount.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(72, 61);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(237, 23);
            textBoxAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Importe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Mes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewExpenses);
            groupBox2.Controls.Add(buttonListWithWhile);
            groupBox2.Controls.Add(buttonListWithFor);
            groupBox2.Location = new Point(12, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de gastos";
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpenses.Columns.AddRange(new DataGridViewColumn[] { ColumnMonth, ColumnAmount });
            dataGridViewExpenses.Location = new Point(15, 22);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.Size = new Size(294, 184);
            dataGridViewExpenses.TabIndex = 7;
            // 
            // ColumnMonth
            // 
            ColumnMonth.HeaderText = "Mes";
            ColumnMonth.Name = "ColumnMonth";
            // 
            // ColumnAmount
            // 
            ColumnAmount.HeaderText = "Importe";
            ColumnAmount.Name = "ColumnAmount";
            // 
            // buttonListWithWhile
            // 
            buttonListWithWhile.Location = new Point(207, 222);
            buttonListWithWhile.Name = "buttonListWithWhile";
            buttonListWithWhile.Size = new Size(102, 29);
            buttonListWithWhile.TabIndex = 6;
            buttonListWithWhile.Text = "Listar con while";
            buttonListWithWhile.UseVisualStyleBackColor = true;
            buttonListWithWhile.Click += buttonListWithWhile_Click;
            // 
            // buttonListWithFor
            // 
            buttonListWithFor.Location = new Point(89, 222);
            buttonListWithFor.Name = "buttonListWithFor";
            buttonListWithFor.Size = new Size(102, 29);
            buttonListWithFor.TabIndex = 5;
            buttonListWithFor.Text = "Listar con for";
            buttonListWithFor.UseVisualStyleBackColor = true;
            buttonListWithFor.Click += buttonListWithFor_Click;
            // 
            // expenseManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 456);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "expenseManager";
            Text = "Administrador de gastos";
            Load += expenseManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button saveAmount;
        private ComboBox comboBoxAmount;
        private TextBox textBoxAmount;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewExpenses;
        private DataGridViewTextBoxColumn ColumnMonth;
        private DataGridViewTextBoxColumn ColumnAmount;
        private Button buttonListWithWhile;
        private Button buttonListWithFor;
    }
}
