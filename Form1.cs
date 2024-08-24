using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();

            TextBoxTarea.KeyDown += TextBoxTarea_KeyDown;

          
            comboBoxEstado.Items.Add("Pendiente");
            comboBoxEstado.Items.Add("En Progreso");
            comboBoxEstado.Items.Add("Finalizado");
            comboBoxEstado.SelectedIndex = 0; 
        }

        private void TextBoxTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarTarea();
                e.Handled = true; // Prevenir el sonido de beep
                e.SuppressKeyPress = true; // Prevenir la escritura del Enter en el TextBox
            }
        }

        private void AgregarTarea()
        {
            if (TextBoxTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar un nombre para la tarea");
                return;
            }

            string estadoSeleccionado = comboBoxEstado.SelectedItem.ToString();
            Tarea nuevaTarea = new Tarea(TextBoxTarea.Text, estadoSeleccionado);
            tareas.Add(nuevaTarea);

            
            TextBoxTarea.Text = "";

            RenderizarTareas();
        }

      
        private void ActualizarContadores()
        {
            int pendientes = 0, enProgreso = 0, completadas = 0;

            // Contar las tareas según el estado
            foreach (Tarea tarea in tareas)
            {
                if (tarea.Estado == "Pendiente")
                    pendientes++;
                else if (tarea.Estado == "En Progreso")
                    enProgreso++;
                else if (tarea.Estado == "Finalizado")
                    completadas++;
            }

            // Actualizar los labels con los contadores
            labelPendientes.Text = $"Pendientes ({pendientes})";
            labelEnProgreso.Text = $"En Progreso ({enProgreso})";
            labelCompletadas.Text = $"Finalizado ({completadas})";
        }

     
        private void RenderizarTareas()
        {
            
            flowLayoutPanelTareasPendientes.Controls.Clear();
            flowLayoutPanelTareasEnProgreso.Controls.Clear();
            flowLayoutPanelTareasCompletadas.Controls.Clear();

            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.Nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(5);
                tarjeta.Margin = new Padding(2);
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                
                if (tarea.Estado == "Pendiente")
                {
                    tarjeta.BackColor = Color.LightBlue;
                }
                else if (tarea.Estado == "En Progreso")
                {
                    tarjeta.BackColor = Color.Orange;
                }
                else if (tarea.Estado == "Finalizado")
                {
                    tarjeta.BackColor = Color.LightGreen;
                }

                tarjeta.DoubleClick += (sender, e) =>
                {
                    if (tarea.Estado == "Pendiente")
                    {
                        tarea.Estado = "En Progreso";
                    }
                    else if (tarea.Estado == "En Progreso")
                    {
                        tarea.Estado = "Finalizado";
                    }
                    else if (tarea.Estado == "Finalizado")
                    {
                        tareas.Remove(tarea);
                    }
                    RenderizarTareas();
                };

                // Añadir tarea al panel correspondiente según su estado
                if (tarea.Estado == "Pendiente")
                {
                    flowLayoutPanelTareasPendientes.Controls.Add(tarjeta);
                }
                else if (tarea.Estado == "En Progreso")
                {
                    flowLayoutPanelTareasEnProgreso.Controls.Add(tarjeta);
                }
                else if (tarea.Estado == "Finalizado")
                {
                    flowLayoutPanelTareasCompletadas.Controls.Add(tarjeta);
                }
            }

            ActualizarContadores();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }
    }
}
