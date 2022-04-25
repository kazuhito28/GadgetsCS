using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics;

namespace CGadge
{
    public partial class GadgetsForm : Form
    {
    public GadgetsForm()
        {
            InitializeComponent();
            
        }    

        private async Task InitializeAsync()
        {
            await GadgetsView.EnsureCoreWebView2Async(null);   // CoreWebView2 初期化待ち
            GadgetsView.NavigationStarting += webview2_NavigationStarting;
            GadgetsView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            _ = InitializeAsync();
            GadgetsView.Source = new Uri("file://server02/data/%EF%BE%8E%EF%BD%BD%EF%BE%84%EF%BE%83%EF%BE%9E%EF%BD%B0%EF%BE%80/desktop/test.html");

            MessageBox.Show("load");

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("shown");
            //GadgetsView.Size = new System.Drawing.Size(GadgetsForm.clientsize.width , GadgetsForm.clientsize.height 404);
        }

        private void webview2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (!e.Uri.Contains("file://server02/data/%EF%BE%8E%EF%BD%BD%EF%BE%84%EF%BE%83%EF%BE%9E%EF%BD%B0%EF%BE%80/desktop/test.html"))
            {
                MessageBox.Show(e.Uri);
                //MessageBox.Show("許可サイトではありません。\r\nデフォルトブラウザで開きます。");
                Process.Start(e.Uri); // デフォルトブラウザで開く
                e.Cancel = true; // webview2内でのアクセスをキャンセル
                
                return;
            }
            MessageBox.Show("test1");
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;                       // NewWindow のキャンセル
            if (!e.Uri.Contains("teratail"))
            {
                MessageBox.Show(e.Uri);
                Process.Start(e.Uri);
                return;
            }
            GadgetsView.CoreWebView2.Navigate(e.Uri);  // 既存WebView2で遷移
            MessageBox.Show(e.Uri);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }
    }
}

