#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d6c174afe875333d622bbdafb84d3a3b55a7d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_EditKhachHang), @"mvc.1.0.view", @"/Views/KhachHang/EditKhachHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhachHang/EditKhachHang.cshtml", typeof(AspNetCore.Views_KhachHang_EditKhachHang))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d6c174afe875333d622bbdafb84d3a3b55a7d4", @"/Views/KhachHang/EditKhachHang.cshtml")]
    public class Views_KhachHang_EditKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.Show>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/moment/min/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/bootstrap-daterangepicker/daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/custom.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 13, true);
            WriteLiteral("<style>\r\n    ");
            EndContext();
            BeginContext(45, 661, true);
            WriteLiteral(@"@media(min-width: 768px) {
        .modal-dialog {
            width: 800px;
            margin: 30px auto;
        }
    }

    .has-feedback .form-control {
        padding-right: 20px;
    }
</style>
<div class=""modal-dialog"">
    <!-- Modal content-->
    <div class=""modal-content"" id=""abc"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>           
            <Center> <h1 style=""color:red"">Chỉnh sửa khách hàng VIP</h1> </Center>      
        </div>
        <div class=""modal-body"">
            <div class=""x_panel"">
                <div class=""x_content"">
");
            EndContext();
#line 24 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
                     using (Html.BeginForm("Edit", "KhachHang", new { i = 11 }, FormMethod.Post))
                    {

#line default
#line hidden
            BeginContext(828, 973, true);
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""form-horizontal"">
                                <div class=""item form-group col-md-6 col-sm-12 col-xs-12"">
                                    <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
                                        Mã Khách Hàng
                                    </label>
                                    <div class=""col-md-8 col-sm-6 col-xs-12 "">
                                        <fieldset class=""col-xs-12"" style=""padding:0px"">
                                            <div class=""control-group"">
                                                <div class=""controls"">
                                                    <div class="" xdisplay_inputx form-group has-feedback"">
                                                        <input type=""hidden"" id=""IDtxt"" class=""form-control has-feedback-right"" name=""ID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1801, "\"", 1818, 1);
#line 37 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 1809, Model.ID, 1809, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1819, 163, true);
            WriteLiteral(">\r\n                                                        <input type=\"text\" id=\"MaKH\" readonly asp-for=\"MaKH\" class=\"form-control has-feedback-right\" name=\"MaKH\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1982, "\"", 2001, 1);
