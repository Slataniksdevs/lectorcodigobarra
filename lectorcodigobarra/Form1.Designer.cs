namespace lectorcodigobarra
{
    partial class mainform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.comboBoxPuertos = new System.Windows.Forms.ComboBox();
            this.textBoxDatos = new System.Windows.Forms.TextBox();
            this.textBoxRun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.Nticket = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ComboBoxPuertos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(41, 91);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(230, 26);
            this.textBoxEstado.TabIndex = 5;
            // 
            // comboBoxPuertos
            // 
            this.comboBoxPuertos.FormattingEnabled = true;
            this.comboBoxPuertos.Location = new System.Drawing.Point(196, 42);
            this.comboBoxPuertos.Name = "comboBoxPuertos";
            this.comboBoxPuertos.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPuertos.TabIndex = 6;
            // 
            // textBoxDatos
            // 
            this.textBoxDatos.Location = new System.Drawing.Point(27, 138);
            this.textBoxDatos.Multiline = true;
            this.textBoxDatos.Name = "textBoxDatos";
            this.textBoxDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDatos.Size = new System.Drawing.Size(615, 150);
            this.textBoxDatos.TabIndex = 4;
            // 
            // textBoxRun
            // 
            this.textBoxRun.Location = new System.Drawing.Point(117, 315);
            this.textBoxRun.Name = "textBoxRun";
            this.textBoxRun.Size = new System.Drawing.Size(263, 26);
            this.textBoxRun.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(117, 352);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(263, 26);
            this.textBoxSerial.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(117, 393);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(263, 26);
            this.textBoxTicket.TabIndex = 11;
            // 
            // Nticket
            // 
            this.Nticket.AutoSize = true;
            this.Nticket.Location = new System.Drawing.Point(27, 399);
            this.Nticket.Name = "Nticket";
            this.Nticket.Size = new System.Drawing.Size(84, 20);
            this.Nticket.TabIndex = 12;
            this.Nticket.Text = "N de ticket";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(598, 315);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(166, 26);
            this.textBoxResultado.TabIndex = 13;
            this.textBoxResultado.Text = "}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "valor del servicio";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.Nticket);
            this.Controls.Add(this.textBoxTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRun);
            this.Controls.Add(this.textBoxDatos);
            this.Controls.Add(this.comboBoxPuertos);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxPuertos;
        private System.Windows.Forms.TextBox textBoxDatos;
        private System.Windows.Forms.TextBox textBoxRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.Label Nticket;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label4;
    }
}

