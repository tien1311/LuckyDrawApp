#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditAirport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0ebedad3f37bce64d8cc8970f4690aab8fb170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_EditAirport), @"mvc.1.0.view", @"/Views/Data/EditAirport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/EditAirport.cshtml", typeof(AspNetCore.Views_Data_EditAirport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d0ebedad3f37bce64d8cc8970f4690aab8fb170", @"/Views/Data/EditAirport.cshtml")]
    public class Views_Data_EditAirport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.Airport>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 13, true);
            WriteLiteral("<style>\r\n    ");
            EndContext();
            BeginContext(48, 648, true);
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
            <h1 style=""color:red"">Chỉnh sửa sân bay</h1>
        </div>
        <div class=""modal-body"">
");
            EndContext();
#line 29 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditAirport.cshtml"
             using (Html.BeginForm("SaveEditAirport", "Data", new { i = 9 }, FormMethod.Post))
            {

#line default
#line hidden
            BeginContext(807, 279, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-sm-4"">
                        <div class=""form-group"">
                            <label for=""inputEmail3"" class=""control-label"">Sân bay</label>
                            <input type=""hidden"" name=""ID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1086, "\"", 1103, 1);
#line 35 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditAirport.cshtml"
WriteAttributeValue("", 1094, Model.ID, 1094, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1104, 85, true);
            WriteLiteral(">\r\n                            <input class=\"form-control\" name=\"Name\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1189, "\"", 1208, 1);
#line 36 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditAirport.cshtml"
WriteAttributeValue("", 1197, Model.Name, 1197, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1209, 506, true);
            WriteLiteral(@">
                        </div>
                    </div>

                    <div class=""col-sm-4"">
                        <div class=""form-group"">
                            <label for=""inputEmail3"" class=""control-label"">&nbsp;</label>
                            <div>
                                <button type=""submit"" class=""btn btn-primary"" value="""">Lưu</button>
                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 49 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\EditAirport.cshtml"
            }

#line default
#line hidden
            BeginContext(1730, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.Airport> Html { get; private set; }
    }
}
#pragma warning restore 1591
