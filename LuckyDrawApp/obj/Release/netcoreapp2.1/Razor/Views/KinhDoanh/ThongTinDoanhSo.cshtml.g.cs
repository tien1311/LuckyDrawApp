#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b57eab05d8d535ab8305e107c83bd51858a1b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KinhDoanh_ThongTinDoanhSo), @"mvc.1.0.view", @"/Views/KinhDoanh/ThongTinDoanhSo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KinhDoanh/ThongTinDoanhSo.cshtml", typeof(AspNetCore.Views_KinhDoanh_ThongTinDoanhSo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b57eab05d8d535ab8305e107c83bd51858a1b0", @"/Views/KinhDoanh/ThongTinDoanhSo.cshtml")]
    public class Views_KinhDoanh_ThongTinDoanhSo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Manager_EV.Models.ViewModel.ImportDoanhSoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 15, true);
            WriteLiteral("\r\n<style>\r\n    ");
            EndContext();
            BeginContext(81, 661, true);
            WriteLiteral(@"@media (min-width: 768px) {
        .modal-dialog {
            width: 1000px;
            margin: 30px auto;
        }
    }
</style>
<div class=""modal-dialog"">
    <!-- Modal content-->
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            <h1 style=""color:red"">Doanh số </h1>
        </div>

        <div class=""row"" style=""margin: 0 10px;"">
            <div class=""col-sm-2"">
                <div class=""form-group"">
                    <label>Năm</label>
                    <select class=""form-control"" name=""Nam"" id=""Nam"">
");
            EndContext();
