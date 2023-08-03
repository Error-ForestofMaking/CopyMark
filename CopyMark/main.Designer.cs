namespace CopyMark
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.my_panel = new System.Windows.Forms.Panel();
            this.time_label = new System.Windows.Forms.Label();
            this.my_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.start_bt = new System.Windows.Forms.Button();
            this.menubar_panel = new System.Windows.Forms.Panel();
            this.close_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.info_label = new System.Windows.Forms.Label();
            this.my_panel.SuspendLayout();
            this.menubar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // my_panel
            // 
            this.my_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.my_panel.BackColor = System.Drawing.Color.White;
            this.my_panel.Controls.Add(this.info_label);
            this.my_panel.Controls.Add(this.time_label);
            this.my_panel.Controls.Add(this.my_label);
            this.my_panel.Controls.Add(this.score_label);
            this.my_panel.Controls.Add(this.start_bt);
            this.my_panel.Controls.Add(this.progressBar1);
            this.my_panel.Location = new System.Drawing.Point(0, 50);
            this.my_panel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.my_panel.Name = "my_panel";
            this.my_panel.Size = new System.Drawing.Size(400, 550);
            this.my_panel.TabIndex = 0;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(27, 215);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(197, 25);
            this.time_label.TabIndex = 3;
            this.time_label.Text = "아직 테스트하지 않음";
            // 
            // my_label
            // 
            this.my_label.AutoSize = true;
            this.my_label.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.my_label.Location = new System.Drawing.Point(25, 25);
            this.my_label.Name = "my_label";
            this.my_label.Size = new System.Drawing.Size(114, 40);
            this.my_label.TabIndex = 2;
            this.my_label.Text = "내 점수";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("맑은 고딕", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score_label.Location = new System.Drawing.Point(12, 80);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(202, 106);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Null";
            // 
            // start_bt
            // 
            this.start_bt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_bt.BackColor = System.Drawing.Color.DodgerBlue;
            this.start_bt.FlatAppearance.BorderSize = 0;
            this.start_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_bt.ForeColor = System.Drawing.Color.White;
            this.start_bt.Location = new System.Drawing.Point(0, 490);
            this.start_bt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(400, 60);
            this.start_bt.TabIndex = 0;
            this.start_bt.Text = "시작";
            this.start_bt.UseVisualStyleBackColor = false;
            this.start_bt.Click += new System.EventHandler(this.start_bt_ClickAsync);
            // 
            // menubar_panel
            // 
            this.menubar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menubar_panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.menubar_panel.Controls.Add(this.close_bt);
            this.menubar_panel.Controls.Add(this.label1);
            this.menubar_panel.ForeColor = System.Drawing.Color.White;
            this.menubar_panel.Location = new System.Drawing.Point(0, 0);
            this.menubar_panel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.menubar_panel.Name = "menubar_panel";
            this.menubar_panel.Size = new System.Drawing.Size(400, 50);
            this.menubar_panel.TabIndex = 1;
            this.menubar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menubar_panel_MouseDown);
            this.menubar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menubar_panel_MouseMove);
            // 
            // close_bt
            // 
            this.close_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_bt.BackColor = System.Drawing.Color.LightCoral;
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(350, 0);
            this.close_bt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(50, 50);
            this.close_bt.TabIndex = 4;
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CopyMark";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 490);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 60);
            this.progressBar1.TabIndex = 4;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(27, 335);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(215, 125);
            this.info_label.TabIndex = 2;
            this.info_label.Text = "CopyMark for Windows\r\n\r\nProgram Ver : 1.0\r\nRule Ver : 1.0\r\ngoUP UI PC 1.2";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.menubar_panel);
            this.Controls.Add(this.my_panel);
            this.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "main";
            this.Text = "CopyMark";
            this.Load += new System.EventHandler(this.main_Load);
            this.my_panel.ResumeLayout(false);
            this.my_panel.PerformLayout();
            this.menubar_panel.ResumeLayout(false);
            this.menubar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel my_panel;
        private System.Windows.Forms.Panel menubar_panel;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Label my_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label info_label;
    }
}

