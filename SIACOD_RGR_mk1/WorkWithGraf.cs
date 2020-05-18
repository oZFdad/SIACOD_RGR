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
        private Random _rnd=new Random();
        private bool _check;
        public WorkWithGraf()
        {
            InitializeComponent();
            rbLaba6.Checked = true;
        }

        private void ShowResult()
        {
            lbResalt.Text = _process.GetResaltSearch();
            _check = false;
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
            if (_check)
            {
                _process.CheckVertex(new GrafData
                {
                    ClicPoint = new Point(e.X, e.Y)
                });
                painBox.Refresh();
                return;
            }
            var weight = 30;
            if (rbLaba6.Checked)
            {
                weight = _rnd.Next(1, 11);
            }
            _process.ClickOnPainBox(new GrafData
            {
                ClicPoint = new Point(e.X, e.Y),
                CheckEdgeRoute = !rbLaba5.Checked,
                Weight = weight
            });
            painBox.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            painBox.Refresh();
        }

        private void btDoAlgoritm_Click(object sender, EventArgs e)
        {
            _process.algoritmComplete += ShowResult;
            if (rbLaba6.Checked)
            {
                if (!_check)
                {
                    MessageBox.Show("Выберете старт и финиш", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _check = true;
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