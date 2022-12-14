using System;
using System.Data;
using System.Data.SqlClient;
using DAL_CapaDato;
using BLL_CapaNegocio;

namespace UI_CapaPresentacion
{
    public partial class FrmIniciarsesion : Form
    {
        private Label labusuario;
        private Button btniniciar;
        private Button btncancelar;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label label2;
        private Button btnRegistar;
        private Button button2;
        public Label mensajeerror;
        private PictureBox pictureBox1;
        private Label label1;
        Usuario usuario = new Usuario();

        public FrmIniciarsesion()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarsesion));
            this.labusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mensajeerror = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labusuario
            // 
            this.labusuario.AutoSize = true;
            this.labusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labusuario.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labusuario.ForeColor = System.Drawing.Color.White;
            this.labusuario.Location = new System.Drawing.Point(303, 55);
            this.labusuario.Name = "labusuario";
            this.labusuario.Size = new System.Drawing.Size(124, 28);
            this.labusuario.TabIndex = 0;
            this.labusuario.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(305, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btniniciar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btniniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btniniciar.Location = new System.Drawing.Point(303, 281);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(163, 52);
            this.btniniciar.TabIndex = 2;
            this.btniniciar.Text = "Iniciar Sesi?n";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btncancelar.Location = new System.Drawing.Point(560, 281);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(166, 52);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(466, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(195, 23);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(464, 129);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(197, 23);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "?A?n no tienes una cuenta?";
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegistar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistar.Location = new System.Drawing.Point(34, 281);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(163, 52);
            this.btnRegistar.TabIndex = 8;
            this.btnRegistar.Text = "Registrate";
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(8, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "PROBAR NAVEGAVILIDAD EN CLIENTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mensajeerror
            // 
            this.mensajeerror.AccessibleName = "lblerrormensaje";
            this.mensajeerror.AutoSize = true;
            this.mensajeerror.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensajeerror.ForeColor = System.Drawing.Color.Black;
            this.mensajeerror.Location = new System.Drawing.Point(303, 230);
            this.mensajeerror.Name = "mensajeerror";
            this.mensajeerror.Size = new System.Drawing.Size(120, 23);
            this.mensajeerror.TabIndex = 10;
            this.mensajeerror.Text = "Mensaje Error";
            this.mensajeerror.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 111);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIniciarsesion
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(773, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mensajeerror);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labusuario);
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Name = "FrmIniciarsesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btniniciar_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "")
            { if (txtPass.Text != "")
                {
                    var validalogin = usuario.Login(txtUsername.Text, txtPass.Text);
                    if (validalogin == true)
                    {
                        string tipoUsuario = usuario.VerificarUsuario(txtUsername.Text);
                        if (tipoUsuario == null) { 
                        FrmCliente cliente = new FrmCliente();
                        cliente.Show(); 
                        }
                    else
                    {
                        if (tipoUsuario == "Gerente") {
                                FrmGerente gerente = new FrmGerente();
                                gerente.Show();
                            }
                            
                        else if (tipoUsuario == "Administrador") { 
                                FrmAdmin admin = new FrmAdmin();
                                admin.Show();
                            }
                        else if (tipoUsuario == "Encargado de inventario y stock") {
                                Frmencargadoinventario inv = new Frmencargadoinventario();
                                inv.Show();
                            }
                    }
                        
                        this.Hide();
                    }else
                    {
                        msgerror("Incorrecto usuario o contrase?a \n\n");
                        txtPass.Clear();
                        txtUsername.Focus();
                    }


                }
                else msgerror("Ingrese su contrase?a por favor!!\n\n");
            
            }
            else msgerror("Ingrese su usuario por favor!!\n\n");


        }
        private void msgerror(string mensaje)
        {
            mensajeerror.Text = "" + mensaje;
            mensajeerror.Visible = true;
        }
            
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar();
            this.Hide();
            registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }

     
    }
}