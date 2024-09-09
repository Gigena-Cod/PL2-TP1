namespace Features
{
    partial class CreateClient
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
            buttonCancel = new Button();
            buttonSave = new Button();
            label5 = new Label();
            label3 = new Label();
            textBoxLimitCredit = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxDebt = new TextBox();
            label1 = new Label();
            textBoxCode = new TextBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(80, 203);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 35);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(210, 203);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 35);
            buttonSave.TabIndex = 28;
            buttonSave.Text = "Crear";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.MaximumSize = new Size(400, 0);
            label5.Name = "label5";
            label5.Size = new Size(381, 30);
            label5.TabIndex = 27;
            label5.Text = "Aquí puedes registrar un nuevo cliente ingresando su código, nombre, deuda y límite de crédito.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 129);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 26;
            label3.Text = "Limite de credito";
            // 
            // textBoxLimitCredit
            // 
            textBoxLimitCredit.Location = new Point(210, 156);
            textBoxLimitCredit.Name = "textBoxLimitCredit";
            textBoxLimitCredit.Size = new Size(173, 23);
            textBoxLimitCredit.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 58);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 24;
            label4.Text = "Nombre y apellido";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(210, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(173, 23);
            textBoxName.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 22;
            label2.Text = "Deuda";
            // 
            // textBoxDebt
            // 
            textBoxDebt.Location = new Point(12, 156);
            textBoxDebt.Name = "textBoxDebt";
            textBoxDebt.Size = new Size(173, 23);
            textBoxDebt.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 20;
            label1.Text = "Codigo";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(12, 85);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(173, 23);
            textBoxCode.TabIndex = 19;
            // 
            // CreateClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 260);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBoxLimitCredit);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxDebt);
            Controls.Add(label1);
            Controls.Add(textBoxCode);
            Name = "CreateClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private Label label5;
        private Label label3;
        private TextBox textBoxLimitCredit;
        private Label label4;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxDebt;
        private Label label1;
        private TextBox textBoxCode;
    }
}