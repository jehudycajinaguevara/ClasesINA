﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesINA.Formularios
{
    public partial class Constantes : MaterialForm
    {
        //VALORES CONSTANTES
        const double PI = 3.14;


        public Constantes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //acá vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue500, Primary.Blue700,
                    Primary.Blue500, Accent.LightBlue200,
                    TextShade.WHITE
                );
        }

        private void btnImprimirConstante_Click(object sender, EventArgs e)
        {
           
        }

        private void Constantes_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            lblValorConstante.Text = "" + PI;
        }
    }
}
