﻿using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADONET2023
{
    public partial class NuevaRegion : Form
    {
        public NuevaRegion()
        {
            InitializeComponent();
        }

        private void Grabar_Click(object sender, EventArgs e)
        {

            try
            {
                BProducto negocio = new BProducto();
                negocio.Insertar(new Entidad.Producto
                {
                    Nombre = txtCode.Text,
                    Precio = txtDescription.Text,
                });
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
