namespace RadiatorDoTranzystora
{
    partial class Form111
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form111));
            this.label1 = new System.Windows.Forms.Label();
            this.tbTjmax = new System.Windows.Forms.TextBox();
            this.linkmail = new System.Windows.Forms.LinkLabel();
            this.linkwww = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRthcs = new System.Windows.Forms.TextBox();
            this.tbRthjc = new System.Windows.Forms.TextBox();
            this.tbRthsa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTamb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbJ = new System.Windows.Forms.TextBox();
            this.tbU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTj = new System.Windows.Forms.TextBox();
            this.tbRth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tjmax [st.C]";
            // 
            // tbTjmax
            // 
            this.tbTjmax.BackColor = System.Drawing.SystemColors.Info;
            this.tbTjmax.Location = new System.Drawing.Point(76, 15);
            this.tbTjmax.Name = "tbTjmax";
            this.tbTjmax.Size = new System.Drawing.Size(71, 20);
            this.tbTjmax.TabIndex = 5;
            this.tbTjmax.Text = "150";
            this.tbTjmax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkmail
            // 
            this.linkmail.AutoSize = true;
            this.linkmail.Location = new System.Drawing.Point(188, 174);
            this.linkmail.Name = "linkmail";
            this.linkmail.Size = new System.Drawing.Size(121, 13);
            this.linkmail.TabIndex = 23;
            this.linkmail.TabStop = true;
            this.linkmail.Text = "zielonyeufor@gmail.com";
            this.linkmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkmail_LinkClicked);
            // 
            // linkwww
            // 
            this.linkwww.AutoSize = true;
            this.linkwww.Location = new System.Drawing.Point(201, 159);
            this.linkwww.Name = "linkwww";
            this.linkwww.Size = new System.Drawing.Size(94, 13);
            this.linkwww.TabIndex = 22;
            this.linkwww.TabStop = true;
            this.linkwww.Text = "Kuba Miszcz 2016";
            this.linkwww.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbRthcs);
            this.groupBox3.Controls.Add(this.tbRthjc);
            this.groupBox3.Controls.Add(this.tbRthsa);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbTjmax);
            this.groupBox3.Location = new System.Drawing.Point(171, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(154, 107);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Z Datasheet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rth j-c";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rth s-a";
            // 
            // tbRthcs
            // 
            this.tbRthcs.BackColor = System.Drawing.SystemColors.Info;
            this.tbRthcs.Location = new System.Drawing.Point(76, 59);
            this.tbRthcs.Name = "tbRthcs";
            this.tbRthcs.Size = new System.Drawing.Size(71, 20);
            this.tbRthcs.TabIndex = 271;
            this.tbRthcs.Text = "1";
            this.tbRthcs.TextChanged += new System.EventHandler(this.tbRthcs_TextChanged);
            // 
            // tbRthjc
            // 
            this.tbRthjc.BackColor = System.Drawing.SystemColors.Info;
            this.tbRthjc.Location = new System.Drawing.Point(76, 37);
            this.tbRthjc.Name = "tbRthjc";
            this.tbRthjc.Size = new System.Drawing.Size(71, 20);
            this.tbRthjc.TabIndex = 6;
            this.tbRthjc.Text = "10";
            this.tbRthjc.TextChanged += new System.EventHandler(this.tbRthjc_TextChanged);
            // 
            // tbRthsa
            // 
            this.tbRthsa.BackColor = System.Drawing.SystemColors.Info;
            this.tbRthsa.Location = new System.Drawing.Point(76, 81);
            this.tbRthsa.Name = "tbRthsa";
            this.tbRthsa.Size = new System.Drawing.Size(71, 20);
            this.tbRthsa.TabIndex = 8;
            this.tbRthsa.Text = "25";
            this.tbRthsa.TextChanged += new System.EventHandler(this.tbRthsa_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rth c-s";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTamb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbJ);
            this.groupBox2.Controls.Add(this.tbU);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(153, 90);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane:";
            // 
            // tbTamb
            // 
            this.tbTamb.BackColor = System.Drawing.SystemColors.Info;
            this.tbTamb.Location = new System.Drawing.Point(75, 15);
            this.tbTamb.Name = "tbTamb";
            this.tbTamb.Size = new System.Drawing.Size(71, 20);
            this.tbTamb.TabIndex = 1;
            this.tbTamb.Text = "50";
            this.tbTamb.TextChanged += new System.EventHandler(this.tbTamb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tamb [st.C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "P [W]";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbP
            // 
            this.tbP.BackColor = System.Drawing.Color.PeachPuff;
            this.tbP.Cursor = System.Windows.Forms.Cursors.No;
            this.tbP.Location = new System.Drawing.Point(74, 16);
            this.tbP.Name = "tbP";
            this.tbP.ReadOnly = true;
            this.tbP.Size = new System.Drawing.Size(71, 20);
            this.tbP.TabIndex = 4;
            this.tbP.Text = "2.4";
            this.tbP.TextChanged += new System.EventHandler(this.tbP_TextChanged);
            // 
            // tbJ
            // 
            this.tbJ.BackColor = System.Drawing.SystemColors.Info;
            this.tbJ.Location = new System.Drawing.Point(75, 61);
            this.tbJ.Name = "tbJ";
            this.tbJ.Size = new System.Drawing.Size(71, 20);
            this.tbJ.TabIndex = 3;
            this.tbJ.Text = "200";
            this.tbJ.TextChanged += new System.EventHandler(this.tbJ_TextChanged);
            // 
            // tbU
            // 
            this.tbU.BackColor = System.Drawing.SystemColors.Info;
            this.tbU.Location = new System.Drawing.Point(75, 38);
            this.tbU.Name = "tbU";
            this.tbU.Size = new System.Drawing.Size(71, 20);
            this.tbU.TabIndex = 2;
            this.tbU.Text = "12";
            this.tbU.TextChanged += new System.EventHandler(this.tbU_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "J [mA]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "U [V]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTj);
            this.groupBox1.Controls.Add(this.tbRth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(153, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // tbTj
            // 
            this.tbTj.BackColor = System.Drawing.Color.PeachPuff;
            this.tbTj.Cursor = System.Windows.Forms.Cursors.No;
            this.tbTj.Location = new System.Drawing.Point(74, 59);
            this.tbTj.Name = "tbTj";
            this.tbTj.ReadOnly = true;
            this.tbTj.Size = new System.Drawing.Size(71, 20);
            this.tbTj.TabIndex = 10;
            this.tbTj.Text = "1";
            // 
            // tbRth
            // 
            this.tbRth.BackColor = System.Drawing.Color.PeachPuff;
            this.tbRth.Cursor = System.Windows.Forms.Cursors.No;
            this.tbRth.Location = new System.Drawing.Point(74, 37);
            this.tbRth.Name = "tbRth";
            this.tbRth.ReadOnly = true;
            this.tbRth.Size = new System.Drawing.Size(71, 20);
            this.tbRth.TabIndex = 9;
            this.tbRth.Text = "1";
            this.tbRth.TextChanged += new System.EventHandler(this.tbRth_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tj";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 200;
            // 
            // Form111
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 203);
            this.Controls.Add(this.linkmail);
            this.Controls.Add(this.linkwww);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form111";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radiator do Tranzystora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTjmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTj;
        private System.Windows.Forms.TextBox tbRth;
        private System.Windows.Forms.TextBox tbRthsa;
        private System.Windows.Forms.TextBox tbRthcs;
        private System.Windows.Forms.TextBox tbRthjc;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbJ;
        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.TextBox tbTamb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkmail;
        private System.Windows.Forms.LinkLabel linkwww;
    }
}

