
namespace Clientes
{
    partial class FrmConsultaClientesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaClientesList));
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblVista = new System.Windows.Forms.Label();
            this.LstClientes = new System.Windows.Forms.ListView();
            this.ClmNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmComentarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbCiudad = new System.Windows.Forms.ComboBox();
            this.CbVista = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PctFoto
            // 
            this.PctFoto.Image = global::Clientes.Properties.Resources.mountain_bike_sport_icon_123970;
            this.PctFoto.Location = new System.Drawing.Point(52, 41);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(84, 81);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 0;
            this.PctFoto.TabStop = false;
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCiudad.Location = new System.Drawing.Point(210, 60);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(52, 17);
            this.LblCiudad.TabIndex = 1;
            this.LblCiudad.Text = "Ciudad";
            // 
            // LblVista
            // 
            this.LblVista.AutoSize = true;
            this.LblVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblVista.Location = new System.Drawing.Point(575, 60);
            this.LblVista.Name = "LblVista";
            this.LblVista.Size = new System.Drawing.Size(39, 17);
            this.LblVista.TabIndex = 2;
            this.LblVista.Text = "Vista";
            // 
            // LstClientes
            // 
            this.LstClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmNombre,
            this.ClmApellidos,
            this.ClmEmail,
            this.ClmComentarios});
            this.LstClientes.HideSelection = false;
            this.LstClientes.LargeImageList = this.imageList2;
            this.LstClientes.Location = new System.Drawing.Point(33, 162);
            this.LstClientes.Name = "LstClientes";
            this.LstClientes.Size = new System.Drawing.Size(683, 223);
            this.LstClientes.SmallImageList = this.imageList1;
            this.LstClientes.TabIndex = 3;
            this.LstClientes.UseCompatibleStateImageBehavior = false;
            this.LstClientes.View = System.Windows.Forms.View.Details;
            // 
            // ClmNombre
            // 
            this.ClmNombre.Text = "Nombre";
            this.ClmNombre.Width = 120;
            // 
            // ClmApellidos
            // 
            this.ClmApellidos.Text = "Apellidos";
            this.ClmApellidos.Width = 220;
            // 
            // ClmEmail
            // 
            this.ClmEmail.Text = "Email";
            this.ClmEmail.Width = 200;
            // 
            // ClmComentarios
            // 
            this.ClmComentarios.Text = "Comentarios";
            this.ClmComentarios.Width = 600;
            // 
            // CbCiudad
            // 
            this.CbCiudad.FormattingEnabled = true;
            this.CbCiudad.Location = new System.Drawing.Point(213, 101);
            this.CbCiudad.Name = "CbCiudad";
            this.CbCiudad.Size = new System.Drawing.Size(241, 21);
            this.CbCiudad.TabIndex = 4;
            this.CbCiudad.DropDown += new System.EventHandler(this.CbCiudad_DropDown);
            this.CbCiudad.SelectedIndexChanged += new System.EventHandler(this.CbCiudad_SelectedIndexChanged);
            // 
            // CbVista
            // 
            this.CbVista.FormattingEnabled = true;
            this.CbVista.Location = new System.Drawing.Point(578, 101);
            this.CbVista.Name = "CbVista";
            this.CbVista.Size = new System.Drawing.Size(138, 21);
            this.CbVista.TabIndex = 5;
            this.CbVista.DropDown += new System.EventHandler(this.CbVista_DropDown);
            this.CbVista.SelectedIndexChanged += new System.EventHandler(this.CbVista_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "msn.ico");
            this.imageList1.Images.SetKeyName(1, "star_favourite_21830.ico");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "msn.ico");
            this.imageList2.Images.SetKeyName(1, "star_favourite_21830.ico");
            // 
            // FrmConsultaClientesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.CbVista);
            this.Controls.Add(this.CbCiudad);
            this.Controls.Add(this.LstClientes);
            this.Controls.Add(this.LblVista);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.PctFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaClientesList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblVista;
        private System.Windows.Forms.ListView LstClientes;
        private System.Windows.Forms.ColumnHeader ClmNombre;
        private System.Windows.Forms.ColumnHeader ClmApellidos;
        private System.Windows.Forms.ColumnHeader ClmEmail;
        private System.Windows.Forms.ColumnHeader ClmComentarios;
        private System.Windows.Forms.ComboBox CbCiudad;
        private System.Windows.Forms.ComboBox CbVista;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}