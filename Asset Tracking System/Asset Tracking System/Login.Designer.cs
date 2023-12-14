namespace Asset_Tracking_System
{
    partial class Login
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
            label1 = new Label();
            txtPass = new TextBox();
            lblname = new Label();
            txtName = new TextBox();
            lblError = new Label();
            cbs = new CheckBox();
            btnLogIn = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(558, 318);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 26;
            label1.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(468, 402);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(290, 27);
            txtPass.TabIndex = 25;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(550, 158);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(140, 37);
            lblname.TabIndex = 24;
            lblname.Text = "Username";
            lblname.Click += lblname_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(468, 234);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 27);
            txtName.TabIndex = 23;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(468, 453);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 37);
            lblError.TabIndex = 27;
            // 
            // cbs
            // 
            cbs.AutoSize = true;
            cbs.Location = new Point(794, 405);
            cbs.Margin = new Padding(2, 2, 2, 2);
            cbs.Name = "cbs";
            cbs.Size = new Size(132, 24);
            cbs.TabIndex = 28;
            cbs.Text = "show password";
            cbs.UseVisualStyleBackColor = true;
            cbs.CheckedChanged += cbs_CheckedChanged;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.Location = new Point(507, 538);
            btnLogIn.Margin = new Padding(2, 2, 2, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(230, 86);
            btnLogIn.TabIndex = 29;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(507, 717);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(230, 86);
            btnExit.TabIndex = 30;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 844);
            Controls.Add(btnExit);
            Controls.Add(btnLogIn);
            Controls.Add(cbs);
            Controls.Add(lblError);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(lblname);
            Controls.Add(txtName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Label lblname;
        private TextBox txtName;
        private Label lblError;
        private CheckBox cbs;
        private Button btnLogIn;
        private Button btnExit;
    }
}