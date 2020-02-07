# 百度文字识别基本流程

![百度文字识别基本流程](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/docs/images/baidu-ocr-basic-process.PNG)

“百度文字识别基本流程”是一个基于“流程图”的项目模版，针对使用“百度文字识别活动包”的流程进行了优化。你可以从[templates/BaiduOcrBasicProcess](https://github.com/allenlooplee/BaiduOcrActivitiesPack/tree/master/templates/BaiduOcrBasicProcess)下载这个模版。

> 注意：因为百度文字识别活动包还没发布到UiPath Go，所以在使用这个项目模版时需要手动更新百度文字识别活动包，你可以到[GitHub Releases](https://github.com/allenlooplee/BaiduOcrActivitiesPack/releases)下载最新的版本。

这个项目模板包含以下五个步骤：

## 初始化序列（Initialize）

这个步骤负责加载配置信息。默认情况下，它会从ops/config/AppKeys.xlsx中加载API Key和Secret Key。

## 加载图片序列（Load Image）

这个步骤负责检查并获取下一个需要处理的图片的路径，并把hasNext变量设为True。

## 流程决策（Flow Decision）

如果hasNext变量的值为True，则执行“处理图片序列”步骤；否则，执行“结束序列”步骤。

## 处理图片序列（Process Image）

这个步骤负责执行指定的文字识别活动，从识别结果中提取所需信息，并对已处理的图片进行归档。这个步骤已经包含Baidu OCR Scope活动，并设置了“初始化序列”加载的API Key和Secret Key。你只需把用于示例的VAT Invoice活动换成你想使用的文字识别活动，并设置图片路径就行了。

## 结束序列（Finalize）

这个步骤负责整个流程的收尾工作，如发送一份处理报告。
