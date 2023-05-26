namespace WindowsFormsApp1
{
    partial class fNote
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.txb_Title = new System.Windows.Forms.TextBox();
            this.lb_message = new System.Windows.Forms.Label();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.dgv_Note = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fnote_btn_export = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fnote_lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Note)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.Location = new System.Drawing.Point(0, 4);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Lime;
            this.btn_Update.Location = new System.Drawing.Point(242, 4);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(126, 50);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(481, 4);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 50);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(27, 79);
            this.lb_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(69, 22);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "Tiêu đề";
            // 
            // txb_Title
            // 
            this.txb_Title.Location = new System.Drawing.Point(127, 76);
            this.txb_Title.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_Title.Multiline = true;
            this.txb_Title.Name = "txb_Title";
            this.txb_Title.Size = new System.Drawing.Size(405, 36);
            this.txb_Title.TabIndex = 5;
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.Location = new System.Drawing.Point(27, 178);
            this.lb_message.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(82, 22);
            this.lb_message.TabIndex = 6;
            this.lb_message.Text = "Nội dung";
            // 
            // txb_Message
            // 
            this.txb_Message.Location = new System.Drawing.Point(127, 181);
            this.txb_Message.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txb_Message.Multiline = true;
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(405, 332);
            this.txb_Message.TabIndex = 7;
            // 
            // dgv_Note
            // 
            this.dgv_Note.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Note.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Note.Location = new System.Drawing.Point(588, 79);
            this.dgv_Note.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_Note.Name = "dgv_Note";
            this.dgv_Note.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Note.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Note.Size = new System.Drawing.Size(385, 434);
            this.dgv_Note.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fnote_btn_export);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Location = new System.Drawing.Point(127, 521);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 52);
            this.panel1.TabIndex = 8;
            // 
            // fnote_btn_export
            // 
            this.fnote_btn_export.BackColor = System.Drawing.Color.DarkGray;
            this.fnote_btn_export.Location = new System.Drawing.Point(720, 4);
            this.fnote_btn_export.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fnote_btn_export.Name = "fnote_btn_export";
            this.fnote_btn_export.Size = new System.Drawing.Size(126, 50);
            this.fnote_btn_export.TabIndex = 5;
            this.fnote_btn_export.Text = "Xuất ra excel";
            this.fnote_btn_export.UseVisualStyleBackColor = false;
            this.fnote_btn_export.Click += new System.EventHandler(this.fnote_btn_export_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(817, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH GHI CHÚ";
            // 
            // fnote_lb_time
            // 
            this.fnote_lb_time.AutoSize = true;
            this.fnote_lb_time.Location = new System.Drawing.Point(832, 592);
            this.fnote_lb_time.Name = "fnote_lb_time";
            this.fnote_lb_time.Size = new System.Drawing.Size(0, 22);
            this.fnote_lb_time.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 


            // 
            // fNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1045, 623);
            this.Controls.Add(this.fnote_lb_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Note);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.txb_Title);
            this.Controls.Add(this.lb_title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Note)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox txb_Title;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox txb_Message;
        private System.Windows.Forms.DataGridView dgv_Note;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label fnote_lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button fnote_btn_export;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

