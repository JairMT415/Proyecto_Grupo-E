﻿using ProyectoCamioncitos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCamioncitos.Vista.Conductor
{
    public partial class ChoferCrudView : Form
    {
        public ChoferCrudView()
        {
            InitializeComponent();
            //Vista a Controlador
            ChoferCrudController ctrl = new ChoferCrudController(this);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gbClienteDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
