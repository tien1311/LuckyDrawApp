#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901d15fb0a883c4b61dd3424e8d9f797c2f17e7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_EditCTKM), @"mvc.1.0.view", @"/Views/Data/EditCTKM.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/EditCTKM.cshtml", typeof(AspNetCore.Views_Data_EditCTKM))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901d15fb0a883c4b61dd3424e8d9f797c2f17e7b", @"/Views/Data/EditCTKM.cshtml")]
    public class Views_Data_EditCTKM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.ChuongTrinhKhuyenMai>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 13, true);
            WriteLiteral("<style>\r\n    ");
            EndContext();
            BeginContext(61, 772, true);
            WriteLiteral(@"@media(min-width: 768px) {
        .modal-dialog {
            width: 1000px;
            margin: 30px auto;
        }
    }

    .modal-body img {
        width: 100% !important;
        height: auto !important;
    }

    .modal-header {
        padding: 6px 15px;
        border-bottom: none;
    }
</style>

<div class=""modal-dialog"">
    <!-- Modal content-->
    <div class=""modal-content"" style="" background: #2A3F54;"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" style="" color: #fff;"" data-dismiss=""modal"">&times;</button>
            <h1 style=""color: #FFF; font-size: 16px;"">Chỉnh sửa bài viết</h1>
        </div>
        <div class=""modal-body"" style=""border-radius:8px; background-color:#fff;"">
");
            EndContext();
#line 29 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
             using (Html.BeginForm("SaveEditCTKM", "Data", new { i = 9 }, FormMethod.Post))
            {

#line default
#line hidden
            BeginContext(941, 323, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-sm-2"">
                        <div class=""form-group"">
                            <label for=""inputEmail3"" class=""control-label"">Hình đại diện (690 x 360)</label>
                            <input class=""form-control"" name=""Images"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1264, "\"", 1285, 1);
#line 35 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
WriteAttributeValue("", 1272, Model.Images, 1272, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1286, 61, true);
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"ID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1347, "\"", 1367, 1);
#line 36 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
WriteAttributeValue("", 1355, Model.RowID, 1355, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1368, 332, true);
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""form-group"">
                            <label for=""inputEmail3"" class=""control-label"">Tiêu đề</label>
                            <input class=""form-control"" name=""Title"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1700, "\"", 1720, 1);
#line 42 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
WriteAttributeValue("", 1708, Model.Title, 1708, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1721, 336, true);
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-sm-3"">
                        <div class=""form-group"">
                            <label>Từ thời gian</label>
                            <input type=""datetime-local"" class=""form-control"" id=""datefrom"" name=""datefrom"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2057, "\"", 2080, 1);
#line 48 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
WriteAttributeValue("", 2065, Model.DateFrom, 2065, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2081, 333, true);
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-sm-3"">
                        <div class=""form-group"">
                            <label>Đến thời gian</label>
                            <input type=""datetime-local"" class=""form-control"" id=""dateto"" name=""dateto"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2414, "\"", 2435, 1);
#line 54 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
WriteAttributeValue("", 2422, Model.DateTo, 2422, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2436, 647, true);
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""form-group"">
                            <label for=""inputEmail3"" class=""control-label"">&nbsp;</label>
                            <div>
                                <button type=""submit"" class=""btn btn-primary"" name=""create"" value=""Save"">Lưu</button>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-12"">
                        <textarea name=""CreateContent"" id=""CreateContent"">
                            ");
            EndContext();
            BeginContext(3084, 13, false);
#line 67 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
                       Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(3097, 91, true);
            WriteLiteral("\r\n                        </textarea>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 71 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditCTKM.cshtml"
            }

#line default
#line hidden
            BeginContext(3203, 55, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <!-- jQuery -->\r\n    ");
            EndContext();
            BeginContext(3258, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c525941f2eb43ecb5ccc31e830a899e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3317, 30, true);
            WriteLiteral("\r\n    <!-- Bootstrap -->\r\n    ");
            EndContext();
            BeginContext(3347, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1466e1c00222479b976ce132245c50a3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3415, 251, true);
            WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            CKEDITOR.replace(\'CreateContent\', {\r\n                height: 200,\r\n                filebrowserUploadUrl: \'/Data/UploadCKEditor\'\r\n            });\r\n        });\r\n    </script>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.ChuongTrinhKhuyenMai> Html { get; private set; }
    }
}
#pragma warning restore 1591
