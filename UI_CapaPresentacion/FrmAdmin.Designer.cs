namespace UI_CapaPresentacion
{
    partial class FrmAdmin
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btncrearusuario = new System.Windows.Forms.Button();
            this.btnmodificarusuario = new System.Windows.Forms.Button();
            this.btninhabilitarusuario = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(989, 671);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(859, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(85, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(459, 114);
            this.button4.TabIndex = 7;
            this.button4.Text = "Perfil Administrador";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btncrearusuario
            // 
            this.btncrearusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncrearusuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncrearusuario.ForeColor = System.Drawing.Color.White;
            this.btncrearusuario.Location = new System.Drawing.Point(33, 221);
            this.btncrearusuario.Name = "btncrearusuario";
            this.btncrearusuario.Size = new System.Drawing.Size(129, 57);
            this.btncrearusuario.TabIndex = 10;
            this.btncrearusuario.Text = "Crear usuario";
            this.btncrearusuario.UseVisualStyleBackColor = false;
            this.btncrearusuario.Click += new System.EventHandler(this.btncrearusuario_Click);
            // 
            // btnmodificarusuario
            // 
            this.btnmodificarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmodificarusuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmodificarusuario.ForeColor = System.Drawing.Color.White;
            this.btnmodificarusuario.Location = new System.Drawing.Point(186, 222);
            this.btnmodificarusuario.Name = "btnmodificarusuario";
            this.btnmodificarusuario.Size = new System.Drawing.Size(132, 56);
            this.btnmodificarusuario.TabIndex = 11;
            this.btnmodificarusuario.Text = "Modificar usuario";
            this.btnmodificarusuario.UseVisualStyleBackColor = false;
            this.btnmodificarusuario.Click += new System.EventHandler(this.btnmodificarusuario_Click);
            // 
            // btninhabilitarusuario
            // 
            this.btninhabilitarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btninhabilitarusuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninhabilitarusuario.ForeColor = System.Drawing.Color.White;
            this.btninhabilitarusuario.Location = new System.Drawing.Point(345, 222);
            this.btninhabilitarusuario.Name = "btninhabilitarusuario";
            this.btninhabilitarusuario.Size = new System.Drawing.Size(129, 56);
            this.btninhabilitarusuario.TabIndex = 12;
            this.btninhabilitarusuario.Text = "Inhabilitar usuario";
            this.btninhabilitarusuario.UseVisualStyleBackColor = false;
            this.btninhabilitarusuario.Click += new System.EventHandler(this.btninhabilitarusuario_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnvolver.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvolver.ForeColor = System.Drawing.Color.White;
            this.btnvolver.Location = new System.Drawing.Point(502, 222);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(142, 54);
            this.btnvolver.TabIndex = 13;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(698, 318);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btninhabilitarusuario);
            this.Controls.Add(this.btnmodificarusuario);
            this.Controls.Add(this.btncrearusuario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button4;
        private Button btncrearusuario;
        private Button btnmodificarusuario;
        private Button btninhabilitarusuario;
        private Button btnvolver;
    }
}