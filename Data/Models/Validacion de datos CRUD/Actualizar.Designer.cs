namespace ExamenFinalProgramaciónIKraven.Data.Models.Validacion_de_datos_CRUD
{
    partial class Actualizar
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
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonNelPastel = new System.Windows.Forms.Button();
            this.labelMensajeActualizar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(15, 49);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(85, 31);
            this.buttonActualizar.TabIndex = 22;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonNelPastel
            // 
            this.buttonNelPastel.Location = new System.Drawing.Point(106, 49);
            this.buttonNelPastel.Name = "buttonNelPastel";
            this.buttonNelPastel.Size = new System.Drawing.Size(85, 31);
            this.buttonNelPastel.TabIndex = 23;
            this.buttonNelPastel.Text = "Nel pastel";
            this.buttonNelPastel.UseVisualStyleBackColor = true;
            this.buttonNelPastel.Click += new System.EventHandler(this.buttonNelPastel_Click);
            // 
            // labelMensajeActualizar
            // 
            this.labelMensajeActualizar.AutoSize = true;
            this.labelMensajeActualizar.Location = new System.Drawing.Point(12, 9);
            this.labelMensajeActualizar.Name = "labelMensajeActualizar";
            this.labelMensajeActualizar.Size = new System.Drawing.Size(192, 16);
            this.labelMensajeActualizar.TabIndex = 24;
            this.labelMensajeActualizar.Text = "Seguro que quieres actualizar?";
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 89);
            this.Controls.Add(this.labelMensajeActualizar);
            this.Controls.Add(this.buttonNelPastel);
            this.Controls.Add(this.buttonActualizar);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonNelPastel;
        private System.Windows.Forms.Label labelMensajeActualizar;
    }
}