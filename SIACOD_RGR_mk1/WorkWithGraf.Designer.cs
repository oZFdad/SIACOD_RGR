namespace SIACOD_RGR_mk1
{
    partial class WorkWithGraf
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
            this.painBox = new System.Windows.Forms.PictureBox();
            this.rbRGR = new System.Windows.Forms.RadioButton();
            this.rbLaba4 = new System.Windows.Forms.RadioButton();
            this.rbLaba5 = new System.Windows.Forms.RadioButton();
            this.rbLaba6 = new System.Windows.Forms.RadioButton();
            this.lbChooseEx = new System.Windows.Forms.Label();
            this.btDoAlgoritm = new System.Windows.Forms.Button();
            this.lbResalt = new System.Windows.Forms.Label();
            this.dgwDej = new System.Windows.Forms.DataGridView();
            this.StartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeihtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbLaba4DFS = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.painBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgwDej)).BeginInit();
            this.SuspendLayout();
            // 
            // painBox
            // 
            this.painBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.painBox.Location = new System.Drawing.Point(251, 13);
            this.painBox.Name = "painBox";
            this.painBox.Size = new System.Drawing.Size(537, 425);
            this.painBox.TabIndex = 0;
            this.painBox.TabStop = false;
            this.painBox.Paint += new System.Windows.Forms.PaintEventHandler(this.painBox_Paint);
            this.painBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painBox_MouseDown);
            // 
            // rbRGR
            // 
            this.rbRGR.AutoSize = true;
            this.rbRGR.Location = new System.Drawing.Point(16, 31);
            this.rbRGR.Name = "rbRGR";
            this.rbRGR.Size = new System.Drawing.Size(45, 17);
            this.rbRGR.TabIndex = 3;
            this.rbRGR.TabStop = true;
            this.rbRGR.Text = "РГР";
            this.rbRGR.UseVisualStyleBackColor = true;
            this.rbRGR.CheckedChanged += new System.EventHandler(this.rbRGR_CheckedChanged);
            // 
            // rbLaba4
            // 
            this.rbLaba4.AutoSize = true;
            this.rbLaba4.Location = new System.Drawing.Point(16, 77);
            this.rbLaba4.Name = "rbLaba4";
            this.rbLaba4.Size = new System.Drawing.Size(144, 17);
            this.rbLaba4.TabIndex = 4;
            this.rbLaba4.TabStop = true;
            this.rbLaba4.Text = "ЛР №4 Поиск в ширину";
            this.rbLaba4.UseVisualStyleBackColor = true;
            this.rbLaba4.CheckedChanged += new System.EventHandler(this.rbLaba4_CheckedChanged);
            // 
            // rbLaba5
            // 
            this.rbLaba5.AutoSize = true;
            this.rbLaba5.Location = new System.Drawing.Point(16, 100);
            this.rbLaba5.Name = "rbLaba5";
            this.rbLaba5.Size = new System.Drawing.Size(133, 17);
            this.rbLaba5.TabIndex = 5;
            this.rbLaba5.TabStop = true;
            this.rbLaba5.Text = "ЛР №5 Эйлеров цикл";
            this.rbLaba5.UseVisualStyleBackColor = true;
            this.rbLaba5.CheckedChanged += new System.EventHandler(this.rbLaba5_CheckedChanged);
            // 
            // rbLaba6
            // 
            this.rbLaba6.AutoSize = true;
            this.rbLaba6.Location = new System.Drawing.Point(16, 123);
            this.rbLaba6.Name = "rbLaba6";
            this.rbLaba6.Size = new System.Drawing.Size(119, 17);
            this.rbLaba6.TabIndex = 6;
            this.rbLaba6.TabStop = true;
            this.rbLaba6.Text = "ЛР №6 - Дейкстра";
            this.rbLaba6.UseVisualStyleBackColor = true;
            this.rbLaba6.CheckedChanged += new System.EventHandler(this.rbLaba6_CheckedChanged);
            // 
            // lbChooseEx
            // 
            this.lbChooseEx.AutoSize = true;
            this.lbChooseEx.Location = new System.Drawing.Point(13, 9);
            this.lbChooseEx.Name = "lbChooseEx";
            this.lbChooseEx.Size = new System.Drawing.Size(96, 13);
            this.lbChooseEx.TabIndex = 7;
            this.lbChooseEx.Text = "Выбрать задание";
            // 
            // btDoAlgoritm
            // 
            this.btDoAlgoritm.Location = new System.Drawing.Point(13, 146);
            this.btDoAlgoritm.Name = "btDoAlgoritm";
            this.btDoAlgoritm.Size = new System.Drawing.Size(144, 23);
            this.btDoAlgoritm.TabIndex = 8;
            this.btDoAlgoritm.Text = "Проверить задание";
            this.btDoAlgoritm.UseVisualStyleBackColor = true;
            this.btDoAlgoritm.Click += new System.EventHandler(this.btDoAlgoritm_Click);
            // 
            // lbResalt
            // 
            this.lbResalt.AutoSize = true;
            this.lbResalt.Location = new System.Drawing.Point(13, 172);
            this.lbResalt.MaximumSize = new System.Drawing.Size(200, 350);
            this.lbResalt.Name = "lbResalt";
            this.lbResalt.Size = new System.Drawing.Size(194, 26);
            this.lbResalt.TabIndex = 9;
            this.lbResalt.Text = "Для получения результата нажмите вкнопку выше";
            // 
            // dgwDej
            // 
            this.dgwDej.AllowUserToAddRows = false;
            this.dgwDej.AllowUserToDeleteRows = false;
            this.dgwDej.AllowUserToOrderColumns = true;
            this.dgwDej.AllowUserToResizeRows = false;
            this.dgwDej.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwDej.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDej.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.StartColumn, this.FinishColumn, this.WeihtColumn});
            this.dgwDej.Location = new System.Drawing.Point(12, 223);
            this.dgwDej.Name = "dgwDej";
            this.dgwDej.RowHeadersWidth = 40;
            this.dgwDej.Size = new System.Drawing.Size(219, 215);
            this.dgwDej.TabIndex = 10;
            this.dgwDej.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDej_CellValueChanged);
            // 
            // StartColumn
            // 
            this.StartColumn.Frozen = true;
            this.StartColumn.HeaderText = "Start";
            this.StartColumn.Name = "StartColumn";
            this.StartColumn.ReadOnly = true;
            this.StartColumn.Width = 54;
            // 
            // FinishColumn
            // 
            this.FinishColumn.Frozen = true;
            this.FinishColumn.HeaderText = "Finish";
            this.FinishColumn.Name = "FinishColumn";
            this.FinishColumn.ReadOnly = true;
            this.FinishColumn.Width = 59;
            // 
            // WeihtColumn
            // 
            this.WeihtColumn.Frozen = true;
            this.WeihtColumn.HeaderText = "Weight";
            this.WeihtColumn.Name = "WeihtColumn";
            this.WeihtColumn.Width = 66;
            // 
            // rbLaba4DFS
            // 
            this.rbLaba4DFS.AutoSize = true;
            this.rbLaba4DFS.Location = new System.Drawing.Point(16, 54);
            this.rbLaba4DFS.Name = "rbLaba4DFS";
            this.rbLaba4DFS.Size = new System.Drawing.Size(146, 17);
            this.rbLaba4DFS.TabIndex = 11;
            this.rbLaba4DFS.TabStop = true;
            this.rbLaba4DFS.Text = "ЛР №4 Поиск в глубину";
            this.rbLaba4DFS.UseVisualStyleBackColor = true;
            this.rbLaba4DFS.CheckedChanged += new System.EventHandler(this.rbLaba4DFS_CheckedChanged);
            // 
            // WorkWithGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbLaba4DFS);
            this.Controls.Add(this.dgwDej);
            this.Controls.Add(this.lbResalt);
            this.Controls.Add(this.btDoAlgoritm);
            this.Controls.Add(this.lbChooseEx);
            this.Controls.Add(this.rbLaba6);
            this.Controls.Add(this.rbLaba5);
            this.Controls.Add(this.rbLaba4);
            this.Controls.Add(this.rbRGR);
            this.Controls.Add(this.painBox);
            this.Name = "WorkWithGraf";
            this.Text = "Form1";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkWithGraf_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize) (this.painBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgwDej)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btDoAlgoritm;
        private System.Windows.Forms.DataGridView dgwDej;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishColumn;
        private System.Windows.Forms.Label lbChooseEx;
        private System.Windows.Forms.Label lbResalt;
        private System.Windows.Forms.PictureBox painBox;
        private System.Windows.Forms.RadioButton rbLaba4;
        private System.Windows.Forms.RadioButton rbLaba4DFS;
        private System.Windows.Forms.RadioButton rbLaba5;
        private System.Windows.Forms.RadioButton rbLaba6;
        private System.Windows.Forms.RadioButton rbRGR;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeihtColumn;

        #endregion
    }
}