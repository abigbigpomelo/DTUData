namespace LeafSoft.PartPanel
{
    partial class TCPServerPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDataReceiver = new LeafSoft.Units.TabDataReceive();
            this.MDataCounter = new LeafSoft.Units.DataCounter();
            this.Configer = new LeafSoft.Units.NetTCPServer();
            this.labelShow = new LeafSoft.Units.Label();
            this.SuspendLayout();
            // 
            // tabDataReceiver
            // 
            this.tabDataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDataReceiver.Location = new System.Drawing.Point(181, 3);
            this.tabDataReceiver.Name = "tabDataReceiver";
            this.tabDataReceiver.Size = new System.Drawing.Size(602, 200);
            this.tabDataReceiver.TabIndex = 1;
            // 
            // MDataCounter
            // 
            this.MDataCounter.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.MDataCounter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MDataCounter.Location = new System.Drawing.Point(0, 475);
            this.MDataCounter.Name = "MDataCounter";
            this.MDataCounter.Size = new System.Drawing.Size(800, 25);
            this.MDataCounter.TabIndex = 6;
            // 
            // Configer
            // 
            this.Configer.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Configer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Configer.Location = new System.Drawing.Point(3, 0);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(172, 200);
            this.Configer.TabIndex = 1;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // labelShow
            // 
            this.labelShow.Location = new System.Drawing.Point(21, 307);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(184, 76);
            this.labelShow.TabIndex = 7;
            // 
            // TCPServerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.tabDataReceiver);
            this.Controls.Add(this.MDataCounter);
            this.Controls.Add(this.Configer);
            this.Name = "TCPServerPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private Units.NetTCPServer Configer;
        private Units.DataCounter MDataCounter;
        public Units.TabDataReceive tabDataReceiver;
        private Units.Label labelShow;
    }
}
