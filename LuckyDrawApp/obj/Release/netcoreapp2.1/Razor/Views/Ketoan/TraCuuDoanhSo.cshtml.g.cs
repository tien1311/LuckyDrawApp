#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc5db7e4858be04459d58ea29b0d054a2b472c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ketoan_TraCuuDoanhSo), @"mvc.1.0.view", @"/Views/Ketoan/TraCuuDoanhSo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ketoan/TraCuuDoanhSo.cshtml", typeof(AspNetCore.Views_Ketoan_TraCuuDoanhSo))]
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
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc5db7e4858be04459d58ea29b0d054a2b472c4", @"/Views/Ketoan/TraCuuDoanhSo.cshtml")]
    public class Views_Ketoan_TraCuuDoanhSo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<Manager_EV.Models.ViewModel.ImportDoanhSoViewModel>>
    {
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
        private global::AspNetCore.Views_Ketoan_TraCuuDoanhSo.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
  
    ViewData["Title"] = "Tra Cứu Doanh Số";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(274, 80, true);
            WriteLiteral("\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title>");
            EndContext();
            BeginContext(355, 17, false);
#line 11 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(372, 196, true);
            WriteLiteral("</title>\r\n<style>\r\n    .container {\r\n        display: inline-block;\r\n        width: 100%;\r\n    }\r\n</style>\r\n<h2>Tra cứu doanh số đại lý</h2>\r\n\r\n<div class=\"x_panel\">\r\n    <div class=\"x_content\">\r\n");
            EndContext();
#line 22 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
         using (Html.BeginForm("TraCuuDoanhSo", "KeToan", new { i = 5 }, FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(671, 2380, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-sm-1"">
                    <div class=""form-group"">
                        <label>Tháng</label>
                        <input class=""form-control"" type=""text"" name=""Thang"" placeholder=""Tháng"" />
                    </div>
                </div>
                <div class=""col-sm-1"">
                    <div class=""form-group"">
                        <label>Năm</label>
                        <select class=""form-control"" name=""Nam"">
                            <option value=""2020"">2020</option>
                            <option value=""2021"" selected>2021</option>
                            <option value=""2022"">2022</option>
                            <option value=""2023"">2023</option>
                            <option value=""2024"">2024</option>
                            <option value=""2025"">2025</option>
                            <option value=""2026"">2026</option>
                            <option value=""2027"">2027</");
            WriteLiteral(@"option>
                            <option value=""2028"">2028</option>
                            <option value=""2029"">2029</option>
                            <option value=""2030"">2030</option>
                        </select>
                    </div>
                </div>
                <div class=""col-sm-1"">
                    <div class=""item form-group"">
                        <label>Mã KH</label>
                        <input class=""form-control"" type=""text"" name=""MaKH"" placeholder=""Mã KH"" />
                    </div>
                </div>
                <div class=""col-sm-1"">
                    <div class=""form-group"">
                        <label>&nbsp;</label>
                        <div>
                            <button type=""submit"" class=""btn btn-success btn-block"" name=""Search"" value=""Search"">Tìm kiếm</button>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-1"">
                    <div cl");
            WriteLiteral(@"ass=""form-group"">
                        <label>&nbsp;</label>
                        <div>
                            <button type=""submit"" class=""btn btn-info btn-block"" name=""Export"" value=""Export"">Xuất Excel</button>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 72 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
        }

#line default
#line hidden
            BeginContext(3062, 1219, true);
            WriteLiteral(@"    </div>
</div>

<div class=""x_panel"">
    <div class=""x_content"">
        <div class=""table-responsive"">
            <table id=""gridHoanVe"" class=""table table-striped jambo_table bulk_action"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">STT </th>
                        <th class=""column-title"">Tháng </th>
                        <th class=""column-title"">Mã KH </th>
                        <th class=""column-title"">Tổng </th>
                        <th class=""column-title"">VN </th>
                        <th class=""column-title"">VJ </th>
                        <th class=""column-title"">QH </th>
                        <th class=""column-title"">VU </th>
                        <th class=""column-title"">IATA </th>
                        <th class=""column-title"">Khác </th>
                        <th class=""bulk-actions"" colspan=""9"">
                            <a class=""antoo"" style=""color:#fff; font-weight:500;"">Bulk ");
            WriteLiteral("Actions ( <span class=\"action-cnt\"> </span> ) <i class=\"fa fa-chevron-down\"></i></a>\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 98 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#line 100 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(4426, 79, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4506, 8, false);
#line 103 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.STT);

#line default
#line hidden
            EndContext();
            BeginContext(4514, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4567, 10, false);
#line 104 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.Thang);

#line default
#line hidden
            EndContext();
            BeginContext(4577, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(4579, 8, false);
#line 104 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                                    Write(item.Nam);

#line default
#line hidden
            EndContext();
            BeginContext(4587, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4640, 9, false);
#line 105 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.MaKH);

#line default
#line hidden
            EndContext();
            BeginContext(4649, 68, true);
            WriteLiteral("</td>\r\n                                <td style=\"font-weight:bold\">");
            EndContext();
            BeginContext(4718, 45, false);
#line 106 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                                        Write(item.Tong.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(4763, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4816, 43, false);
#line 107 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.VN.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(4859, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4912, 43, false);
#line 108 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.VJ.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(4955, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(5008, 43, false);
#line 109 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.QH.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5051, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(5104, 43, false);
#line 110 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.VU.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5147, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(5200, 45, false);
#line 111 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.IATA.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5245, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(5298, 45, false);
#line 112 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                                        Write(item.Khac.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5343, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 114 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                        }

#line default
#line hidden
#line 114 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(5435, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 118 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
             if (Model != null)
            {

#line default
#line hidden
            BeginContext(5531, 64, true);
            WriteLiteral("                <nav style=\"float:right;\">\r\n                    ");
            EndContext();
            BeginContext(5595, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c3ec79b68524831bac1f90f112e4c26", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Ketoan_TraCuuDoanhSo.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
#line 121 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
__PagerViewComponentTagHelper.pagingList = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("paging-list", __PagerViewComponentTagHelper.pagingList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5637, 26, true);
            WriteLiteral("\r\n                </nav>\r\n");
            EndContext();
#line 123 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
            }

#line default
#line hidden
            BeginContext(5678, 40, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 129 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
 if (ViewBag.ThongBao != null)
{

#line default
#line hidden
            BeginContext(5753, 45, true);
            WriteLiteral("    <script charset=\"UTF-8\">\r\n        alert(\'");
            EndContext();
            BeginContext(5799, 26, false);
#line 132 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(5825, 20, true);
            WriteLiteral("\');\r\n    </script>\r\n");
            EndContext();
#line 134 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Ketoan\TraCuuDoanhSo.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<Manager_EV.Models.ViewModel.ImportDoanhSoViewModel>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pager")]
        public class __Generated__PagerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PagerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public ReflectionIT.Mvc.Paging.IPagingList pagingList { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Pager", new { pagingList });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
