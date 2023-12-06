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
            dataGridView1 = new DataGridView();
            btnSubmit = new Button();
            label2 = new Label();
            txtModel = new TextBox();
            label1 = new Label();
            txtMan = new TextBox();
            lblname = new Label();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(139, 404);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(449, 41);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Click the box to add purchase date";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dtpPdate
            // 
            dtpPdate.Location = new Point(958, 404);
            dtpPdate.Margin = new Padding(2);
            dtpPdate.Name = "dtpPdate";
            dtpPdate.Size = new Size(289, 27);
            dtpPdate.TabIndex = 34;
            dtpPdate.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(69, 319);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 37);
            label6.TabIndex = 33;
            label6.Text = "IP Address";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(291, 330);
            txtIp.Margin = new Padding(2);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(290, 27);
            txtIp.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 474);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 37);
            label5.TabIndex = 31;
            label5.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(291, 484);
            txtNote.Margin = new Padding(2);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(290, 27);
            txtNote.TabIndex = 30;
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssign.Location = new Point(39, 576);
            lblAssign.Margin = new Padding(2, 0, 2, 0);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(224, 37);
            lblAssign.TabIndex = 29;
            lblAssign.Text = "Assign Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 229);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 37);
            label3.TabIndex = 28;
            label3.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(291, 239);
            txtType.Margin = new Padding(2);
            txtType.Name = "txtType";
            txtType.Size = new Size(290, 27);
            txtType.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(292, 576);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(422, 180);
            dataGridView1.TabIndex = 26;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(292, 814);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(178, 114);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 24;
            label2.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(291, 159);
            txtModel.Margin = new Padding(2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(290, 27);
            txtModel.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 22;
            label1.Text = "Manufacturer";
            // 
            // txtMan
            // 
            txtMan.Location = new Point(292, 90);
            txtMan.Margin = new Padding(2);
            txtMan.Name = "txtMan";
            txtMan.Size = new Size(290, 27);
            txtMan.TabIndex = 21;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(69, 19);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(90, 37);
            lblname.TabIndex = 20;
            lblname.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(291, 30);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 27);
            txtName.TabIndex = 19;
            // 
            // EditA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 741);
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
            Name = "EditA";
            Text = "EditA";
            Load += EditA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnSubmit;
        private Label label2;
        private TextBox txtModel;
        private Label label1;
        private TextBox txtMan;
        private Label lblname;
        private TextBox txtName;
    }
}