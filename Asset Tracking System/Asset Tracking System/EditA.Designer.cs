namespace Asset_Tracking_System
{
    partial class EditA
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
            checkBox1 = new CheckBox();
            dtpPdate = new DateTimePicker();
            label6 = new Label();
            txtIp = new TextBox();
            label5 = new Label();
            txtNote = new TextBox();
            lblAssign = new Label();
            label3 = new Label();
            txtType = new TextBox();
            dgvE = new DataGridView();
            btnSubmit = new Button();
            label2 = new Label();
            txtModel = new TextBox();
            label1 = new Label();
            txtMan = new TextBox();
            lblname = new Label();
            txtName = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpINS = new DateTimePicker();
            txtOSM = new TextBox();
            txtOSV = new TextBox();
            txtOSN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvE).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(186, 618);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(541, 49);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Click the box to add purchase date";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dtpPdate
            // 
            dtpPdate.Location = new Point(834, 636);
            dtpPdate.Margin = new Padding(2);
            dtpPdate.Name = "dtpPdate";
            dtpPdate.Size = new Size(360, 31);
            dtpPdate.TabIndex = 34;
            dtpPdate.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(98, 535);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(173, 45);
            label6.TabIndex = 33;
            label6.Text = "IP Address";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(376, 548);
            txtIp.Margin = new Padding(2);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(362, 31);
            txtIp.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(98, 705);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 45);
            label5.TabIndex = 31;
            label5.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(376, 718);
            txtNote.Margin = new Padding(2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(362, 31);
            txtNote.TabIndex = 30;
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssign.Location = new Point(61, 833);
            lblAssign.Margin = new Padding(2, 0, 2, 0);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(265, 45);
            lblAssign.TabIndex = 29;
            lblAssign.Text = "Assign Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 422);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 28;
            label3.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(376, 435);
            txtType.Margin = new Padding(2);
            txtType.Name = "txtType";
            txtType.Size = new Size(362, 31);
            txtType.TabIndex = 27;
            // 
            // dgvE
            // 
            dgvE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvE.Location = new Point(377, 833);
            dgvE.Margin = new Padding(2);
            dgvE.MultiSelect = false;
            dgvE.Name = "dgvE";
            dgvE.ReadOnly = true;
            dgvE.RowHeadersWidth = 62;
            dgvE.RowTemplate.Height = 33;
            dgvE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvE.Size = new Size(528, 225);
            dgvE.TabIndex = 26;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(377, 1131);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(222, 142);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 322);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 45);
            label2.TabIndex = 24;
            label2.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(376, 335);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(362, 31);
            txtModel.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 235);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 22;
            label1.Text = "Manufacturer";
            // 
            // txtMan
            // 
            txtMan.Location = new Point(377, 248);
            txtMan.Margin = new Padding(2);
            txtMan.Name = "txtMan";
            txtMan.Size = new Size(362, 31);
            txtMan.TabIndex = 21;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(98, 160);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(107, 45);
            lblname.TabIndex = 20;
            lblname.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(376, 174);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 31);
            txtName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(260, 60);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(236, 45);
            label4.TabIndex = 36;
            label4.Text = "Software Asset";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1438, 60);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(236, 45);
            label7.TabIndex = 37;
            label7.Text = "Software Asset";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1159, 436);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(260, 45);
            label11.TabIndex = 41;
            label11.Text = "Installation Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1159, 263);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(178, 45);
            label8.TabIndex = 40;
            label8.Text = "OS Version";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1159, 349);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(220, 45);
            label9.TabIndex = 39;
            label9.Text = "Manufacturer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1159, 174);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(157, 45);
            label10.TabIndex = 38;
            label10.Text = "OS Name";
            // 
            // dtpINS
            // 
            dtpINS.Location = new Point(1475, 447);
            dtpINS.Margin = new Padding(2);
            dtpINS.Name = "dtpINS";
            dtpINS.Size = new Size(360, 31);
            dtpINS.TabIndex = 42;
            // 
            // txtOSM
            // 
            txtOSM.Location = new Point(1475, 349);
            txtOSM.Margin = new Padding(2);
            txtOSM.Name = "txtOSM";
            txtOSM.Size = new Size(362, 31);
            txtOSM.TabIndex = 45;
            // 
            // txtOSV
            // 
            txtOSV.Location = new Point(1476, 262);
            txtOSV.Margin = new Padding(2);
            txtOSV.Name = "txtOSV";
            txtOSV.Size = new Size(362, 31);
            txtOSV.TabIndex = 44;
            // 
            // txtOSN
            // 
            txtOSN.Location = new Point(1475, 188);
            txtOSN.Margin = new Padding(2);
            txtOSN.Name = "txtOSN";
            txtOSN.Size = new Size(362, 31);
            txtOSN.TabIndex = 43;
            // 
            // EditA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1895, 1283);
            Controls.Add(txtOSM);
            Controls.Add(txtOSV);
            Controls.Add(txtOSN);
            Controls.Add(dtpINS);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(dtpPdate);
            Controls.Add(label6);
            Controls.Add(txtIp);
            Controls.Add(label5);
            Controls.Add(txtNote);
            Controls.Add(lblAssign);
            Controls.Add(label3);
            Controls.Add(txtType);
            Controls.Add(dgvE);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(txtMan);
            Controls.Add(lblname);
            Controls.Add(txtName);
            Margin = new Padding(4);
            Name = "EditA";
            Text = "EditA";
            Load += EditA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private DateTimePicker dtpPdate;
        private Label label6;
        private TextBox txtIp;
        private Label label5;
        private TextBox txtNote;
        private Label lblAssign;
        private Label label3;
        private TextBox txtType;
        private DataGridView dgvE;
        private Button btnSubmit;
        private Label label2;
        private TextBox txtModel;
        private Label label1;
        private TextBox txtMan;
        private Label lblname;
        private TextBox txtName;
        private Label label4;
        private Label label7;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpINS;
        private TextBox txtOSM;
        private TextBox txtOSV;
        private TextBox txtOSN;
    }
}