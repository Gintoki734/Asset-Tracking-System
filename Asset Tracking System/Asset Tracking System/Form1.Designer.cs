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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnEdit.Location = new Point(535, 871);
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
            dataGridView2.Location = new Point(23, 20);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(2077, 760);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnAddAsset
            // 
            btnAddAsset.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnAddAsset.Location = new Point(23, 871);
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
            btnDelete.Location = new Point(1016, 871);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(377, 132);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE ASSET";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnV
            // 
            btnV.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnV.Location = new Point(1523, 871);
            btnV.Margin = new Padding(2);
            btnV.Name = "btnV";
            btnV.Size = new Size(478, 132);
            btnV.TabIndex = 5;
            btnV.Text = "Check vulnerability";
            btnV.UseVisualStyleBackColor = true;
            btnV.Click += btnV_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2127, 20);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 760);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // btnEnd
            // 
            btnEnd.Font = new Font("Segoe UI Semilight", 26F, FontStyle.Italic, GraphicsUnit.Point);
            btnEnd.Location = new Point(2263, 871);
            btnEnd.Margin = new Padding(2);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(279, 132);
            btnEnd.TabIndex = 7;
            btnEnd.Text = "Close";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2554, 1055);
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
        }

        #endregion
        private Button btnEdit;
        private DataGridView dataGridView2;
        private Button btnAddAsset;
        private Button btnDelete;
        private Button btnV;
        private RichTextBox richTextBox1;
        private Button btnEnd;
    }
}