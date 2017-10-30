namespace UI
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSalarioMensual = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQ1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbArs1 = new System.Windows.Forms.Label();
            this.lbAfp1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTD1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbIRS1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotalD1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTotal2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalD2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbIRS2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTD2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbAfp2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbArs2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbQ2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCalular);
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbSalarioMensual);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario Mensual.";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(9, 41);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(314, 26);
            this.txtSalario.TabIndex = 1;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // btnCalular
            // 
            this.btnCalular.Location = new System.Drawing.Point(338, 41);
            this.btnCalular.Name = "btnCalular";
            this.btnCalular.Size = new System.Drawing.Size(92, 26);
            this.btnCalular.TabIndex = 2;
            this.btnCalular.Text = "Calcular";
            this.btnCalular.UseVisualStyleBackColor = true;
            this.btnCalular.Click += new System.EventHandler(this.btnCalular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(436, 41);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 26);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salario Mensual:";
            // 
            // lbSalarioMensual
            // 
            this.lbSalarioMensual.AutoSize = true;
            this.lbSalarioMensual.Location = new System.Drawing.Point(94, 20);
            this.lbSalarioMensual.Name = "lbSalarioMensual";
            this.lbSalarioMensual.Size = new System.Drawing.Size(10, 13);
            this.lbSalarioMensual.TabIndex = 1;
            this.lbSalarioMensual.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbTotalD1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbIRS1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbTD1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbAfp1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbArs1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbQ1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 293);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Primera Quincena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salario";
            // 
            // lbQ1
            // 
            this.lbQ1.AutoSize = true;
            this.lbQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ1.Location = new System.Drawing.Point(163, 21);
            this.lbQ1.Name = "lbQ1";
            this.lbQ1.Size = new System.Drawing.Size(13, 18);
            this.lbQ1.TabIndex = 1;
            this.lbQ1.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ARS Ley:";
            // 
            // lbArs1
            // 
            this.lbArs1.AutoSize = true;
            this.lbArs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArs1.Location = new System.Drawing.Point(163, 54);
            this.lbArs1.Name = "lbArs1";
            this.lbArs1.Size = new System.Drawing.Size(13, 18);
            this.lbArs1.TabIndex = 3;
            this.lbArs1.Text = "-";
            // 
            // lbAfp1
            // 
            this.lbAfp1.AutoSize = true;
            this.lbAfp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfp1.Location = new System.Drawing.Point(163, 87);
            this.lbAfp1.Name = "lbAfp1";
            this.lbAfp1.Size = new System.Drawing.Size(13, 18);
            this.lbAfp1.TabIndex = 5;
            this.lbAfp1.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "AFP Ley:";
            // 
            // lbTD1
            // 
            this.lbTD1.AutoSize = true;
            this.lbTD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTD1.Location = new System.Drawing.Point(163, 121);
            this.lbTD1.Name = "lbTD1";
            this.lbTD1.Size = new System.Drawing.Size(13, 18);
            this.lbTD1.TabIndex = 7;
            this.lbTD1.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Deduccones ARS / AFP";
            // 
            // lbIRS1
            // 
            this.lbIRS1.AutoSize = true;
            this.lbIRS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRS1.Location = new System.Drawing.Point(163, 155);
            this.lbIRS1.Name = "lbIRS1";
            this.lbIRS1.Size = new System.Drawing.Size(13, 18);
            this.lbIRS1.TabIndex = 9;
            this.lbIRS1.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cotizable para IRS";
            // 
            // lbTotalD1
            // 
            this.lbTotalD1.AutoSize = true;
            this.lbTotalD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalD1.Location = new System.Drawing.Point(163, 188);
            this.lbTotalD1.Name = "lbTotalD1";
            this.lbTotalD1.Size = new System.Drawing.Size(13, 18);
            this.lbTotalD1.TabIndex = 11;
            this.lbTotalD1.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total Deducciones";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(163, 249);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(13, 18);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total de Ingresos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbTotal2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbTotalD2);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lbIRS2);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lbTD2);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lbAfp2);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lbArs2);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lbQ2);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Location = new System.Drawing.Point(338, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 293);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Segunda Quincena";
            // 
            // lbTotal2
            // 
            this.lbTotal2.AutoSize = true;
            this.lbTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal2.Location = new System.Drawing.Point(163, 249);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(13, 18);
            this.lbTotal2.TabIndex = 13;
            this.lbTotal2.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total de Ingresos";
            // 
            // lbTotalD2
            // 
            this.lbTotalD2.AutoSize = true;
            this.lbTotalD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalD2.Location = new System.Drawing.Point(163, 188);
            this.lbTotalD2.Name = "lbTotalD2";
            this.lbTotalD2.Size = new System.Drawing.Size(13, 18);
            this.lbTotalD2.TabIndex = 11;
            this.lbTotalD2.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Total Deducciones";
            // 
            // lbIRS2
            // 
            this.lbIRS2.AutoSize = true;
            this.lbIRS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRS2.Location = new System.Drawing.Point(163, 155);
            this.lbIRS2.Name = "lbIRS2";
            this.lbIRS2.Size = new System.Drawing.Size(13, 18);
            this.lbIRS2.TabIndex = 9;
            this.lbIRS2.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Cotizable para IRS";
            // 
            // lbTD2
            // 
            this.lbTD2.AutoSize = true;
            this.lbTD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTD2.Location = new System.Drawing.Point(163, 121);
            this.lbTD2.Name = "lbTD2";
            this.lbTD2.Size = new System.Drawing.Size(13, 18);
            this.lbTD2.TabIndex = 7;
            this.lbTD2.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Total Deduccones ARS / AFP";
            // 
            // lbAfp2
            // 
            this.lbAfp2.AutoSize = true;
            this.lbAfp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAfp2.Location = new System.Drawing.Point(163, 87);
            this.lbAfp2.Name = "lbAfp2";
            this.lbAfp2.Size = new System.Drawing.Size(13, 18);
            this.lbAfp2.TabIndex = 5;
            this.lbAfp2.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "AFP Ley:";
            // 
            // lbArs2
            // 
            this.lbArs2.AutoSize = true;
            this.lbArs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArs2.Location = new System.Drawing.Point(163, 54);
            this.lbArs2.Name = "lbArs2";
            this.lbArs2.Size = new System.Drawing.Size(13, 18);
            this.lbArs2.TabIndex = 3;
            this.lbArs2.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "ARS Ley:";
            // 
            // lbQ2
            // 
            this.lbQ2.AutoSize = true;
            this.lbQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQ2.Location = new System.Drawing.Point(163, 21);
            this.lbQ2.Name = "lbQ2";
            this.lbQ2.Size = new System.Drawing.Size(13, 18);
            this.lbQ2.TabIndex = 1;
            this.lbQ2.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Salario";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTotalD1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbIRS1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTD1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAfp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbArs1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbQ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSalarioMensual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbTotal2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalD2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbIRS2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTD2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbAfp2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbArs2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbQ2;
        private System.Windows.Forms.Label label23;
    }
}

