
namespace SudungAPINV
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.btnHTDS = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvHienthi = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ số lương";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(311, 132);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(160, 20);
            this.txtmanv.TabIndex = 6;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(311, 168);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(160, 20);
            this.txttennv.TabIndex = 7;
            // 
            // txthsl
            // 
            this.txthsl.Location = new System.Drawing.Point(311, 204);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(160, 20);
            this.txthsl.TabIndex = 8;
            // 
            // btnHTDS
            // 
            this.btnHTDS.Location = new System.Drawing.Point(537, 126);
            this.btnHTDS.Name = "btnHTDS";
            this.btnHTDS.Size = new System.Drawing.Size(75, 23);
            this.btnHTDS.TabIndex = 10;
            this.btnHTDS.Text = "Hiển thị DS";
            this.btnHTDS.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(537, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(537, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvHienthi
            // 
            this.dgvHienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthi.Location = new System.Drawing.Point(166, 250);
            this.dgvHienthi.Name = "dgvHienthi";
            this.dgvHienthi.Size = new System.Drawing.Size(486, 147);
            this.dgvHienthi.TabIndex = 13;
            this.dgvHienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(700, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvHienthi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHTDS);
            this.Controls.Add(this.txthsl);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.Button btnHTDS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvHienthi;
        private System.Windows.Forms.Button btnSua;
    }
}

