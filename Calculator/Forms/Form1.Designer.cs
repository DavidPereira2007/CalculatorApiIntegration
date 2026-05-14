namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblNumber = new Label();
            lblResult = new Label();
            panelMenu = new Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            bntsobra = new Button();
            bntClear = new Button();
            bntDelete = new Button();
            bntdiv = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            bnt7 = new Button();
            bnt8 = new Button();
            bnt9 = new Button();
            bntmultiply = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            bnt4 = new Button();
            bnt5 = new Button();
            bnt6 = new Button();
            bntsubtract = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            bnt0 = new Button();
            bntPont = new Button();
            bntIgual = new Button();
            panelTop.SuspendLayout();
            panelMenu.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblNumber);
            panelTop.Controls.Add(lblResult);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(299, 115);
            panelTop.TabIndex = 0;
            // 
            // lblNumber
            // 
            lblNumber.Font = new Font("Segoe UI", 25F);
            lblNumber.ForeColor = SystemColors.AppWorkspace;
            lblNumber.Location = new Point(6, 9);
            lblNumber.Name = "lblNumber";
            lblNumber.RightToLeft = RightToLeft.No;
            lblNumber.Size = new Size(286, 46);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "000";
            lblNumber.TextAlign = ContentAlignment.MiddleRight;
            lblNumber.Visible = false;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 25F);
            lblResult.Location = new Point(6, 66);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(290, 46);
            lblResult.TabIndex = 0;
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(flowLayoutPanel5);
            panelMenu.Controls.Add(flowLayoutPanel4);
            panelMenu.Controls.Add(flowLayoutPanel3);
            panelMenu.Controls.Add(flowLayoutPanel2);
            panelMenu.Controls.Add(flowLayoutPanel1);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 115);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(299, 346);
            panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(bntsobra);
            flowLayoutPanel5.Controls.Add(bntClear);
            flowLayoutPanel5.Controls.Add(bntDelete);
            flowLayoutPanel5.Controls.Add(bntdiv);
            flowLayoutPanel5.Location = new Point(3, 19);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(293, 60);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // bntsobra
            // 
            bntsobra.Enabled = false;
            bntsobra.Font = new Font("Segoe UI", 12F);
            bntsobra.Location = new Point(3, 3);
            bntsobra.Name = "bntsobra";
            bntsobra.Size = new Size(67, 54);
            bntsobra.TabIndex = 1;
            bntsobra.UseVisualStyleBackColor = true;
            // 
            // bntClear
            // 
            bntClear.Font = new Font("Segoe UI", 12F);
            bntClear.Location = new Point(76, 3);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(67, 54);
            bntClear.TabIndex = 2;
            bntClear.Text = "CE";
            bntClear.UseVisualStyleBackColor = true;
            bntClear.Click += bntClear_Click;
            // 
            // bntDelete
            // 
            bntDelete.Font = new Font("Segoe UI", 12F);
            bntDelete.Location = new Point(149, 3);
            bntDelete.Name = "bntDelete";
            bntDelete.Size = new Size(67, 54);
            bntDelete.TabIndex = 3;
            bntDelete.Text = "C";
            bntDelete.UseVisualStyleBackColor = true;
            bntDelete.Click += bntDelete_Click;
            // 
            // bntdiv
            // 
            bntdiv.Font = new Font("Segoe UI", 12F);
            bntdiv.Location = new Point(222, 3);
            bntdiv.Name = "bntdiv";
            bntdiv.Size = new Size(67, 54);
            bntdiv.TabIndex = 4;
            bntdiv.Text = "/";
            bntdiv.UseVisualStyleBackColor = true;
            bntdiv.Click += bntdiv_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(bnt7);
            flowLayoutPanel4.Controls.Add(bnt8);
            flowLayoutPanel4.Controls.Add(bnt9);
            flowLayoutPanel4.Controls.Add(bntmultiply);
            flowLayoutPanel4.Location = new Point(3, 85);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(293, 60);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // bnt7
            // 
            bnt7.Font = new Font("Segoe UI", 12F);
            bnt7.Location = new Point(3, 3);
            bnt7.Name = "bnt7";
            bnt7.Size = new Size(67, 54);
            bnt7.TabIndex = 1;
            bnt7.Text = "7";
            bnt7.UseVisualStyleBackColor = true;
            bnt7.Click += bnt7_Click;
            // 
            // bnt8
            // 
            bnt8.Font = new Font("Segoe UI", 12F);
            bnt8.Location = new Point(76, 3);
            bnt8.Name = "bnt8";
            bnt8.Size = new Size(67, 54);
            bnt8.TabIndex = 2;
            bnt8.Text = "8";
            bnt8.UseVisualStyleBackColor = true;
            bnt8.Click += bnt8_Click;
            // 
            // bnt9
            // 
            bnt9.Font = new Font("Segoe UI", 12F);
            bnt9.Location = new Point(149, 3);
            bnt9.Name = "bnt9";
            bnt9.Size = new Size(67, 54);
            bnt9.TabIndex = 3;
            bnt9.Text = "9";
            bnt9.UseVisualStyleBackColor = true;
            bnt9.Click += bnt9_Click;
            // 
            // bntmultiply
            // 
            bntmultiply.Font = new Font("Segoe UI", 12F);
            bntmultiply.Location = new Point(222, 3);
            bntmultiply.Name = "bntmultiply";
            bntmultiply.Size = new Size(67, 54);
            bntmultiply.TabIndex = 4;
            bntmultiply.Text = "X";
            bntmultiply.UseVisualStyleBackColor = true;
            bntmultiply.Click += bntmultiply_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(bnt4);
            flowLayoutPanel3.Controls.Add(bnt5);
            flowLayoutPanel3.Controls.Add(bnt6);
            flowLayoutPanel3.Controls.Add(bntsubtract);
            flowLayoutPanel3.Location = new Point(3, 151);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(293, 60);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // bnt4
            // 
            bnt4.Font = new Font("Segoe UI", 12F);
            bnt4.Location = new Point(3, 3);
            bnt4.Name = "bnt4";
            bnt4.Size = new Size(67, 54);
            bnt4.TabIndex = 1;
            bnt4.Text = "4";
            bnt4.UseVisualStyleBackColor = true;
            bnt4.Click += bnt4_Click;
            // 
            // bnt5
            // 
            bnt5.Font = new Font("Segoe UI", 12F);
            bnt5.Location = new Point(76, 3);
            bnt5.Name = "bnt5";
            bnt5.Size = new Size(67, 54);
            bnt5.TabIndex = 2;
            bnt5.Text = "5";
            bnt5.UseVisualStyleBackColor = true;
            bnt5.Click += bnt5_Click;
            // 
            // bnt6
            // 
            bnt6.Font = new Font("Segoe UI", 12F);
            bnt6.Location = new Point(149, 3);
            bnt6.Name = "bnt6";
            bnt6.Size = new Size(67, 54);
            bnt6.TabIndex = 3;
            bnt6.Text = "6";
            bnt6.UseVisualStyleBackColor = true;
            bnt6.Click += bnt6_Click;
            // 
            // bntsubtract
            // 
            bntsubtract.Font = new Font("Segoe UI", 12F);
            bntsubtract.Location = new Point(222, 3);
            bntsubtract.Name = "bntsubtract";
            bntsubtract.Size = new Size(67, 54);
            bntsubtract.TabIndex = 4;
            bntsubtract.Text = "-";
            bntsubtract.UseVisualStyleBackColor = true;
            bntsubtract.Click += bntsubtract_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn1);
            flowLayoutPanel2.Controls.Add(btn2);
            flowLayoutPanel2.Controls.Add(btn3);
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Location = new Point(3, 217);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(293, 60);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F);
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 54);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F);
            btn2.Location = new Point(76, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 54);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F);
            btn3.Location = new Point(149, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 54);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(222, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 54);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(bnt0);
            flowLayoutPanel1.Controls.Add(bntPont);
            flowLayoutPanel1.Controls.Add(bntIgual);
            flowLayoutPanel1.Location = new Point(3, 283);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(293, 60);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(67, 54);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // bnt0
            // 
            bnt0.Font = new Font("Segoe UI", 12F);
            bnt0.Location = new Point(76, 3);
            bnt0.Name = "bnt0";
            bnt0.Size = new Size(67, 54);
            bnt0.TabIndex = 2;
            bnt0.Text = "0";
            bnt0.UseVisualStyleBackColor = true;
            bnt0.Click += bnt0_Click;
            // 
            // bntPont
            // 
            bntPont.Font = new Font("Segoe UI", 12F);
            bntPont.Location = new Point(149, 3);
            bntPont.Name = "bntPont";
            bntPont.Size = new Size(67, 54);
            bntPont.TabIndex = 3;
            bntPont.Text = ".";
            bntPont.UseVisualStyleBackColor = true;
            bntPont.Click += bntPont_Click;
            // 
            // bntIgual
            // 
            bntIgual.Font = new Font("Segoe UI", 12F);
            bntIgual.Location = new Point(222, 3);
            bntIgual.Name = "bntIgual";
            bntIgual.Size = new Size(67, 54);
            bntIgual.TabIndex = 4;
            bntIgual.Text = "=";
            bntIgual.UseVisualStyleBackColor = true;
            bntIgual.Click += bntIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 461);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Calculator";
            panelTop.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelMenu;
        private Button btn1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Label lblResult;
        private Button bntsobra;
        private Button bntClear;
        private Button bntDelete;
        private Button bntdiv;
        private Button bnt7;
        private Button bnt8;
        private Button bnt9;
        private Button bntmultiply;
        private Button bnt4;
        private Button bnt5;
        private Button bnt6;
        private Button bntsubtract;
        private Button bnt0;
        private Button bntPont;
        private Button bntIgual;
        private Label lblNumber;
        private Button button1;
    }
}
