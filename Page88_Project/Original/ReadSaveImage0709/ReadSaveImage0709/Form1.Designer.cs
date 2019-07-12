namespace ReadSaveImage0709
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamma1Item = new System.Windows.Forms.ToolStripMenuItem();
            this.gamma2Item = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastLUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increase1Item = new System.Windows.Forms.ToolStripMenuItem();
            this.increase2Item = new System.Windows.Forms.ToolStripMenuItem();
            this.deceaseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parabolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramStrechingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicStrechItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateStrechItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adjustmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItem,
            this.saveItem,
            this.grayToolStripMenuItem,
            this.exitItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(138, 34);
            this.openItem.Text = "&Open";
            this.openItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(138, 34);
            this.saveItem.Text = "&Save";
            this.saveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.grayToolStripMenuItem.Text = "&Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.GrayToolStripMenuItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(138, 34);
            this.exitItem.Text = "&Exit";
            this.exitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // adjustmentToolStripMenuItem
            // 
            this.adjustmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.inverseItem,
            this.gammaToolStripMenuItem,
            this.contrastLUTToolStripMenuItem,
            this.parabolaToolStripMenuItem,
            this.histogramViewToolStripMenuItem,
            this.histogramStrechingToolStripMenuItem});
            this.adjustmentToolStripMenuItem.Name = "adjustmentToolStripMenuItem";
            this.adjustmentToolStripMenuItem.Size = new System.Drawing.Size(133, 34);
            this.adjustmentToolStripMenuItem.Text = "Adjustment";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItem,
            this.subItem});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.brightnessToolStripMenuItem.Text = "&Brightness";
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(164, 34);
            this.addItem.Text = "Add";
            this.addItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // subItem
            // 
            this.subItem.Name = "subItem";
            this.subItem.Size = new System.Drawing.Size(164, 34);
            this.subItem.Text = "Subtract";
            this.subItem.Click += new System.EventHandler(this.SubItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increItem,
            this.decreItem});
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.contrastToolStripMenuItem.Text = "&Contrast";
            // 
            // increItem
            // 
            this.increItem.Name = "increItem";
            this.increItem.Size = new System.Drawing.Size(171, 34);
            this.increItem.Text = "increase";
            this.increItem.Click += new System.EventHandler(this.IncreItem_Click);
            // 
            // decreItem
            // 
            this.decreItem.Name = "decreItem";
            this.decreItem.Size = new System.Drawing.Size(171, 34);
            this.decreItem.Text = "Decrease";
            this.decreItem.Click += new System.EventHandler(this.DecreItem_Click);
            // 
            // inverseItem
            // 
            this.inverseItem.Name = "inverseItem";
            this.inverseItem.Size = new System.Drawing.Size(279, 34);
            this.inverseItem.Text = "&Inverse";
            this.inverseItem.Click += new System.EventHandler(this.InverseItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamma1Item,
            this.gamma2Item});
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.gammaToolStripMenuItem.Text = "&Gamma";
            // 
            // gamma1Item
            // 
            this.gamma1Item.Name = "gamma1Item";
            this.gamma1Item.Size = new System.Drawing.Size(239, 34);
            this.gamma1Item.Text = "gamma > 1";
            this.gamma1Item.Click += new System.EventHandler(this.Gamma1Item_Click);
            // 
            // gamma2Item
            // 
            this.gamma2Item.Name = "gamma2Item";
            this.gamma2Item.Size = new System.Drawing.Size(239, 34);
            this.gamma2Item.Text = "0 < gamma < 1";
            this.gamma2Item.Click += new System.EventHandler(this.Gamma2Item_Click);
            // 
            // contrastLUTToolStripMenuItem
            // 
            this.contrastLUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increase1Item,
            this.increase2Item,
            this.deceaseItem});
            this.contrastLUTToolStripMenuItem.Name = "contrastLUTToolStripMenuItem";
            this.contrastLUTToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.contrastLUTToolStripMenuItem.Text = "ContrastLUT";
            // 
            // increase1Item
            // 
            this.increase1Item.Name = "increase1Item";
            this.increase1Item.Size = new System.Drawing.Size(247, 34);
            this.increase1Item.Text = "Increase";
            this.increase1Item.Click += new System.EventHandler(this.Increase1Item_Click);
            // 
            // increase2Item
            // 
            this.increase2Item.Name = "increase2Item";
            this.increase2Item.Size = new System.Drawing.Size(247, 34);
            this.increase2Item.Text = "Increase(smooth)";
            this.increase2Item.Click += new System.EventHandler(this.Increase2Item_Click);
            // 
            // deceaseItem
            // 
            this.deceaseItem.Name = "deceaseItem";
            this.deceaseItem.Size = new System.Drawing.Size(247, 34);
            this.deceaseItem.Text = "Decrease";
            this.deceaseItem.Click += new System.EventHandler(this.DeceaseItem_Click);
            // 
            // parabolaToolStripMenuItem
            // 
            this.parabolaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapItem,
            this.cupItem});
            this.parabolaToolStripMenuItem.Name = "parabolaToolStripMenuItem";
            this.parabolaToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.parabolaToolStripMenuItem.Text = "Parabola";
            // 
            // CapItem
            // 
            this.CapItem.Name = "CapItem";
            this.CapItem.Size = new System.Drawing.Size(124, 34);
            this.CapItem.Text = "Cap";
            this.CapItem.Click += new System.EventHandler(this.CapItem_Click);
            // 
            // cupItem
            // 
            this.cupItem.Name = "cupItem";
            this.cupItem.Size = new System.Drawing.Size(124, 34);
            this.cupItem.Text = "Cup";
            this.cupItem.Click += new System.EventHandler(this.CupItem_Click);
            // 
            // histogramViewToolStripMenuItem
            // 
            this.histogramViewToolStripMenuItem.Name = "histogramViewToolStripMenuItem";
            this.histogramViewToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.histogramViewToolStripMenuItem.Text = "Histogram View";
            this.histogramViewToolStripMenuItem.Click += new System.EventHandler(this.HistogramViewToolStripMenuItem_Click);
            // 
            // histogramStrechingToolStripMenuItem
            // 
            this.histogramStrechingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicStrechItem,
            this.rateStrechItem,
            this.equalizationItem});
            this.histogramStrechingToolStripMenuItem.Name = "histogramStrechingToolStripMenuItem";
            this.histogramStrechingToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.histogramStrechingToolStripMenuItem.Text = "Histogram Streching";
            // 
            // basicStrechItem
            // 
            this.basicStrechItem.Name = "basicStrechItem";
            this.basicStrechItem.Size = new System.Drawing.Size(201, 34);
            this.basicStrechItem.Text = "Basic";
            this.basicStrechItem.Click += new System.EventHandler(this.BasicStrechItem_Click);
            // 
            // rateStrechItem
            // 
            this.rateStrechItem.Name = "rateStrechItem";
            this.rateStrechItem.Size = new System.Drawing.Size(201, 34);
            this.rateStrechItem.Text = "Rate";
            this.rateStrechItem.Click += new System.EventHandler(this.RateStrechItem_Click);
            // 
            // equalizationItem
            // 
            this.equalizationItem.Name = "equalizationItem";
            this.equalizationItem.Size = new System.Drawing.Size(201, 34);
            this.equalizationItem.Text = "Equallzation";
            this.equalizationItem.Click += new System.EventHandler(this.EqualizationItem_Click);
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // sfdSave
            // 
            this.sfdSave.FileOk += new System.ComponentModel.CancelEventHandler(this.SfdSave_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem subItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increItem;
        private System.Windows.Forms.ToolStripMenuItem decreItem;
        private System.Windows.Forms.ToolStripMenuItem inverseItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamma1Item;
        private System.Windows.Forms.ToolStripMenuItem gamma2Item;
        private System.Windows.Forms.ToolStripMenuItem contrastLUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increase1Item;
        private System.Windows.Forms.ToolStripMenuItem increase2Item;
        private System.Windows.Forms.ToolStripMenuItem deceaseItem;
        private System.Windows.Forms.ToolStripMenuItem parabolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CapItem;
        private System.Windows.Forms.ToolStripMenuItem cupItem;
        private System.Windows.Forms.ToolStripMenuItem histogramViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramStrechingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicStrechItem;
        private System.Windows.Forms.ToolStripMenuItem rateStrechItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationItem;
    }
}

