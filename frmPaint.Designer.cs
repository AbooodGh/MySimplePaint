namespace TestPicture
{
    partial class frmPaint
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbTextPan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFormColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWithe = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.paneltop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneltop.Controls.Add(this.lbTextPan);
            this.paneltop.Controls.Add(this.button2);
            this.paneltop.Controls.Add(this.btnFormColor);
            this.paneltop.Controls.Add(this.button1);
            this.paneltop.Controls.Add(this.btnRefresh);
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.flowLayoutPanel1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1118, 94);
            this.paneltop.TabIndex = 0;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltop_Paint);
            // 
            // lbTextPan
            // 
            this.lbTextPan.Location = new System.Drawing.Point(956, 33);
            this.lbTextPan.Name = "lbTextPan";
            this.lbTextPan.Size = new System.Drawing.Size(39, 22);
            this.lbTextPan.TabIndex = 3;
            this.lbTextPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbTextPan.TextChanged += new System.EventHandler(this.lbTextPan_TextChanged);
            this.lbTextPan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbTextPan_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = ">>";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFormColor
            // 
            this.btnFormColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormColor.Location = new System.Drawing.Point(109, 31);
            this.btnFormColor.Name = "btnFormColor";
            this.btnFormColor.Size = new System.Drawing.Size(109, 38);
            this.btnFormColor.TabIndex = 4;
            this.btnFormColor.Text = "Form Color";
            this.btnFormColor.UseVisualStyleBackColor = true;
            this.btnFormColor.Click += new System.EventHandler(this.btnFormColor_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(917, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "<<";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 39);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnWithe);
            this.flowLayoutPanel1.Controls.Add(this.btnBlack);
            this.flowLayoutPanel1.Controls.Add(this.btnRed);
            this.flowLayoutPanel1.Controls.Add(this.btnYellow);
            this.flowLayoutPanel1.Controls.Add(this.btnGreen);
            this.flowLayoutPanel1.Controls.Add(this.btnBlue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(349, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnWithe
            // 
            this.btnWithe.ForeColor = System.Drawing.Color.White;
            this.btnWithe.Location = new System.Drawing.Point(3, 3);
            this.btnWithe.Name = "btnWithe";
            this.btnWithe.Size = new System.Drawing.Size(81, 47);
            this.btnWithe.TabIndex = 1;
            this.btnWithe.UseVisualStyleBackColor = true;
            this.btnWithe.Click += new System.EventHandler(this.btnWithe_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(90, 3);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(81, 47);
            this.btnBlack.TabIndex = 2;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRed.Location = new System.Drawing.Point(177, 3);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(81, 47);
            this.btnRed.TabIndex = 5;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnYellow.Location = new System.Drawing.Point(264, 3);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(81, 47);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGreen.Location = new System.Drawing.Point(351, 3);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(81, 47);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBlue.Location = new System.Drawing.Point(438, 3);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(81, 47);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 94);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1118, 561);
            this.panelCenter.TabIndex = 1;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            this.panelCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCenter_MouseDown);
            this.panelCenter.MouseHover += new System.EventHandler(this.panelCenter_MouseHover);
            this.panelCenter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCenter_MouseMove);
            this.panelCenter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCenter_MouseUp);
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 655);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.paneltop);
            this.Name = "frmPaint";
            this.Text = "frmPaint";
            this.Load += new System.EventHandler(this.frmPaint_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPaint_Paint);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnWithe;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFormColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox lbTextPan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}