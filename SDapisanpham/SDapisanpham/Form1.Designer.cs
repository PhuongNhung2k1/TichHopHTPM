
namespace SDapisanpham
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan ly san pham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(269, 117);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(166, 20);
            this.txtmasp.TabIndex = 4;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(269, 168);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(166, 20);
            this.txttensp.TabIndex = 5;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(269, 219);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(166, 20);
            this.txtdongia.TabIndex = 6;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(532, 113);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(532, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(532, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvhienthi
            // 
            this.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthi.Location = new System.Drawing.Point(142, 261);
            this.dgvhienthi.Name = "dgvhienthi";
            this.dgvhienthi.Size = new System.Drawing.Size(545, 150);
            this.dgvhienthi.TabIndex = 10;
            this.dgvhienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhienthi_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvhienthi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvhienthi;
    }
}

