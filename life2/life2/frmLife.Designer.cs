namespace life2
{
    partial class frmLife
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
            this.components = new System.ComponentModel.Container();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.gpLife = new GraphPaperGrid.GraphPaper();
            this.SuspendLayout();
            // 
            // tmrCheck
            // 
            this.tmrCheck.Interval = 50;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // gpLife
            // 
            this.gpLife.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpLife.Location = new System.Drawing.Point(67, 39);
            this.gpLife.Name = "gpLife";
            this.gpLife.Size = new System.Drawing.Size(590, 311);
            this.gpLife.TabIndex = 0;
            // 
            // frmLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 420);
            this.Controls.Add(this.gpLife);
            this.Name = "frmLife";
            this.Text = "Life";
            this.Load += new System.EventHandler(this.frmLife_Load);
            this.Shown += new System.EventHandler(this.frmLife_Shown);
            this.ResizeBegin += new System.EventHandler(this.frmLife_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmLife_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmLife_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private GraphPaperGrid.GraphPaper gpLife;
        private System.Windows.Forms.Timer tmrCheck;
    }
}

