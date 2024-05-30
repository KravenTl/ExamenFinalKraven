namespace ExamenFinalProgramaciónIKraven.Data.Models.Validacion_de_datos_CRUD
{
    partial class Eliminar
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
            this.labelMensajeEliminar = new System.Windows.Forms.Label();
            this.buttonNelPastel = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMensajeEliminar
            // 
            this.labelMensajeEliminar.AutoSize = true;
            this.labelMensajeEliminar.Location = new System.Drawing.Point(12, 9);
            this.labelMensajeEliminar.Name = "labelMensajeEliminar";
            this.labelMensajeEliminar.Size = new System.Drawing.Size(255, 16);
            this.labelMensajeEliminar.TabIndex = 30;
            this.labelMensajeEliminar.Text = "Seguro que quieres eliminar un producto?";
            // 
            // buttonNelPastel
            // 
            this.buttonNelPastel.Location = new System.Drawing.Point(130, 49);
            this.buttonNelPastel.Name = "buttonNelPastel";
            this.buttonNelPastel.Size = new System.Drawing.Size(85, 31);
            this.buttonNelPastel.TabIndex = 29;
            this.buttonNelPastel.Text = "Nel pastel";
            this.buttonNelPastel.UseVisualStyleBackColor = true;
            this.buttonNelPastel.Click += new System.EventHandler(this.buttonNelPastel_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(49, 49);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 31);
            this.buttonEliminar.TabIndex = 31;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 121);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelMensajeEliminar);
            this.Controls.Add(this.buttonNelPastel);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMensajeEliminar;
        private System.Windows.Forms.Button buttonNelPastel;
        private System.Windows.Forms.Button buttonEliminar;
    }
}