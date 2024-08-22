namespace Vectores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.handlerPlayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListWithFor = new System.Windows.Forms.Button();
            this.ListWithWhile = new System.Windows.Forms.Button();
            this.listPlayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial", 10F);
            this.name.Location = new System.Drawing.Point(126, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 23);
            this.name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.handlerPlayer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos";
            // 
            // handlerPlayer
            // 
            this.handlerPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.handlerPlayer.Location = new System.Drawing.Point(186, 70);
            this.handlerPlayer.Name = "handlerPlayer";
            this.handlerPlayer.Size = new System.Drawing.Size(96, 30);
            this.handlerPlayer.TabIndex = 2;
            this.handlerPlayer.Text = "Cargar";
            this.handlerPlayer.UseVisualStyleBackColor = true;
            this.handlerPlayer.Click += new System.EventHandler(this.handlerPlayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListWithFor);
            this.groupBox2.Controls.Add(this.ListWithWhile);
            this.groupBox2.Controls.Add(this.listPlayers);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 224);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de datos";
            // 
            // ListWithFor
            // 
            this.ListWithFor.Location = new System.Drawing.Point(86, 182);
            this.ListWithFor.Name = "ListWithFor";
            this.ListWithFor.Size = new System.Drawing.Size(89, 33);
            this.ListWithFor.TabIndex = 3;
            this.ListWithFor.Text = "Listar con for";
            this.ListWithFor.UseVisualStyleBackColor = true;
            this.ListWithFor.Click += new System.EventHandler(this.ListWithFor_Click);
            // 
            // ListWithWhile
            // 
            this.ListWithWhile.Location = new System.Drawing.Point(186, 182);
            this.ListWithWhile.Name = "ListWithWhile";
            this.ListWithWhile.Size = new System.Drawing.Size(96, 33);
            this.ListWithWhile.TabIndex = 2;
            this.ListWithWhile.Text = "Lista con while";
            this.ListWithWhile.UseVisualStyleBackColor = true;
            this.ListWithWhile.Click += new System.EventHandler(this.ListWithWhile_Click);
            // 
            // listPlayers
            // 
            this.listPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listPlayers.HideSelection = false;
            this.listPlayers.Location = new System.Drawing.Point(11, 20);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(271, 140);
            this.listPlayers.TabIndex = 0;
            this.listPlayers.UseCompatibleStateImageBehavior = false;
            this.listPlayers.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vectores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button handlerPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ListWithFor;
        private System.Windows.Forms.Button ListWithWhile;
        private System.Windows.Forms.ListView listPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

