#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcaa6794bdd753eb0577a1c18807768c10deeeca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_DSCongViec), @"mvc.1.0.view", @"/Views/Data/DSCongViec.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/DSCongViec.cshtml", typeof(AspNetCore.Views_Data_DSCongViec))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcaa6794bdd753eb0577a1c18807768c10deeeca", @"/Views/Data/DSCongViec.cshtml")]
    public class Views_Data_DSCongViec : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.CongViecModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.1.7.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
  
    ViewData["Title"] = "DSCongViec";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(140, 126, true);
            WriteLiteral("\r\n<h2>DANH SÁCH PHÂN VIỆC VÀ QUY ĐỊNH</h2>\r\n<div class=\"x_panel\" style=\"padding: 10px 17px 0;\">\r\n    <div class=\"x_content\">\r\n");
            EndContext();
#line 11 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
         using (Html.BeginForm("SaveCongViecPB", "Data", new { i = 9 }, FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(368, 346, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-sm-3"">
                    <div class=""form-group"">
                        <label for="""" class=""col-sm-4 "" style=""padding-top:11px"">Phòng ban</label>
                        <div class=""col-sm-8"">
                            <select id=""MaPB"" name=""MaPB"" class=""form-control"">
");
            EndContext();
#line 19 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                 foreach (var item in Model.ListPB)
                                {

#line default
#line hidden
            BeginContext(818, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 861, "\"", 879, 1);
#line 21 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
WriteAttributeValue("", 869, item.MaPB, 869, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(880, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(882, 7, false);
#line 21 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                          Write(item.PB);

#line default
#line hidden
            EndContext();
            BeginContext(889, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 22 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }

#line default
#line hidden
            BeginContext(935, 1047, true);
            WriteLiteral(@"                            </select>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <div class=""form-group"">
                        <div class=""col-sm-12"">
                            <select id=""CongViec"" name=""CongViec"" class=""form-control"">
                                <option selected=""selected"" value=""1"">Phân việc</option>
                                <option value=""2"">Quy định </option>
                            </select>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <button type=""submit"" class=""btn btn-primary"" name=""search"">Lưu</button>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-12"">
                    <textarea name=""NoiDung"" id=""NoiDung"">
                            
                    </textarea>
                </div");
            WriteLiteral(">\r\n            </div>\r\n");
            EndContext();
#line 48 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
        }

#line default
#line hidden
            BeginContext(1993, 612, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""x_panel"" style=""padding: 10px 17px 0;"">
    <div class=""x_content"">
        <table class=""table table-hover table-bordered"" id=""gridDSCongViec"">

            <thead>
                <tr>
                    <th>STT</th>
                    <th>Mã NV</th>
                    <th>Tên NV</th>
                    <th>Phòng ban</th>
                    <th>Phân việc</th>
                    <th>Quy định</th>
                    <th>Phân việc chung</th>
                    <th>Quy định chung</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 70 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                  
                    int i = 1;
                    foreach (var item in Model.ListNV)
                    {

#line default
#line hidden
            BeginContext(2736, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2799, 1, false);
#line 75 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2800, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2840, 9, false);
#line 76 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                           Write(item.MaNV);

#line default
#line hidden
            EndContext();
            BeginContext(2849, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2889, 8, false);
#line 77 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                           Write(item.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(2897, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2937, 13, false);
#line 78 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                           Write(item.PhongBan);

#line default
#line hidden
            EndContext();
            BeginContext(2950, 66, true);
            WriteLiteral("</td>\r\n                            <td onclick=\"phanviec(this)\">\r\n");
            EndContext();
#line 80 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                 if (item.PhanViec == "Tạo mới")
                                {

#line default
#line hidden
            BeginContext(3117, 84, true);
            WriteLiteral("                                    <a style=\"color:red;\" class=\"phanviec\" href=\"#\">");
            EndContext();
            BeginContext(3202, 13, false);
#line 82 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                               Write(item.PhanViec);

#line default
#line hidden
            EndContext();
            BeginContext(3215, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 83 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3329, 85, true);
            WriteLiteral("                                    <a style=\"color:blue;\" class=\"phanviec\" href=\"#\">");
            EndContext();
            BeginContext(3415, 13, false);
#line 86 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                                Write(item.PhanViec);

#line default
#line hidden
            EndContext();
            BeginContext(3428, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 87 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }

#line default
#line hidden
            BeginContext(3469, 71, true);
            WriteLiteral("                                <input type=\"hidden\" class=\"IDphanviec\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3540, "\"", 3558, 1);
#line 88 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
WriteAttributeValue("", 3548, item.MaNV, 3548, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3559, 98, true);
            WriteLiteral(" />\r\n                            </td>\r\n                            <td onclick=\"quydinh(this)\">\r\n");
            EndContext();
#line 91 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                 if (item.QuyDinh == "Tạo mới")
                                {

#line default
#line hidden
            BeginContext(3757, 83, true);
            WriteLiteral("                                    <a style=\"color:red;\" class=\"quydinh\" href=\"#\">");
            EndContext();
            BeginContext(3841, 12, false);
#line 93 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                              Write(item.QuyDinh);

#line default
#line hidden
            EndContext();
            BeginContext(3853, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 94 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3967, 84, true);
            WriteLiteral("                                    <a style=\"color:blue;\" class=\"quydinh\" href=\"#\">");
            EndContext();
            BeginContext(4052, 12, false);
#line 97 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                               Write(item.QuyDinh);

#line default
#line hidden
            EndContext();
            BeginContext(4064, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 98 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }

#line default
#line hidden
            BeginContext(4105, 70, true);
            WriteLiteral("                                <input type=\"hidden\" class=\"IDquydinh\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4175, "\"", 4193, 1);
#line 99 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
WriteAttributeValue("", 4183, item.MaNV, 4183, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4194, 104, true);
            WriteLiteral(" />\r\n                            </td>\r\n                            <td onclick=\"phanviecchung(this)\">\r\n");
            EndContext();
#line 102 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                 if (item.PhanViecChung == "Tạo mới")
                                {

#line default
#line hidden
            BeginContext(4404, 89, true);
            WriteLiteral("                                    <a style=\"color:red;\" class=\"phanviecchung\" href=\"#\">");
            EndContext();
            BeginContext(4494, 18, false);
#line 104 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                                    Write(item.PhanViecChung);

#line default
#line hidden
            EndContext();
            BeginContext(4512, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 105 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4626, 90, true);
            WriteLiteral("                                    <a style=\"color:blue;\" class=\"phanviecchung\" href=\"#\">");
            EndContext();
            BeginContext(4717, 18, false);
#line 108 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                                     Write(item.PhanViecChung);

#line default
#line hidden
            EndContext();
            BeginContext(4735, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 109 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }

#line default
#line hidden
            BeginContext(4776, 71, true);
            WriteLiteral("                                <input type=\"hidden\" class=\"IDphanviec\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4847, "\"", 4865, 1);
#line 110 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
WriteAttributeValue("", 4855, item.MaNV, 4855, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4866, 103, true);
            WriteLiteral(" />\r\n                            </td>\r\n                            <td onclick=\"quydinhchung(this)\">\r\n");
            EndContext();
#line 113 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                 if (item.QuyDinhChung == "Tạo mới")
                                {

#line default
#line hidden
            BeginContext(5074, 88, true);
            WriteLiteral("                                    <a style=\"color:red;\" class=\"quydinhchung\" href=\"#\">");
            EndContext();
            BeginContext(5163, 17, false);
#line 115 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                                   Write(item.QuyDinhChung);

#line default
#line hidden
            EndContext();
            BeginContext(5180, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 116 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5294, 89, true);
            WriteLiteral("                                    <a style=\"color:blue;\" class=\"quydinhchung\" href=\"#\">");
            EndContext();
            BeginContext(5384, 17, false);
#line 119 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                                                                    Write(item.QuyDinhChung);

#line default
#line hidden
            EndContext();
            BeginContext(5401, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 120 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                                }

#line default
#line hidden
            BeginContext(5442, 70, true);
            WriteLiteral("                                <input type=\"hidden\" class=\"IDquydinh\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5512, "\"", 5530, 1);
#line 121 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
WriteAttributeValue("", 5520, item.MaNV, 5520, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5531, 71, true);
            WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 124 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DSCongViec.cshtml"
                        i++;
                    }
                

#line default
#line hidden
            BeginContext(5674, 125, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"modal fade\" id=\"openPopup\" role=\"dialog\">\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(5799, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05e54ca8a71a49cba8b0c151fa795c37", async() => {
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
            BeginContext(5847, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5849, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f1a01e190f14199a4bd545673aa9dcd", async() => {
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
            BeginContext(5896, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5898, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "701b0c8347c845d38357279fb284397b", async() => {
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
            BeginContext(5955, 2837, true);
            WriteLiteral(@"
<script>
    function phanviec(object) {
        var subject_id = object.querySelector('.IDphanviec').value;
        var x = object.querySelector('.phanviec').innerHTML;

        $.ajax({
            type: ""POST"",
            url: ""/Data/PhanViec"",
            data: { khoachinh: subject_id, congviec: x },
            success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal('show');

            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });

    };
    function quydinh(object) {
        var subject_id = object.querySelector('.IDquydinh').value;
        var x = object.querySelector('.quydinh').innerHTML;

        $.ajax({
            type: ""POST"",
            url: ""/Data/QuyDinh"",
            data: { khoachinh: subject_id, congviec: x },
           ");
            WriteLiteral(@" success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal('show');

            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    };
    function phanviecchung(object) {
        var subject_id = object.querySelector('.IDphanviec').value;
        var x = object.querySelector('.phanviecchung').innerHTML;

        $.ajax({
            type: ""POST"",
            url: ""/Data/PhanViecChung"",
            data: { khoachinh: subject_id, congviec: x },
            success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal('show');

            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
               ");
            WriteLiteral(@" alert(response.responseText);
            }
        });

    };
    function quydinhchung(object) {
        var subject_id = object.querySelector('.IDquydinh').value;
        var x = object.querySelector('.quydinhchung').innerHTML;

        $.ajax({
            type: ""POST"",
            url: ""/Data/QuyDinhChung"",
            data: { khoachinh: subject_id, congviec: x },
            success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal('show');

            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    };
</script>
");
            EndContext();
            BeginContext(8792, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09de3779a69b434ba850c4c28a43615e", async() => {
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
            BeginContext(8846, 203, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        CKEDITOR.replace(\'NoiDung\', {\r\n            height: 200,\r\n            filebrowserUploadUrl: \'/Data/UploadCKEditor\'\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.CongViecModel> Html { get; private set; }
    }
}
#pragma warning restore 1591