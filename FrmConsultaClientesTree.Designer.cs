
namespace Clientes
{
    partial class FrmConsultaClientesTree
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaClientesTree));
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.TreClientes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtComentarios = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblComentarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PctFoto
            // 
            this.PctFoto.Location = new System.Drawing.Point(523, 12);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(110, 143);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 0;
            this.PctFoto.TabStop = false;
            // 
            // TreClientes
            // 
            this.TreClientes.ImageIndex = 0;
            this.TreClientes.ImageList = this.imageList1;
            this.TreClientes.Location = new System.Drawing.Point(68, 161);
            this.TreClientes.Name = "TreClientes";
            this.TreClientes.SelectedImageIndex = 0;
            this.TreClientes.Size = new System.Drawing.Size(261, 239);
            this.TreClientes.TabIndex = 1;
            this.TreClientes.DoubleClick += new System.EventHandler(this.TrvClientes_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tierra.ico");
            this.imageList1.Images.SetKeyName(1, "estrella.ico");
            this.imageList1.Images.SetKeyName(2, "msn.ico");
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(473, 161);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(209, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(473, 202);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(209, 20);
            this.TxtApellidos.TabIndex = 3;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(473, 242);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(209, 20);
            this.TxtCiudad.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(473, 282);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(209, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtComentarios
            // 
            this.TxtComentarios.Location = new System.Drawing.Point(473, 321);
            this.TxtComentarios.Multiline = true;
            this.TxtComentarios.Name = "TxtComentarios";
            this.TxtComentarios.Size = new System.Drawing.Size(209, 77);
            this.TxtComentarios.TabIndex = 6;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblNombre.Location = new System.Drawing.Point(376, 161);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 7;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblApellidos.Location = new System.Drawing.Point(376, 202);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(65, 17);
            this.LblApellidos.TabIndex = 8;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCiudad.Location = new System.Drawing.Point(376, 242);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(52, 17);
            this.LblCiudad.TabIndex = 9;
            this.LblCiudad.Text = "Ciudad";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblEmail.Location = new System.Drawing.Point(376, 282);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 17);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Email";
            // 
            // LblComentarios
            // 
            this.LblComentarios.AutoSize = true;
            this.LblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblComentarios.Location = new System.Drawing.Point(376, 321);
            this.LblComentarios.Name = "LblComentarios";
            this.LblComentarios.Size = new System.Drawing.Size(87, 17);
            this.LblComentarios.TabIndex = 11;
            this.LblComentarios.Text = "Comentarios";
            // 
            // FrmConsultaClientesTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.LblComentarios);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtComentarios);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TreClientes);
            this.Controls.Add(this.PctFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaClientesTree";
            this.Text = "Tree";
            this.Activated += new System.EventHandler(this.FrmConsultaClientesTree_Load);
            this.Load += new System.EventHandler(this.FrmConsultaClientesTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.TreeView TreClientes;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtComentarios;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblComentarios;
        private System.Windows.Forms.ImageList imageList1;
    }
}