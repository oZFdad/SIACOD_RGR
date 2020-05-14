using Graf.Logic;
using Graf.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIACOD_RGR_mk1
{
    public partial class WorkWithGraf : Form
    {
        private Process _process = new Process();
        public WorkWithGraf()
        {
            InitializeComponent();
            rbRGR.Checked = true;
        }

        private void ShowResult()
        {
            lbResalt.Text = _process.GetResaltSearch();
        }

        private void painBox_Paint(object sender, PaintEventArgs e)
        {
            _process.Draw(new GrafData
            {
                FormGraphics = e.Graphics,
                CheckEdgeRoute = !rbLaba5.Checked
            });
        }

        private void painBox_MouseDown(object sender, MouseEventArgs e)
        {
            _process.ClickOnPainBox(new GrafData
            {
                ClicPoint = new Point(e.X, e.Y),
                CheckEdgeRoute = !rbLaba5.Checked,
                Weight = 30
            });
            painBox.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            painBox.Refresh();
        }

        private void btDoAlgoritm_Click(object sender, EventArgs e)
        {
            if (rbRGR.Checked)
            {
                _process.algoritmComplete += ShowResult;
            }
            if (rbLaba4.Checked)
            {
                _process.algoritmComplete += ShowResult;
            }
            _process.DoAlgoritm(new CheckEx
            {
                RGR = rbRGR.Checked,
                Laba4 = rbLaba4.Checked,
                Laba5 = rbLaba5.Checked,
                Laba6 = rbLaba6.Checked
            });
        }

        private void rbRGR_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void rbLaba4_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
        }
        private void rbLaba5_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void rbLaba6_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            _process = new Process();
            painBox.Refresh();
        }

        private void WorkWithGraf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            painBox.Refresh();
        }
    }
}