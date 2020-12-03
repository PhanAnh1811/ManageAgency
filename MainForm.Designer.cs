
namespace QuanLyDaiLy
{
    partial class MainForm
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
            this.btn_Agency = new System.Windows.Forms.Button();
            this.btn_Items = new System.Windows.Forms.Button();
            this.btn_Release = new System.Windows.Forms.Button();
            this.btn_Money = new System.Windows.Forms.Button();
            this.btn_Debt = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Agency
            // 
            this.btn_Agency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agency.Location = new System.Drawing.Point(65, 12);
            this.btn_Agency.Name = "btn_Agency";
            this.btn_Agency.Size = new System.Drawing.Size(155, 75);
            this.btn_Agency.TabIndex = 0;
            this.btn_Agency.Text = "ĐẠI LÝ";
            this.btn_Agency.UseVisualStyleBackColor = true;
            this.btn_Agency.Click += new System.EventHandler(this.btn_Agency_Click);
            // 
            // btn_Items
            // 
            this.btn_Items.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Items.Location = new System.Drawing.Point(316, 12);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.Size = new System.Drawing.Size(155, 75);
            this.btn_Items.TabIndex = 1;
            this.btn_Items.Text = "MẶT HÀNG";
            this.btn_Items.UseVisualStyleBackColor = true;
            this.btn_Items.Click += new System.EventHandler(this.btn_Items_Click);
            // 
            // btn_Release
            // 
            this.btn_Release.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Release.Location = new System.Drawing.Point(560, 12);
            this.btn_Release.Name = "btn_Release";
            this.btn_Release.Size = new System.Drawing.Size(155, 75);
            this.btn_Release.TabIndex = 2;
            this.btn_Release.Text = "XUẤT HÀNG";
            this.btn_Release.UseVisualStyleBackColor = true;
            this.btn_Release.Click += new System.EventHandler(this.btn_Release_Click);
            // 
            // btn_Money
            // 
            this.btn_Money.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Money.Location = new System.Drawing.Point(65, 150);
            this.btn_Money.Name = "btn_Money";
            this.btn_Money.Size = new System.Drawing.Size(155, 75);
            this.btn_Money.TabIndex = 3;
            this.btn_Money.Text = "THU TIỀN";
            this.btn_Money.UseVisualStyleBackColor = true;
            this.btn_Money.Click += new System.EventHandler(this.btn_Money_Click);
            // 
            // btn_Debt
            // 
            this.btn_Debt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Debt.Location = new System.Drawing.Point(316, 150);
            this.btn_Debt.Name = "btn_Debt";
            this.btn_Debt.Size = new System.Drawing.Size(155, 75);
            this.btn_Debt.TabIndex = 4;
            this.btn_Debt.Text = "THU NỢ";
            this.btn_Debt.UseVisualStyleBackColor = true;
            this.btn_Debt.Click += new System.EventHandler(this.btn_Debt_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(560, 150);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(155, 75);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "ĐĂNG XUẤT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 500);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Debt);
            this.Controls.Add(this.btn_Money);
            this.Controls.Add(this.btn_Release);
            this.Controls.Add(this.btn_Items);
            this.Controls.Add(this.btn_Agency);
            this.Name = "MainForm";
            this.Text = "QUẢN LÝ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Agency;
        private System.Windows.Forms.Button btn_Items;
        private System.Windows.Forms.Button btn_Release;
        private System.Windows.Forms.Button btn_Money;
        private System.Windows.Forms.Button btn_Debt;
        private System.Windows.Forms.Button btn_Logout;
    }
}