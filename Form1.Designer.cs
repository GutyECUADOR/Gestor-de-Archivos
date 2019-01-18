namespace Gestor_de_Archivos
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
            this.list_archivos = new System.Windows.Forms.ListView();
            this.lbl_currentPath = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_fileContents = new System.Windows.Forms.TextBox();
            this.picture_imageContents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_imageContents)).BeginInit();
            this.SuspendLayout();
            // 
            // list_archivos
            // 
            this.list_archivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.list_archivos.FullRowSelect = true;
            this.list_archivos.Location = new System.Drawing.Point(12, 45);
            this.list_archivos.Name = "list_archivos";
            this.list_archivos.Size = new System.Drawing.Size(309, 223);
            this.list_archivos.TabIndex = 0;
            this.list_archivos.UseCompatibleStateImageBehavior = false;
            this.list_archivos.View = System.Windows.Forms.View.Details;
            this.list_archivos.DoubleClick += new System.EventHandler(this.list_archivos_DoubleClick);
            // 
            // lbl_currentPath
            // 
            this.lbl_currentPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_currentPath.Location = new System.Drawing.Point(12, 9);
            this.lbl_currentPath.Name = "lbl_currentPath";
            this.lbl_currentPath.Size = new System.Drawing.Size(516, 23);
            this.lbl_currentPath.TabIndex = 1;
            this.lbl_currentPath.Text = "label1";
            this.lbl_currentPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 461;
            // 
            // txt_fileContents
            // 
            this.txt_fileContents.Location = new System.Drawing.Point(328, 45);
            this.txt_fileContents.Multiline = true;
            this.txt_fileContents.Name = "txt_fileContents";
            this.txt_fileContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_fileContents.Size = new System.Drawing.Size(309, 223);
            this.txt_fileContents.TabIndex = 2;
            this.txt_fileContents.Visible = false;
            // 
            // picture_imageContents
            // 
            this.picture_imageContents.Location = new System.Drawing.Point(328, 45);
            this.picture_imageContents.Name = "picture_imageContents";
            this.picture_imageContents.Size = new System.Drawing.Size(309, 223);
            this.picture_imageContents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_imageContents.TabIndex = 3;
            this.picture_imageContents.TabStop = false;
            this.picture_imageContents.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 311);
            this.Controls.Add(this.picture_imageContents);
            this.Controls.Add(this.txt_fileContents);
            this.Controls.Add(this.lbl_currentPath);
            this.Controls.Add(this.list_archivos);
            this.Name = "Form1";
            this.Text = "Gestor de Archivos";
            ((System.ComponentModel.ISupportInitialize)(this.picture_imageContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_archivos;
        private System.Windows.Forms.Label lbl_currentPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txt_fileContents;
        private System.Windows.Forms.PictureBox picture_imageContents;
    }
}

