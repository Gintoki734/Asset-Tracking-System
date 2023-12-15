namespace Asset_Tracking_System
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
            btnEdit = new Button();
            dataGridView2 = new DataGridView();
            btnAddAsset = new Button();
            btnDelete = new Button();
            btnV = new Button();
            richTextBox1 = new RichTextBox();
            btnEnd = new Button();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnEdit.Location = new Point(428, 727);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(270, 106);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT ASSET";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 96);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1662, 608);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnAddAsset
            // 
            btnAddAsset.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnAddAsset.Location = new Point(18, 727);
            btnAddAsset.Margin = new Padding(2);
            btnAddAsset.Name = "btnAddAsset";
            btnAddAsset.Size = new Size(270, 106);
            btnAddAsset.TabIndex = 3;
            btnAddAsset.Text = "Add Asset";
            btnAddAsset.UseVisualStyleBackColor = true;
            btnAddAsset.Click += btnAddAsset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.Location = new Point(813, 727);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(302, 106);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE ASSET";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnV
            // 
            btnV.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnV.Location = new Point(1218, 727);
            btnV.Margin = new Padding(2);
            btnV.Name = "btnV";
            btnV.Size = new Size(382, 106);
            btnV.TabIndex = 5;
            btnV.Text = "Check vulnerability";
            btnV.UseVisualStyleBackColor = true;
            btnV.Click += btnV_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1702, 96);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(333, 609);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btnEnd
            // 
            btnEnd.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnEnd.Location = new Point(1810, 727);
            btnEnd.Margin = new Padding(2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(223, 106);
            btnEnd.TabIndex = 7;
            btnEnd.Text = "Close";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(1282, 37);
            label4.TabIndex = 37;
            label4.Text = "Please select the data row you want to delete or editor check vulnerability for before clicking the button";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1702, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 37);
            label1.TabIndex = 38;
            label1.Text = "Vulnerability Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1861, 844);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btnEnd);
            Controls.Add(richTextBox1);
            Controls.Add(btnV);
            Controls.Add(btnDelete);
            Controls.Add(btnAddAsset);
            Controls.Add(dataGridView2);
            Controls.Add(btnEdit);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private DataGridView dataGridView2;
        private Button btnAddAsset;
        private Button btnDelete;
        private Button btnV;
        private RichTextBox richTextBox1;
        private Button btnEnd;
        private Label label4;
        private Label label1;
    }
}