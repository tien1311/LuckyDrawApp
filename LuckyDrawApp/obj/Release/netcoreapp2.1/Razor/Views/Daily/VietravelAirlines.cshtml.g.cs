#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed61732bbb49c29c434cf9483752570c0f446b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Daily_VietravelAirlines), @"mvc.1.0.view", @"/Views/Daily/VietravelAirlines.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Daily/VietravelAirlines.cshtml", typeof(AspNetCore.Views_Daily_VietravelAirlines))]
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
#line 1 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed61732bbb49c29c434cf9483752570c0f446b8c", @"/Views/Daily/VietravelAirlines.cshtml")]
    public class Views_Daily_VietravelAirlines : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingList<Manager_EV.Models.SubjectModel>>
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
        private global::AspNetCore.Views_Daily_VietravelAirlines.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
  
    ViewData["Title"] = "Công văn VietravelAirlines";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(273, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(281, 17, false);
#line 9 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(298, 66, true);
            WriteLiteral("</title>\r\n<div>\r\n    <h2 class=\"col-sm-8\">VietravelAirlines</h2>\r\n");
            EndContext();
#line 12 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
     using (Html.BeginForm("SearchNews", "Daily", new { i = 8 }, FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(455, 504, true);
            WriteLiteral(@"        <div class=""col-sm-4"">
            <div class=""row"">
                <div class=""col-xs-8"">
                    <input class=""form-control"" type=""text"" name=""tieude"" value="""" placeholder=""Từ khóa tiêu đề"" />
                    <input type=""hidden"" name=""section_id"" value=""132"" />
                </div>
                <div class=""col-xs-4"">
                    <button type=""submit"" class=""btn btn-primary"">Tìm kiếm</button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 25 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
    }

#line default
#line hidden
            BeginContext(966, 136, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"clearfix\">\r\n\r\n</div>\r\n<div class=\"row \">\r\n    <div class=\"col-md-12 col-sm-12\">\r\n        <div class=\"x_panel\">\r\n");
            EndContext();
#line 35 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1159, 598, true);
            WriteLiteral(@"                <div class=""x_content change_color"" style=""padding:0px;"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12"">
                            <div style=""height:100%;"">
                                <div class=""thumbnail"" style=""padding:0;float:left;width:82px;height:82px;margin:10px;max-height:100%;"">
                                    <div class=""image"" style=""width:82px;height:82px;"">
                                        <img style=""max-width:100%; margin-right:10px; display: block;border:0.6px solid;border-color:#dacfcf""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1757, "\"", 1774, 1);
#line 43 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
WriteAttributeValue("", 1763, item.Image, 1763, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1775, 233, true);
            WriteLiteral(" alt=\"image\" />\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div style=\"margin-top:10px;\">\r\n\r\n                                ");
            EndContext();
            BeginContext(2009, 164, false);
#line 50 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
                           Write(Html.ActionLink(item.Description, "QuyDinhHang", "Daily", new { subject_id = @item.subject_id, i = 8 }, new { style = "font-size:12px;font-weight:700;color:#000" }));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 176, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                <span style=\"margin-top:10px;display:block;font-size:10px;color:blue;\">");
            EndContext();
            BeginContext(2350, 9, false);
#line 53 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
                                                                                                  Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2359, 129, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 58 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
            }

#line default
#line hidden
            BeginContext(2503, 80, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\" style=\"float:right;\">\r\n    ");
            EndContext();
            BeginContext(2583, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76d78191018c4d2bafdb420f3fc2c3d1", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Daily_VietravelAirlines.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
#line 63 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\VietravelAirlines.cshtml"
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
            BeginContext(2625, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingList<Manager_EV.Models.SubjectModel>> Html { get; private set; }
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
