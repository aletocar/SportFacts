namespace SportFacts
{
    partial class VentanaInicio
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
            this.panelInicio = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.panelAgregarUsuario = new System.Windows.Forms.Panel();
            this.rBtnTecnico = new System.Windows.Forms.RadioButton();
            this.rBtnDeportista = new System.Windows.Forms.RadioButton();
            this.rBtnMedico = new System.Windows.Forms.RadioButton();
            this.btnCancelarAgregarUsuario = new System.Windows.Forms.Button();
            this.btnConfirmarAgregarUsuario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelInicio.SuspendLayout();
            this.panelAgregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInicio.Controls.Add(this.textBox2);
            this.panelInicio.Controls.Add(this.textBox1);
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.btnIngresar);
            this.panelInicio.Controls.Add(this.btnAgregarUsuario);
            this.panelInicio.Location = new System.Drawing.Point(339, 439);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(273, 100);
            this.panelInicio.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(67, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(67, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.Location = new System.Drawing.Point(192, 65);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(67, 65);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(119, 23);
            this.btnAgregarUsuario.TabIndex = 6;
            this.btnAgregarUsuario.Text = "Crear Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // panelAgregarUsuario
            // 
            this.panelAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAgregarUsuario.Controls.Add(this.rBtnTecnico);
            this.panelAgregarUsuario.Controls.Add(this.rBtnDeportista);
            this.panelAgregarUsuario.Controls.Add(this.rBtnMedico);
            this.panelAgregarUsuario.Controls.Add(this.btnCancelarAgregarUsuario);
            this.panelAgregarUsuario.Controls.Add(this.btnConfirmarAgregarUsuario);
            this.panelAgregarUsuario.Controls.Add(this.label9);
            this.panelAgregarUsuario.Controls.Add(this.dtpFechaNac);
            this.panelAgregarUsuario.Controls.Add(this.txtConfirmar);
            this.panelAgregarUsuario.Controls.Add(this.txtPass);
            this.panelAgregarUsuario.Controls.Add(this.label7);
            this.panelAgregarUsuario.Controls.Add(this.label8);
            this.panelAgregarUsuario.Controls.Add(this.label5);
            this.panelAgregarUsuario.Controls.Add(this.label6);
            this.panelAgregarUsuario.Controls.Add(this.label4);
            this.panelAgregarUsuario.Controls.Add(this.label3);
            this.panelAgregarUsuario.Controls.Add(this.txtMail);
            this.panelAgregarUsuario.Controls.Add(this.txtUsername);
            this.panelAgregarUsuario.Controls.Add(this.txtApellido);
            this.panelAgregarUsuario.Controls.Add(this.txtNombre);
            this.panelAgregarUsuario.Location = new System.Drawing.Point(319, 149);
            this.panelAgregarUsuario.Name = "panelAgregarUsuario";
            this.panelAgregarUsuario.Size = new System.Drawing.Size(304, 421);
            this.panelAgregarUsuario.TabIndex = 1;
            this.panelAgregarUsuario.Visible = false;
            // 
            // rBtnTecnico
            // 
            this.rBtnTecnico.AutoSize = true;
            this.rBtnTecnico.Location = new System.Drawing.Point(122, 312);
            this.rBtnTecnico.Name = "rBtnTecnico";
            this.rBtnTecnico.Size = new System.Drawing.Size(64, 17);
            this.rBtnTecnico.TabIndex = 17;
            this.rBtnTecnico.TabStop = true;
            this.rBtnTecnico.Text = "Técnico";
            this.rBtnTecnico.UseVisualStyleBackColor = true;
            // 
            // rBtnDeportista
            // 
            this.rBtnDeportista.AutoSize = true;
            this.rBtnDeportista.Location = new System.Drawing.Point(211, 312);
            this.rBtnDeportista.Name = "rBtnDeportista";
            this.rBtnDeportista.Size = new System.Drawing.Size(73, 17);
            this.rBtnDeportista.TabIndex = 17;
            this.rBtnDeportista.TabStop = true;
            this.rBtnDeportista.Text = "Deportista";
            this.rBtnDeportista.UseVisualStyleBackColor = true;
            // 
            // rBtnMedico
            // 
            this.rBtnMedico.AutoSize = true;
            this.rBtnMedico.Location = new System.Drawing.Point(38, 312);
            this.rBtnMedico.Name = "rBtnMedico";
            this.rBtnMedico.Size = new System.Drawing.Size(60, 17);
            this.rBtnMedico.TabIndex = 16;
            this.rBtnMedico.TabStop = true;
            this.rBtnMedico.Text = "Medico";
            this.rBtnMedico.UseVisualStyleBackColor = true;
            this.rBtnMedico.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCancelarAgregarUsuario
            // 
            this.btnCancelarAgregarUsuario.Location = new System.Drawing.Point(111, 367);
            this.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario";
            this.btnCancelarAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregarUsuario.TabIndex = 15;
            this.btnCancelarAgregarUsuario.Text = "Cancelar";
            this.btnCancelarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarUsuario.Click += new System.EventHandler(this.btnCancelarAgregarUsuario_Click);
            // 
            // btnConfirmarAgregarUsuario
            // 
            this.btnConfirmarAgregarUsuario.Location = new System.Drawing.Point(212, 367);
            this.btnConfirmarAgregarUsuario.Name = "btnConfirmarAgregarUsuario";
            this.btnConfirmarAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarAgregarUsuario.TabIndex = 14;
            this.btnConfirmarAgregarUsuario.Text = "Agregar";
            this.btnConfirmarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnConfirmarAgregarUsuario.Click += new System.EventHandler(this.btnConfirmarAgregarUsuario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(165, 274);
            this.dtpFechaNac.MaxDate = new System.DateTime(2014, 11, 8, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaNac.TabIndex = 12;
            this.dtpFechaNac.Value = new System.DateTime(2014, 11, 8, 0, 0, 0, 0);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(125, 248);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmar.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(125, 222);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(162, 20);
            this.txtPass.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirmar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(125, 196);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(162, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 170);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(125, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(162, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelAgregarUsuario);
            this.Name = "VentanaInicio";
            this.Text = "Sport Facts";
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelAgregarUsuario.ResumeLayout(false);
            this.panelAgregarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Panel panelAgregarUsuario;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rBtnMedico;
        private System.Windows.Forms.Button btnCancelarAgregarUsuario;
        private System.Windows.Forms.Button btnConfirmarAgregarUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.RadioButton rBtnTecnico;
        private System.Windows.Forms.RadioButton rBtnDeportista;

    }
}

