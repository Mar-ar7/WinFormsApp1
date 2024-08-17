using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (TextBoxTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar un nombre para la tarea");
                return;
            }

            Tarea nuevaTarea = new Tarea(TextBoxTarea.Text, "Pendiente");
            tareas.Add(nuevaTarea);

            RenderizarTareas();
        }

        private void ButtonEliminarultimaterea_Click(object sender, EventArgs e)
        {
            if (tareas.Count > 0)
            {
                tareas.RemoveAt(tareas.Count - 1);

                RenderizarTareas();
            }
            else
            {
                MessageBox.Show("No hay tareas para eliminar");
            }
        }
        private void RenderizarTareas()
        {
 
            flowLayoutPanelTareasPendientes.Controls.Clear();

       
            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.Nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(5);
                tarjeta.Margin = new Padding(2);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.font);
                };
                flowLayoutPanelTareasPendientes.Controls.Add(tarjeta);
            }
        }
    }
}
