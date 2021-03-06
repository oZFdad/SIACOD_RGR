﻿using Graf.Logic;
using Graf.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SIACOD_RGR_mk1
{
    public partial class WorkWithGraf : Form
    {
        private Process _process = new Process();
        private Random _rnd = new Random();
        private bool _check;
        private bool _subscr;
        public WorkWithGraf()
        {
            InitializeComponent();
            rbRGR.Checked = true;
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
            if (!_subscr)
            {
                _subscr = true;
                _process.AddEdgeEvent += AddRowInDGW;
            }
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
                Laba4BFS = rbLaba4.Checked,
                Laba4DFS = rbLaba4DFS.Checked,
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
        
        private void rbLaba4DFS_CheckedChanged(object sender, EventArgs e)
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
            dgwDej.Visible = true;
        }

        private void Clear()
        {
            _process = new Process();
            _subscr = false;
            dgwDej.Visible = false;
            painBox.Refresh();
        }

        private void WorkWithGraf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            painBox.Refresh();
        }

        private void AddRowInDGW(List<EdgeForDGW> data)
        {
            dgwDej.Rows.Clear();
            foreach (var edgeForDgw in data)
            {
                dgwDej.Rows.Add(edgeForDgw.Start, edgeForDgw.Finish, edgeForDgw.Weight);
            }
        }

        private void dgwDej_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index >= 0)
            {
                var collection = dgwDej.Rows[index].Cells;
                var start = Convert.ToInt32(collection[0].Value);
                var finish = Convert.ToInt32(collection[1].Value);
                var weight = Convert.ToInt32(collection[2].Value);
                _process.EditEdge(start, finish, weight);
                painBox.Refresh();
            }
        }

        
    }
}