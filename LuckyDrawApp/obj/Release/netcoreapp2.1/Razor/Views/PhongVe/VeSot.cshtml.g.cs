#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d021a5a7e10b18811083f6fde19c89b5a7f972"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhongVe_VeSot), @"mvc.1.0.view", @"/Views/PhongVe/VeSot.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PhongVe/VeSot.cshtml", typeof(AspNetCore.Views_PhongVe_VeSot))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d021a5a7e10b18811083f6fde19c89b5a7f972", @"/Views/PhongVe/VeSot.cshtml")]
    public class Views_PhongVe_VeSot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.ListVeSotModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.1.7.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
  
    ViewData["Title"] = "Báo cáo vé sót";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(143, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(151, 17, false);
#line 6 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 151, true);
            WriteLiteral("</title>\r\n<h2 style=\"text-align: center; font-weight: bold;\">DANH SÁCH VÉ CHƯA BÁO CÁO </h2>\r\n<br />\r\n\r\n<div class=\"row\" style=\"margin-bottom:10px;\">\r\n");
            EndContext();
#line 11 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
     using (Html.BeginForm("SearchVeSot", "PhongVe", new { i = 13 }, FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(414, 505, true);
            WriteLiteral(@"        <div class=""col-sm-4 col-xs-12"">
            <button class=""btn btn-danger"" type=""submit"" name=""getBCVS"" value=""getBCVS"">Lấy danh sách vé sót mới nhất</button>
            <a class=""btn btn-success"" id=""btnSendSMS"" name=""SendSMS"" onclick=""SendSMS()"">Gửi SMS</a>
        </div>
        <div class=""col-sm-4 col-xs-12"" style=""float:right"">

            <div class=""form-group"">
                <div class=""col-xs-9"">
                    <select class=""form-control"" name=""ma"" id=""ListTen"">
");
            EndContext();
#line 22 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                         if (Model != null && Model.ListTen != null)
                        {
                            foreach (var item in Model.ListTen)
                            {

#line default
#line hidden
            BeginContext(1112, 39, true);
            WriteLiteral("                                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1151, "\"", 1167, 1);
#line 26 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 1159, item.Ma, 1159, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1168, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(1208, 10, false);
#line 27 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Expr1);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 45, true);
            WriteLiteral("\r\n                                </option>\r\n");
            EndContext();
#line 29 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(1321, 267, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""col-xs-3"">
                    <button type=""submit"" class=""btn btn-primary"" name=""Search"" value=""Search"">Search</button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 38 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
    }

#line default
#line hidden
            BeginContext(1595, 330, true);
            WriteLiteral(@"</div>

<div class=""row"">
    <div class=""table-responsive"">
        <table id=""gridVeSot"" class=""table table-hover table-bordered"">
            <thead>
                <tr class=""bg-danger"">
                    <td colspan=""12"">
                        DS vé sót đã gửi SMS lúc <span style=""font-weight:bold; color:red;"">");
            EndContext();
            BeginContext(1926, 16, false);
#line 47 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                                                       Write(Model.NgayGuiSMS);

#line default
#line hidden
            EndContext();
            BeginContext(1942, 55, true);
            WriteLiteral("</span> bởi <span style=\"font-weight:bold; color:red;\">");
            EndContext();
            BeginContext(1998, 17, false);
#line 47 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                                                                                                                               Write(Model.NguoiGuiSMS);

#line default
#line hidden
            EndContext();
            BeginContext(2015, 202, true);
            WriteLiteral("</span>. Tin nhắn chỉ gửi đến những người có số vé trước ngày hiện tại. Bạn chỉ được gửi tin nhắn sau 10h và chỉ gửi được 1 lần trong ngày.\r\n                        <input type=\"hidden\" id=\"timeSendSMS\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2217, "\"", 2290, 1);
#line 48 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 2225, DateTime.Parse(Model.NgayGuiSMS).ToString("yyyy-MM-dd HH:mm:ss"), 2225, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2291, 96, true);
            WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n                <tr class=\"bg-success\">\r\n");
            EndContext();
#line 52 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                     if (Model.VeSot.Count > 0)
                    {

#line default
#line hidden
            BeginContext(2459, 142, true);
            WriteLiteral("                        <td colspan=\"12\">\r\n                            DS vé sót được cập nhật lúc <span style=\"font-weight:bold; color:red;\">");
            EndContext();
            BeginContext(2602, 26, false);
#line 55 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                                                              Write(Model.VeSot[0].NgayCapNhat);

#line default
#line hidden
            EndContext();
            BeginContext(2628, 55, true);
            WriteLiteral("</span> bởi <span style=\"font-weight:bold; color:red;\">");
            EndContext();
            BeginContext(2684, 26, false);
#line 55 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                                                                                                                                                Write(Model.VeSot[0].NhanVienTao);

#line default
#line hidden
            EndContext();
            BeginContext(2710, 133, true);
            WriteLiteral("</span>. Nếu bạn muốn xem DS báo cáo vé sót mới nhất hãy bấm vào nút \"Lấy danh sách vé sót mới nhất\"\r\n                        </td>\r\n");
            EndContext();
#line 57 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                    }

#line default
#line hidden
            BeginContext(2866, 560, true);
            WriteLiteral(@"                </tr>
                <tr>
                    <th></th>
                    <th>STT</th>
                    <th>HK</th>
                    <th>Nhân Viên</th>
                    <th>PNR</th>
                    <th>TK NO</th>
                    <th>Nghiệp vụ</th>
                    <th>Ngày Xuất</th>
                    <th>Mã NV</th>
                    <th>Hành Trình</th>
                    <th>Tình Trạng</th>
                    <th>Ngày Báo Cáo</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 75 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                  int i = 1; 

#line default
#line hidden
            BeginContext(3458, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 76 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                 if (Model != null && Model.VeSot != null)
                {
                    foreach (var item in Model.VeSot)
                    {
                        double n = int.Parse(item.NgayMua.Substring(0, 2)) % 2;
                        if (int.Parse(item.NgayMua.Substring(0, 2)) % 2 == 0)
                        {

#line default
#line hidden
            BeginContext(3802, 291, true);
            WriteLiteral(@"                            <tr class=""bg-info"">
                                <td><a class=""VeSot"" style=""color:blue;"" data-toggle=""modal"" data-target=""#openPopup"" href=""javascript:;""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i></a></td>
                                <td>");
            EndContext();
            BeginContext(4094, 1, false);
#line 85 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4095, 55, true);
            WriteLiteral("</td>\r\n                                <td class=\"hang\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4150, "\"", 4165, 1);
#line 86 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 4155, item.MaHK, 4155, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4166, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4168, 9, false);
#line 86 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                            Write(item.MaHK);

#line default
#line hidden
            EndContext();
            BeginContext(4177, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4221, 10, false);
#line 87 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Expr1);

#line default
#line hidden
            EndContext();
            BeginContext(4231, 54, true);
            WriteLiteral("</td>\r\n                                <td class=\"PNR\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4285, "\"", 4299, 1);
#line 88 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 4290, item.PNR, 4290, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4300, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4302, 8, false);
#line 88 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                          Write(item.PNR);

#line default
#line hidden
            EndContext();
            BeginContext(4310, 55, true);
            WriteLiteral("</td>\r\n                                <td class=\"sove\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4365, "\"", 4383, 1);
#line 89 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 4370, item.TKNockt, 4370, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4384, 103, true);
            WriteLiteral("><a class=\"VeSot\" style=\"color:blue;\" data-toggle=\"modal\" data-target=\"#openPopup\" href=\"javascript:;\">");
            EndContext();
            BeginContext(4488, 12, false);
#line 89 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                                                                                                                                     Write(item.TKNockt);

#line default
#line hidden
            EndContext();
            BeginContext(4500, 47, true);
            WriteLiteral("</a></td>\r\n                                <td>");
            EndContext();
            BeginContext(4548, 13, false);
#line 90 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Nghiepvu);

#line default
#line hidden
            EndContext();
            BeginContext(4561, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4605, 12, false);
#line 91 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.NgayMua);

#line default
#line hidden
            EndContext();
            BeginContext(4617, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4661, 7, false);
#line 92 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Ma);

#line default
#line hidden
            EndContext();
            BeginContext(4668, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4712, 13, false);
#line 93 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.ID_HanhT);

#line default
#line hidden
            EndContext();
            BeginContext(4725, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4769, 14, false);
#line 94 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.TinhTrang);

#line default
#line hidden
            EndContext();
            BeginContext(4783, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4827, 11, false);
#line 95 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.NgayUp);

#line default
#line hidden
            EndContext();
            BeginContext(4838, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 97 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                            i++;
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4998, 275, true);
            WriteLiteral(@"                            <tr>
                                <td><a class=""VeSot"" style=""color:blue;"" data-toggle=""modal"" data-target=""#openPopup"" href=""javascript:;""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i></a></td>
                                <td>");
            EndContext();
            BeginContext(5274, 1, false);
#line 103 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(5275, 55, true);
            WriteLiteral("</td>\r\n                                <td class=\"hang\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5330, "\"", 5345, 1);
#line 104 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 5335, item.MaHK, 5335, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5346, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5348, 9, false);
#line 104 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                            Write(item.MaHK);

#line default
#line hidden
            EndContext();
            BeginContext(5357, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5401, 10, false);
#line 105 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Expr1);

#line default
#line hidden
            EndContext();
            BeginContext(5411, 54, true);
            WriteLiteral("</td>\r\n                                <td class=\"PNR\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5465, "\"", 5479, 1);
#line 106 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 5470, item.PNR, 5470, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5480, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5482, 8, false);
#line 106 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                          Write(item.PNR);

#line default
#line hidden
            EndContext();
            BeginContext(5490, 55, true);
            WriteLiteral("</td>\r\n                                <td class=\"sove\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5545, "\"", 5563, 1);
#line 107 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
WriteAttributeValue("", 5550, item.TKNockt, 5550, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5564, 103, true);
            WriteLiteral("><a class=\"VeSot\" style=\"color:blue;\" data-toggle=\"modal\" data-target=\"#openPopup\" href=\"javascript:;\">");
            EndContext();
            BeginContext(5668, 12, false);
#line 107 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                                                                                                                                                                     Write(item.TKNockt);

#line default
#line hidden
            EndContext();
            BeginContext(5680, 47, true);
            WriteLiteral("</a></td>\r\n                                <td>");
            EndContext();
            BeginContext(5728, 13, false);
#line 108 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Nghiepvu);

#line default
#line hidden
            EndContext();
            BeginContext(5741, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5785, 12, false);
#line 109 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.NgayMua);

#line default
#line hidden
            EndContext();
            BeginContext(5797, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5841, 7, false);
#line 110 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.Ma);

#line default
#line hidden
            EndContext();
            BeginContext(5848, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5892, 13, false);
#line 111 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.ID_HanhT);

#line default
#line hidden
            EndContext();
            BeginContext(5905, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5949, 14, false);
#line 112 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.TinhTrang);

#line default
#line hidden
            EndContext();
            BeginContext(5963, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(6007, 11, false);
#line 113 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                               Write(item.NgayUp);

#line default
#line hidden
            EndContext();
            BeginContext(6018, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 115 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
                            i++;
                        }                           

                    }
                }

#line default
#line hidden
            BeginContext(6192, 808, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <p style=""font-style:italic; color:red"">
        &nbsp;&nbsp;&nbsp;&nbsp;Yêu cầu nhân viên phải nộp báo cáo ngay sau khi xuất vé, chậm nhất là 10h sáng hôm sau (bao gồm cả thứ 7 & chủ nhật). Kế toán sẽ căn cứ vào báo cáo vé sót của booker trực để thống kê booker vi phạm. Cứ 1 lần bị chụp màn hình web không nộp báo cáo vé của các ngày trước sẽ bị tính là 1 lần. Cứ mỗi 3 lần chậm nộp báo cáo sẽ bị trừ 500.000VND.
    </p>
    <p style=""font-style:italic; color:red"">
        &nbsp;&nbsp;&nbsp;&nbsp;Ví dụ như 11h hôm nay ngày 25/11, booker A, không báo cáo vé B xuất ngày 24/11, đến chiều ngày 26/11 mới nộp báo cáo thì số lần tính chậm nộp báo cáo sẽ là 2 lần.
    </p>
</div>
<div class=""modal fade"" id=""openPopup"" role=""dialog"">
</div>

");
            EndContext();
            BeginContext(7000, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34b4372d1584f1390fa43fbf45ad234", async() => {
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
            BeginContext(7048, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7050, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aff0b5a063d4f5caee106963d9147cf", async() => {
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
            BeginContext(7097, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7099, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edb0b600b9d1442d826ca6e3febdc7ae", async() => {
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
            BeginContext(7156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 136 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
 if (ViewBag.message != null)
{

#line default
#line hidden
            BeginContext(7192, 45, true);
            WriteLiteral("    <script charset=\"UTF-8\">\r\n        alert(\'");
            EndContext();
            BeginContext(7238, 25, false);
#line 139 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
          Write(Html.Raw(ViewBag.message));

#line default
#line hidden
            EndContext();
            BeginContext(7263, 20, true);
            WriteLiteral("\');\r\n    </script>\r\n");
            EndContext();
#line 141 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\VeSot.cshtml"
}

#line default
#line hidden
            BeginContext(7286, 3172, true);
            WriteLiteral(@"<script>
    $(document).ready(function () {
       
        var timeSendSMS = document.getElementById(""timeSendSMS"").value;
        //var temp = new Date(timeSendSMS);
        var temp1 = new Date();
        //var DaySMS = temp.getDate();
        //var DayNow = temp1.getDate();
        var HoursNow = temp1.getHours();
        var diff = (new Date() - new Date(timeSendSMS.replace(/-/g, '/'))) / 86400000;
      
        //var diff = DayNow - DaySMS;
        if (diff < 1 && HoursNow < 10) {
            $(""#btnSendSMS"").attr(""disabled"", ""disabled"");
            var element = document.getElementById(""btnSendSMS"");
            element.classList.remove(""btn-success"");
            element.classList.add(""btn-default"");
        }
    });
    function SendSMS() {
        var timeSendSMS = document.getElementById(""timeSendSMS"").value;
        //var temp = new Date(timeSendSMS);
        var temp1 = new Date();
        //var DaySMS = temp.getDate();
        //var DayNow = temp1.getDate();
        ");
            WriteLiteral(@"var HoursNow = temp1.getHours();
        var diff = (new Date() - new Date(timeSendSMS.replace(/-/g, '/'))) / 86400000;
        /*var diff = DayNow - DaySMS;*/
        if (diff > 1 && HoursNow >= 10) {
            $.ajax({
                type: ""POST"",
                url: ""/PhongVe/SendSMSVeSot"",
                success: function (response) {
                    if (response == true) {
                        alert(""Gửi SMS thành công"");
                    }
                    else {
                        alert(""Gửi SMS không thành công"");
                    }
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            });
        }
        else {

            alert(""Bạn không thể gửi tin nhắn vì chưa tới thời gian quy định"");
        }
    };
    $(""#gridVeSot .VeSot"").click(fun");
            WriteLiteral(@"ction () {
        var pnr = $(this).closest('tr').find('.PNR').attr('id');
        var sove = $(this).closest('tr').find('.sove').attr('id');
        var hang = $(this).closest('tr').find('.hang').attr('id');

        var rowjQuery = $(this).closest(""tr"");
        var currentIndex = rowjQuery[0].rowIndex;
        if ($(this).closest('tr').find('.hang').attr('id').trim() == ""QH"") {
            var sove = $(this).closest('tr').find('.PNR').attr('id');
        }

        $.ajax({
            type: ""POST"",
            url: ""/PhongVe/BaoCaoVeSot"",
            data: {
                PNR: pnr,
                SOVE: sove,
                HANG: hang,
                Index: currentIndex
            },
            success: function (response) {
                $('#openPopup').html(response);
                $('#openPopup').modal('show');
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response");
            WriteLiteral(") {\r\n                alert(response.responseText);\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.ListVeSotModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
