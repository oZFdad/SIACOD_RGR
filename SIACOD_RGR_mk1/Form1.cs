using Graf.Logic;
using Graf.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIACOD_RGR_mk1
{
    public partial class Form1 : Form
    {
        private Process _process = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void painBox_Paint(object sender, PaintEventArgs e)
        {
            _process.Draw(new GrafData
            {
                FormGraphics = e.Graphics,
                CheckEdgeRoute = checkBoxForRoute.Checked
            });
        }

        private void painBox_MouseDown(object sender, MouseEventArgs e)
        {
            _process.ClickOnPainBox(new GrafData
            {
                ClicPoint = new Point(e.X, e.Y),
                CheckEdgeRoute = checkBoxForRoute.Checked,
                Weight = 30
            });
            painBox.Refresh();
        }

        private void checkBoxForRoute_CheckedChanged(object sender, EventArgs e)
        {
            _process.CheckedChangedOnCheckBoxForRoute();
            painBox.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
        }
    }
}