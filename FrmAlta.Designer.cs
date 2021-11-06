
namespace Clientes
{
    partial class FrmAlta
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
            this.LstClientes = new System.Windows.Forms.ListBox();
            this.LblClientes = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.ChkVip = new System.Windows.Forms.CheckBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblComentario = new System.Windows.Forms.Label();
            this.LblVip = new System.Windows.Forms.Label();
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LstClientes
            // 
            this.LstClientes.FormattingEnabled = true;
            this.LstClientes.Location = new System.Drawing.Point(17, 110);
            this.LstClientes.Name = "LstClientes";
            this.LstClientes.Size = new System.Drawing.Size(250, 264);
            this.LstClientes.TabIndex = 3;
            this.LstClientes.Click += new System.EventHandler(this.LstClientes_Click);
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.LblClientes.Location = new System.Drawing.Point(12, 81);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(91, 26);
            this.LblClientes.TabIndex = 4;
            this.LblClientes.Text = "Clientes";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(406, 139);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(284, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(406, 184);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(284, 20);
            this.TxtApellidos.TabIndex = 7;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(406, 224);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(284, 20);
            this.TxtCiudad.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(406, 269);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(284, 20);
            this.TxtEmail.TabIndex = 9;
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(406, 307);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(284, 68);
            this.TxtComentario.TabIndex = 10;
            // 
            // ChkVip
            // 
            this.ChkVip.AutoSize = true;
            this.ChkVip.Location = new System.Drawing.Point(406, 383);
            this.ChkVip.Name = "ChkVip";
            this.ChkVip.Size = new System.Drawing.Size(15, 14);
            this.ChkVip.TabIndex = 11;
            this.ChkVip.UseVisualStyleBackColor = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblNombre.Location = new System.Drawing.Point(294, 139);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 12;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblApellidos.Location = new System.Drawing.Point(294, 184);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(65, 17);
            this.LblApellidos.TabIndex = 13;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCiudad.Location = new System.Drawing.Point(294, 227);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(52, 17);
            this.LblCiudad.TabIndex = 14;
            this.LblCiudad.Text = "Ciudad";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblEmail.Location = new System.Drawing.Point(294, 269);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(42, 17);
            this.LblEmail.TabIndex = 15;
            this.LblEmail.Text = "Email";
            // 
            // LblComentario
            // 
            this.LblComentario.AutoSize = true;
            this.LblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblComentario.Location = new System.Drawing.Point(294, 307);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(80, 17);
            this.LblComentario.TabIndex = 16;
            this.LblComentario.Text = "Comentario";
            // 
            // LblVip
            // 
            this.LblVip.AutoSize = true;
            this.LblVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblVip.Location = new System.Drawing.Point(294, 380);
            this.LblVip.Name = "LblVip";
            this.LblVip.Size = new System.Drawing.Size(29, 17);
            this.LblVip.TabIndex = 17;
            this.LblVip.Text = "VIP";
            // 
            // PctFoto
            // 
            this.PctFoto.Location = new System.Drawing.Point(501, 12);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(94, 114);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 5;
            this.PctFoto.TabStop = false;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.BtnBorrar.Image = global::Clientes.Properties.Resources.delete_unapprove_discard_remove_x_red_icon_icons_com_55984;
            this.BtnBorrar.Location = new System.Drawing.Point(118, 12);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(47, 50);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.BtnGuardar.Image = global::Clientes.Properties.Resources.savedisk_floppydisk_guardar_1543;
            this.BtnGuardar.Location = new System.Drawing.Point(65, 12);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(47, 50);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.BtnNuevo.Image = global::Clientes.Properties.Resources.star_favourite_21830;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 12);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(47, 50);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.Location = new System.Drawing.Point(318, 39);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(75, 23);
            this.BtnCargarFoto.TabIndex = 18;
            this.BtnCargarFoto.Text = "Cargar Foto";
            this.BtnCargarFoto.UseVisualStyleBackColor = true;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.LblVip);
            this.Controls.Add(this.LblComentario);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.ChkVip);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.PctFoto);
            this.Controls.Add(this.LblClientes);
            this.Controls.Add(this.LstClientes);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.ListBox LstClientes;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.CheckBox ChkVip;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblComentario;
        private System.Windows.Forms.Label LblVip;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}