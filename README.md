# Xamarin iOS binding WeChatSDK v1.8.31

### NuGet 安装
- [Xamarin.iOS.WechatOpenSDK](https://www.nuget.org/packages/Xamarin.iOS.WechatOpenSDK) [![NuGet](https://img.shields.io/nuget/v/Xamarin.iOS.WechatOpenSDK.svg?label=NuGet)](https://www.nuget.org/packages/Xamarin.iOS.WechatOpenSDK)


- #### 在 ```AppDelegate.cs``` 的 ```didFinishLaunchingWithOptions``` 函数中向微信注册ID

- #### 引用
```
    using WeChat_Xamarin;
```

- #### 向微信注册ID
```
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        //请填写您的AppID,否则不会激活微信页面
        WXApi.RegisterApp("AppID");
        
        return true;
    }
```

- #### 调用微信分享文本
```
    WXSendMessage("SDK1.8.3" +
                  "1.SDK增加调起微信刷卡支付接口" +
                  "2.SDK增加小程序订阅消息接口" +
                  "3.修复小程序订阅消息接口没有resp的问题");
```

- #### 微信分享文本函数
```
    void WXSendMessage(string text)
    {
        try {
            SendMessageToWXReq req = new SendMessageToWXReq();
            req.Text = text;
            req.BText = true;
            req.Scene = (int)WXScene.Session;

            var result = WXApi.SendReq(req);
            UIAlertView alertView = new UIAlertView("", "分享结果:" + result, null, "取消");
            alertView.Show();
        } catch (Exception ex) {
            UIAlertView alertView = new UIAlertView("", "错误:" + ex, null, "取消");
            alertView.Show();
        }
    }
```
