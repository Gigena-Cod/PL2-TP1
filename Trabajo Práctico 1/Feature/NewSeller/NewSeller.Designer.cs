namespace Trabajo_Práctico_1.Feature.NewSeller
{
    partial class NewSeller
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
            textBoxSalary = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label5 = new Label();
            buttonCreateSeller = new Button();
            buttonCloseCreateSellet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(376, 15);
            label1.TabIndex = 0;
            label1.Text = "Aquí podrás registrar un  nuevo vendedor en el sistema. Solo necesitar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(201, 15);
            label2.TabIndex = 1;
            label2.Text = "ingresar su código, nombre y salario.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 79);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Codigo";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(14, 103);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(171, 23);
            textBoxCode.TabIndex = 3;
            textBoxCode.TextChanged += textBoxCode_TextChanged;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(214, 103);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(171, 23);
            textBoxSalary.TabIndex = 5;
            textBoxSalary.TextChanged += textBoxSalary_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 79);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Salario";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 166);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(373, 23);
            textBoxName.TabIndex = 7;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 142);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 6;
            label5.Text = "Nombre completo";
            // 
            // buttonCreateSeller
            // 
            buttonCreateSeller.Location = new Point(214, 220);
            buttonCreateSeller.Name = "buttonCreateSeller";
            buttonCreateSeller.Size = new Size(97, 33);
            buttonCreateSeller.TabIndex = 8;
            buttonCreateSeller.Text = "Crear";
            buttonCreateSeller.UseVisualStyleBackColor = true;
            buttonCreateSeller.Click += buttonCreateSeller_Click;
            // 
            // buttonCloseCreateSellet
            // 
            buttonCloseCreateSellet.Location = new Point(88, 220);
            buttonCloseCreateSellet.Name = "buttonCloseCreateSellet";
            buttonCloseCreateSellet.Size = new Size(97, 33);
            buttonCloseCreateSellet.TabIndex = 9;
            buttonCloseCreateSellet.Text = "Cancelar";
            buttonCloseCreateSellet.UseVisualStyleBackColor = true;
            buttonCloseCreateSellet.Click += buttonCloseCreateSellet_Click;
            // 
            // NewSeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 267);
            Controls.Add(buttonCloseCreateSellet);
            Controls.Add(buttonCreateSeller);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(textBoxSalary);
            Controls.Add(label4);
            Controls.Add(textBoxCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewSeller";
            Text = "Crear vendedor";
            Load += NewSeller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxCode;
        private TextBox textBoxSalary;
        private Label label4;
        private TextBox textBoxName;
        private Label label5;
        private Button buttonCreateSeller;
        private Button buttonCloseCreateSellet;
    }
}