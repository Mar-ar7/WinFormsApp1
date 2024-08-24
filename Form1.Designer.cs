namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox TextBoxTarea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTareasPendientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTareasEnProgreso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTareasCompletadas;
        private System.Windows.Forms.Label labelPendientes;
        private System.Windows.Forms.Label labelEnProgreso;
        private System.Windows.Forms.Label labelCompletadas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxEstado = new ComboBox();
            TextBoxTarea = new TextBox();
            flowLayoutPanelTareasPendientes = new FlowLayoutPanel();
            flowLayoutPanelTareasEnProgreso = new FlowLayoutPanel();
            flowLayoutPanelTareasCompletadas = new FlowLayoutPanel();
            labelPendientes = new Label();
            labelEnProgreso = new Label();
            labelCompletadas = new Label();
            SuspendLayout();
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(12, 12);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(150, 28);
            comboBoxEstado.TabIndex = 0;
            // 
            // TextBoxTarea
            // 
            TextBoxTarea.Location = new Point(170, 12);
            TextBoxTarea.Name = "TextBoxTarea";
            TextBoxTarea.Size = new Size(250, 27);
            TextBoxTarea.TabIndex = 1;
            // 
            // flowLayoutPanelTareasPendientes
            // 
            flowLayoutPanelTareasPendientes.Location = new Point(12, 66);
            flowLayoutPanelTareasPendientes.Name = "flowLayoutPanelTareasPendientes";
            flowLayoutPanelTareasPendientes.Size = new Size(150, 298);
            flowLayoutPanelTareasPendientes.TabIndex = 3;
            // 
            // flowLayoutPanelTareasEnProgreso
            // 
            flowLayoutPanelTareasEnProgreso.Location = new Point(170, 66);
            flowLayoutPanelTareasEnProgreso.Name = "flowLayoutPanelTareasEnProgreso";
            flowLayoutPanelTareasEnProgreso.Size = new Size(150, 298);
            flowLayoutPanelTareasEnProgreso.TabIndex = 4;
            // 
            // flowLayoutPanelTareasCompletadas
            // 
            flowLayoutPanelTareasCompletadas.Location = new Point(330, 66);
            flowLayoutPanelTareasCompletadas.Name = "flowLayoutPanelTareasCompletadas";
            flowLayoutPanelTareasCompletadas.Size = new Size(150, 298);
            flowLayoutPanelTareasCompletadas.TabIndex = 5;
            // 
            // labelPendientes
            // 
            labelPendientes.AutoSize = true;
            labelPendientes.Location = new Point(12, 378);
            labelPendientes.Name = "labelPendientes";
            labelPendientes.Size = new Size(102, 20);
            labelPendientes.TabIndex = 6;
            labelPendientes.Text = "Pendientes (0)";
            // 
            // labelEnProgreso
            // 
            labelEnProgreso.AutoSize = true;
            labelEnProgreso.Location = new Point(12, 398);
            labelEnProgreso.Name = "labelEnProgreso";
            labelEnProgreso.Size = new Size(110, 20);
            labelEnProgreso.TabIndex = 7;
            labelEnProgreso.Text = "En Progreso (0)";
            // 
            // labelCompletadas
            // 
            labelCompletadas.AutoSize = true;
            labelCompletadas.Location = new Point(12, 418);
            labelCompletadas.Name = "labelCompletadas";
            labelCompletadas.Size = new Size(99, 20);
            labelCompletadas.TabIndex = 8;
            labelCompletadas.Text = "Finalizado (0)";
            // 
            // Form1
            // 
            ClientSize = new Size(771, 545);
            Controls.Add(comboBoxEstado);
            Controls.Add(TextBoxTarea);
            Controls.Add(labelPendientes);
            Controls.Add(flowLayoutPanelTareasPendientes);
            Controls.Add(labelEnProgreso);
            Controls.Add(flowLayoutPanelTareasEnProgreso);
            Controls.Add(labelCompletadas);
            Controls.Add(flowLayoutPanelTareasCompletadas);
            Name = "Form1";
            Text = "Gestión de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
