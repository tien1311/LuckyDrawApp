#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81963c32961bd6017ad72a020e99fd74ccfd9a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_ThongBao), @"mvc.1.0.view", @"/Views/Data/ThongBao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/ThongBao.cshtml", typeof(AspNetCore.Views_Data_ThongBao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81963c32961bd6017ad72a020e99fd74ccfd9a13", @"/Views/Data/ThongBao.cshtml")]
    public class Views_Data_ThongBao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Manager_EV.Models.ThongBao_ALL>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.1.7.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
  
    ViewData["Title"] = "Thông báo";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(142, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(150, 17, false);
#line 6 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(167, 696, true);
            WriteLiteral(@"</title>
<h2>Thông báo</h2>

<div class=""x_panel"">
    <div class=""x_content"">
        <div>
            <a id=""BtnCreate"" href=""javascript:;"" class=""btn btn-primary"">Tạo mới</a>
        </div>
        <div class=""table-responsive"">
            <table id=""gridArticle"" class=""table table-hover table-bordered"">
                <thead>
                    <tr>
                        <th></th>
                        <th>STT</th>
                        <th>Người lập</th>
                        <th>Ngày lập</th>
                        <th>Tiêu đề</th>
                        <th>Phòng ban</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 27 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                     if (Model != null)
                    {
                        int i = 1;
                        foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1043, 31, true);
            WriteLiteral("                            <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1074, "\"", 1087, 1);
#line 32 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
WriteAttributeValue("", 1079, item.ID, 1079, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1088, 198, true);
            WriteLiteral(">\r\n                                <td><a class=\"Edit\" style=\"color:blue;\" href=\"javascript:;\"><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i></a></td>\r\n                                <td>");
            EndContext();
            BeginContext(1287, 1, false);
#line 34 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1332, 13, false);
#line 35 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                               Write(item.NguoiLap);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1389, 51, false);
#line 36 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                               Write(DateTime.Parse(item.NgayLap).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1484, 11, false);
#line 37 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                               Write(item.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1539, 13, false);
#line 38 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                               Write(item.PhongBan);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 40 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
                            i++;
                        }
                    }

#line default
#line hidden
            BeginContext(1678, 147, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"modal fade\" id=\"openPopup\" role=\"dialog\">\r\n</div>\r\n");
            EndContext();
            BeginContext(1825, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d81a7c13c144ad2ad2fd3cadd109248", async() => {
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
            BeginContext(1873, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1875, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232da5840a37446fab228d1ceb005164", async() => {
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
            BeginContext(1922, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1924, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb5c906aa92c44ec917a52673fdc1ee5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1981, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
 if (ViewBag.ThongBao != null)
{

#line default
#line hidden
            BeginContext(2018, 45, true);
            WriteLiteral("    <script charset=\"UTF-8\">\r\n        alert(\'");
            EndContext();
            BeginContext(2064, 26, false);
#line 56 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 20, true);
            WriteLiteral("\');\r\n    </script>\r\n");
            EndContext();
#line 58 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\ThongBao.cshtml"
}

#line default
#line hidden
            BeginContext(2113, 1438, true);
            WriteLiteral(@"<script>
    $(""#BtnCreate"").click(function () {

        $.ajax({
            type: ""POST"",
            url: ""/Data/CreateThongBao"",
            success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal({
                    backdrop: 'static',
                    keyboard: false,
                    show: true
                });
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });

    $(""#gridArticle .Edit"").click(function () {
        var id = String($(this).closest('tr').attr('id'));

        $.ajax({
            type: ""POST"",
            url: ""/Data/EditThongBao"",
            data: {
                ID: id
            },
            success: function (response) {
                $('#openPopup').html(response);
                $");
            WriteLiteral(@"('#openPopup').modal({
                    backdrop: 'static',
                    keyboard: false,
                    show: true
                });
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Manager_EV.Models.ThongBao_ALL>> Html { get; private set; }
    }
}
#pragma warning restore 1591
