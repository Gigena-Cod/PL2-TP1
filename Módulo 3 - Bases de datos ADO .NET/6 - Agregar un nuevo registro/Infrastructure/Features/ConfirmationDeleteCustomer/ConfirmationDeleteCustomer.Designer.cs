namespace Infrastructure.Features
{
    partial class ConfirmationDeleteCustomer
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
            labelDescription = new Label();
            button2 = new Button();
            buttonDeleteCustomer = new Button();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(12, 18);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(391, 39);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Estás a punto de eliminar al usuario {customer.Name}. Esta acción es irreversible y no podrás realizar más cambios. ¿Deseas continuar?";
            // 
            // button2
            // 
            button2.Location = new Point(79, 88);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(211, 88);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(115, 30);
            buttonDeleteCustomer.TabIndex = 3;
            buttonDeleteCustomer.Text = "Eliminar";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // ConfirmationDeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 138);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(button2);
            Controls.Add(labelDescription);
            Name = "ConfirmationDeleteCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmar eliminación";
            Load += ConfirmationDeleteCustomer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelDescription;
        private Button button2;
        private Button buttonDeleteCustomer;
    }
}