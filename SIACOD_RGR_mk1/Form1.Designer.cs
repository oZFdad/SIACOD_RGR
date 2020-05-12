namespace SIACOD_RGR_mk1
{
    partial class Form1
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
            this.checkBoxForRoute = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.painBox)).BeginInit();
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
            // checkBoxForRoute
            // 
            this.checkBoxForRoute.AutoSize = true;
            this.checkBoxForRoute.Location = new System.Drawing.Point(13, 13);
            this.checkBoxForRoute.Name = "checkBoxForRoute";
            this.checkBoxForRoute.Size = new System.Drawing.Size(80, 17);
            this.checkBoxForRoute.TabIndex = 1;
            this.checkBoxForRoute.Text = "checkBox1";
            this.checkBoxForRoute.UseVisualStyleBackColor = true;
            this.checkBoxForRoute.CheckedChanged += new System.EventHandler(this.checkBoxForRoute_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxForRoute);
            this.Controls.Add(this.painBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.painBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox painBox;

        #endregion

        private System.Windows.Forms.CheckBox checkBoxForRoute;
        private System.Windows.Forms.Button button1;
    }
}