#line 24 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                         for (int i = 2020; i <= 2030; i++)
                        {
                            if (DateTime.Now.Year == i)
                            {

#line default
#line hidden
            BeginContext(918, 48, true);
            WriteLiteral("                                <option selected");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 966, "\"", 976, 1);
#line 28 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
WriteAttributeValue("", 974, i, 974, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(977, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(979, 1, false);
#line 28 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(980, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 29 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1087, 39, true);
            WriteLiteral("                                <option");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 1126, "\"", 1137, 1);
#line 32 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
WriteAttributeValue("", 1135, i, 1135, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1138, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1140, 1, false);
#line 32 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 33 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                            }

                        }

#line default
#line hidden
            BeginContext(1212, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1883, 33, true);
            WriteLiteral("\r\n                    </select>\r\n");
            EndContext();
#line 56 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                       
                        string s = ViewBag.MAKH;
                    

#line default
#line hidden
            BeginContext(2408, 83, true);
            WriteLiteral("                    <input class=\"form-control\" type=\"hidden\" name=\"MaKH\" id=\"MaKH\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2491, "\"", 2512, 1);
#line 59 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
WriteAttributeValue("", 2499, ViewBag.MAKH, 2499, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2513, 1659, true);
            WriteLiteral(@" />
                </div>
            </div>
            <div class=""col-sm-2"">
                <div class=""form-group"">
                    <label>&nbsp;</label>
                    <div id=""Doanhso"">
                        <button type=""submit"" class=""btn btn-success btn-block btnDoanhSo"" name=""Search"" value=""Search"">Tìm kiếm</button>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"" style=""margin:0px"">
            <div class=""table-responsive"">
                <table id=""gridDoanhSo"" class=""table table-striped jambo_table bulk_action"">
                    <thead>
                        <tr class=""headings"">
                            <th class=""column-title"">STT </th>
                            <th class=""column-title"">Tháng </th>
                            <th class=""column-title"">Mã KH </th>
                            <th class=""column-title"">Tổng </th>
                            <th class=""column-title"">VN </th>
 ");
            WriteLiteral(@"                           <th class=""column-title"">VJ </th>
                            <th class=""column-title"">QH </th>
                            <th class=""column-title"">IATA </th>
                            <th class=""column-title"">Khác </th>
                            <th class=""bulk-actions"" colspan=""9"">
                                <a class=""antoo"" style=""color:#fff; font-weight:500;"">Bulk Actions ( <span class=""action-cnt""> </span> ) <i class=""fa fa-chevron-down""></i></a>
                            </th>
                        </tr>
                    </thead>
                    <tbody id=""tbody"">
");
            EndContext();
#line 92 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                         if (Model != null)
                        {
                            if (Model.Count > 0)
                            {
                                foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(4421, 39, true);
            WriteLiteral("                                    <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4460, "\"", 4475, 1);
#line 98 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
WriteAttributeValue("", 4465, item.MaKH, 4465, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4476, 56, true);
            WriteLiteral(">\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(4533, 8, false);
#line 99 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.STT);

#line default
#line hidden
            EndContext();
            BeginContext(4541, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(4602, 10, false);
#line 100 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.Thang);

#line default
#line hidden
            EndContext();
            BeginContext(4612, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(4614, 8, false);
#line 100 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                            Write(item.Nam);

#line default
#line hidden
            EndContext();
            BeginContext(4622, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(4683, 9, false);
#line 101 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.MaKH);

#line default
#line hidden
            EndContext();
            BeginContext(4692, 89, true);
            WriteLiteral("</td>\r\n                                        <td style=\"font-weight:bold; color: red;\">");
            EndContext();
            BeginContext(4782, 45, false);
#line 102 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                                             Write(item.Tong.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(4827, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(4888, 43, false);
#line 103 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.VN.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(4931, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(4992, 43, false);
#line 104 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.VJ.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5035, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(5096, 43, false);
#line 105 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.QH.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5139, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(5200, 45, false);
#line 106 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.IATA.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5245, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(5306, 45, false);
#line 107 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                                Write(item.Khac.ToString("#,##0").Replace(".", ","));

#line default
#line hidden
            EndContext();
            BeginContext(5351, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 109 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                                }
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5532, 164, true);
            WriteLiteral("                                <tr>\r\n                                    <td colspan=\"9\">Đại lý này không có doanh số</td>\r\n                                </tr>\r\n");
            EndContext();
#line 116 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\ThongTinDoanhSo.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5754, 2200, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<script>
    $(""#Doanhso .btnDoanhSo"").click(function () {
        var makh = document.getElementById(""MaKH"").value;
        var nam = document.getElementById(""Nam"").value;

        $.ajax({
            type: ""POST"",
            url: ""/KinhDoanh/SearchDoanhSo"",
            data: { MaKH: makh, Nam: nam },
            success: function (response) {
                $(""#tbody"").empty();
                var len = response.length;

                for (var i = 0; i < len; i++) {
                    var tr_str = ""<tr>"" +
                        ""<td align='left'>"" + response[i].stt + ""</td>"" +
                        ""<td align='left'>"" + response[i].thang +""/""+ response[i].nam + ""</td>"" +
                        ""<td align='left'>"" + response[i].maKH + ""</td>"" +
                        ""<td align='left' style='font-weight:bold; color: red;'>"" + formatNumber(response[i].tong) + ""</td>"" ");
            WriteLiteral(@"+
                        ""<td align='left'>"" + formatNumber(response[i].vn) + ""</td>"" +
                        ""<td align='left'>"" + formatNumber(response[i].vj) + ""</td>"" +
                        ""<td align='left'>"" + formatNumber(response[i].qh) + ""</td>"" +
                        ""<td align='left'>"" + formatNumber(response[i].iata) + ""</td>"" +
                        ""<td align='left'>"" + formatNumber(response[i].khac) + ""</td>""
                        ""</tr>"";

                    $(""#gridDoanhSo tbody"").append(tr_str);
                }
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });


    function formatNumber(number) {
        number = number.toFixed(0) + '';
        x = number.split('.');
        x1 = x[0];
        x2 = x.length > 1 ? '.' + x[1] : '';
        var rgx = /(\d+)(\d{3})/;");
            WriteLiteral("\r\n        while (rgx.test(x1)) {\r\n            x1 = x1.replace(rgx, \'$1\' + \',\' + \'$2\');\r\n        }\r\n        return x1 + x2;\r\n    }\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Manager_EV.Models.ViewModel.ImportDoanhSoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
