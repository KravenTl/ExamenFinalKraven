﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalProgramaciónIKraven.Data.Models.Validacion_de_datos_CRUD
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            Close();
        }

        private void buttonNelPastel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
