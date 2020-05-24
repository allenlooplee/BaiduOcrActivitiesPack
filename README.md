# 百度OCR活动包

![海报](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/docs/images/Poster.png)

[百度AI开放平台](https://ai.baidu.com/)提供多种文字识别，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程，我也在《RPA开发与应用》（即将出版）中详细讲解了如何在UiPath Studio中识别增值税发票。本代码库的目的是打通UiPath和百度OCR，让开发者能在UiPath Studio中通过简单的拖放和设置把百度OCR用到相关流程中，从而加速开发过程。

## 快速开始

在UiPath Studio中使用百度OCR活动包可以遵循以下步骤：
1. **创建项目**：使用[templates/CloudOcrBasicProcess](https://github.com/allenlooplee/CloudOcrActivitiesPack/tree/master/templates/CloudOcrBasicProcess)模版创建OCR流程，你可以查阅[它的文档](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/cloud-ocr-basic-process.md)。
2. **安装活动包**：打开UiPath Studio的Manage Packages，在[nuget.org](https://api.nuget.org/v3/index.json)中搜索并安装Baidu.AI.Ocr.Activities。
3. **配置密钥**：在百度AI开放平台上创建文字识别应用，并把API Key和Secret Key保存到[config/baidu_ocr_config.xlsx](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/templates/CloudOcrBasicProcess/config/baidu_ocr_config.xlsx)。
4. **加载密钥**: 使用[snippets/LoadBaiduOcrConfig.xaml](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/snippets/LoadBaiduOcrConfig.xaml)代码片段从上述配置文件加载密钥。
5. **使用活动**：把你想使用的OCR活动从Activities面板拖到OCR Scope活动中。

## OCR活动清单

本活动包支持以下[云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)的OCR活动：

#|名称|类型|活动
---|---|---|---
1|[增值税发票识别](https://ai.baidu.com/tech/ocr_receipts/vat_invoice)|票据|[VatInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VatInvoiceActivity.cs)
2|[定额发票识别](https://ai.baidu.com/tech/ocr_receipts/quota_invoice)|票据|[QuotaInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/QuotaInvoiceActivity.cs)
3|[出租车票识别](https://ai.baidu.com/tech/ocr_receipts/taxi_receipt)|票据|[TaxiReceiptActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaxiReceiptActivity.cs)
4|[火车票识别](https://ai.baidu.com/tech/ocr_receipts/train_ticket)|票据|[TrainTicketActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TrainTicketActivity.cs)
5|[身份证识别](https://ai.baidu.com/tech/ocr_cards/idcard)|卡证|[IdCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/IdCardActivity.cs)
6|[户口本识别](https://ai.baidu.com/tech/ocr_cards/household_register)|卡证|[HouseholdRegisterActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HouseholdRegisterActivity.cs)
7|[出生医学证明识别](https://ai.baidu.com/tech/ocr_cards/birth_certificate)|卡证|[BirthCertificateActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BirthCertificateActivity.cs)
8|[护照识别](https://ai.baidu.com/tech/ocr_cards/passport)|卡证|[PassportActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/PassportActivity.cs)
9|[港澳通行证识别](https://ai.baidu.com/tech/ocr_cards/HK_Macau_exitentrypermit)|卡证|[HkMacauExitentrypermitActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HkMacauExitentrypermitActivity.cs)
10|[台湾通行证识别](https://ai.baidu.com/tech/ocr_cards/taiwan_exitentrypermit)|卡证|[TaiwanExitentrypermitActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaiwanExitentrypermitActivity.cs)
11|[营业执照识别](https://ai.baidu.com/tech/ocr_cards/business)|卡证|[BusinessLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BusinessLicenseActivity.cs)
12|[银行卡识别](https://ai.baidu.com/tech/ocr_cards/bankcard)|卡证|[BankCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BankCardActivity.cs)
13|[行驶证识别](https://ai.baidu.com/tech/ocr_cars/vehicle_license)|汽车场景|[VehicleLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleLicenseActivity.cs)
14|[驾驶证识别](https://ai.baidu.com/tech/ocr_cars/driving_license)|汽车场景|[DriverLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/DriverLicenseActivity.cs)
15|[机动车销售发票识别](https://ai.baidu.com/tech/ocr_cars/vehicle_invoice)|汽车场景|[VehicleInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleInvoiceActivity.cs)
16|[车辆合格证识别](https://ai.baidu.com/tech/ocr_cars/vehicle_certificate)|汽车场景|[VehicleCertificateActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleCertificateActivity.cs)

## 其他代码库和参考资料
* [云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)
* [百度OCR API文档](https://ai.baidu.com/ai-doc/OCR/Ek3h7xypm)
* [百度AI开放平台 .NET SDK](https://github.com/Baidu-AIP/dotnet-sdk)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [How to Create Activities](https://docs.uipath.com/integrations/docs/how-to-create-activities)
* [Testing Framework for UiPath](https://connect.uipath.com/marketplace/components/uipath-testing-framework)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往百度AI开放平台进行文字识别。
* 本活动包并不收取任何费用，百度AI开放平台可能[根据你的使用情况收取费用](https://ai.baidu.com/ai-doc/OCR/Jk3h7xtsd)。
