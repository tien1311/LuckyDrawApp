#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd9baf4971cee19288d216e6f12d54358982a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhongVe_DanhSachTongGuiMailDaiLy), @"mvc.1.0.view", @"/Views/PhongVe/DanhSachTongGuiMailDaiLy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PhongVe/DanhSachTongGuiMailDaiLy.cshtml", typeof(AspNetCore.Views_PhongVe_DanhSachTongGuiMailDaiLy))]
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
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd9baf4971cee19288d216e6f12d54358982a5a", @"/Views/PhongVe/DanhSachTongGuiMailDaiLy.cshtml")]
    public class Views_PhongVe_DanhSachTongGuiMailDaiLy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.DanhSachTongNhanVienXuatDoiVe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery.dataTables.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.1.7.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.1.8.9.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
  
    ViewData["Title"] = "Báo cáo tổng nhân viên Xuất vé - Đổi vé";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(258, 11, true);
            WriteLiteral("\r\n\r\n<title>");
            EndContext();
            BeginContext(270, 17, false);
#line 11 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(287, 10, true);
            WriteLiteral("</title>\r\n");
            EndContext();
            BeginContext(297, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "678e0b5de59f4245acd612f26f9d64d4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(353, 579, true);
            WriteLiteral(@"
<style>
    .form-horizontal .has-feedback .form-control-feedback {
        right: 0;
    }

    #gridVeHoan th {
        padding: 10px 6px;
    }

    .pagination {
        margin: 8px 0;
    }

    .table > tbody > tr > td, .table > tbody > tr > th, .table > tfoot > tr > td, .table > tfoot > tr > th, .table > thead > tr > td, .table > thead > tr > th {
        vertical-align: middle;
    }

    .table {
        margin-bottom: 0px;
    }
</style>
<h2>Báo cáo tổng nhân viên Xuất vé - Đổi vé</h2>

<div class=""x_panel"">
    <div class=""x_content"">
");
            EndContext();
#line 38 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
         using (Html.BeginForm("DanhSachTongGuiMailDaiLy", "PhongVe", new { i = 3 }, FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(1047, 421, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""form-horizontal"">
                <div class=""col-sm-4 col-xs-8"">
                    <div class=""form-group"">
                        <label for="""" class=""col-sm-4 col-xs-2"" style=""padding-top:11px"">Ngày</label>
                        <div class=""col-sm-8 col-xs-10"">
                            <select id=""NGAYTIMKIEM"" name=""NGAYTIMKIEM"" class=""form-control"">
");
            EndContext();
#line 47 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                 if (ViewBag.NGAY == "HN")
                                {

#line default
#line hidden
            BeginContext(1563, 82, true);
            WriteLiteral("                                    <option selected value=\"HN\">Hôm nay</option>\r\n");
            EndContext();
#line 50 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1753, 73, true);
            WriteLiteral("                                    <option value=\"HN\">Hôm nay</option>\r\n");
            EndContext();
#line 54 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }

#line default
#line hidden
            BeginContext(1861, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                 if (ViewBag.NGAY == "HT")
                                {

#line default
#line hidden
            BeginContext(1958, 82, true);
            WriteLiteral("                                    <option selected value=\"HT\">Hôm qua</option>\r\n");
            EndContext();
#line 59 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2148, 73, true);
            WriteLiteral("                                    <option value=\"HT\">Hôm qua</option>\r\n");
            EndContext();
#line 63 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }

#line default
#line hidden
            BeginContext(2256, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 64 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                 if (ViewBag.NGAY == "TuanT")
                                {

#line default
#line hidden
            BeginContext(2354, 88, true);
            WriteLiteral("                                    <option selected value=\"TuanT\">Tuần trước</option>\r\n");
            EndContext();
#line 67 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2550, 79, true);
            WriteLiteral("                                    <option value=\"TuanT\">Tuần trước</option>\r\n");
            EndContext();
#line 71 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }

#line default
#line hidden
            BeginContext(2664, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 72 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                 if (ViewBag.NGAY == "ThangT")
                                {

#line default
#line hidden
            BeginContext(2763, 90, true);
            WriteLiteral("                                    <option selected value=\"ThangT\">Tháng trước</option>\r\n");
            EndContext();
#line 75 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2961, 81, true);
            WriteLiteral("                                    <option value=\"ThangT\">Tháng trước</option>\r\n");
            EndContext();
#line 79 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }

#line default
#line hidden
            BeginContext(3077, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 80 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                 if (ViewBag.NGAY == "NamT")
                                {

#line default
#line hidden
            BeginContext(3174, 86, true);
            WriteLiteral("                                    <option selected value=\"NamT\">Năm trước</option>\r\n");
            EndContext();
#line 83 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3368, 77, true);
            WriteLiteral("                                    <option value=\"NamT\">Năm trước</option>\r\n");
            EndContext();
#line 87 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }

#line default
#line hidden
            BeginContext(3480, 531, true);
            WriteLiteral(@"



                            </select>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-2 col-xs-3"">
                    <div class=""form-group"">

                        <div class=""col-xs-6"">
                            <button type=""submit"" class=""btn btn-primary"" value=""Search"" name=""search"">Tìm kiếm</button>
                        </div>
                    </div>
                </div>
            </div>
           
        </div>
");
            EndContext();
            BeginContext(4015, 1817, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"" style=""height:auto;"">
                    <div class=""x_title"">
                        <span style=""font-size: 16px;color: red;"">Tính năng tìm kiếm mở rộng</span>

                        <ul class=""nav navbar-right panel_toolbox"">
                            <li style=""float:right;"">
                                <a class=""collapse-link""><i class=""fa fa-chevron-up"" style=""color:red""></i></a>
                            </li>


                        </ul>
                        <div class=""clearfix""></div>
                    </div>

                    <div class=""x_content"" style=""display:none;"">


                        <div class=""row"">

                            <div class=""form-horizontal"">
                                <div class=""item col-sm-4"">
                                    <div class=""form-group"">
                                        <labe");
            WriteLiteral(@"l class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"" for=""first-name"">
                                            Từ Ngày
                                        </label>
                                        <div class=""col-md-8 col-sm-6 col-xs-12 "">

                                            <fieldset class=""col-xs-12"" style=""padding:0px"">
                                                <div class=""control-group"">
                                                    <div class=""controls"">
                                                        <div class="" xdisplay_inputx form-group has-feedback"">
                                                            <input type=""text"" class=""form-control has-feedback-right"" id=""single_cal5"" name=""cal_from""");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 5832, "\'", 5857, 1);
#line 142 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
WriteAttributeValue("", 5840, ViewBag.DateFrom, 5840, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5858, 644, true);
            WriteLiteral(@">
                                                            <span class=""fa fa-calendar-o form-control-feedback right"" aria-hidden=""true""></span>
                                                            <span id=""inputSuccess2Status"" class=""sr-only"">(success)</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </fieldset>
                                        </div>
                                    </div>
                                </div>
");
            EndContext();
            BeginContext(6624, 964, true);
            WriteLiteral(@"                                <div class=""item col-sm-4"">
                                    <div class=""form-group"">
                                        <label class=""col-form-label pad-top-6 col-md-4 col-sm-4 col-xs-12 label-align"" for=""first-name"">
                                            Đến Ngày
                                        </label>
                                        <div class=""col-md-8 col-sm-6 col-xs-12 "">
                                            <fieldset class=""col-xs-12"" style=""padding:0px"">
                                                <div class=""control-group"">
                                                    <div class=""controls"">
                                                        <div class="" xdisplay_inputx form-group has-feedback"" id="""">
                                                            <input type=""text"" class=""form-control has-feedback-right"" id=""single_cal6"" name=""cal_to""");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 7588, "\'", 7611, 1);
#line 163 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
WriteAttributeValue("", 7596, ViewBag.DateTo, 7596, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7612, 1228, true);
            WriteLiteral(@">
                                                            <span class=""fa fa-calendar-o form-control-feedback right"" aria-hidden=""true""></span>
                                                            <span id=""inputSuccess2Status"" class=""sr-only"">(success)</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </fieldset>
                                        </div>
                                    </div>
                                </div>
                            </div>




                        </div>


                        <div class=""row"">
                            <div class=""form-horizontal"">
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label for="""" class=""col-sm-4"" style=""pa");
            WriteLiteral("dding-top:11px\">Nhân viên</label>\r\n                                        <div class=\"col-sm-8\">\r\n                                            <select id=\"NHANVIEN\" name=\"NHANVIEN\" class=\"form-control\">\r\n");
            EndContext();
#line 188 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                 if (Model.ListNhanVien != null)
                                                {

#line default
#line hidden
            BeginContext(8973, 85, true);
            WriteLiteral("                                                <option value=\"All\">Tất cả</option>\r\n");
            EndContext();
#line 191 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                    foreach (var item in Model.ListNhanVien)
                                                    {

#line default
#line hidden
            BeginContext(9207, 55, true);
            WriteLiteral("                                                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9262, "\"", 9287, 1);
#line 193 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
WriteAttributeValue("", 9270, item.TenDangNhap, 9270, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9288, 55, true);
            WriteLiteral(">\r\n                                                    ");
            EndContext();
            BeginContext(9344, 16, false);
#line 194 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                               Write(item.TenNhanVien);

#line default
#line hidden
            EndContext();
            BeginContext(9360, 61, true);
            WriteLiteral("\r\n                                                </option>\r\n");
            EndContext();
#line 196 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                    }
                                                }

#line default
#line hidden
            BeginContext(9527, 983, true);
            WriteLiteral(@"

                                            </select>
                                        </div>
                                    </div>
                                </div>


                            </div>






                            <div class=""col-sm-2"">
                                <div class=""form-group"">

                                    <div class=""col-xs-6"">
                                        <button type=""submit"" class=""btn btn-primary"" value=""SearchMoRong"" name=""search"">Tìm kiếm</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
            <div class=""row"">
                <div class=""form-horizontal"">
                    <div class=""col-sm-8"">
                        <span style=""color:red;font-size:14px;"">");
            EndContext();
            BeginContext(10511, 16, false);
#line 230 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                           Write(ViewBag.ThongBao);

#line default
#line hidden
            EndContext();
            BeginContext(10527, 81, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 234 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"

                        }

#line default
#line hidden
            BeginContext(10637, 953, true);
            WriteLiteral(@"                    </div>
                </div>

                <div class=""x_panel"">
                    <div class=""x_content"">
                        <div class=""table-responsive"" style=""font-size:12px;"">

                            <table id=""gridTable"" class=""table table-striped jambo_table bulk_action"">
                                <thead>
                                    <tr class=""headings"">
                                        <th class=""column-title""> STT</th>
                                        <th class=""column-title""> Mã NV </th>
                                        <th class=""column-title""> Tên NV  </th>
                                        <th class=""column-title""> SL xuất vé </th>
                                        <th class=""column-title""> SL đổi vé </th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 254 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                     if (Model == null)
                                {

#line default
#line hidden
            BeginContext(11682, 322, true);
            WriteLiteral(@"                                    <tr class=""even pointer"">
                                        <td colspan=""12"" style=""text-align:center;"">
                                            <i>Không có thông tin để hiển thị</i>
                                        </td>
                                    </tr>
");
            EndContext();
#line 261 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                }
                                else
                                {
                                    foreach (var item in Model.ListNhanVienXuatDoiVe)
                                    {

#line default
#line hidden
            BeginContext(12238, 133, true);
            WriteLiteral("                                    <tr class=\"even pointer\">\r\n                                        <td style=\"text-align:center\">");
            EndContext();
            BeginContext(12372, 8, false);
#line 267 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                                 Write(item.STT);

#line default
#line hidden
            EndContext();
            BeginContext(12380, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(12441, 9, false);
#line 268 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                Write(item.MaNV);

#line default
#line hidden
            EndContext();
            BeginContext(12450, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(12511, 10, false);
#line 269 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                Write(item.TenNV);

#line default
#line hidden
            EndContext();
            BeginContext(12521, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(12582, 13, false);
#line 270 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                Write(item.SLXuatVe);

#line default
#line hidden
            EndContext();
            BeginContext(12595, 60, true);
            WriteLiteral("</td>\r\n                                        <td class=\"\">");
            EndContext();
            BeginContext(12656, 12, false);
#line 271 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                                Write(item.SLDoiVe);

#line default
#line hidden
            EndContext();
            BeginContext(12668, 54, true);
            WriteLiteral("</td>\r\n\r\n\r\n                                    </tr>\r\n");
            EndContext();
#line 275 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\PhongVe\DanhSachTongGuiMailDaiLy.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(12796, 281, true);
            WriteLiteral(@"                                </tbody>
                            </table>

                        </div>
                    </div>
                </div>

                <div class=""modal fade"" id=""openPopup"" role=""dialog"">
                </div>

                ");
            EndContext();
            BeginContext(13077, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6500ae97dc244df28af94e0d58164d79", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13125, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(13143, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce4de696b9f4ccb8c85e2a396b5a307", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13190, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(13208, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80148bafa7214d6ca8c2f6148a90af0d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13265, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.DanhSachTongNhanVienXuatDoiVe> Html { get; private set; }
    }
}
#pragma warning restore 1591