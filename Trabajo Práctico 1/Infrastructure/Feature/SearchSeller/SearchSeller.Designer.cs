namespace Trabajo_Práctico_1.Infrastructure.Feature.SearchSeller
{
    partial class SearchSeller
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxCode = new TextBox();
            buttonSearch = new Button();
            labelSalary = new Label();
            labelName = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.MaximumSize = new Size(350, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 45);
            label1.TabIndex = 0;
            label1.Text = "En este formulario podrás buscar la información de un vendedor ingresando su código en el campo de texto. Al presionar el botón \"Buscar\", se mostrarán el nombre y el sueldo del vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 161);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 192);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Salario";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(17, 100);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(194, 23);
            textBoxCode.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(268, 96);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(89, 33);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Buscar";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(77, 192);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(12, 15);
            labelSalary.TabIndex = 5;
            labelSalary.Text = "-";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(77, 161);
            labelName.Name = "labelName";
            labelName.Size = new Size(12, 15);
            labelName.TabIndex = 6;
            labelName.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 78);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 7;
            label6.Text = "Codigo";
            // 
            // SearchSeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 266);
            Controls.Add(label6);
            Controls.Add(labelName);
            Controls.Add(labelSalary);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchSeller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de datos de un vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxCode;
        private Button buttonSearch;
        private Label labelSalary;
        private Label labelName;
        private Label label6;
    }
}