using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using TP_2___FInal.Clases.clsTareas;

namespace TP_2___FInal
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();

            oBLLEquipo = new BLLEquipo();
            oBEEquipo = new BEEquipo();
            oBEPrueba = new BEPrueba();
            oBLLPrueba = new BLLPrueba();
            oBEProyecto = new BEProyecto();
            oBLLProyecto = new BLLProyecto();
            oBLLDesa = new BLLDesarrollo();
            oBEDesa = new BEDesarrollo(string.Empty);

            oBLLTarea = new BLLTarea();
        }

        BETarea oBETarea;
        BLLTarea oBLLTarea;
        BEEquipo oBEEquipo;
        BLLEquipo oBLLEquipo;
        BLLPrueba oBLLPrueba;
        BEPrueba oBEPrueba;
        BEProyecto oBEProyecto;
        BLLProyecto oBLLProyecto;
        BLLDesarrollo oBLLDesa;
        BEDesarrollo oBEDesa;


        public static List<BEEquipo> LEquipo;
        public static List<BETarea> LTareas = new List<BETarea> { };
        public static List<BEProyecto> LProyecto = new List<BEProyecto> { };

        private void frmSistema_Load(object sender, EventArgs e)
        {
            refreshCombo();
            refreshDatagridEquipo();
            refreshDataGridProyecto();
            refreshDatagridTarea();


        }

        void limpiarTextBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
        }

        #region REFRESH Combo/DataGridView
        private void refreshCombo()
        {
            this.comboCategoria.DataSource = null;
            this.comboCategoria.DataSource = Enum.GetValues(typeof(BEEnum.Categorias));
        }

        private void refreshDatagridTarea()
        {
            dataGridView1.DataSource = null;

            dataGridView1.Refresh();

            dataGridView1.DataSource = oBLLTarea.ListarTodo();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dataGridView1.Refresh();

        }

        private void refreshDatagridEquipo()
        {
            dataGridViewEquipos.DataSource = null;

            dataGridViewEquipos.DataSource = oBLLEquipo.ListarTodo();

            dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewEquipos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void refreshDataGridProyecto()
        {
            dataGridViewProyecto.DataSource = null;

            dataGridViewProyecto.DataSource = oBLLProyecto.ListarTodo();

            dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewEquipos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEquipos.SelectedRows.Count > 0)
                {
                    oBEEquipo = (BEEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;

                    if (comboCategoria.Text == "Prueba")
                    {
                        BEPrueba oBEPrueba = new BEPrueba();
                        BLLPrueba oBLLPrueba = new BLLPrueba();

                        oBEPrueba.nombre = txtTareaNombre.Text;
                        oBEPrueba.Valor = Convert.ToDouble(txtTareaValor.Text);
                        oBEPrueba.fechafinalizacion = dateTimePicker1.Value.ToString();


                        if (oBLLPrueba.Guardar(oBEPrueba))
                        {
                            oBLLPrueba.GuardarTareaEquipo(oBEPrueba, oBEEquipo);
                        }

                        refreshDatagridTarea();


                    }
                    else
                    {
                        BEDesarrollo oBEDesa = new BEDesarrollo(txtDescDesa.Text);
                        BLLDesarrollo oBLLDesa = new BLLDesarrollo();

                        oBEDesa.nombre = txtTareaNombre.Text;
                        oBEDesa.Valor = Convert.ToDouble(txtTareaValor.Text);



                        if (oBLLDesa.Guardar(oBEDesa))
                        {
                            oBLLDesa.GuardarTareaEquipo(oBEDesa, oBEEquipo);
                        }

                        refreshDatagridTarea();
                    }
                    refreshDatagridEquipo();
                }
                else
                {
                    MessageBox.Show("Seleccione un equipo para agregar la tarea.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            oBEEquipo = new BEEquipo();
            oBLLEquipo = new BLLEquipo();
            try
            {
                if (txtNombreEquipo.Text != string.Empty)
                {

                    oBEEquipo.Nombre = txtNombreEquipo.Text;

                    oBEEquipo.Estado = "Iniciada";

                    oBLLEquipo.Guardar(oBEEquipo);



                    refreshDatagridEquipo();



                    BEEquipo.CantEquipos++;

                    limpiarTextBox(txtNombreEquipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void dataGridViewEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            if (dataGridViewEquipos.CurrentRow != null)
            {
                oBEEquipo = (BEEquipo)this.dataGridViewEquipos.CurrentRow.DataBoundItem;


                if (oBEEquipo != null && oBEEquipo.ListaTareas != null)
                {
                    dataGridView1.DataSource = null;

                    dataGridView1.DataSource = oBEEquipo.ListaTareas;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {

                    dataGridView1.DataSource = null;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }





        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                oBETarea = (BETarea)dataGridView1.CurrentRow.DataBoundItem;

                DialogResult Respuesta = MessageBox.Show("Desea modificar la tarea?", "Modificar", MessageBoxButtons.OKCancel);

                if (Respuesta == DialogResult.OK)
                {
                    BETarea oBETareaAModif = new BETarea();
                    oBETareaAModif.codigo = oBETarea.codigo;
                    oBETareaAModif.nombre = txtTareaNombre.Text;
                    oBETareaAModif.Valor = Convert.ToDouble(txtTareaValor.Text);

                    oBLLTarea.Guardar(oBETareaAModif);

                    refreshDatagridTarea();
                    refreshDatagridEquipo();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error", "Error");
            }



        }

        private void btnBorrarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                oBETarea = (BETarea)dataGridView1.CurrentRow.DataBoundItem;
                oBEEquipo = (BEEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;

                DialogResult Respuesta;

                Respuesta = MessageBox.Show("Esta seguro de eliminar la tarea?", "Borrar", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    oBLLTarea.Baja(oBETarea);

                    refreshDatagridEquipo();
                    refreshDatagridTarea();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void lblCate_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if ((BETarea)dataGridView1.CurrentRow.DataBoundItem is BEDesarrollo)
                {
                    BEDesarrollo oTarea = (BEDesarrollo)dataGridView1.CurrentRow.DataBoundItem;
                    lblCate.Text = "Desarrollo";
                    lblespecial.Text = oTarea.Desc.ToString();


                }
                else
                {
                    BEPrueba oTarea = (BEPrueba)dataGridView1.CurrentRow.DataBoundItem;
                    lblCate.Text = "Prueba";
                    lblespecial.Text = oTarea.fechafinalizacion.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                oBEEquipo = new BEEquipo();
                oBLLEquipo = new BLLEquipo();

                BEEquipo EquipoSelec = (BEEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;
                DialogResult Respuesta;

                Respuesta = MessageBox.Show("Quiere borrar el equipo?", "Borrar", MessageBoxButtons.YesNo);
                if (Respuesta == DialogResult.Yes)
                {
                    if (EquipoSelec.Estado == "Iniciada") {
                        oBLLEquipo.Baja(EquipoSelec);



                        refreshDatagridEquipo();



                        limpiarTextBox(txtNombreEquipo);
                    }
                    else
                    {
                        MessageBox.Show("El equipo esta asociado a un proyecto, finalize el proyecto.");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (oBEEquipo != (BEEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem)
                {
                    MessageBox.Show("Seleccione un equipo.");
                }
                else if (oBEEquipo.Estado == "Asociado")
                {
                    MessageBox.Show(oBEEquipo.Nombre + " ya esta asociado a un proyecto.");
                }
                else
                {
                    BEProyecto oBEPro = new BEProyecto();
                    BLLProyecto oBLLPro = new BLLProyecto();

                    oBEPro.Nombre = txtNombreProyecto.Text;
                    oBEPro.Equipo = oBEEquipo;
                    oBEEquipo.Estado = "Asociado";

                    oBLLPro.Guardar(oBEPro);




                    refreshDataGridProyecto();
                    refreshDatagridEquipo();
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void dataGridViewProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //clsProyecto oProyecto = (clsProyecto)dataGridViewProyecto.CurrentRow.DataBoundItem;

            //label12.Text = oProyecto.Equipo.Estado.ToString();

            //refreshDataGridProyecto();
        }

        private void btnModifEquipo_Click(object sender, EventArgs e)
        {
            BEEquipo oBEEquipo = (BEEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;

            DialogResult Modif = MessageBox.Show("Seguro que desea modificar este Equipo?", "Modificar", MessageBoxButtons.OKCancel);


            if (Modif == DialogResult.OK)
            {
                oBEEquipo.Nombre = txtNombreEquipo.Text;
                oBLLEquipo.Guardar(oBEEquipo);
                refreshDatagridEquipo();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    clsProyecto ProyectoSelec = (clsProyecto)dataGridViewProyecto.CurrentRow.DataBoundItem;
            //    DialogResult Respuesta;
            //    int pos = 0;

            //    foreach (clsProyecto item in LProyecto)
            //    {
            //        if (ProyectoSelec.Nombre == txtNombreProyecto.Text)
            //        {
            //            Respuesta = MessageBox.Show("Quiere borrar el proyecto?", "Borrar", MessageBoxButtons.YesNo);
            //            if (Respuesta == DialogResult.Yes)
            //            {
            //                pos = LProyecto.IndexOf(ProyectoSelec);

            //                LProyecto.RemoveAt(pos);

            //                clsProyecto.CantProyecto = clsProyecto.CantProyecto - 1;

            //                refreshDataGridProyecto();

            //                limpiarTextBox(txtNombreProyecto);
            //                break;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnModificarProyect_Click(object sender, EventArgs e)
        {
            try
            {
                BEProyecto ProyectoSelec = (BEProyecto)dataGridViewProyecto.CurrentRow.DataBoundItem;

                DialogResult Resultado;



                Resultado = MessageBox.Show("Desea modificar el nombre de este proyecto?", "Modificar", MessageBoxButtons.YesNo);
                if (Resultado == DialogResult.Yes)
                {
                    ProyectoSelec.Nombre = txtNombreProyecto.Text;
                    oBLLProyecto.Guardar(ProyectoSelec);
                    refreshDataGridProyecto();

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

    
        
    

        private void btnFinalizarProyec_Click(object sender, EventArgs e)
        {
            try
            {
                BEProyecto oProyecto = (BEProyecto)dataGridViewProyecto.CurrentRow.DataBoundItem;

                DialogResult resultado;

                resultado = MessageBox.Show("Desea finalizar este proyecto?", "Finalizar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (oProyecto.Estado != "Finalizado") 
                    { 
                    oProyecto.Estado = "Finalizado";
                    oBLLProyecto.Guardar(oProyecto);

                    refreshDataGridProyecto();
                    refreshDatagridEquipo();
                    refreshDatagridTarea();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboCategoria.SelectedItem.ToString() == "Prueba")
            {
                txtDescDesa.Enabled = false;
                dateTimePicker1.Enabled = true;

            }
            else
            {
                txtDescDesa.Enabled = true;
                dateTimePicker1.Enabled = false;
            }
        }
    }
}
