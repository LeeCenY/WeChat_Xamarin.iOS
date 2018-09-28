using System;

using UIKit;
using WeChat_Xamarin;

namespace WeChat_XamarinDemo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            WXSendMessage("SDK1.8.3" +
                          "1.SDK增加调起微信刷卡支付接口" +
                          "2.SDK增加小程序订阅消息接口" +
                          "3.修复小程序订阅消息接口没有resp的问题");
        }

        void WXSendMessage(string text)
        {
            try
            {
                SendMessageToWXReq req = new SendMessageToWXReq();
                req.Text = text;
                req.BText = true;
                req.Scene = (int)WXScene.Session;

                var result = WXApi.SendReq(req);
                UIAlertView alertView = new UIAlertView("", "分享结果:" + result, null, "取消");
                alertView.Show();
            }
            catch (Exception ex)
            {
                UIAlertView alertView = new UIAlertView("", "错误:" + ex, null, "取消");
                alertView.Show();
            }
        }
    }
}
