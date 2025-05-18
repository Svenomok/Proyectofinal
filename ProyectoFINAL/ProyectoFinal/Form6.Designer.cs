namespace ProyectoFinal
{
    partial class frmCitas
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
            citas = new Label();
            SuspendLayout();
            // 
            // citas
            // 
            citas.AutoSize = true;
            citas.Location = new Point(353, 2);
            citas.Name = "citas";
            citas.Size = new Size(47, 25);
            citas.TabIndex = 0;
            citas.Text = "c‫itas";
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(citas);
            Name = "frmCitas";
            Text = "Citas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label citas;
    }
}