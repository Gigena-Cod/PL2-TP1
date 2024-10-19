namespace Infrastructure.Features
{
    partial class FindUserByCode
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
            textBoxId = new TextBox();
            labelId = new Label();
            buttonFindCustomer = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDebts = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(300, 47);
            label1.TabIndex = 0;
            label1.Text = "Aquí podrás buscar un cliente por su ID y visualizar todos sus datos asociados de manera rápida y sencilla";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(36, 72);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(12, 75);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 15);
            labelId.TabIndex = 2;
            labelId.Text = "ID";
            // 
            // buttonFindCustomer
            // 
            buttonFindCustomer.Location = new Point(213, 67);
            buttonFindCustomer.Name = "buttonFindCustomer";
            buttonFindCustomer.Size = new Size(86, 30);
            buttonFindCustomer.TabIndex = 3;
            buttonFindCustomer.Text = "Buscar";
            buttonFindCustomer.UseVisualStyleBackColor = true;
            buttonFindCustomer.Click += buttonFindCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 211);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Deuda";
            // 
            // textBoxDebts
            // 
            textBoxDebts.Location = new Point(69, 203);
            textBoxDebts.Name = "textBoxDebts";
            textBoxDebts.ReadOnly = true;
            textBoxDebts.Size = new Size(136, 23);
            textBoxDebts.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(69, 168);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.ReadOnly = true;
            textBoxLastName.Size = new Size(136, 23);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(69, 133);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.ReadOnly = true;
            textBoxFirstName.Size = new Size(136, 23);
            textBoxFirstName.TabIndex = 11;
            // 
            // FindUserByCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 252);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxDebts);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonFindCustomer);
            Controls.Add(labelId);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Name = "FindUserByCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar usuario";
            Load += FindUserByCode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private Label labelId;
        private Button buttonFindCustomer;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDebts;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
    }
}