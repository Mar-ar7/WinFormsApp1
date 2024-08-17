namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxTarea = new TextBox();
            ButtonAgregar = new Button();
            flowLayoutPanelTareasPendientes = new FlowLayoutPanel();
            ButtonEliminarultimatarea = new Button();
            SuspendLayout();
            // 
            // TextBoxTarea
            // 
            TextBoxTarea.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBoxTarea.Location = new Point(40, 24);
            TextBoxTarea.Name = "TextBoxTarea";
            TextBoxTarea.PlaceholderText = "Ingrese su tarea";
            TextBoxTarea.Size = new Size(281, 29);
            TextBoxTarea.TabIndex = 0;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAgregar.Location = new Point(378, 22);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(126, 29);
            ButtonAgregar.TabIndex = 1;
            ButtonAgregar.Text = "Agregar";
            ButtonAgregar.UseVisualStyleBackColor = true;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // flowLayoutPanelTareasPendientes
            // 
            flowLayoutPanelTareasPendientes.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTareasPendientes.Location = new Point(40, 82);
            flowLayoutPanelTareasPendientes.Name = "flowLayoutPanelTareasPendientes";
            flowLayoutPanelTareasPendientes.Size = new Size(281, 345);
            flowLayoutPanelTareasPendientes.TabIndex = 2;
            // 
            // ButtonEliminarultimatarea
            // 
            ButtonEliminarultimatarea.Location = new Point(378, 82);
            ButtonEliminarultimatarea.Name = "ButtonEliminarultimatarea";
            ButtonEliminarultimatarea.Size = new Size(126, 29);
            ButtonEliminarultimatarea.TabIndex = 3;
            ButtonEliminarultimatarea.Text = "Eliminar Tarea";
            ButtonEliminarultimatarea.UseVisualStyleBackColor = true;
            ButtonEliminarultimatarea.Click += ButtonEliminarultimaterea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonEliminarultimatarea);
            Controls.Add(flowLayoutPanelTareasPendientes);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxTarea;
        private Button ButtonAgregar;
        private FlowLayoutPanel flowLayoutPanelTareasPendientes;
        private Button ButtonEliminarultimatarea;
    }
}
