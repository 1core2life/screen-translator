using System.Drawing;

namespace translator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.translatedText = new System.Windows.Forms.Label();
            this.copyrightLabel0 = new System.Windows.Forms.Label();
            this.explainLabel0 = new System.Windows.Forms.Label();
            this.explainLabel1 = new System.Windows.Forms.Label();
            this.explainLabel2 = new System.Windows.Forms.Label();
            this.explainLabel3 = new System.Windows.Forms.Label();
            this.explainLabel4 = new System.Windows.Forms.Label();
            this.explainLabel5 = new System.Windows.Forms.Label();
            this.explainLabel6 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.videoLabel0 = new System.Windows.Forms.Label();
            this.explainLabel7 = new System.Windows.Forms.Label();
            this.videoLabel1 = new System.Windows.Forms.LinkLabel();
            this.sizeChangeCombo = new System.Windows.Forms.ComboBox();
            this.optionBox = new System.Windows.Forms.GroupBox();
            this.engButton = new System.Windows.Forms.Button();
            this.optionLabel3 = new System.Windows.Forms.Label();
            this.japButton = new System.Windows.Forms.Button();
            this.backColorChangeCombo = new System.Windows.Forms.ComboBox();
            this.optionLabel2 = new System.Windows.Forms.Label();
            this.colorChangeCombo = new System.Windows.Forms.ComboBox();
            this.optionLabel1 = new System.Windows.Forms.Label();
            this.optionLabel0 = new System.Windows.Forms.Label();
            this.optionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(-1, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(230, 37);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Screen Translator";
            // 
            // translatedText
            // 
            this.translatedText.AutoSize = true;
            this.translatedText.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.translatedText.Location = new System.Drawing.Point(373, 292);
            this.translatedText.Name = "translatedText";
            this.translatedText.Size = new System.Drawing.Size(82, 16);
            this.translatedText.TabIndex = 5;
            this.translatedText.Text = "글자 예시";
            // 
            // copyrightLabel0
            // 
            this.copyrightLabel0.AutoSize = true;
            this.copyrightLabel0.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.copyrightLabel0.Location = new System.Drawing.Point(12, 442);
            this.copyrightLabel0.Name = "copyrightLabel0";
            this.copyrightLabel0.Size = new System.Drawing.Size(103, 15);
            this.copyrightLabel0.TabIndex = 6;
            this.copyrightLabel0.Text = "program By codic";
            // 
            // explainLabel0
            // 
            this.explainLabel0.AutoSize = true;
            this.explainLabel0.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel0.Location = new System.Drawing.Point(8, 77);
            this.explainLabel0.Name = "explainLabel0";
            this.explainLabel0.Size = new System.Drawing.Size(74, 20);
            this.explainLabel0.TabIndex = 8;
            this.explainLabel0.Text = "사용 방법";
            // 
            // explainLabel1
            // 
            this.explainLabel1.AutoSize = true;
            this.explainLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel1.Location = new System.Drawing.Point(10, 105);
            this.explainLabel1.Name = "explainLabel1";
            this.explainLabel1.Size = new System.Drawing.Size(266, 15);
            this.explainLabel1.TabIndex = 9;
            this.explainLabel1.Text = "1.Alt + 2를 눌러 반투명 스크린으로 이동합니다.";
            // 
            // explainLabel2
            // 
            this.explainLabel2.AutoSize = true;
            this.explainLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel2.Location = new System.Drawing.Point(10, 139);
            this.explainLabel2.Name = "explainLabel2";
            this.explainLabel2.Size = new System.Drawing.Size(308, 15);
            this.explainLabel2.TabIndex = 10;
            this.explainLabel2.Text = "2.화면에 비춰지는 곳 중 원하시는 부분을 드래그합니다.";
            // 
            // explainLabel3
            // 
            this.explainLabel3.AutoSize = true;
            this.explainLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel3.Location = new System.Drawing.Point(10, 173);
            this.explainLabel3.Name = "explainLabel3";
            this.explainLabel3.Size = new System.Drawing.Size(282, 15);
            this.explainLabel3.TabIndex = 11;
            this.explainLabel3.Text = "3.Alt + 3를 눌러 완전 투명 스크린으로 이동합니다.";
            // 
            // explainLabel4
            // 
            this.explainLabel4.AutoSize = true;
            this.explainLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel4.Location = new System.Drawing.Point(10, 209);
            this.explainLabel4.Name = "explainLabel4";
            this.explainLabel4.Size = new System.Drawing.Size(298, 15);
            this.explainLabel4.TabIndex = 12;
            this.explainLabel4.Text = "4.Alt + 1을 누르면 선택 영역 하단에 자막이 나옵니다.";
            // 
            // explainLabel5
            // 
            this.explainLabel5.AutoSize = true;
            this.explainLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel5.Location = new System.Drawing.Point(10, 242);
            this.explainLabel5.Name = "explainLabel5";
            this.explainLabel5.Size = new System.Drawing.Size(321, 15);
            this.explainLabel5.TabIndex = 13;
            this.explainLabel5.Text = "5.새로운 공간을 지정하고 싶으신 경우, 1~4를 반복합니다.";
            // 
            // explainLabel6
            // 
            this.explainLabel6.AutoSize = true;
            this.explainLabel6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel6.Location = new System.Drawing.Point(10, 292);
            this.explainLabel6.Name = "explainLabel6";
            this.explainLabel6.Size = new System.Drawing.Size(88, 15);
            this.explainLabel6.TabIndex = 14;
            this.explainLabel6.Text = "* 종료 Alt + F4";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.versionLabel.Location = new System.Drawing.Point(235, 28);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(34, 15);
            this.versionLabel.TabIndex = 15;
            this.versionLabel.Text = "v 2.0";
            // 
            // videoLabel0
            // 
            this.videoLabel0.AutoSize = true;
            this.videoLabel0.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.videoLabel0.Location = new System.Drawing.Point(10, 346);
            this.videoLabel0.Name = "videoLabel0";
            this.videoLabel0.Size = new System.Drawing.Size(108, 15);
            this.videoLabel0.TabIndex = 16;
            this.videoLabel0.Text = "* 사용 방법 동영상";
            // 
            // explainLabel7
            // 
            this.explainLabel7.AutoSize = true;
            this.explainLabel7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explainLabel7.Location = new System.Drawing.Point(10, 318);
            this.explainLabel7.Name = "explainLabel7";
            this.explainLabel7.Size = new System.Drawing.Size(122, 15);
            this.explainLabel7.TabIndex = 17;
            this.explainLabel7.Text = "* 화면 지우기 Alt + 4";
            // 
            // videoLabel1
            // 
            this.videoLabel1.AutoSize = true;
            this.videoLabel1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.videoLabel1.Location = new System.Drawing.Point(17, 373);
            this.videoLabel1.Name = "videoLabel1";
            this.videoLabel1.Size = new System.Drawing.Size(259, 13);
            this.videoLabel1.TabIndex = 19;
            this.videoLabel1.TabStop = true;
            this.videoLabel1.Text = "https://www.youtube.com/watch?v=tomHduc3vGU";
            // 
            // sizeChangeCombo
            // 
            this.sizeChangeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeChangeCombo.FormattingEnabled = true;
            this.sizeChangeCombo.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "20",
            "30"});
            this.sizeChangeCombo.Location = new System.Drawing.Point(67, 30);
            this.sizeChangeCombo.Name = "sizeChangeCombo";
            this.sizeChangeCombo.Size = new System.Drawing.Size(121, 28);
            this.sizeChangeCombo.TabIndex = 20;
            // 
            // optionBox
            // 
            this.optionBox.Controls.Add(this.engButton);
            this.optionBox.Controls.Add(this.optionLabel3);
            this.optionBox.Controls.Add(this.japButton);
            this.optionBox.Controls.Add(this.backColorChangeCombo);
            this.optionBox.Controls.Add(this.optionLabel2);
            this.optionBox.Controls.Add(this.colorChangeCombo);
            this.optionBox.Controls.Add(this.optionLabel1);
            this.optionBox.Controls.Add(this.optionLabel0);
            this.optionBox.Controls.Add(this.sizeChangeCombo);
            this.optionBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionBox.Location = new System.Drawing.Point(337, 47);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(243, 233);
            this.optionBox.TabIndex = 21;
            this.optionBox.TabStop = false;
            this.optionBox.Text = "환경 설정";
            // 
            // engButton
            // 
            this.engButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.engButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engButton.Location = new System.Drawing.Point(67, 187);
            this.engButton.Name = "engButton";
            this.engButton.Size = new System.Drawing.Size(51, 28);
            this.engButton.TabIndex = 32;
            this.engButton.Text = "영어";
            this.engButton.UseVisualStyleBackColor = false;
            this.engButton.Click += new System.EventHandler(this.engButton_Click);
            // 
            // optionLabel3
            // 
            this.optionLabel3.AutoSize = true;
            this.optionLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionLabel3.Location = new System.Drawing.Point(2, 195);
            this.optionLabel3.Name = "optionLabel3";
            this.optionLabel3.Size = new System.Drawing.Size(59, 15);
            this.optionLabel3.TabIndex = 31;
            this.optionLabel3.Text = "번역 언어";
            // 
            // japButton
            // 
            this.japButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.japButton.Location = new System.Drawing.Point(136, 187);
            this.japButton.Name = "japButton";
            this.japButton.Size = new System.Drawing.Size(52, 28);
            this.japButton.TabIndex = 29;
            this.japButton.Text = "일어";
            this.japButton.UseVisualStyleBackColor = true;
            this.japButton.Click += new System.EventHandler(this.japButton_Click);
            // 
            // backColorChangeCombo
            // 
            this.backColorChangeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backColorChangeCombo.FormattingEnabled = true;
            this.backColorChangeCombo.Items.AddRange(new object[] {
            "빨간색",
            "파란색",
            "초록색",
            "노란색",
            "하얀색",
            "검은색"});
            this.backColorChangeCombo.Location = new System.Drawing.Point(67, 113);
            this.backColorChangeCombo.Name = "backColorChangeCombo";
            this.backColorChangeCombo.Size = new System.Drawing.Size(121, 28);
            this.backColorChangeCombo.TabIndex = 26;
            // 
            // optionLabel2
            // 
            this.optionLabel2.AutoSize = true;
            this.optionLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionLabel2.Location = new System.Drawing.Point(2, 120);
            this.optionLabel2.Name = "optionLabel2";
            this.optionLabel2.Size = new System.Drawing.Size(59, 15);
            this.optionLabel2.TabIndex = 25;
            this.optionLabel2.Text = "글자 배경";
            // 
            // colorChangeCombo
            // 
            this.colorChangeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorChangeCombo.FormattingEnabled = true;
            this.colorChangeCombo.Items.AddRange(new object[] {
            "빨간색",
            "파란색",
            "초록색",
            "노란색",
            "하얀색",
            "검은색"});
            this.colorChangeCombo.Location = new System.Drawing.Point(67, 71);
            this.colorChangeCombo.Name = "colorChangeCombo";
            this.colorChangeCombo.Size = new System.Drawing.Size(121, 28);
            this.colorChangeCombo.TabIndex = 24;
            // 
            // optionLabel1
            // 
            this.optionLabel1.AutoSize = true;
            this.optionLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionLabel1.Location = new System.Drawing.Point(2, 78);
            this.optionLabel1.Name = "optionLabel1";
            this.optionLabel1.Size = new System.Drawing.Size(59, 15);
            this.optionLabel1.TabIndex = 23;
            this.optionLabel1.Text = "글자 색깔";
            // 
            // optionLabel0
            // 
            this.optionLabel0.AutoSize = true;
            this.optionLabel0.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionLabel0.Location = new System.Drawing.Point(2, 34);
            this.optionLabel0.Name = "optionLabel0";
            this.optionLabel0.Size = new System.Drawing.Size(59, 15);
            this.optionLabel0.TabIndex = 22;
            this.optionLabel0.Text = "글자 크기";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 466);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.videoLabel1);
            this.Controls.Add(this.explainLabel7);
            this.Controls.Add(this.videoLabel0);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.translatedText);
            this.Controls.Add(this.explainLabel6);
            this.Controls.Add(this.explainLabel5);
            this.Controls.Add(this.explainLabel4);
            this.Controls.Add(this.explainLabel3);
            this.Controls.Add(this.explainLabel2);
            this.Controls.Add(this.explainLabel1);
            this.Controls.Add(this.explainLabel0);
            this.Controls.Add(this.copyrightLabel0);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Screen Translator";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.optionBox.ResumeLayout(false);
            this.optionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label translatedText;
        private System.Windows.Forms.Label copyrightLabel0;
        private System.Windows.Forms.Label explainLabel0;
        private System.Windows.Forms.Label explainLabel1;
        private System.Windows.Forms.Label explainLabel2;
        private System.Windows.Forms.Label explainLabel3;
        private System.Windows.Forms.Label explainLabel4;
        private System.Windows.Forms.Label explainLabel5;
        private System.Windows.Forms.Label explainLabel6;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label videoLabel0;
        private System.Windows.Forms.Label explainLabel7;
        private System.Windows.Forms.LinkLabel videoLabel1;
        private System.Windows.Forms.ComboBox sizeChangeCombo;
        private System.Windows.Forms.GroupBox optionBox;
        private System.Windows.Forms.Label optionLabel0;
        private System.Windows.Forms.ComboBox colorChangeCombo;
        private System.Windows.Forms.Label optionLabel1;
        private System.Windows.Forms.ComboBox backColorChangeCombo;
        private System.Windows.Forms.Label optionLabel2;
        private System.Windows.Forms.Button engButton;
        private System.Windows.Forms.Label optionLabel3;
        private System.Windows.Forms.Button japButton;
    }
}

