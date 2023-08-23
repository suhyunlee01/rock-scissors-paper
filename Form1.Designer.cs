namespace 닷넷_연습_가위바위보_앱_제작
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
            this.rk = new System.Windows.Forms.Button();
            this.sr = new System.Windows.Forms.Button();
            this.pr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.My = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Com = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rk
            // 
            this.rk.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rk.Location = new System.Drawing.Point(264, 151);
            this.rk.Name = "rk";
            this.rk.Size = new System.Drawing.Size(75, 39);
            this.rk.TabIndex = 0;
            this.rk.Text = "✊";
            this.rk.UseVisualStyleBackColor = true;
            this.rk.Click += new System.EventHandler(this.rk_Click);
            // 
            // sr
            // 
            this.sr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sr.Location = new System.Drawing.Point(384, 151);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(75, 39);
            this.sr.TabIndex = 1;
            this.sr.Text = "✌️";
            this.sr.UseVisualStyleBackColor = true;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // pr
            // 
            this.pr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pr.Location = new System.Drawing.Point(506, 151);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(75, 39);
            this.pr.TabIndex = 2;
            this.pr.Text = "✋";
            this.pr.UseVisualStyleBackColor = true;
            this.pr.Click += new System.EventHandler(this.pr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(270, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "내가 낸 것";
            // 
            // My
            // 
            this.My.AutoSize = true;
            this.My.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.My.Location = new System.Drawing.Point(439, 247);
            this.My.Name = "My";
            this.My.Size = new System.Drawing.Size(54, 21);
            this.My.TabIndex = 4;
            this.My.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(270, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "컴퓨터가 낸 것";
            // 
            // Com
            // 
            this.Com.AutoSize = true;
            this.Com.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Com.Location = new System.Drawing.Point(439, 276);
            this.Com.Name = "Com";
            this.Com.Size = new System.Drawing.Size(54, 21);
            this.Com.TabIndex = 6;
            this.Com.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(270, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "승 패 결과";
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Res.Location = new System.Drawing.Point(439, 308);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(54, 21);
            this.Res.TabIndex = 8;
            this.Res.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Com);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.My);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.rk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rk;
        private System.Windows.Forms.Button sr;
        private System.Windows.Forms.Button pr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label My;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Com;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Res;
    }
}