#line 38 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 1990, Model.MaKH, 1990, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2002, 1203, true);
            WriteLiteral(@">
                                                    </div>
                                                </div>
                                            </div>
                                        </fieldset>
                                    </div>
                                </div>
                                <div class=""item form-group col-md-6 col-sm-12 col-xs-12"">
                                    <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
                                        Tên Công Ty
                                    </label>
                                    <div class=""col-md-8 col-sm-6 col-xs-12 "">
                                        <fieldset class=""col-xs-12"" style=""padding:0px"">
                                            <div class=""control-group"">
                                                <div class=""controls"">
                                                    <div class="" xdisplay_inputx form-group ");
            WriteLiteral("has-feedback\">\r\n                                                        <input type=\"text\" id=\"TenKH\" readonly asp-for=\"TenKH\" class=\"form-control has-feedback-right\" name=\"TenKH\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3205, "\"", 3226, 1);
#line 54 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 3213, Model.TenCty, 3213, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3227, 1010, true);
            WriteLiteral(@">
                                                    </div>
                                                </div>
                                            </div>
                                        </fieldset>
                                    </div>
                                </div>
                                <div class=""item form-group col-md-6 col-sm-12 col-xs-12"">
                                    <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
                                        Nhóm
                                    </label>
                                    <div class=""col-md-8 col-sm-6 col-xs-12 "">
                                        <fieldset class=""col-xs-12"" style=""padding:0px"">
                                            <div class=""control-group"">
                                                <div class=""controls"">
                                                    <select name=""NhomKH"" id=""NhomKH""");
            EndContext();
            BeginWriteAttribute("value", " value=", 4237, "", 4255, 1);
#line 69 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 4244, Model.Nhom, 4244, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4255, 87, true);
            WriteLiteral(" class=\"form-control\">\r\n                                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4342, "\"", 4363, 1);
#line 70 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 4350, Model.IDNhom, 4350, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4364, 17, true);
            WriteLiteral(" selected hidden>");
            EndContext();
            BeginContext(4382, 10, false);
#line 70 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
                                                                                                 Write(Model.Nhom);

#line default
#line hidden
            EndContext();
            BeginContext(4392, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 71 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
                                                         foreach (var item in Model.ListNhomDL)
                                                        {

#line default
#line hidden
            BeginContext(4559, 67, true);
            WriteLiteral("                                                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4626, "\"", 4646, 1);
#line 73 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 4634, item.IDNhom, 4634, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4647, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4649, 12, false);
#line 73 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
                                                                                    Write(item.TenNhom);

#line default
#line hidden
            EndContext();
            BeginContext(4661, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 74 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(4731, 1176, true);
            WriteLiteral(@"                                                    </select>
                                                </div>
                                            </div>
                                        </fieldset>
                                    </div>
                                </div>
                                <div class=""item form-group col-md-6 col-sm-12 col-xs-12"">
                                    <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
                                        Ghi Chú
                                    </label>
                                    <div class=""col-md-8 col-sm-6 col-xs-12 "">
                                        <fieldset class=""col-xs-12"" style=""padding:0px"">
                                            <div class=""control-group"">
                                                <div class=""controls"">
                                                    <div class="" xdisplay_inputx form-group has-");
            WriteLiteral("feedback\">\r\n                                                        <input type=\"text\" id=\"GhiChu\" class=\"form-control has-feedback-right\" name=\"GhiChu\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5907, "\"", 5928, 1);
#line 90 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 5915, Model.Ghichu, 5915, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5929, 1363, true);
            WriteLiteral(@">
                                                    </div>
                                                </div>
                                            </div>
                                        </fieldset>
                                    </div>
                                </div>
                                <div class=""item form-group col-md-6 col-sm-12 col-xs-12"">
                                    <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
                                        Trạng thái
                                    </label>
                                    <div class=""col-md-8 col-sm-6 col-xs-12 "">
                                        <fieldset class=""col-xs-12"" style=""padding:0px"">
                                            <div class=""control-group"">
                                                <div class=""controls"">
                                                    <div class="" xdisplay_inputx form-group h");
            WriteLiteral(@"as-feedback"">
                                                        <label class=""checkbox-inline"" style=""line-height:20px;"">
                                                            <input type=""checkbox"" id=""Hidden"" name=""Hidden""> Ẩn
                                                            <input type=""hidden"" id=""Hiddentxt""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7292, "\"", 7313, 1);
#line 108 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
WriteAttributeValue("", 7300, Model.Status, 7300, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7314, 732, true);
            WriteLiteral(@" />
                                                        </label>
                                                    </div>
                                                </div>
                                            </div>
                                        </fieldset>
                                    </div>
                                </div>
                                <div class=""item form-group col-md-6 col-sm-12 col-xs-12"" style=""text-align:right"">
                                    <button type=""submit"" class=""btn btn-primary"" id=""Edit"" name=""Edit"" value=""Edit"">Lưu</button>
                                </div>
                            </div>
                        </div>
");
            EndContext();
#line 121 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KhachHang\EditKhachHang.cshtml"
                    }

#line default
#line hidden
            BeginContext(8069, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n   \r\n</div><!-- jQuery -->\r\n");
            EndContext();
            BeginContext(8171, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4b0fc16f354a39abb1671329ac3524", async() => {
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
            BeginContext(8230, 22, true);
            WriteLiteral("\r\n<!-- Bootstrap -->\r\n");
            EndContext();
            BeginContext(8252, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aea5980d9a641da845b05705b0f41df", async() => {
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
            BeginContext(8320, 38, true);
            WriteLiteral("\r\n<!-- bootstrap-daterangepicker -->\r\n");
            EndContext();
            BeginContext(8358, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7a97296b16a47edb33863edc1ce4ff4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(8418, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c1626a470246998d1f4a08851fdf61", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8496, 33, true);
            WriteLiteral("\r\n<!-- Custom Theme Scripts -->\r\n");
            EndContext();
            BeginContext(8529, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30d7e80925a847ba9ceee7eb43f4bc85", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8571, 194, true);
            WriteLiteral("\r\n<script>\r\n    var hid = document.getElementById(\"Hiddentxt\").value;\r\n    if (hid == \"True\") {\r\n        document.getElementById(\"Hidden\").setAttribute(\"checked\", \"checked\");\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.Show> Html { get; private set; }
    }
}
#pragma warning restore 1591
