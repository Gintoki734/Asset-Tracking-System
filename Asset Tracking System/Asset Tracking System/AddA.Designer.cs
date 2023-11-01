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
            btnSubmit.Location = new Point(500, 1122);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(222, 142);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(500, 825);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(528, 225);
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
            lblAssign.Location = new Point(184, 825);
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
            label5.Location = new Point(221, 698);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 45);
            label5.TabIndex = 14;
            label5.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(499, 710);
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
            txtIp.Size = new Size(362, 31);
            txtIp.TabIndex = 15;
            txtIp.TextChanged += textBox7_TextChanged;
            // 
            // dtpPdate
            // 
            dtpPdate.Location = new Point(1333, 610);
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
            checkBox1.Location = new Point(309, 610);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(541, 49);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Click the box to add purchase date";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AddA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1319);
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
    }
}