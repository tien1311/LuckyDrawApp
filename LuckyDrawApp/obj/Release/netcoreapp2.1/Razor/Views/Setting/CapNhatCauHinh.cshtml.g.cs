#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "758ad9cdb0e832abea4b36586283144b2b9bc50d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_CapNhatCauHinh), @"mvc.1.0.view", @"/Views/Setting/CapNhatCauHinh.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Setting/CapNhatCauHinh.cshtml", typeof(AspNetCore.Views_Setting_CapNhatCauHinh))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"758ad9cdb0e832abea4b36586283144b2b9bc50d", @"/Views/Setting/CapNhatCauHinh.cshtml")]
    public class Views_Setting_CapNhatCauHinh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.CapNhatCauHinh>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
  
    ViewData["Title"] = "Cập Nhật Ngày Giờ";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(105, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(113, 17, false);
#line 5 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 10, true);
            WriteLiteral("</title>\r\n");
            EndContext();
            BeginContext(181, 62, true);
            WriteLiteral("\r\n<div class=\"item form-group col-md-6 col-sm-12 col-xs-12\">\r\n");
            EndContext();
#line 9 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
     using (Html.BeginForm("CapNhat", "Setting", new { i = 1 }, FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(333, 540, true);
            WriteLiteral(@"        <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
            Ngày bắt đầu 
        </label>
        <div class=""col-md-8 col-sm-6 col-xs-12 "">
            <fieldset class=""col-xs-12"" style=""padding:0px"">
                <div class=""control-group"">
                    <div class=""controls"">
                        <div class="" xdisplay_inputx form-group has-feedback"" id="""">
                            <input type=""text"" class=""form-control has-feedback-right"" id=""single_cal1"" name=""HDMoi""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 873, "\"", 893, 1);
#line 19 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
WriteAttributeValue("", 881, Model.HDMoi, 881, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(894, 875, true);
            WriteLiteral(@">
                            <span class=""fa fa-calendar-o form-control-feedback right"" aria-hidden=""true""></span>
                            <span id=""inputSuccess2Status"" class=""sr-only"">(success)</span>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"">
            Ngày kết thúc
        </label>
        <div class=""col-md-8 col-sm-6 col-xs-12 "">
            <fieldset class=""col-xs-12"" style=""padding:0px"">
                <div class=""control-group"">
                    <div class=""controls"">
                        <div class="" xdisplay_inputx form-group has-feedback"" id="""">
                            <input type=""text"" class=""form-control has-feedback-right"" id=""single_cal2"" name=""HDKT""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1769, "\"", 1788, 1);
#line 35 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
WriteAttributeValue("", 1777, Model.HDKT, 1777, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1789, 470, true);
            WriteLiteral(@">
                            <span class=""fa fa-calendar-o form-control-feedback right"" aria-hidden=""true""></span>
                            <span id=""inputSuccess2Status"" class=""sr-only"">(success)</span>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <div class=""col-sm-3"">
            <button type=""submit"" class=""btn btn-primary"" name=""search"">Lưu</button>
        </div>
");
            EndContext();
#line 48 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
                    
    }

#line default
#line hidden
            BeginContext(2449, 62, true);
            WriteLiteral("</div>\r\n<input type=\"hidden\" class=\"form-control\" name=\"RowID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2511, "\"", 2531, 1);
#line 51 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
WriteAttributeValue("", 2519, Model.RowID, 2519, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2532, 18, true);
            WriteLiteral(" id=\"RowID\" />\r\n\r\n");
            EndContext();
#line 53 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
 if (ViewBag.ThongBao != null)
{

#line default
#line hidden
            BeginContext(2585, 45, true);
            WriteLiteral("    <script charset=\"UTF-8\">\r\n        alert(\'");
            EndContext();
            BeginContext(2631, 26, false);
#line 56 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 20, true);
            WriteLiteral("\');\r\n    </script>\r\n");
            EndContext();
#line 58 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Setting\CapNhatCauHinh.cshtml"
}

#line default
#line hidden
            BeginContext(2680, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.CapNhatCauHinh> Html { get; private set; }
    }
}
#pragma warning restore 1591
