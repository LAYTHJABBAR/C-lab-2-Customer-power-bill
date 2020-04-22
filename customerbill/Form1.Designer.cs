namespace customerbill
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlCalculated = new System.Windows.Forms.Panel();
            this.txtCalculated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblw2 = new System.Windows.Forms.Label();
            this.txtKWH2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pnlOffPeak = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblw1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtKWH = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtCNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCamount = new System.Windows.Forms.Label();
            this.lblRamount = new System.Windows.Forms.Label();
            this.lblCOamount = new System.Windows.Forms.Label();
            this.lblIamount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlCalculated.SuspendLayout();
            this.pnlOffPeak.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1041, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Application Calculate a Customer Power Bill";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radIndustrial);
            this.panel2.Controls.Add(this.radCommercial);
            this.panel2.Controls.Add(this.radResidential);
            this.panel2.Location = new System.Drawing.Point(22, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 342);
            this.panel2.TabIndex = 4;
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(18, 252);
            this.radIndustrial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(161, 33);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(18, 146);
            this.radCommercial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(186, 33);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(18, 36);
            this.radResidential.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(176, 33);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(22, 828);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 94);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(612, 828);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 94);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(279, 828);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(268, 94);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnlCalculated
            // 
            this.pnlCalculated.Controls.Add(this.txtCalculated);
            this.pnlCalculated.Controls.Add(this.label7);
            this.pnlCalculated.Location = new System.Drawing.Point(881, 812);
            this.pnlCalculated.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCalculated.Name = "pnlCalculated";
            this.pnlCalculated.Size = new System.Drawing.Size(542, 155);
            this.pnlCalculated.TabIndex = 12;
            this.pnlCalculated.Visible = false;
            // 
            // txtCalculated
            // 
            this.txtCalculated.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculated.Location = new System.Drawing.Point(196, 43);
            this.txtCalculated.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCalculated.Multiline = true;
            this.txtCalculated.Name = "txtCalculated";
            this.txtCalculated.Size = new System.Drawing.Size(276, 65);
            this.txtCalculated.TabIndex = 1;
            this.txtCalculated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Your Bill is :";
            // 
            // lblw2
            // 
            this.lblw2.AutoSize = true;
            this.lblw2.Location = new System.Drawing.Point(2, 29);
            this.lblw2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblw2.Name = "lblw2";
            this.lblw2.Size = new System.Drawing.Size(358, 33);
            this.lblw2.TabIndex = 15;
            this.lblw2.Text = "KWH Used in Off-Peak Hours";
            // 
            // txtKWH2
            // 
            this.txtKWH2.Location = new System.Drawing.Point(398, 22);
            this.txtKWH2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKWH2.Multiline = true;
            this.txtKWH2.Name = "txtKWH2";
            this.txtKWH2.Size = new System.Drawing.Size(252, 58);
            this.txtKWH2.TabIndex = 16;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(691, 29);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(539, 33);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Type here Only KWH Used in off-peak hours";
            // 
            // pnlOffPeak
            // 
            this.pnlOffPeak.Controls.Add(this.lblw2);
            this.pnlOffPeak.Controls.Add(this.lbl2);
            this.pnlOffPeak.Controls.Add(this.txtKWH2);
            this.pnlOffPeak.Location = new System.Drawing.Point(425, 691);
            this.pnlOffPeak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOffPeak.Name = "pnlOffPeak";
            this.pnlOffPeak.Size = new System.Drawing.Size(1235, 99);
            this.pnlOffPeak.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblw1);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Controls.Add(this.txtKWH);
            this.panel3.Location = new System.Drawing.Point(425, 591);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 96);
            this.panel3.TabIndex = 19;
            // 
            // lblw1
            // 
            this.lblw1.AutoSize = true;
            this.lblw1.Location = new System.Drawing.Point(2, 29);
            this.lblw1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblw1.Name = "lblw1";
            this.lblw1.Size = new System.Drawing.Size(148, 33);
            this.lblw1.TabIndex = 15;
            this.lblw1.Text = "KWH Used ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(691, 29);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(496, 33);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Type here Only KWH Used in Peak hours";
            // 
            // txtKWH
            // 
            this.txtKWH.Location = new System.Drawing.Point(398, 22);
            this.txtKWH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKWH.Multiline = true;
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.Size = new System.Drawing.Size(252, 58);
            this.txtKWH.TabIndex = 16;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(34, 135);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(273, 33);
            this.lblNumber.TabIndex = 20;
            this.lblNumber.Text = "Customer Number:";
            // 
            // txtCNumber
            // 
            this.txtCNumber.Location = new System.Drawing.Point(40, 181);
            this.txtCNumber.Multiline = true;
            this.txtCNumber.Name = "txtCNumber";
            this.txtCNumber.Size = new System.Drawing.Size(444, 92);
            this.txtCNumber.TabIndex = 21;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 292);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(243, 33);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(40, 341);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 92);
            this.txtName.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(507, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 73);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "&Add >>";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // grpBox
            // 
            this.grpBox.AutoSize = true;
            this.grpBox.Controls.Add(this.lblIamount);
            this.grpBox.Controls.Add(this.lblCOamount);
            this.grpBox.Controls.Add(this.lblRamount);
            this.grpBox.Controls.Add(this.lblCamount);
            this.grpBox.Controls.Add(this.lblCustomer);
            this.grpBox.Controls.Add(this.label6);
            this.grpBox.Controls.Add(this.label5);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.lstCustomer);
            this.grpBox.Location = new System.Drawing.Point(654, 76);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.grpBox.Size = new System.Drawing.Size(964, 510);
            this.grpBox.TabIndex = 25;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Customer List";
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 33;
            this.lstCustomer.Location = new System.Drawing.Point(23, 48);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(383, 400);
            this.lstCustomer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total no of Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sum of Charge Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sum of Residential";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sum of Commercial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sum of Industrial";
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Location = new System.Drawing.Point(768, 36);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(190, 66);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = " ";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCamount
            // 
            this.lblCamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCamount.Location = new System.Drawing.Point(768, 132);
            this.lblCamount.Name = "lblCamount";
            this.lblCamount.Size = new System.Drawing.Size(190, 66);
            this.lblCamount.TabIndex = 7;
            this.lblCamount.Text = " ";
            this.lblCamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRamount
            // 
            this.lblRamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRamount.Location = new System.Drawing.Point(768, 216);
            this.lblRamount.Name = "lblRamount";
            this.lblRamount.Size = new System.Drawing.Size(190, 66);
            this.lblRamount.TabIndex = 8;
            this.lblRamount.Text = " ";
            this.lblRamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCOamount
            // 
            this.lblCOamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCOamount.Location = new System.Drawing.Point(768, 311);
            this.lblCOamount.Name = "lblCOamount";
            this.lblCOamount.Size = new System.Drawing.Size(190, 66);
            this.lblCOamount.TabIndex = 9;
            this.lblCOamount.Text = " ";
            this.lblCOamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIamount
            // 
            this.lblIamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIamount.Location = new System.Drawing.Point(768, 408);
            this.lblIamount.Name = "lblIamount";
            this.lblIamount.Size = new System.Drawing.Size(190, 66);
            this.lblIamount.TabIndex = 10;
            this.lblIamount.Text = " ";
            this.lblIamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1972, 1921);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlOffPeak);
            this.Controls.Add(this.pnlCalculated);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Customer Power Bill";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCalculated.ResumeLayout(false);
            this.pnlCalculated.PerformLayout();
            this.pnlOffPeak.ResumeLayout(false);
            this.pnlOffPeak.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pnlCalculated;
        private System.Windows.Forms.TextBox txtCalculated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblw2;
        private System.Windows.Forms.TextBox txtKWH2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlOffPeak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblw1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtKWH;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtCNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblIamount;
        private System.Windows.Forms.Label lblCOamount;
        private System.Windows.Forms.Label lblRamount;
        private System.Windows.Forms.Label lblCamount;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCustomer;
    }
}

