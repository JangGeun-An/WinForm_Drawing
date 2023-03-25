namespace Drawing
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검정색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파랑색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빨간색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우개ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.도구ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.불러오기ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "파일";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.지우기ToolStripMenuItem,
            this.색변경ToolStripMenuItem,
            this.굵기ToolStripMenuItem,
            this.지우개ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 지우기ToolStripMenuItem
            // 
            this.지우기ToolStripMenuItem.Name = "지우기ToolStripMenuItem";
            this.지우기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.지우기ToolStripMenuItem.Text = "모두 지우기";
            this.지우기ToolStripMenuItem.Click += new System.EventHandler(this.지우기ToolStripMenuItem_Click);
            // 
            // 색변경ToolStripMenuItem
            // 
            this.색변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.검정색ToolStripMenuItem,
            this.파랑색ToolStripMenuItem,
            this.빨간색ToolStripMenuItem});
            this.색변경ToolStripMenuItem.Name = "색변경ToolStripMenuItem";
            this.색변경ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.색변경ToolStripMenuItem.Text = "색 변경";
            // 
            // 검정색ToolStripMenuItem
            // 
            this.검정색ToolStripMenuItem.Name = "검정색ToolStripMenuItem";
            this.검정색ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.검정색ToolStripMenuItem.Text = "검정색";
            this.검정색ToolStripMenuItem.Click += new System.EventHandler(this.검정색ToolStripMenuItem_Click);
            // 
            // 파랑색ToolStripMenuItem
            // 
            this.파랑색ToolStripMenuItem.Name = "파랑색ToolStripMenuItem";
            this.파랑색ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.파랑색ToolStripMenuItem.Text = "파랑색";
            this.파랑색ToolStripMenuItem.Click += new System.EventHandler(this.파랑색ToolStripMenuItem_Click);
            // 
            // 빨간색ToolStripMenuItem
            // 
            this.빨간색ToolStripMenuItem.Name = "빨간색ToolStripMenuItem";
            this.빨간색ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.빨간색ToolStripMenuItem.Text = "빨간색";
            this.빨간색ToolStripMenuItem.Click += new System.EventHandler(this.빨간색ToolStripMenuItem_Click);
            // 
            // 굵기ToolStripMenuItem
            // 
            this.굵기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.굵기1ToolStripMenuItem,
            this.굵기2ToolStripMenuItem,
            this.굵기3ToolStripMenuItem});
            this.굵기ToolStripMenuItem.Name = "굵기ToolStripMenuItem";
            this.굵기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.굵기ToolStripMenuItem.Text = "굵기";
            // 
            // 굵기1ToolStripMenuItem
            // 
            this.굵기1ToolStripMenuItem.Name = "굵기1ToolStripMenuItem";
            this.굵기1ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.굵기1ToolStripMenuItem.Text = "굵기 : 1";
            this.굵기1ToolStripMenuItem.Click += new System.EventHandler(this.굵기1ToolStripMenuItem_Click);
            // 
            // 굵기2ToolStripMenuItem
            // 
            this.굵기2ToolStripMenuItem.Name = "굵기2ToolStripMenuItem";
            this.굵기2ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.굵기2ToolStripMenuItem.Text = "굵기 : 2";
            this.굵기2ToolStripMenuItem.Click += new System.EventHandler(this.굵기2ToolStripMenuItem_Click);
            // 
            // 굵기3ToolStripMenuItem
            // 
            this.굵기3ToolStripMenuItem.Name = "굵기3ToolStripMenuItem";
            this.굵기3ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.굵기3ToolStripMenuItem.Text = "굵기 : 3";
            this.굵기3ToolStripMenuItem.Click += new System.EventHandler(this.굵기3ToolStripMenuItem_Click);
            // 
            // 지우개ToolStripMenuItem
            // 
            this.지우개ToolStripMenuItem.Name = "지우개ToolStripMenuItem";
            this.지우개ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.지우개ToolStripMenuItem.Text = "지우개";
            this.지우개ToolStripMenuItem.Click += new System.EventHandler(this.지우개ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "장근_그림판";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검정색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파랑색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빨간색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우개ToolStripMenuItem;
    }
}

