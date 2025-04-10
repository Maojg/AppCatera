// FormLoading.cs
using System;
using System.Drawing;
using System.Windows.Forms;

public partial class FormLoading : Form
{
    public FormLoading()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.White;
        this.Width = 300;
        this.Height = 100;

        Label lbl = new Label();
        lbl.Text = "Cargando...";
        lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        lbl.Dock = DockStyle.Fill;
        lbl.TextAlign = ContentAlignment.MiddleCenter;
        this.Controls.Add(lbl);
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}
