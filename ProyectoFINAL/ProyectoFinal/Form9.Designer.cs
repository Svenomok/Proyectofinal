namespace ProyectoFinal
{
    partial class frmPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(360, 9);
            label.Name = "label";
            label.Size = new Size(84, 25);
            label.TabIndex = 0;
            label.Text = "Pacientes";
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Name = "frmPacientes";
            Text = "Pacientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
    }
}