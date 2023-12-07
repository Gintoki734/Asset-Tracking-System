namespace Asset_Tracking_System
{
    partial class AddA
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
            txtName = new TextBox();
            lblname = new Label();
            label1 = new Label();
            txtMan = new TextBox();
            label2 = new Label();
            txtModel = new TextBox();
            btnSubmit = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtType = new TextBox();
            lblAssign = new Label();
            label5 = new Label();
            txtNote = new TextBox();
            label6 = new Label();
            txtIp = new TextBox();
            dtpPdate = new DateTimePicker();
            checkBox1 = new CheckBox();
            label4 = new Label();
            txtOm = new TextBox();
            label7 = new Label();
            txtOv = new TextBox();
            label8 = new Label();
            txtOn = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtIns = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(499, 142);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(362, 31);
            txtName.TabIndex = 0;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(221, 129);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(107, 45);
            lblname.TabIndex = 1;
            lblname.Text = "Name";
            lblname.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 204);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 3;
            label1.Text = "Manufacturer";
            // 
            // txtMan
            // 
            txtMan.Location = new Point(500, 218);
            txtMan.Margin = new Padding(2);
            txtMan.Name = "txtMan";
            txtMan.ReadOnly = true;
            txtMan.Size = new Size(362, 31);
            txtMan.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(221, 291);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 45);
            label2.TabIndex = 5;
            label2.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(499, 304);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(362, 31);
            txtModel.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(500, 1168);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(293, 142);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(500, 871);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(719, 225);
            dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(221, 391);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 9;
            label3.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(499, 404);
            txtType.Margin = new Padding(2);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(362, 31);
            txtType.TabIndex = 8;
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssign.Location = new Point(184, 871);
            lblAssign.Margin = new Padding(2, 0, 2, 0);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(265, 45);
            lblAssign.TabIndex = 10;
            lblAssign.Text = "Assign Employee";
            lblAssign.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(221, 743);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 45);
            label5.TabIndex = 14;
            label5.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(499, 756);
            txtNote.Margin = new Padding(2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(362, 31);
            txtNote.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(221, 504);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(173, 45);
            label6.TabIndex = 16;
            label6.Text = "IP Address";
            label6.Click += label6_Click;
            // 
            // txtIp
            // 
            txtIp.Location = new Point(499, 518);
            txtIp.Margin = new Padding(2);
            txtIp.Name = "txtIp";
            txtIp.ReadOnly = true;
            txtIp.Size = new Size(362, 31);
            txtIp.TabIndex = 15;
            txtIp.TextChanged += textBox7_TextChanged;
            // 
            // dtpPdate
            // 
            dtpPdate.Location = new Point(1333, 656);
            dtpPdate.Margin = new Padding(2);
            dtpPdate.Name = "dtpPdate";
            dtpPdate.Size = new Size(360, 31);
            dtpPdate.TabIndex = 17;
            dtpPdate.Visible = false;
            dtpPdate.ValueChanged += dtpPdate_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(309, 656);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(541, 49);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Click the box to add purchase date";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1138, 231);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 45);
            label4.TabIndex = 24;
            label4.Text = "OS Version";
            // 
            // txtOm
            // 
            txtOm.Location = new Point(1416, 317);
            txtOm.Margin = new Padding(2);
            txtOm.Name = "txtOm";
            txtOm.ReadOnly = true;
            txtOm.Size = new Size(362, 31);
            txtOm.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1138, 317);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(220, 45);
            label7.TabIndex = 22;
            label7.Text = "Manufacturer";
            // 
            // txtOv
            // 
            txtOv.Location = new Point(1417, 231);
            txtOv.Margin = new Padding(2);
            txtOv.Name = "txtOv";
            txtOv.ReadOnly = true;
            txtOv.Size = new Size(362, 31);
            txtOv.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1138, 142);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 45);
            label8.TabIndex = 20;
            label8.Text = "OS Name";
            // 
            // txtOn
            // 
            txtOn.Location = new Point(1416, 155);
            txtOn.Margin = new Padding(2);
            txtOn.Name = "txtOn";
            txtOn.ReadOnly = true;
            txtOn.Size = new Size(362, 31);
            txtOn.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(499, 32);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(249, 45);
            label9.TabIndex = 25;
            label9.Text = "Hardware Asset";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1417, 32);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(236, 45);
            label10.TabIndex = 26;
            label10.Text = "Software Asset";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1138, 404);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(260, 45);
            label11.TabIndex = 28;
            label11.Text = "Installation Date";
            // 
            // txtIns
            // 
            txtIns.Location = new Point(1416, 418);
            txtIns.Margin = new Padding(2);
            txtIns.Name = "txtIns";
            txtIns.ReadOnly = true;
            txtIns.Size = new Size(362, 31);
            txtIns.TabIndex = 29;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(1543, 1168);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(236, 125);
            btnBack.TabIndex = 30;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1319);
            Controls.Add(btnBack);
            Controls.Add(txtIns);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(txtOm);
            Controls.Add(label7);
            Controls.Add(txtOv);
            Controls.Add(label8);
            Controls.Add(txtOn);
            Controls.Add(checkBox1);
            Controls.Add(dtpPdate);
            Controls.Add(label6);
            Controls.Add(txtIp);
            Controls.Add(label5);
            Controls.Add(txtNote);
            Controls.Add(lblAssign);
            Controls.Add(label3);
            Controls.Add(txtType);
            Controls.Add(dataGridView1);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(txtMan);
            Controls.Add(lblname);
            Controls.Add(txtName);
            Margin = new Padding(2);
            Name = "AddA";
            Text = "AddA";
            Load += AddA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblname;
        private Label label1;
        private TextBox txtMan;
        private Label label2;
        private TextBox txtModel;
        private Button btnSubmit;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtType;
        private Label lblAssign;
        private Label label5;
        private TextBox txtNote;
        private Label label6;
        private TextBox txtIp;
        private DateTimePicker dtpPdate;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox txtOm;
        private Label label7;
        private TextBox txtOv;
        private Label label8;
        private TextBox txtOn;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtIns;
        private Button btnBack;
    }
}