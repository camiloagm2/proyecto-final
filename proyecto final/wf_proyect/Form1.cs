using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_proyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            estudante est1 = new estudante();
            est1.nombre = "Camilo";
            est1.Estado = "Activo";
            est1.blestudio = "III ciclo - Ingenieria informatica";
            est1.blnombre = "Gutièrrez Mansilla Camilo Alfonso";
            est1.blnacimiento = "16/02/1979";
            est1.blvalidez = "valido hasta el 31/01/2019";
         


            estudante est2 = new estudante();
            est2.nombre = "José";
            est2.Estado = "Inactivo";
            est2.blestudio = "II ciclo - Ingenieria de Redes";
            est2.blnombre = "Gutièrrez Mansilla Jose ";
            est2.blnacimiento = "16/02/1979";
            est2.blvalidez = "valido hasta el 31/01/2019";

            estudante est3 = new estudante();
            est3.nombre = "Siguas";
            est3.Estado = "Activo";
            est3.blestudio = "III ciclo - Ingenieria informatica";
            est3.blnombre = "Gutièrrez Mansilla Camilo Alfonso";
            est3.blnacimiento = "16/02/1979";
            est3.blvalidez = "valido hasta el 31/01/2019";

            estudante est4 = new estudante();
            est4.nombre = "Orly";
            est4.Estado = "Inactivo";
            est4.blestudio = "III ciclo - Ingenieria informatica";
            est4.blnombre = "Gutièrrez Mansilla Camilo Alfonso";
            est4.blnacimiento = "16/02/1979";
            est4.blvalidez = "valido hasta el 31/01/2019";

            List<estudante> list1 = new List<estudante>();
            list1.Add(est1);
            list1.Add(est2);
            list1.Add(est3);
            list1.Add(est4);

            cbxEstudiante.DataSource = list1;
            cbxEstudiante.DisplayMember = "nombre" ;


        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

            string estudiante;
            estudiante = (cbxEstudiante.SelectedItem as estudante).Estado;
            lblResultado.Text = estudiante;

        }

        private void cbxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estu;
            estu = (cbxEstudiante.SelectedItem as estudante).blestudio;
            lbl_Estudio.Text = estu;

            string nomb;
            nomb = (cbxEstudiante.SelectedItem as estudante).blnombre;
            lbl_nombre.Text = nomb;

            string nacim;
            nacim = (cbxEstudiante.SelectedItem as estudante).blnacimiento;
            lbl_nacimiento.Text = nacim;

            string val;
            val = (cbxEstudiante.SelectedItem as estudante).blvalidez;
            lbl_validez.Text = val;

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Estudio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkfoto_Click(object sender, EventArgs e)
        {

        }
    }
}
