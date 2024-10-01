using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BE;
using BLL;
using TP_2___FInal.Clases.clsTareas;

namespace TP_2___FInal
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
            oBEEquipo = new BEEquipo();
            oBLLEquipo = new BLLEquipo();
            oBEPrueba = new BEPrueba();
            oBLLPrueba = new BLLPrueba();
            oBEDesa = new BEDesarrollo(String.Empty);
            oBLLDesa = new BLLDesarrollo();
            oBETarea = new BETarea();
            oBLLTarea = new BLLTarea();
            oBEProyecto = new BEProyecto();
            oBLLProyecto = new BLLProyecto();
        }

        BEEquipo oBEEquipo;
        BLLEquipo oBLLEquipo;
        BEPrueba oBEPrueba;
        BLLPrueba oBLLPrueba;
        BEDesarrollo oBEDesa;
        BLLDesarrollo oBLLDesa;
        BETarea oBETarea;
        BLLTarea oBLLTarea;
        BEProyecto oBEProyecto;
        BLLProyecto oBLLProyecto;

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEEquipo> ListaEquipo = new List<BEEquipo>();
                ListaEquipo = oBLLEquipo.ListarTodo();
                
                lblTotal.Text = ListaEquipo.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<BETarea> ListaTareas = new List<BETarea>();
                ListaTareas = oBLLTarea.ListarTodo();

                List<BEPrueba> ListaPrueba = new List<BEPrueba>();
                ListaPrueba = oBLLPrueba.ListarTodo();

                List<BEDesarrollo> ListaDesa = new List<BEDesarrollo>();
                ListaDesa = oBLLDesa.ListarTodo();

                lblTotal.Text = "Pruebas: " + ListaPrueba.Count.ToString() + " Desarrollo: " + ListaDesa.Count.ToString() + " Total: " + ListaTareas.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEProyecto>ListaProyecto = new List<BEProyecto>();
                ListaProyecto = oBLLProyecto.ListarTodo();
                lblTotal.Text = ListaProyecto.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }
    }
}
