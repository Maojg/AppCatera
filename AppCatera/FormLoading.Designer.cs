using System.Windows.Forms;

namespace AppCatera
{
    partial class FormLoading
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Cargando...";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Dock = DockStyle.Fill;
            // 
            // FormLoading
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.TopMost = true;
            this.Name = "FormLoading";
            this.Text = "Cargando";
            this.ResumeLayout(false);
        }
    }
}
