#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52b633e53cc82459491da297ad77aab336a89c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DDBL_ViewDetailDDBL), @"mvc.1.0.view", @"/Views/DDBL/ViewDetailDDBL.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DDBL/ViewDetailDDBL.cshtml", typeof(AspNetCore.Views_DDBL_ViewDetailDDBL))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b633e53cc82459491da297ad77aab336a89c35", @"/Views/DDBL/ViewDetailDDBL.cshtml")]
    public class Views_DDBL_ViewDetailDDBL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Manager_EV.Models.TenHanhKhach>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 13, true);
            WriteLiteral("<style>\r\n    ");
            EndContext();
            BeginContext(59, 1036, true);
            WriteLiteral(@"@media(min-width: 768px) {
        .modal-dialog {
            width: 800px;
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
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            <h1 style=""color:red"">Danh sách khách bay</h1>
        </div>
        <div class="""">
            <table id="""" class=""table table-striped jambo_table bulk_action"">
                <thead>
                    <tr class=""headings"">
                        <th>STT</th>
                        <th>Tên khách</th>
                        <th>Giá bán</th>
                        <th>Giá giảm</th>
                    </tr>
                </thead>
             ");
            WriteLiteral("   <tbody>\r\n");
            EndContext();
#line 41 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml"
                     if (Model != null)
                    {
                        int i = 1;
                        foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1275, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1346, 1, false);
#line 47 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml"
                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1391, 10, false);
#line 48 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml"
                               Write(item.TenHK);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1445, 11, false);
#line 49 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml"
                               Write(item.GiaBan);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1500, 12, false);
#line 50 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml"
                               Write(item.GiaGiam);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 52 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\DDBL\ViewDetailDDBL.cshtml"
                            i++;
                        }
                    }

#line default
#line hidden
            BeginContext(1638, 98, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Manager_EV.Models.TenHanhKhach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
