#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c4be251f49f5773f97486c683ffd870573599e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Daily_TraCuuVeHoan), @"mvc.1.0.view", @"/Views/Daily/TraCuuVeHoan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Daily/TraCuuVeHoan.cshtml", typeof(AspNetCore.Views_Daily_TraCuuVeHoan))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c4be251f49f5773f97486c683ffd870573599e", @"/Views/Daily/TraCuuVeHoan.cshtml")]
    public class Views_Daily_TraCuuVeHoan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Manager_EV.Models.VeHoanModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
  
    ViewData["Title"] = "Tra Cứu Vé Hoàn";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(149, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(157, 17, false);
#line 7 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(174, 88, true);
            WriteLiteral("</title>\r\n<h2>Tra cứu vé hoàn</h2>\r\n<div class=\"x_panel\">\r\n    <div class=\"x_content\">\r\n");
            EndContext();
#line 11 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
         using (Html.BeginForm("SearchVeHoan", "Daily", new { i = 8 }, FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(363, 741, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-sm-6 col-xs-12"">
                    <div class=""item form-group col-md-8 col-sm-8 col-xs-8"">
                        <div class=""col-md-12 col-sm-12 col-xs-12 "">
                            <input type=""text"" id=""sove"" style=""height:25px;"" placeholder=""Số vé"" name=""sove"" class=""form-control"">
                        </div>
                    </div>
                    <div class=""item form-group col-md-4 col-sm-4 col-xs-4"" style=""text-align:left;"">
                        <input type=""submit"" class=""btn btn-primary"" style=""height:25px;padding-top:0;"" value=""Tìm vé"" name=""searchVeBtn"" />

                    </div>
                </div>
            </div>
");
            EndContext();
#line 26 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
        }

#line default
#line hidden
            BeginContext(1115, 1033, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table id=""gridHoanVe"" class=""table table-striped jambo_table bulk_action"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">STT </th>
                        <th class=""column-title"">Danh mục </th>
                        <th class=""column-title"">Số vé </th>
                        <th class=""column-title"">Yêu cầu </th>
                        <th class=""column-title"">Mã KH</th>
                        <th class=""column-title"">Ngày gửi </th>
                        <th class=""column-title"">Ngày hoàn </th>
                        <th class=""column-title"">Tình trạng </th>


                        <th class=""bulk-actions"" colspan=""7"">
                            <a class=""antoo"" style=""color:#fff; font-weight:500;"">Bulk Actions ( <span class=""action-cnt""> </span> ) <i class=""fa fa-chevron-down""></i></a>
                        </th>
                    </tr>
                </t");
            WriteLiteral("head>\r\n\r\n");
            EndContext();
#line 47 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#line 49 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
            BeginContext(2279, 64, true);
            WriteLiteral("                        <tbody>\r\n                            <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2343, "\"", 2364, 1);
#line 53 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
WriteAttributeValue("", 2348, item.subject_id, 2348, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2365, 71, true);
            WriteLiteral(" class=\"even pointer\">\r\n\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(2437, 8, false);
#line 55 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        Write(item.STT);

#line default
#line hidden
            EndContext();
            BeginContext(2445, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 56 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 if (item.DanhMuc == "VN Quốc Nội")
                                {
                                    var danhmuc = "VNQN";

#line default
#line hidden
            BeginContext(2615, 49, true);
            WriteLiteral("                                    <td class=\"\">");
            EndContext();
            BeginContext(2665, 7, false);
#line 59 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            Write(danhmuc);

#line default
#line hidden
            EndContext();
            BeginContext(2672, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 60 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                }

#line default
#line hidden
            BeginContext(2714, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 61 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 if (item.DanhMuc == "VN  Quốc Tế")
                                {
                                    var danhmuc = "VNQT";

#line default
#line hidden
            BeginContext(2877, 49, true);
            WriteLiteral("                                    <td class=\"\">");
            EndContext();
            BeginContext(2927, 7, false);
#line 64 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            Write(danhmuc);

#line default
#line hidden
            EndContext();
            BeginContext(2934, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 65 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                }

#line default
#line hidden
            BeginContext(2976, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 66 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 if (item.DanhMuc == "VietJet Air")
                                {
                                    var danhmuc = "VJ";

#line default
#line hidden
            BeginContext(3137, 49, true);
            WriteLiteral("                                    <td class=\"\">");
            EndContext();
            BeginContext(3187, 7, false);
#line 69 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            Write(danhmuc);

#line default
#line hidden
            EndContext();
            BeginContext(3194, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 70 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                }

#line default
#line hidden
            BeginContext(3236, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 71 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 if (item.DanhMuc == "Quốc Tế Các Hãng Khác")
                                {
                                    var danhmuc = "BSP";

#line default
#line hidden
            BeginContext(3408, 49, true);
            WriteLiteral("                                    <td class=\"\">");
            EndContext();
            BeginContext(3458, 7, false);
#line 74 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            Write(danhmuc);

#line default
#line hidden
            EndContext();
            BeginContext(3465, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 75 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                }

#line default
#line hidden
            BeginContext(3507, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 76 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 if (item.DanhMuc == "Bamboo Airways")
                                {
                                    var danhmuc = "QH";

#line default
#line hidden
            BeginContext(3671, 49, true);
            WriteLiteral("                                    <td class=\"\">");
            EndContext();
            BeginContext(3721, 7, false);
#line 79 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            Write(danhmuc);

#line default
#line hidden
            EndContext();
            BeginContext(3728, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 80 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                }

#line default
#line hidden
            BeginContext(3770, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 81 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 if (item.DanhMuc == "Vietravel Airlines")
                                {
                                    var danhmuc = "VU";

#line default
#line hidden
            BeginContext(3938, 49, true);
            WriteLiteral("                                    <td class=\"\">");
            EndContext();
            BeginContext(3988, 7, false);
#line 84 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            Write(danhmuc);

#line default
#line hidden
            EndContext();
            BeginContext(3995, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 85 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                }

#line default
#line hidden
            BeginContext(4037, 127, true);
            WriteLiteral("                                <td><a class=\"ThongTinVeHoan\" data-toggle=\"modal\" data-target=\"#openPopup\" href=\"javascript:;\">");
            EndContext();
            BeginContext(4165, 9, false);
#line 86 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                                                                                                          Write(item.SoVe);

#line default
#line hidden
            EndContext();
            BeginContext(4174, 56, true);
            WriteLiteral("</a></td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4231, 11, false);
#line 87 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        Write(item.YeuCau);

#line default
#line hidden
            EndContext();
            BeginContext(4242, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4295, 14, false);
#line 88 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        Write(item.member_kh);

#line default
#line hidden
            EndContext();
            BeginContext(4309, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(4362, 12, false);
#line 89 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        Write(item.NgayGui);

#line default
#line hidden
            EndContext();
            BeginContext(4374, 71, true);
            WriteLiteral("</td>\r\n                                <td class=\"\" style=\"color:red;\">");
            EndContext();
            BeginContext(4446, 13, false);
#line 90 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                                           Write(item.NgayHoan);

#line default
#line hidden
            EndContext();
            BeginContext(4459, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 92 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                 switch (item.TinhTrang)
                                {
                                    case "0":

#line default
#line hidden
            BeginContext(4608, 75, true);
            WriteLiteral("                                        <td class=\"pending\"> Đã hủy </td>\r\n");
            EndContext();
#line 96 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        break;
                                    case "1":


#line default
#line hidden
            BeginContext(4780, 69, true);
            WriteLiteral("                                        <td class=\"new_\"> Mới </td>\r\n");
            EndContext();
#line 100 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"

                                        break;
                                    case "2":
                                        {
                                            if (item.subject_ishot == "1")
                                            {

#line default
#line hidden
            BeginContext(5112, 196, true);
            WriteLiteral("                                                <td class=\"waitting\">\r\n                                                    Đang chờ điện SC\r\n                                                </td>\r\n");
            EndContext();
#line 109 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"

                                            }
                                            else if (item.subject_ishot == "2")
                                            {

#line default
#line hidden
            BeginContext(5485, 198, true);
            WriteLiteral("                                                <td class=\"waitting\">\r\n                                                    Đang chuyển No Go\r\n                                                </td>\r\n");
            EndContext();
#line 116 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(5827, 202, true);
            WriteLiteral("                                                <td class=\"waitting\">\r\n                                                    Đang chờ hãng kiểm tra\r\n                                                </td>\r\n");
            EndContext();
#line 122 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                            }
                                        }

                                        break;
                                    case "3":

#line default
#line hidden
            BeginContext(6216, 100, true);
            WriteLiteral("                                        <td class=\"export\"> Đã hoàn - chờ Hãng chi tiền hoàn </td>\r\n");
            EndContext();
#line 128 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        break;

                                    case "4":

#line default
#line hidden
            BeginContext(6413, 73, true);
            WriteLiteral("                                        <td class=\"export\"> Sự cố </td>\r\n");
            EndContext();
#line 132 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        break;

                                    case "5":

#line default
#line hidden
            BeginContext(6583, 77, true);
            WriteLiteral("                                        <td class=\"waitting\"> Đã nhận </td>\r\n");
            EndContext();
#line 136 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        break;
                                    case "6":

#line default
#line hidden
            BeginContext(6755, 99, true);
            WriteLiteral("                                        <td class=\"export\"> Đã hoàn - Hãng đã chi tiền hoàn </td>\r\n");
            EndContext();
#line 139 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        break;
                                    case "7":

#line default
#line hidden
            BeginContext(6949, 90, true);
            WriteLiteral("                                        <td class=\"export\"> Đang chờ mở OK để hoàn </td>\r\n");
            EndContext();
#line 142 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                                        break;
                                }

#line default
#line hidden
            BeginContext(7122, 71, true);
            WriteLiteral("                            </tr>\r\n\r\n                        </tbody>\r\n");
            EndContext();
#line 147 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                    }

#line default
#line hidden
#line 147 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Daily\TraCuuVeHoan.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(7235, 1177, true);
            WriteLiteral(@"            </table>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""openPopup"" role=""dialog"">
</div>

<script type=""text/javascript"" src=""http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js""></script>
<script src=""http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js"" type=""text/javascript""></script>
<link href=""http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/blitzer/jquery-ui.css"" rel=""stylesheet"" type=""text/css"" />

<script type=""text/javascript"">
    $(""#gridHoanVe .ThongTinVeHoan"").click(function () {
        var subject_id = String($(this).closest('tr').attr('id'));
        $.ajax({
            type: ""POST"",
            
            url: ""/Daily/ThongTinVe"",
            data: { khoachinh: subject_id },
            success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal('show');

            },
            failure: function (response) {
                alert(response.responseText);");
            WriteLiteral("\r\n            },\r\n            error: function (response) {\r\n                alert(response.responseText);\r\n            }\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Manager_EV.Models.VeHoanModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
