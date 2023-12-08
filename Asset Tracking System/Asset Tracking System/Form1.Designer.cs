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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnEdit.Location = new Point(614, 871);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(338, 132);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT ASSET";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(68, 52);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(2242, 760);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnAddAsset
            // 
            btnAddAsset.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnAddAsset.Location = new Point(102, 871);
            btnAddAsset.Margin = new Padding(2);
            btnAddAsset.Name = "btnAddAsset";
            btnAddAsset.Size = new Size(338, 132);
            btnAddAsset.TabIndex = 3;
            btnAddAsset.Text = "Add Asset";
            btnAddAsset.UseVisualStyleBackColor = true;
            btnAddAsset.Click += btnAddAsset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.Location = new Point(1095, 871);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(377, 132);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE ASSET";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2554, 1055);
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
        }

        #endregion
        private Button btnEdit;
        private DataGridView dataGridView2;
        private Button btnAddAsset;
        private Button btnDelete;
    }
}