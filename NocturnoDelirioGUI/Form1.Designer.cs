namespace GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gCuenta;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.GroupBox gRes;
        private System.Windows.Forms.ComboBox cmbAnfitriona;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb60;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ListBox lbCitas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gCuenta = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.gRes = new System.Windows.Forms.GroupBox();
            this.lbCitas = new System.Windows.Forms.ListBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rb60 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbAnfitriona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gCuenta.SuspendLayout();
            this.gRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCuenta
            // 
            this.gCuenta.Controls.Add(this.label6);
            this.gCuenta.Controls.Add(this.label5);
            this.gCuenta.Controls.Add(this.label4);
            this.gCuenta.Controls.Add(this.label3);
            this.gCuenta.Controls.Add(this.label1);
            this.gCuenta.Controls.Add(this.label2);
            this.gCuenta.Controls.Add(this.btnLogin);
            this.gCuenta.Controls.Add(this.btnRegistrar);
            this.gCuenta.Controls.Add(this.txtTarjeta);
            this.gCuenta.Controls.Add(this.cmbPlan);
            this.gCuenta.Controls.Add(this.txtPassword);
            this.gCuenta.Controls.Add(this.txtEmail);
            this.gCuenta.Controls.Add(this.txtNombre);
            this.gCuenta.Controls.Add(this.txtDNI);
            this.gCuenta.Location = new System.Drawing.Point(16, 15);
            this.gCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.gCuenta.Name = "gCuenta";
            this.gCuenta.Padding = new System.Windows.Forms.Padding(4);
            this.gCuenta.Size = new System.Drawing.Size(400, 271);
            this.gCuenta.TabIndex = 0;
            this.gCuenta.TabStop = false;
            this.gCuenta.Text = "Cuenta";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(147, 244);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(13, 244);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 28);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(107, 212);
            this.txtTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarjeta.MaxLength = 16;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(265, 22);
            this.txtTarjeta.TabIndex = 5;
            // 
            // cmbPlan
            // 
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Items.AddRange(new object[] {
            "Gratis",
            "Premium (S/.50)",
            "VIP (S/.100)"});
            this.cmbPlan.Location = new System.Drawing.Point(107, 175);
            this.cmbPlan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(265, 24);
            this.cmbPlan.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 138);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(265, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 101);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(107, 27);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(132, 22);
            this.txtDNI.TabIndex = 0;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 16;
            this.lbUsuarios.Location = new System.Drawing.Point(16, 293);
            this.lbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(399, 244);
            this.lbUsuarios.TabIndex = 1;
            // 
            // gRes
            // 
            this.gRes.Controls.Add(this.lbCitas);
            this.gRes.Controls.Add(this.btnUndo);
            this.gRes.Controls.Add(this.btnRes);
            this.gRes.Controls.Add(this.btnVer);
            this.gRes.Controls.Add(this.lblPrecio);
            this.gRes.Controls.Add(this.rb60);
            this.gRes.Controls.Add(this.rb30);
            this.gRes.Controls.Add(this.txtHora);
            this.gRes.Controls.Add(this.dtpFecha);
            this.gRes.Controls.Add(this.cmbAnfitriona);
            this.gRes.Location = new System.Drawing.Point(424, 15);
            this.gRes.Margin = new System.Windows.Forms.Padding(4);
            this.gRes.Name = "gRes";
            this.gRes.Padding = new System.Windows.Forms.Padding(4);
            this.gRes.Size = new System.Drawing.Size(733, 320);
            this.gRes.TabIndex = 2;
            this.gRes.TabStop = false;
            this.gRes.Text = "Reserva";
            // 
            // lbCitas
            // 
            this.lbCitas.FormattingEnabled = true;
            this.lbCitas.ItemHeight = 16;
            this.lbCitas.Location = new System.Drawing.Point(21, 160);
            this.lbCitas.Margin = new System.Windows.Forms.Padding(4);
            this.lbCitas.Name = "lbCitas";
            this.lbCitas.Size = new System.Drawing.Size(692, 132);
            this.lbCitas.TabIndex = 9;
            this.lbCitas.SelectedIndexChanged += new System.EventHandler(this.lbCitas_SelectedIndexChanged);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(237, 111);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 28);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Deshacer";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(129, 111);
            this.btnRes.Margin = new System.Windows.Forms.Padding(4);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(100, 28);
            this.btnRes.TabIndex = 7;
            this.btnRes.Text = "Reservar";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(21, 111);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(100, 28);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Verificar";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(307, 76);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio: S/. 0";
            // 
            // rb60
            // 
            this.rb60.AutoSize = true;
            this.rb60.Location = new System.Drawing.Point(160, 74);
            this.rb60.Margin = new System.Windows.Forms.Padding(4);
            this.rb60.Name = "rb60";
            this.rb60.Size = new System.Drawing.Size(91, 20);
            this.rb60.TabIndex = 4;
            this.rb60.TabStop = true;
            this.rb60.Text = "60 min (60)";
            this.rb60.UseVisualStyleBackColor = true;
            this.rb60.CheckedChanged += new System.EventHandler(this.RbDuracion_CheckedChanged);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Location = new System.Drawing.Point(21, 74);
            this.rb30.Margin = new System.Windows.Forms.Padding(4);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(91, 20);
            this.rb30.TabIndex = 3;
            this.rb30.TabStop = true;
            this.rb30.Text = "30 min (30)";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.RbDuracion_CheckedChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(461, 31);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(79, 22);
            this.txtHora.TabIndex = 2;
            this.txtHora.Text = "20:00";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(307, 31);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(132, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // cmbAnfitriona
            // 
            this.cmbAnfitriona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnfitriona.FormattingEnabled = true;
            this.cmbAnfitriona.Items.AddRange(new object[] {
            "Valeria",
            "Camila",
            "Kiara",
            "Luna",
            "Abril",
            "Mia",
            "Zoe",
            "Dana"});
            this.cmbAnfitriona.Location = new System.Drawing.Point(21, 31);
            this.cmbAnfitriona.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnfitriona.Name = "cmbAnfitriona";
            this.cmbAnfitriona.Size = new System.Drawing.Size(265, 24);
            this.cmbAnfitriona.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "N° de Tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "DNI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 554);
            this.Controls.Add(this.gRes);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.gCuenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Nocturno Delirio";
            this.gCuenta.ResumeLayout(false);
            this.gCuenta.PerformLayout();
            this.gRes.ResumeLayout(false);
            this.gRes.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
