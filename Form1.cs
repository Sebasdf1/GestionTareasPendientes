using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                txtTarea.Text = "Escriba la Tarea...";
                txtTarea.ForeColor = Color.Gray;
            }
        }

        private void txtTarea_Enter(object sender, EventArgs e)
        {
            if (txtTarea.Text == "Escriba la Tarea...")
            {
                txtTarea.Text = "";
                txtTarea.ForeColor = Color.Black;
            }
        }

        private void txtTarea_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                txtTarea.Text = "Escriba la Tarea...";
                txtTarea.ForeColor = Color.Gray;
            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text) && txtTarea.Text != "Escriba la Tarea...")
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
                txtTarea.Text = "Escriba la Tarea...";
                txtTarea.ForeColor = Color.Gray;
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una tarea antes de agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
            else
            {
                MessageBox.Show(" ---Seleccione una tarea para eliminar---", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
