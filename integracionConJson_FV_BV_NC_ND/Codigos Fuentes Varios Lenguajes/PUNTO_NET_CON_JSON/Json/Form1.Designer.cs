namespace Json
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_xmlenviado = new System.Windows.Forms.TextBox();
            this.txt_cdr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cadena_codigo_qr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ticket_sunat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_codigohash = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_sunat_recsponsecode = new System.Windows.Forms.TextBox();
            this.txt_sunat_descrip = new System.Windows.Forms.TextBox();
            this.txt_correl = new System.Windows.Forms.TextBox();
            this.txt_seriedoc = new System.Windows.Forms.TextBox();
            this.txttipo_cpe = new System.Windows.Forms.TextBox();
            this.txterror = new System.Windows.Forms.TextBox();
            this.txtestadodocumeto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSendGuiaRemision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.MaxLength = 327679999;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 317);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enviar Factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "errors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "estado_documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "sunat_description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "correlativo_cpe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "serie_cpe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "tipo_cpe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "xml_enviado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "sunat_responsecode";
            // 
            // txt_xmlenviado
            // 
            this.txt_xmlenviado.Location = new System.Drawing.Point(322, 269);
            this.txt_xmlenviado.Name = "txt_xmlenviado";
            this.txt_xmlenviado.Size = new System.Drawing.Size(315, 20);
            this.txt_xmlenviado.TabIndex = 11;
            // 
            // txt_cdr
            // 
            this.txt_cdr.Location = new System.Drawing.Point(322, 295);
            this.txt_cdr.Name = "txt_cdr";
            this.txt_cdr.Size = new System.Drawing.Size(315, 20);
            this.txt_cdr.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "cdr_sunat";
            // 
            // txt_cadena_codigo_qr
            // 
            this.txt_cadena_codigo_qr.Location = new System.Drawing.Point(322, 321);
            this.txt_cadena_codigo_qr.Name = "txt_cadena_codigo_qr";
            this.txt_cadena_codigo_qr.Size = new System.Drawing.Size(315, 20);
            this.txt_cadena_codigo_qr.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "cadena_para_codigo_qr";
            // 
            // txt_ticket_sunat
            // 
            this.txt_ticket_sunat.Location = new System.Drawing.Point(322, 375);
            this.txt_ticket_sunat.Name = "txt_ticket_sunat";
            this.txt_ticket_sunat.Size = new System.Drawing.Size(144, 20);
            this.txt_ticket_sunat.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "ticket_sunat";
            // 
            // txt_codigohash
            // 
            this.txt_codigohash.Location = new System.Drawing.Point(322, 349);
            this.txt_codigohash.Name = "txt_codigohash";
            this.txt_codigohash.Size = new System.Drawing.Size(315, 20);
            this.txt_codigohash.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "codigo_hash";
            // 
            // txt_sunat_recsponsecode
            // 
            this.txt_sunat_recsponsecode.Location = new System.Drawing.Point(322, 243);
            this.txt_sunat_recsponsecode.Name = "txt_sunat_recsponsecode";
            this.txt_sunat_recsponsecode.Size = new System.Drawing.Size(100, 20);
            this.txt_sunat_recsponsecode.TabIndex = 24;
            // 
            // txt_sunat_descrip
            // 
            this.txt_sunat_descrip.Location = new System.Drawing.Point(322, 217);
            this.txt_sunat_descrip.Name = "txt_sunat_descrip";
            this.txt_sunat_descrip.Size = new System.Drawing.Size(100, 20);
            this.txt_sunat_descrip.TabIndex = 23;
            // 
            // txt_correl
            // 
            this.txt_correl.Location = new System.Drawing.Point(322, 189);
            this.txt_correl.Name = "txt_correl";
            this.txt_correl.Size = new System.Drawing.Size(100, 20);
            this.txt_correl.TabIndex = 22;
            // 
            // txt_seriedoc
            // 
            this.txt_seriedoc.Location = new System.Drawing.Point(322, 163);
            this.txt_seriedoc.Name = "txt_seriedoc";
            this.txt_seriedoc.Size = new System.Drawing.Size(100, 20);
            this.txt_seriedoc.TabIndex = 21;
            // 
            // txttipo_cpe
            // 
            this.txttipo_cpe.Location = new System.Drawing.Point(322, 137);
            this.txttipo_cpe.Name = "txttipo_cpe";
            this.txttipo_cpe.Size = new System.Drawing.Size(100, 20);
            this.txttipo_cpe.TabIndex = 20;
            // 
            // txterror
            // 
            this.txterror.Location = new System.Drawing.Point(322, 88);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(315, 20);
            this.txterror.TabIndex = 25;
            // 
            // txtestadodocumeto
            // 
            this.txtestadodocumeto.Location = new System.Drawing.Point(322, 114);
            this.txtestadodocumeto.Name = "txtestadodocumeto";
            this.txtestadodocumeto.Size = new System.Drawing.Size(100, 20);
            this.txtestadodocumeto.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "json Generado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(317, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 26);
            this.label14.TabIndex = 28;
            this.label14.Text = "Respuesta del servicio";
            // 
            // btnSendGuiaRemision
            // 
            this.btnSendGuiaRemision.Location = new System.Drawing.Point(593, 41);
            this.btnSendGuiaRemision.Name = "btnSendGuiaRemision";
            this.btnSendGuiaRemision.Size = new System.Drawing.Size(164, 34);
            this.btnSendGuiaRemision.TabIndex = 29;
            this.btnSendGuiaRemision.Text = "Enviar Guia Remision Remitente";
            this.btnSendGuiaRemision.UseVisualStyleBackColor = true;
            this.btnSendGuiaRemision.Click += new System.EventHandler(this.btnSendGuiaRemision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 415);
            this.Controls.Add(this.btnSendGuiaRemision);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtestadodocumeto);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.txt_sunat_recsponsecode);
            this.Controls.Add(this.txt_sunat_descrip);
            this.Controls.Add(this.txt_correl);
            this.Controls.Add(this.txt_seriedoc);
            this.Controls.Add(this.txttipo_cpe);
            this.Controls.Add(this.txt_ticket_sunat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_codigohash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cadena_codigo_qr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_cdr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_xmlenviado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_xmlenviado;
        private System.Windows.Forms.TextBox txt_cdr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cadena_codigo_qr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ticket_sunat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_codigohash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_sunat_recsponsecode;
        private System.Windows.Forms.TextBox txt_sunat_descrip;
        private System.Windows.Forms.TextBox txt_correl;
        private System.Windows.Forms.TextBox txt_seriedoc;
        private System.Windows.Forms.TextBox txttipo_cpe;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.TextBox txtestadodocumeto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSendGuiaRemision;
    }
}

