#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b150407fbbec08569d2455c1994a175706af0c67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Daily_TraCuuSignIn), @"mvc.1.0.view", @"/Views/Daily/TraCuuSignIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Daily/TraCuuSignIn.cshtml", typeof(AspNetCore.Views_Daily_TraCuuSignIn))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b150407fbbec08569d2455c1994a175706af0c67", @"/Views/Daily/TraCuuSignIn.cshtml")]
    public class Views_Daily_TraCuuSignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Manager_EV.Models.DaiLyEV>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery.dataTables.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
  
    ViewData["Title"] = "Tra cứu Signin";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(144, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(152, 17, false);
#line 7 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 10, true);
            WriteLiteral("</title>\r\n");
            EndContext();
            BeginContext(179, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27f64983c95543b4a202913457b071f2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 318, true);
            WriteLiteral(@"
<h2 style=""text-align: center; font-weight: bold;"">TRA CỨU CODE SIGN IN</h2>
<br />
<style>
    .form-group {
        margin-bottom: 15px;
    }
    tbody tr:first-child {
        background-color: #d9edf7;
    }
</style>
<div class=""x_panel"" style=""padding: 10px 17px 0;"">

    <div class=""x_content"">
");
            EndContext();
#line 22 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
         using (Html.BeginForm("TraCuuSignIn", "Daily", new { i = 8 }, FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(654, 1326, true);
            WriteLiteral(@"            <div class=""row"">
                <div class="""">

                    <div class=""col-md-2 col-xs-12"">
                        <div class=""form-group"">

                            <select name=""DieuKien"" class=""form-control"">
                                <option value=""0"">Sign in</option>
                                <option value=""1"">Code</option>
                            </select>
                        </div>
                    </div>
                    <div class=""col-md-2 col-xs-12"">
                        <div class=""form-group"">
                            <input class=""form-control"" type=""text"" name=""GiaTri"" placeholder=""SignIn hoặc Code""/>
                        </div>
                    </div>
                    <div class=""col-md-1 col-xs-12"">
                        <div class=""form-group"" style=""text-align:right;"">

                            <button type=""submit"" name=""search_KH"" value=""search"" class=""btn btn-primary"">Tìm kiếm</button>
         ");
            WriteLiteral(@"               </div>
                    </div>
                    <div class=""col-md-7 col-xs-12"">
                        <p style=""color:red; font-size:14px; padding-top:8px;"">Lưu ý: dòng màu xanh đại lý đang sử dụng</p>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 52 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
        }

#line default
#line hidden
            BeginContext(1991, 1063, true);
            WriteLiteral(@"    </div>
</div>
<div class=""x_panel"">
    <div class=""x_content"">
        <div class=""row"">
            <div class=""table-responsive"">
                <table id=""gridTaiKhoanDaiLy"" class=""table table-hover table-bordered"">
                    <thead>
                        <tr>
                            <th style=""text-align:center"">STT</th>
                            <th style=""text-align:center"">Mã KH</th>
                            <th>Tên Đại Lý</th>
                            <th style=""text-align:right"">Số Dư</th>
                            <th style=""text-align:center"">Kế toán</th>
                            <th style=""text-align:center"">Kinh Doanh</th>
                            <th style=""text-align:center"">Hãng</th>
                            <th style=""text-align:center"">Miền</th>
                            <th style=""text-align:center"">Sign In</th>
                            <th style=""text-align:center"">Code</th>
                        </tr>
                    ");
            WriteLiteral("</thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 75 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                         if (Model != null)
                        {
                            int i = 1;
                            foreach (var item in Model)
                            {
                                double sodu = 0;
                                if (item.SoDu != "" && item.SoDu != null)
                                {
                                    sodu = double.Parse(item.SoDu);
                                }


#line default
#line hidden
            BeginContext(3520, 35, true);
            WriteLiteral("                                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3555, "\"", 3575, 1);
#line 86 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
WriteAttributeValue("", 3560, item.member_kh, 3560, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3576, 78, true);
            WriteLiteral(" class=\"\">\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(3655, 1, false);
#line 87 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3656, 73, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(3730, 14, false);
#line 88 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.member_kh);

#line default
#line hidden
            EndContext();
            BeginContext(3744, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3792, 19, false);
#line 89 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                   Write(item.member_company);

#line default
#line hidden
            EndContext();
            BeginContext(3811, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 91 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                     if (item.SoDu != "" && item.SoDu != null)
                                    {
                                        

#line default
#line hidden
#line 93 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                         if (sodu > 0)
                                        {

#line default
#line hidden
            BeginContext(4038, 87, true);
            WriteLiteral("                                            <td style=\"color: blue; text-align: right\">");
            EndContext();
            BeginContext(4126, 9, false);
#line 95 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                                                  Write(item.SoDu);

#line default
#line hidden
            EndContext();
            BeginContext(4135, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 96 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(4274, 87, true);
            WriteLiteral("                                            <td style=\"color: red; text-align: right \">");
            EndContext();
            BeginContext(4362, 9, false);
#line 99 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                                                  Write(item.SoDu);

#line default
#line hidden
            EndContext();
            BeginContext(4371, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 100 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                        }

#line default
#line hidden
#line 100 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4541, 90, true);
            WriteLiteral("                                        <td style=\"color: red; text-align: right\">0</td>\r\n");
            EndContext();
#line 105 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4670, 66, true);
            WriteLiteral("                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(4737, 13, false);
#line 106 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.KeToanEV);

#line default
#line hidden
            EndContext();
            BeginContext(4750, 73, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(4824, 15, false);
#line 107 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.NhanVienKD);

#line default
#line hidden
            EndContext();
            BeginContext(4839, 73, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(4913, 12, false);
#line 108 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.HangBay);

#line default
#line hidden
            EndContext();
            BeginContext(4925, 73, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(4999, 9, false);
#line 109 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.Mien);

#line default
#line hidden
            EndContext();
            BeginContext(5008, 73, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(5082, 11, false);
#line 110 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.Signin);

#line default
#line hidden
            EndContext();
            BeginContext(5093, 73, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:center\">");
            EndContext();
            BeginContext(5167, 9, false);
#line 111 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                             Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(5176, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 113 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                i++;
                            }
                        }

#line default
#line hidden
            BeginContext(5318, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 116 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                         if (ViewBag.ThongBao != null && ViewBag.ThongBao != "")
                        {

#line default
#line hidden
            BeginContext(5427, 122, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"9\" style=\"text-align: center; color: red;\">");
            EndContext();
            BeginContext(5550, 16, false);
#line 119 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                                                                                   Write(ViewBag.ThongBao);

#line default
#line hidden
            EndContext();
            BeginContext(5566, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 121 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuSignIn.cshtml"
                        }

#line default
#line hidden
            BeginContext(5635, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Manager_EV.Models.DaiLyEV>> Html { get; private set; }
    }
}
#pragma warning restore 1591
