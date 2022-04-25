using System;

namespace CGadge
{
    partial class GadgetsForm
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
            this.GadgetsView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GadgetsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GadgetsView
            // 
            this.GadgetsView.CreationProperties = null;
            this.GadgetsView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.GadgetsView.Location = new System.Drawing.Point(28, 21);
            this.GadgetsView.Name = "GadgetsView";
            this.GadgetsView.Size = new System.Drawing.Size(734, 404);
            this.GadgetsView.Source = new System.Uri("file:///C:/test.html", System.UriKind.Absolute);
            this.GadgetsView.TabIndex = 0;
            this.GadgetsView.ZoomFactor = 1D;
            this.GadgetsView.Click += new System.EventHandler(this.webView21_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\user\\source\\repos\\CGadge\\CGadge\\images\\custom.png";
            this.pictureBox1.Location = new System.Drawing.Point(740, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GadgetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GadgetsView);
            this.Name = "GadgetsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GadgetsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void webView21_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 GadgetsView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

