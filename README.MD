UI 逻辑位于视图中。 输入逻辑位于控制器中。 业务逻辑位于模型中。

MVC 所用的默认 URL 路由逻辑使用如下格式来确定调用的代码：/[Controller]/[ActionName]/[Parameters]

使用 HtmlEncoder.Default.Encode 防止恶意输入（例如通过 JavaScript）损害应用。

如果浏览器中没有任何更改，则可能是正在查看的缓存内容。 在浏览器中按 Ctrl + F5 强制加载来自服务器的响应。

视图模板应仅使用由控制器提供给它的数据。 