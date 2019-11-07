namespace POSTURA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOnOff = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotor5 = new System.Windows.Forms.TextBox();
            this.txtMotor4 = new System.Windows.Forms.TextBox();
            this.txtMotor3 = new System.Windows.Forms.TextBox();
            this.txtMotor2 = new System.Windows.Forms.TextBox();
            this.txtMotor1 = new System.Windows.Forms.TextBox();
            this.cbPinza = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lComando = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBaudios = new System.Windows.Forms.ComboBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(75, 75);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOnOff,
            this.btnGenerar,
            this.btnSend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 82);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOnOff
            // 
            this.btnOnOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOnOff.Image = global::POSTURA.Properties.Resources.onoff;
            this.btnOnOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(79, 79);
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGenerar.Image = global::POSTURA.Properties.Resources.Command;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(79, 79);
            this.btnGenerar.Text = "toolStripButton1";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSend
            // 
            this.btnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSend.Image = global::POSTURA.Properties.Resources.upload;
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(79, 79);
            this.btnSend.Text = "toolStripButton2";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotor5);
            this.groupBox1.Controls.Add(this.txtMotor4);
            this.groupBox1.Controls.Add(this.txtMotor3);
            this.groupBox1.Controls.Add(this.txtMotor2);
            this.groupBox1.Controls.Add(this.txtMotor1);
            this.groupBox1.Controls.Add(this.cbPinza);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POSICIÓN DE LOS MOTORES";
            // 
            // txtMotor5
            // 
            this.txtMotor5.Location = new System.Drawing.Point(92, 195);
            this.txtMotor5.Name = "txtMotor5";
            this.txtMotor5.Size = new System.Drawing.Size(100, 26);
            this.txtMotor5.TabIndex = 3;
            this.txtMotor5.Text = "1";
            this.toolTip1.SetToolTip(this.txtMotor5, "EL VALOR DEBE DE SER ENTRE 1 Y 254");
            // 
            // txtMotor4
            // 
            this.txtMotor4.Location = new System.Drawing.Point(92, 151);
            this.txtMotor4.Name = "txtMotor4";
            this.txtMotor4.Size = new System.Drawing.Size(100, 26);
            this.txtMotor4.TabIndex = 3;
            this.txtMotor4.Text = "1";
            this.toolTip1.SetToolTip(this.txtMotor4, "EL VALOR DEBE DE SER ENTRE 1 Y 254");
            // 
            // txtMotor3
            // 
            this.txtMotor3.Location = new System.Drawing.Point(92, 107);
            this.txtMotor3.Name = "txtMotor3";
            this.txtMotor3.Size = new System.Drawing.Size(100, 26);
            this.txtMotor3.TabIndex = 3;
            this.txtMotor3.Text = "1";
            this.toolTip1.SetToolTip(this.txtMotor3, "EL VALOR DEBE DE SER ENTRE 1 Y 254");
            // 
            // txtMotor2
            // 
            this.txtMotor2.Location = new System.Drawing.Point(92, 63);
            this.txtMotor2.Name = "txtMotor2";
            this.txtMotor2.Size = new System.Drawing.Size(100, 26);
            this.txtMotor2.TabIndex = 3;
            this.txtMotor2.Text = "1";
            this.toolTip1.SetToolTip(this.txtMotor2, "EL VALOR DEBE DE SER ENTRE 1 Y 254");
            // 
            // txtMotor1
            // 
            this.txtMotor1.Location = new System.Drawing.Point(92, 19);
            this.txtMotor1.Name = "txtMotor1";
            this.txtMotor1.Size = new System.Drawing.Size(100, 26);
            this.txtMotor1.TabIndex = 3;
            this.txtMotor1.Text = "1";
            this.toolTip1.SetToolTip(this.txtMotor1, "EL VALOR DEBE DE SER ENTRE 1 Y 254");
            // 
            // cbPinza
            // 
            this.cbPinza.AutoSize = true;
            this.cbPinza.Location = new System.Drawing.Point(92, 238);
            this.cbPinza.Name = "cbPinza";
            this.cbPinza.Size = new System.Drawing.Size(184, 24);
            this.cbPinza.TabIndex = 2;
            this.cbPinza.Text = "ABIERTO/CERRADO";
            this.cbPinza.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "PINZA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "MOTOR 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "MOTOR 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "MOTOR 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MOTOR 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOTOR 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lComando);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMANDO";
            // 
            // lComando
            // 
            this.lComando.AutoSize = true;
            this.lComando.Location = new System.Drawing.Point(17, 63);
            this.lComando.Name = "lComando";
            this.lComando.Size = new System.Drawing.Size(91, 20);
            this.lComando.TabIndex = 0;
            this.lComando.Text = "COMANDO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "CADENA A ENVIAR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBaudios);
            this.groupBox3.Controls.Add(this.cbPorts);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(371, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 154);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONFIGURACION DEL PUERTO";
            // 
            // cbBaudios
            // 
            this.cbBaudios.FormattingEnabled = true;
            this.cbBaudios.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cbBaudios.Location = new System.Drawing.Point(21, 110);
            this.cbBaudios.Name = "cbBaudios";
            this.cbBaudios.Size = new System.Drawing.Size(181, 28);
            this.cbBaudios.TabIndex = 1;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(21, 56);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(181, 28);
            this.cbPorts.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "BAUD RATE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "NOMBRE DEL PUERTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERFAZ BRACCIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOnOff;
        private System.Windows.Forms.ToolStripButton btnSend;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMotor5;
        private System.Windows.Forms.TextBox txtMotor4;
        private System.Windows.Forms.TextBox txtMotor3;
        private System.Windows.Forms.TextBox txtMotor2;
        private System.Windows.Forms.TextBox txtMotor1;
        private System.Windows.Forms.CheckBox cbPinza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBaudios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lComando;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

