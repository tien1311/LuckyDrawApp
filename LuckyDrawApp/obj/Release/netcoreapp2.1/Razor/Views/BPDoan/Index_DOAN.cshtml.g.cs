#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\BPDoan\Index_DOAN.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7852e16a8cd2db60467c8f08c20784d038081d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BPDoan_Index_DOAN), @"mvc.1.0.view", @"/Views/BPDoan/Index_DOAN.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BPDoan/Index_DOAN.cshtml", typeof(AspNetCore.Views_BPDoan_Index_DOAN))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7852e16a8cd2db60467c8f08c20784d038081d", @"/Views/BPDoan/Index_DOAN.cshtml")]
    public class Views_BPDoan_Index_DOAN : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\BPDoan\Index_DOAN.cshtml"
  
    ViewData["Title"] = "Bộ phận đoàn";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(102, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(112, 17, false);
#line 7 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\BPDoan\Index_DOAN.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 1428, true);
            WriteLiteral(@"</title>

<style>
    .container-login100 {
        width: 100%;
        min-height: 100vh;
        flex-wrap: wrap;
        justify-content: center;
        align-items: center;
        padding: 15px;
        background-position: center;
        background-size: cover;
        background-repeat: no-repeat;
    }

    .img-responsive {
        border-radius: 7px;
        margin-bottom: 30px;
    }

    .logo {
        text-align: center;
        margin-top: 30px;
        margin-bottom: 50px;
    }

    .container-login100 {
        background-image: url('/images/2.png');
    }

    .container-content {
        background: #fff;
        border-radius: 5px;
        padding: 0px;
        text-align: justify;
    }

    .content-iframe {
        margin: auto;
        width: 100%;
    }

    .nav-tabs > li.active > a, .nav-tabs > li.active > a:focus, .nav-tabs > li.active > a:hover {
        font-weight: bold;
    }

    .nav > li > a:focus, .nav > li > a:hover {
    ");
            WriteLiteral(@"    color: #000 !important;
    }

    .content-iframe iframe {
        height: 800px;
        width: 100%;
        border-radius: 7px;
    }

    .tab-content > .active {
        opacity: 1;
    }

    .btn-BSP {
        color: #fff;
        background-color: #6c0678;
        border-color: #6c0678;
    }

    .nav > li > a {
        padding: 8px 13px 8px !important;
    }

    ");
            EndContext();
            BeginContext(1558, 373, true);
            WriteLiteral(@"@media (max-width: 768px) {
        .logo {
            text-align: center;
            margin-top: 0px;
            margin-bottom: 30px;
        }

        .container-login100 {
            background-image: url('/images/5.jpg');
            background-position: inherit;
        }

        .content-iframe {
            width: 100%;
        }
    }

    ");
            EndContext();
            BeginContext(1932, 1590, true);
            WriteLiteral(@"@media (min-width: 768px) {
        .modal-dialog {
            width: 100%;
            margin: auto;
        }
    }
</style>
<div class=""limiter"">
    <div class=""container-login100"" style="""">

        <div class=""content-iframe"">
            <div class=""modal-dialog"">

                <!-- Modal content-->
                <div class=""modal-content"">
                    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"" style=""margin-bottom:10px;"">
                        <li class=""nav-item active"">
                            <a class=""btn btn-warning"" id=""DOAN-tab"" data-toggle=""tab"" href=""#DOAN"" role=""tab"" aria-controls=""DOAN"" aria-selected=""true"">Team đoàn</a>
                        </li>
                    </ul>
                    <div class=""modal-body"">
                        <div class=""tab-content popup"" id=""myTabContent"">
                            <div class=""tab-pane fade  active"" id=""DOAN"" role=""tabpanel"" aria-labelledby=""DOAN-tab"">
                                <");
            WriteLiteral(@"div class=""row"">
                                    <div class=""col-xs-12 container-content"">
                                        <iframe src=""https://docs.google.com/document/d/e/2PACX-1vTUa-3o4LIL3h_VFWal-qBciCq6EB3wwPZMAOBs0ARAerA1t32KfZGS83O2jT1r9whmVfND6VpKDDCy/pub?embedded=true""></iframe>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
