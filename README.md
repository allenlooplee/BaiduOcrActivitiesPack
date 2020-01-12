# 百度文字识别活动包

百度AI开放平台提供多种文字识别，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程。本代码库的目的是打通UiPath和百度文字识别，让开发者能在UiPath Studio中通过简单的拖放和设置把百度文字识别应用到多种RPA流程中。

## 开发计划和状态

名称|类型|活动|发布日期|任务状态
---|---|---|---|---
[增值税发票识别](https://ai.baidu.com/tech/ocr_receipts/vat_invoice)|票据|VatInvoiceActivity|2020-1-12|完成
[定额发票识别](https://ai.baidu.com/tech/ocr_receipts/quota_invoice)|票据|QuotaInvoiceActivity|2020-1-19|计划
[出租车票识别](https://ai.baidu.com/tech/ocr_receipts/taxi_receipt)|票据|TaxiReceiptActivity|2020-1-19|计划

## 安装

## 使用

## 构建

如果你想自行构建或改进代码，你需要安装以下工具：
1. [Visual Studio 2019](https://visualstudio.microsoft.com/)，安装的时候需要[选中Windows Workflow Foundation](https://docs.microsoft.com/en-us/visualstudio/workflow-designer/developing-applications-with-the-workflow-designer?view=vs-2019#install-windows-workflow-foundation)
2. [UiPath Activity Creator](https://marketplace.visualstudio.com/items?itemName=UiPathLabs.UiPathActivitySet)
3. [UiPath Studio](https://www.uipath.com/start-trial)

Visual Studio用来打开[活动包项目](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr.sln)，UiPath Studio用来打开[测试项目](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/tests/Baidu.AI.Ocr.Tests/Main.xaml)。在运行测试项目之前，你需要注册[百度AI开放平台](https://ai.baidu.com/)并创建文字识别应用，然后把API Key和Secret Key填入BaiduOcrScope活动的相应属性。

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 其他代码库和参考资料
* [百度AI开放平台 .NET SDK](https://github.com/Baidu-AIP/dotnet-sdk)
* [百度文字识别API文档](https://ai.baidu.com/ai-doc/OCR/Ek3h7xypm)
* [Quick Start: The 5 minute activity set](https://docs.uipath.com/integrations/docs/quick-start)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)
