#pragma checksum "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf6174817a9d328347fe30983417a4bdd2cb25e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChonChuongTrinh), @"mvc.1.0.view", @"/Views/Home/ChonChuongTrinh.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ChonChuongTrinh.cshtml", typeof(AspNetCore.Views_Home_ChonChuongTrinh))]
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
#line 1 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\_ViewImports.cshtml"
using LuckyDrawApp;

#line default
#line hidden
#line 2 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\_ViewImports.cshtml"
using LuckyDrawApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf6174817a9d328347fe30983417a4bdd2cb25e", @"/Views/Home/ChonChuongTrinh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8c6d77b8076bc8a10254f1f6a21b140f197587", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChonChuongTrinh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LuckyDrawApp.Service.Model.Response.LuckyDrawResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
  
    ViewData["Title"] = "Chọn chương trình";
    Layout = "~/Views/Shared/MasterLayout_LuckyRaw.cshtml";

#line default
#line hidden
            BeginContext(178, 82, true);
            WriteLiteral("\r\n\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title>");
            EndContext();
            BeginContext(261, 17, false);
#line 10 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(278, 1490, true);
            WriteLiteral(@"</title>
<style>
    .container-login100 {
        width: 100%;
        min-height: 100vh;
        flex-wrap: wrap;
        justify-content: center;
        align-items: center;
        background-position: center;
        background-size: cover;
        background-repeat: no-repeat;
        padding: 15px;
        background-image: url('/images/2.png');
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


    .btn-BSP {
        color: #fff;
        background-color: #6c0678;
        border-color: #6c0678;
    }

    .btn-organ {
        background-color: #f5821f;
        border-color: #f5821f;
        color: #fff;
 ");
            WriteLiteral(@"   }

    .badge {
        background-color: #fff;
        padding: 0px;
    }

    .bd-toc {
        font-weight: 400;
        line-height: 1.5;
        font-size: 14px;
    }

        .bd-toc ul {
            padding-left: 0;
            list-style: none;
        }

        .bd-toc li {
            margin-bottom: .25rem;
        }

        .bd-toc ul ul {
            padding-left: 2rem;
            margin-top: .25rem;
        }

    ");
            EndContext();
            BeginContext(1769, 890, true);
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
</style>
<div class=""limiter"">
    <div class=""container-login100"" style="""">
        <div class=""row"">
            <div class=""col-sm-8"">
                <div class=""content-iframe"">
                    <div class=""modal-content"">
                        <div class=""modal-body"">
                            <div class=""x_panel"">
                                <div class=""x_content"">
                                    <div class=""row"">
                                        <h1 class=""text-center""><strong>");
            EndContext();
            BeginContext(2660, 10, false);
#line 113 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2670, 93, true);
            WriteLiteral("</strong></h1>\r\n                                        <input id=\"LuckyDrawID\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2763, "\"", 2780, 1);
#line 114 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
WriteAttributeValue("", 2771, Model.Id, 2771, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2781, 251, true);
            WriteLiteral("/>\r\n                                        <p style=\"font-size: 16px; font-weight: bold;\">Danh sách giải thưởng</p>\r\n                                        <div class=\"col-sm-4\">\r\n                                            <ul class=\"list-group\">\r\n");
            EndContext();
#line 118 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                 for (int i = 0; i < Model.LuckyDrawPrizes.Count; i++)
                                                {

#line default
#line hidden
            BeginContext(3187, 194, true);
            WriteLiteral("                                                    <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                                                        <span>");
            EndContext();
            BeginContext(3382, 29, false);
#line 121 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                         Write(Model.LuckyDrawPrizes[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(3411, 16, true);
            WriteLiteral(" </span>: <span>");
            EndContext();
            BeginContext(3428, 48, false);
#line 121 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                                                       Write(Model.LuckyDrawPrizes[i].Quantity.ToString("D2"));

#line default
#line hidden
            EndContext();
            BeginContext(3476, 14, true);
            WriteLiteral("</span> <span>");
            EndContext();
            BeginContext(3491, 30, false);
#line 121 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                                                                                                                      Write(Model.LuckyDrawPrizes[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(3521, 47, true);
            WriteLiteral("</span> <span class=\"badge\"><input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3568, "\"", 3643, 6);
            WriteAttributeValue("", 3578, "ActiveLuckyDrawPrize(\'", 3578, 22, true);
#line 121 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
WriteAttributeValue("", 3600, Model.LuckyDrawPrizes[i].Id, 3600, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 3628, "\',", 3628, 2, true);
            WriteAttributeValue(" ", 3630, "\'", 3631, 2, true);
#line 121 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
WriteAttributeValue("", 3632, Model.Id, 3632, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3641, "\')", 3641, 2, true);
            EndWriteAttribute();
            BeginContext(3644, 14, true);
            WriteLiteral(" name=\"prizes\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3658, "\"", 3694, 1);
#line 121 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
WriteAttributeValue("", 3666, Model.LuckyDrawPrizes[i].Id, 3666, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3695, 71, true);
            WriteLiteral(" /></span>\r\n                                                    </li>\r\n");
            EndContext();
#line 123 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3817, 1338, true);
            WriteLiteral(@"                                            </ul>
                                        </div>
                                        <div class=""clearfix""></div>
                                        <div class=""text-center"">
                                            <button type=""submit"" onclick=""Refresh();"" class=""btn btn-primary btn-lg"">REFRESH</button>
                                           
                                            <button type=""button"" onclick=""PageQuaySo();"" class=""btn btn-success btn-lg"">QUAY THƯỞNG</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""content-iframe"">
                    <div class=""modal-content"">
                        <div class=""modal-body"">
           ");
            WriteLiteral(@"                 <div class=""x_panel"">
                                <div class=""x_content"">
                                    <div class=""bd-toc"">
                                        <p style=""font-size: 18px; font-weight: bold;"">Danh sách trúng giải</p>
                                        <ul>
");
            EndContext();
#line 148 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                             if (Model.LuckyDrawResults != null)
                                            {
                                                for (int i = 0; i < Model.LuckyDrawPrizes.Count; i++)
                                                {

#line default
#line hidden
            BeginContext(5438, 128, true);
            WriteLiteral("                                                    <li>\r\n                                                        <strong><span>");
            EndContext();
            BeginContext(5567, 29, false);
#line 153 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                 Write(Model.LuckyDrawPrizes[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(5596, 16, true);
            WriteLiteral(" </span>: <span>");
            EndContext();
            BeginContext(5613, 48, false);
#line 153 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                                                               Write(Model.LuckyDrawPrizes[i].Quantity.ToString("D2"));

#line default
#line hidden
            EndContext();
            BeginContext(5661, 14, true);
            WriteLiteral("</span> <span>");
            EndContext();
            BeginContext(5676, 30, false);
#line 153 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                                                                                                                              Write(Model.LuckyDrawPrizes[i].Value);

#line default
#line hidden
            EndContext();
            BeginContext(5706, 80, true);
            WriteLiteral("</span></strong>\r\n                                                        <ul>\r\n");
            EndContext();
#line 155 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                             for (int y = 0; y < Model.LuckyDrawResults.Count; y++)
                                                            {
                                                                if (Model.LuckyDrawPrizes[i].Id == Model.LuckyDrawResults[y].luckyDrawPrizeId)
                                                                {

#line default
#line hidden
            BeginContext(6177, 153, true);
            WriteLiteral("                                                                    <li>\r\n                                                                        <span> ");
            EndContext();
            BeginContext(6331, 34, false);
#line 160 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                          Write(Model.LuckyDrawResults[y].DrawData);

#line default
#line hidden
            EndContext();
            BeginContext(6365, 15, true);
            WriteLiteral(" </span> <span>");
            EndContext();
            BeginContext(6381, 33, false);
#line 160 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                                                                            Write(Model.LuckyDrawResults[y].AgentId);

#line default
#line hidden
            EndContext();
            BeginContext(6414, 98, true);
            WriteLiteral("</span> <span></span>\r\n                                                                    </li>\r\n");
            EndContext();
#line 162 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                                }
                                                            }

#line default
#line hidden
            BeginContext(6642, 122, true);
            WriteLiteral("                                                        </ul>\r\n                                                    </li>\r\n");
            EndContext();
#line 166 "D:\EnViet\Source\LuckyDrawApp\LuckyDrawApp\Views\Home\ChonChuongTrinh.cshtml"
                                                }
                                            }

#line default
#line hidden
            BeginContext(6862, 1345, true);
            WriteLiteral(@"                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    function ActiveLuckyDrawPrize(id, LuckyDrawId) {
        $.ajax({
            type: ""POST"",
            url: ""/Home/ActiveLuckyDrawPrize"",
            data: {
                ID: id,
                LuckyDrawID: LuckyDrawId
            },
            success: function (response) {
                console.log(response);
            },
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response);
            }
        });
    };
    function Refresh() {
        location.reload();
    };
    function PageQuaySo() {
        var radio = document.querySelector('input[name=""p");
            WriteLiteral(@"rizes""]:checked');
        var LuckyDrawID = document.getElementById(""LuckyDrawID"").value;
        var Id = radio.value;
      
        var link = document.createElement(""a"");
        link.href = ""/Home/QuaySo/?LuckyDrawID= "" + LuckyDrawID;
        link.target = ""_blank"";
        link.click();
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LuckyDrawApp.Service.Model.Response.LuckyDrawResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591