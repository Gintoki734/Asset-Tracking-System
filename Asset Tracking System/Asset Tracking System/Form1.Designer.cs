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
            btnAdd = new Button();
            dataGridView2 = new DataGridView();
            btnAddAsset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.Location = new Point(1210, 27);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 106);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(54, 42);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1058, 608);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnAddAsset
            // 
            btnAddAsset.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnAddAsset.Location = new Point(1210, 186);
            btnAddAsset.Margin = new Padding(2);
            btnAddAsset.Name = "btnAddAsset";
            btnAddAsset.Size = new Size(270, 106);
            btnAddAsset.TabIndex = 3;
            btnAddAsset.Text = "Add Asset";
            btnAddAsset.UseVisualStyleBackColor = true;
            btnAddAsset.Click += btnAddAsset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 844);
            Controls.Add(btnAddAsset);
            Controls.Add(dataGridView2);
            Controls.Add(btnAdd);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView dataGridView2;
        private Button btnAddAsset;
    }
}