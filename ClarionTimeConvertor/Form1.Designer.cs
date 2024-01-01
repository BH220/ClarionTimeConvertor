namespace ClarionTimeConvertor
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cDate = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gDate
            // 
            this.gDate.EditValue = null;
            this.gDate.Location = new System.Drawing.Point(25, 60);
            this.gDate.Name = "gDate";
            this.gDate.Properties.Appearance.Font = new System.Drawing.Font("굴림", 12F);
            this.gDate.Properties.Appearance.Options.UseFont = true;
            this.gDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gDate.Size = new System.Drawing.Size(109, 22);
            this.gDate.TabIndex = 0;
            this.gDate.DateTimeChanged += new System.EventHandler(this.gDate_DateTimeChanged);
            this.gDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.gDate_EditValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("굴림", 9F);
            this.labelControl1.Location = new System.Drawing.Point(55, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 12);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "일반형식";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("굴림", 9F);
            this.labelControl2.Location = new System.Drawing.Point(260, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 12);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "클라리온형식";
            // 
            // cDate
            // 
            this.cDate.EditValue = "";
            this.cDate.Location = new System.Drawing.Point(242, 60);
            this.cDate.Name = "cDate";
            this.cDate.Properties.Appearance.Font = new System.Drawing.Font("굴림", 12F);
            this.cDate.Properties.Appearance.Options.UseFont = true;
            this.cDate.Properties.Appearance.Options.UseTextOptions = true;
            this.cDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cDate.Size = new System.Drawing.Size(109, 22);
            this.cDate.TabIndex = 4;
            this.cDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cDate_EditValueChanging);
            this.cDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cDate_KeyDown);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(162, 36);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 122);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.cDate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gDate);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 161);
            this.MinimumSize = new System.Drawing.Size(391, 161);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "날짜 변환기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit gDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit cDate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

