namespace electricity
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
            lblvoltage = new Label();
            lbltname = new Label();
            tbname = new TextBox();
            label1 = new Label();
            tbunit = new TextBox();
            ddlmain = new ComboBox();
            label2 = new Label();
            bttcal = new Button();
            lbelec = new Label();
            lbshowname = new Label();
            lblname = new Label();
            lblcost = new Label();
            tbvoltage = new TextBox();
            lbldemand = new Label();
            tbdemand = new TextBox();
            bgsub = new Button();
            SuspendLayout();
            // 
            // lblvoltage
            // 
            lblvoltage.AutoSize = true;
            lblvoltage.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblvoltage.Location = new Point(14, 220);
            lblvoltage.Name = "lblvoltage";
            lblvoltage.Size = new Size(159, 33);
            lblvoltage.TabIndex = 11;
            lblvoltage.Text = "voltage :";
            // 
            // lbltname
            // 
            lbltname.AutoSize = true;
            lbltname.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbltname.ForeColor = SystemColors.ActiveCaptionText;
            lbltname.Location = new Point(62, 19);
            lbltname.Name = "lbltname";
            lbltname.Size = new Size(111, 33);
            lbltname.TabIndex = 0;
            lbltname.Text = "name :";
            // 
            // tbname
            // 
            tbname.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            tbname.Location = new Point(179, 12);
            tbname.Name = "tbname";
            tbname.Size = new Size(292, 40);
            tbname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 85);
            label1.Name = "label1";
            label1.Size = new Size(127, 33);
            label1.TabIndex = 2;
            label1.Text = "units :";
            // 
            // tbunit
            // 
            tbunit.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            tbunit.Location = new Point(179, 82);
            tbunit.Name = "tbunit";
            tbunit.Size = new Size(127, 40);
            tbunit.TabIndex = 3;
            tbunit.KeyPress += tbunit_KeyPress;
            // 
            // ddlmain
            // 
            ddlmain.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            ddlmain.FormattingEnabled = true;
            ddlmain.Items.AddRange(new object[] { "1 บ้านอยู่อาศัย", "3 กิจการขนาดกลาง", "6 องค์กรที่ไม่แสวงหากำไร" });
            ddlmain.Location = new Point(178, 147);
            ddlmain.Name = "ddlmain";
            ddlmain.Size = new Size(292, 41);
            ddlmain.TabIndex = 4;
            ddlmain.SelectedIndexChanged += ddlmain_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 150);
            label2.Name = "label2";
            label2.Size = new Size(111, 33);
            label2.TabIndex = 5;
            label2.Text = "type :";
            // 
            // bttcal
            // 
            bttcal.BackColor = SystemColors.MenuHighlight;
            bttcal.Font = new Font("Unispace", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            bttcal.ForeColor = SystemColors.ButtonHighlight;
            bttcal.Location = new Point(33, 376);
            bttcal.Name = "bttcal";
            bttcal.Size = new Size(286, 91);
            bttcal.TabIndex = 6;
            bttcal.Text = "calculate";
            bttcal.UseVisualStyleBackColor = false;
            bttcal.Click += bttcal_Click;
            // 
            // lbelec
            // 
            lbelec.AutoSize = true;
            lbelec.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbelec.Location = new Point(367, 429);
            lbelec.Name = "lbelec";
            lbelec.Size = new Size(111, 33);
            lbelec.TabIndex = 7;
            lbelec.Text = "cost :";
            // 
            // lbshowname
            // 
            lbshowname.AutoSize = true;
            lbshowname.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbshowname.Location = new Point(367, 376);
            lbshowname.Name = "lbshowname";
            lbshowname.Size = new Size(111, 33);
            lbshowname.TabIndex = 8;
            lbshowname.Text = "name :";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(475, 376);
            lblname.Name = "lblname";
            lblname.Size = new Size(111, 33);
            lblname.TabIndex = 9;
            lblname.Text = "name :";
            // 
            // lblcost
            // 
            lblcost.AutoSize = true;
            lblcost.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblcost.Location = new Point(475, 429);
            lblcost.Name = "lblcost";
            lblcost.Size = new Size(111, 33);
            lblcost.TabIndex = 10;
            lblcost.Text = "name :";
            // 
            // tbvoltage
            // 
            tbvoltage.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            tbvoltage.Location = new Point(179, 217);
            tbvoltage.Name = "tbvoltage";
            tbvoltage.Size = new Size(127, 40);
            tbvoltage.TabIndex = 12;
            tbvoltage.KeyPress += tbvoltage_KeyPress;
            // 
            // lbldemand
            // 
            lbldemand.AutoSize = true;
            lbldemand.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lbldemand.Location = new Point(14, 292);
            lbldemand.Name = "lbldemand";
            lbldemand.Size = new Size(239, 33);
            lbldemand.TabIndex = 13;
            lbldemand.Text = "Power demand :";
            // 
            // tbdemand
            // 
            tbdemand.BackColor = SystemColors.HighlightText;
            tbdemand.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            tbdemand.Location = new Point(259, 289);
            tbdemand.Name = "tbdemand";
            tbdemand.Size = new Size(132, 40);
            tbdemand.TabIndex = 14;
            tbdemand.KeyPress += tbdemand_KeyPress;
            // 
            // bgsub
            // 
            bgsub.BackColor = Color.Chocolate;
            bgsub.Location = new Point(341, 354);
            bgsub.Name = "bgsub";
            bgsub.Size = new Size(647, 135);
            bgsub.TabIndex = 15;
            bgsub.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1000, 501);
            Controls.Add(tbdemand);
            Controls.Add(lbldemand);
            Controls.Add(tbvoltage);
            Controls.Add(lblvoltage);
            Controls.Add(lblcost);
            Controls.Add(lblname);
            Controls.Add(lbshowname);
            Controls.Add(lbelec);
            Controls.Add(bttcal);
            Controls.Add(label2);
            Controls.Add(ddlmain);
            Controls.Add(tbunit);
            Controls.Add(label1);
            Controls.Add(tbname);
            Controls.Add(lbltname);
            Controls.Add(bgsub);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltname;
        private TextBox tbname;
        private Label label1;
        private TextBox tbunit;
        private ComboBox ddlmain;
        private Label label2;
        private Button bttcal;
        private Label lbelec;
        private Label lbshowname;
        private Label lblname;
        private Label lblcost;
        private TextBox tbvoltage;
        private Label lblvoltage;
        private Label lbldemand;
        private TextBox tbdemand;
        private Button bgsub;
    }
}