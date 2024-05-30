namespace ExamenFinalProgramaciónIKraven.Data.Models.Validacion_de_datos_CRUD
{
    partial class Insertar
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
            this.labelMensajeInsertar = new System.Windows.Forms.Label();
            this.buttonNelPastel = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMensajeInsertar
            // 
            this.labelMensajeInsertar.AutoSize = true;
            this.labelMensajeInsertar.Location = new System.Drawing.Point(12, 9);
            this.labelMensajeInsertar.Name = "labelMensajeInsertar";
            this.labelMensajeInsertar.Size = new System.Drawing.Size(292, 16);
            this.labelMensajeInsertar.TabIndex = 27;
            this.labelMensajeInsertar.Text = "Seguro que quieres insertar un nuevo producto?";
            // 
            // buttonNelPastel
            // 
            this.buttonNelPastel.Location = new System.Drawing.Point(153, 46);
            this.buttonNelPastel.Name = "buttonNelPastel";
            this.buttonNelPastel.Size = new System.Drawing.Size(85, 31);
            this.buttonNelPastel.TabIndex = 26;
            this.buttonNelPastel.Text = "Nel pastel";
            this.buttonNelPastel.UseVisualStyleBackColor = true;
            this.buttonNelPastel.Click += new System.EventHandler(this.buttonNelPastel_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(72, 46);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 31);
            this.buttonInsertar.TabIndex = 28;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 89);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.labelMensajeInsertar);
            this.Controls.Add(this.buttonNelPastel);
            this.Name = "Insertar";
            this.Text = "Insertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensajeInsertar;
        private System.Windows.Forms.Button buttonNelPastel;
        private System.Windows.Forms.Button buttonInsertar;
    }
}