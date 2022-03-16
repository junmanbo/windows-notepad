
namespace MyNotepad
{
    partial class FrmNote
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
            this.tBoxMain = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.페이지설정UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대하기축소하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대하기축소하기기본값복원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.피드백보내ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxMain
            // 
            this.tBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxMain.Location = new System.Drawing.Point(0, 24);
            this.tBoxMain.Multiline = true;
            this.tBoxMain.Name = "tBoxMain";
            this.tBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxMain.Size = new System.Drawing.Size(743, 319);
            this.tBoxMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.새창ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.toolStripSeparator1,
            this.페이지설정UToolStripMenuItem,
            this.인쇄PToolStripMenuItem,
            this.toolStripSeparator2,
            this.끝내기XToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(F)";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // 새로만들기NToolStripMenuItem
            // 
            this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
            this.새로만들기NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.새로만들기NToolStripMenuItem.Text = "새로 만들기(N)";
            this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
            // 
            // 새창ToolStripMenuItem
            // 
            this.새창ToolStripMenuItem.Name = "새창ToolStripMenuItem";
            this.새창ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.새창ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.새창ToolStripMenuItem.Text = "새 창(W)";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.열기ToolStripMenuItem.Text = "열기(O)...";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.저장SToolStripMenuItem.Text = "저장(S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 다른이름으로저장AToolStripMenuItem
            // 
            this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
            this.다른이름으로저장AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // 페이지설정UToolStripMenuItem
            // 
            this.페이지설정UToolStripMenuItem.Name = "페이지설정UToolStripMenuItem";
            this.페이지설정UToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.페이지설정UToolStripMenuItem.Text = "페이지 설정(U)";
            // 
            // 인쇄PToolStripMenuItem
            // 
            this.인쇄PToolStripMenuItem.Name = "인쇄PToolStripMenuItem";
            this.인쇄PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.인쇄PToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.인쇄PToolStripMenuItem.Text = "인쇄(P)...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(X)";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripSeparator4,
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.삭제LToolStripMenuItem,
            this.toolStripSeparator5,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.실행취소UToolStripMenuItem.Text = "실행 취소(U)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(T)";
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.복사CToolStripMenuItem.Text = "복사(C)";
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
            // 
            // 삭제LToolStripMenuItem
            // 
            this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
            this.삭제LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.삭제LToolStripMenuItem.Text = "삭제(L)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈ToolStripMenuItem,
            this.글꼴ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.서식ToolStripMenuItem.Text = "서식(O)";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Checked = true;
            this.자동줄바꿈ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            this.자동줄바꿈ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈ToolStripMenuItem_Click);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.글꼴ToolStripMenuItem.Text = "글꼴(F)...";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대하기축소하기ToolStripMenuItem,
            this.상태표시줄SToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기ToolStripMenuItem.Text = "보기(V)";
            // 
            // 확대하기축소하기ToolStripMenuItem
            // 
            this.확대하기축소하기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대ToolStripMenuItem,
            this.축소ToolStripMenuItem,
            this.확대하기축소하기기본값복원ToolStripMenuItem});
            this.확대하기축소하기ToolStripMenuItem.Name = "확대하기축소하기ToolStripMenuItem";
            this.확대하기축소하기ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.확대하기축소하기ToolStripMenuItem.Text = "확대하기/축소하기";
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            this.확대ToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.확대ToolStripMenuItem.Text = "확대(I)";
            // 
            // 축소ToolStripMenuItem
            // 
            this.축소ToolStripMenuItem.Name = "축소ToolStripMenuItem";
            this.축소ToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.축소ToolStripMenuItem.Text = "축소(O)";
            // 
            // 확대하기축소하기기본값복원ToolStripMenuItem
            // 
            this.확대하기축소하기기본값복원ToolStripMenuItem.Name = "확대하기축소하기기본값복원ToolStripMenuItem";
            this.확대하기축소하기기본값복원ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.확대하기축소하기기본값복원ToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.확대하기축소하기기본값복원ToolStripMenuItem.Text = "확대하기/축소하기 기본값 복원";
            // 
            // 상태표시줄SToolStripMenuItem
            // 
            this.상태표시줄SToolStripMenuItem.Name = "상태표시줄SToolStripMenuItem";
            this.상태표시줄SToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.상태표시줄SToolStripMenuItem.Text = "상태 표시줄(S)";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기HToolStripMenuItem,
            this.메모장정보AToolStripMenuItem,
            this.toolStripSeparator3,
            this.피드백보내ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말ToolStripMenuItem.Text = "도움말(H)";
            // 
            // 도움말보기HToolStripMenuItem
            // 
            this.도움말보기HToolStripMenuItem.Name = "도움말보기HToolStripMenuItem";
            this.도움말보기HToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.도움말보기HToolStripMenuItem.Text = "도움말 보기(H)";
            // 
            // 메모장정보AToolStripMenuItem
            // 
            this.메모장정보AToolStripMenuItem.Name = "메모장정보AToolStripMenuItem";
            this.메모장정보AToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.메모장정보AToolStripMenuItem.Text = "피드백 보내기(F)";
            this.메모장정보AToolStripMenuItem.Click += new System.EventHandler(this.메모장정보AToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // 피드백보내ToolStripMenuItem
            // 
            this.피드백보내ToolStripMenuItem.Name = "피드백보내ToolStripMenuItem";
            this.피드백보내ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.피드백보내ToolStripMenuItem.Text = "메모장 정보(A)";
            this.피드백보내ToolStripMenuItem.Click += new System.EventHandler(this.피드백보내ToolStripMenuItem_Click);
            // 
            // FrmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 343);
            this.Controls.Add(this.tBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNote";
            this.Text = "MyNotepad V1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 페이지설정UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대하기축소하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대하기축소하기기본값복원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 피드백보내ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

