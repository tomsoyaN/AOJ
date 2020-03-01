namespace ProjectAOJ
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnComp = new System.Windows.Forms.Button();
            this.btnNet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox.Location = new System.Drawing.Point(51, 45);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(577, 439);
            this.txtBox.TabIndex = 0;
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(516, 526);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(144, 38);
            this.btnComp.TabIndex = 1;
            this.btnComp.Text = "コンパイラ用";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNet
            // 
            this.btnNet.Location = new System.Drawing.Point(51, 530);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(164, 34);
            this.btnNet.TabIndex = 2;
            this.btnNet.Text = "ネットワーク用";
            this.btnNet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 576);
            this.Controls.Add(this.btnNet);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Button btnNet;
    }
}

