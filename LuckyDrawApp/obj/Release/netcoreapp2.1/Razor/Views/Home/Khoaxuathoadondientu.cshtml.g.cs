#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7062ce1f8ecf1adfa2d0c8b24e85570107e7ca9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Khoaxuathoadondientu), @"mvc.1.0.view", @"/Views/Home/Khoaxuathoadondientu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Khoaxuathoadondientu.cshtml", typeof(AspNetCore.Views_Home_Khoaxuathoadondientu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7062ce1f8ecf1adfa2d0c8b24e85570107e7ca9e", @"/Views/Home/Khoaxuathoadondientu.cshtml")]
    public class Views_Home_Khoaxuathoadondientu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.KhoaHoaDon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
  
    ViewData["Title"] = "Khóa xuất hóa đơn điện tử";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(150, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(158, 17, false);
#line 6 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(175, 572, true);
            WriteLiteral(@"</title>
<div class=""col-md-4"">
    <div class=""form-horizontal"" role=""form"">
        <div class=""col-sm-12"" style="" border: 1px solid black; padding: 5px 5px 5px 5px;"">
            <label for="""" style=""color:red"" class=""col-sm-12"">Chọn khóa điện tử</label>
            <div class=""form-group"">
                <div class=""col-sm-12 form-group"">
                    <div class=""row"">
                        <div class=""col-sm-8"">
                            <select id=""khoa"" name=""khoa"" asp-for=""khoa"" class=""select2_single form-control"" onchange=""getKhoa()"">
");
            EndContext();
#line 16 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                                 foreach (var item in Model.KieuKhoa)
                                {

#line default
#line hidden
            BeginContext(853, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 896, "\"", 918, 1);
#line 18 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 905, item.ItemKey, 905, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(919, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(921, 14, false);
#line 18 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                                                              Write(item.ItemValue);

#line default
#line hidden
            EndContext();
            BeginContext(935, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 19 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                                }

#line default
#line hidden
            BeginContext(981, 633, true);
            WriteLiteral(@"                            </select>
                        </div>
                        <div class=""col-sm-4""> <input type=""submit"" class=""btn btn-danger btn-block"" id=""khoatongBtn"" value=""Khóa""/></div>
                    </div>
                </div>
            </div>
            <label for="""" class=""col-sm-12"">Khóa xuất hóa đơn phòng vé</label>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Loại1</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" id=""txt_PVL1"" name=""txt_PVL1"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1614, "\"", 1637, 1);
#line 30 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 1622, Model.txt_PVL1, 1622, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1638, 316, true);
            WriteLiteral(@" readonly>
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-2 control-label"">Loại 2</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" id=""txt_PVL2"" name=""txt_PVL2"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1954, "\"", 1977, 1);
#line 36 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 1962, Model.txt_PVL2, 1962, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1978, 316, true);
            WriteLiteral(@" readonly>
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-2 control-label"">Loại 3</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" id=""txt_PVL3"" name=""txt_PVL3"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2294, "\"", 2317, 1);
#line 42 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 2302, Model.txt_PVL3, 2302, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2318, 316, true);
            WriteLiteral(@" readonly>
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-2 control-label"">Loại 4</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" id=""txt_PVL4"" name=""txt_PVL4"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2634, "\"", 2657, 1);
#line 48 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 2642, Model.txt_PVL4, 2642, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2658, 1125, true);
            WriteLiteral(@" readonly>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-4"" style=""margin-bottom: 15px;"">
                    <button type=""submit"" class=""btn btn-primary btn-block"" id=""Laydata"" name=""Laydata"" value=""Laydata"">LẤY DATA</button>
                </div>
                <div class=""col-md-push-4 col-md-4"" style=""text-align:right;"">
                    <button type=""submit"" class=""btn btn-success btn-block"" id=""khoaBtn1"" name=""khoaBtn1"" value=""searchBtn1"" disabled>KHÓA</button>
                </div>
            </div>
        </div>
        <div class=""col-sm-12 form-group"" style=""border: 1px solid black; padding: 5px 5px 5px 5px;"">
            <div class=""col-sm-12 form-group"">
                <label for="""" style=""color:red"" class=""col-sm-12"">Ngày tự khóa hóa đơn</label>
            </div>
            <div class=""col-sm-12 form-group"">
                <div class=""row"">
                    <div class=""col-sm-8"">
               ");
            WriteLiteral("         <input type=\"text\" class=\"form-control\" id=\"txt_NgayKhoa\" name=\"txt_NgayKhoa\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3783, "\"", 3810, 1);
#line 67 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 3791, Model.txt_NgayKhoa, 3791, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3811, 675, true);
            WriteLiteral(@">
                    </div>
                    <div class=""col-sm-4""><button type=""submit"" class=""btn btn-danger btn-block"" id=""Ngaykhoa"" name=""Ngaykhoa"" value=""Ngaykhoa"">KHÓA</button></div>
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" style=""color:red"" class=""col-sm-12"">Khóa xuất hóa đơn phòng vé</label>
            </div>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-6 "">Giới hạn hợp đồng 1 ngày</label>
                <div class=""col-sm-6"">
                    <input type=""text"" class=""form-control"" id=""txt_GHTN"" name=""txt_GHTN"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4486, "\"", 4509, 1);
#line 78 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 4494, Model.txt_GHTN, 4494, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4510, 314, true);
            WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-6 "">Chữa số hợp đồng loại 1</label>
                <div class=""col-sm-6"">
                    <input type=""text"" class=""form-control"" id=""txt_ChuaL1"" name=""txt_ChuaL1"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4824, "\"", 4849, 1);
#line 84 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 4832, Model.txt_ChuaL1, 4832, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4850, 314, true);
            WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-6 "">Chữa số hợp đồng loại 2</label>
                <div class=""col-sm-6"">
                    <input type=""text"" class=""form-control"" id=""txt_ChuaL2"" name=""txt_ChuaL2"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5164, "\"", 5189, 1);
#line 90 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 5172, Model.txt_ChuaL2, 5172, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5190, 314, true);
            WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-6 "">Chữa số hợp đồng loại 3</label>
                <div class=""col-sm-6"">
                    <input type=""text"" class=""form-control"" id=""txt_ChuaL3"" name=""txt_ChuaL3"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5504, "\"", 5529, 1);
#line 96 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 5512, Model.txt_ChuaL3, 5512, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5530, 314, true);
            WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label for="""" class=""col-sm-6 "">Chữa số hợp đồng loại 4</label>
                <div class=""col-sm-6"">
                    <input type=""text"" class=""form-control"" id=""txt_ChuaL4"" name=""txt_ChuaL4"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5844, "\"", 5869, 1);
#line 102 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 5852, Model.txt_ChuaL4, 5852, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5870, 1052, true);
            WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-push-8 col-md-4"" style=""text-align:right;"">
                    <button type=""submit"" class=""btn btn-primary btn-block"" id=""Gioihanngay"" name=""Gioihanngay"" value=""Gioihanngay"" >CẬP NHẬT</button>
                </div>
            </div>
            </div>
        </div>
</div>
<div class=""col-md-8"">
    <div class=""form-horizontal"" role=""form"">
        <div class=""form-group"">
            <div class=""col-sm-12"">
                <div class=""col-md-12"" style=""border: 1px solid black; padding: 5px 5px 5px 5px;"">
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label for="""" style=""color:red; text-align:center"" class=""col-sm-12"">Mẫu số</label>
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""txt_KHHD_1"" name");
            WriteLiteral("=\"txt_KHHD_1\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6922, "\"", 6947, 1);
#line 123 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 6930, Model.txt_KHHD_1, 6930, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6948, 201, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txt_KHHD_2\" name=\"txt_KHHD_2\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7149, "\"", 7174, 1);
#line 126 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 7157, Model.txt_KHHD_2, 7157, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7175, 201, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txt_KHHD_3\" name=\"txt_KHHD_3\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7376, "\"", 7401, 1);
#line 129 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 7384, Model.txt_KHHD_3, 7384, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7402, 201, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txt_KHHD_4\" name=\"txt_KHHD_4\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7603, "\"", 7628, 1);
#line 132 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 7611, Model.txt_KHHD_4, 7611, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7629, 471, true);
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-md-9"">
                        <div class=""form-group"">
                            <label for="""" style=""color:red;text-align:center"" class=""col-sm-12"">KHHD</label>
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" id=""txt_Serial_L1"" name=""txt_Serial_L1"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8100, "\"", 8128, 1);
#line 140 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 8108, Model.txt_Serial_L1, 8108, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8129, 207, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txt_Serial_L2\" name=\"txt_Serial_L2\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8336, "\"", 8364, 1);
#line 143 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 8344, Model.txt_Serial_L2, 8344, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8365, 207, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txt_Serial_L3\" name=\"txt_Serial_L3\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8572, "\"", 8600, 1);
#line 146 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 8580, Model.txt_Serial_L3, 8580, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8601, 207, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txt_Serial_L4\" name=\"txt_Serial_L4\" placeholder=\"\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8808, "\"", 8836, 1);
#line 149 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
WriteAttributeValue("", 8816, Model.txt_Serial_L4, 8816, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8837, 1050, true);
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            <button type=""submit"" class=""btn btn-primary btn-block"" id=""updateKHHD"" name=""updateKHHD"" value=""update"">CẬP NHẬT</button>
                        </div>
                    </div>
                </div>
                <br />
                <div class=""col-md-3"" style=""border:1px solid black;"">
                    <div class=""form-group"">
                        <label for="""" style=""color:red;"" class=""col-sm-12"">Nội dung thông báo chữ</label>
                    </div>
                    <div class=""form-group"">
                        <label for="""" style=""text-align:center;"" class=""col-sm-12"">Chọn phần mềm</label>
                    </div>
                    <div class=""form-group"">
                        <select id=""khoaphanmem"" name=""khoaphanmem"" asp-for=""khoaphanmem"" class=""select2_single form-control"" o");
            WriteLiteral("nchange=\"getPhanmem()\" >\r\n");
            EndContext();
#line 168 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                             foreach (var item in Model.PhanMem)
                            {

#line default
#line hidden
            BeginContext(9984, 40, true);
            WriteLiteral("                                <option ");
            EndContext();
            BeginContext(10025, 11, false);
#line 170 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                                   Write(item.Select);

#line default
#line hidden
            EndContext();
            BeginContext(10036, 17, true);
            WriteLiteral(" class=\"Phanmem\">");
            EndContext();
            BeginContext(10054, 12, false);
#line 170 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                                                                Write(item.Phanmem);

#line default
#line hidden
            EndContext();
            BeginContext(10066, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 171 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                            }

#line default
#line hidden
            BeginContext(10108, 489, true);
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-primary btn-block"" id=""updatePhanmem"" name=""updatePhanmem"" value=""updatePhanmem"">CẬP NHẬT</button>
                    </div>
                </div>
                <div class=""col-md-9 "" style=""border: 1px solid black; padding: 5px 5px 5px 5px; margin-bottom:40px;"">
                    <div class=""form-group"" >
");
            EndContext();
            BeginContext(10695, 41, true);
            WriteLiteral("                        <h5 id=\"Noidung\">");
            EndContext();
            BeginContext(10737, 35, false);
#line 181 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Home\Khoaxuathoadondientu.cshtml"
                                    Write(Html.Raw(Model.PhanMem[0].Thongbao));

#line default
#line hidden
            EndContext();
            BeginContext(10772, 10408, true);
            WriteLiteral(@"</h5>
                    </div>
                </div>
                <div class=""form-group"">
                    <label for="""" class=""col-sm-12"">Nhập mật khẩu để xác nhận</label>
                </div>
                <div class=""form-group col-md-3"">
                    <input type=""password"" class=""form-control"" id=""nhapmk"" name=""nhapmk"" placeholder="""" value="""">
                </div>
            </div>
        </div>
    </div>
</div>




<style>
    .boderexam1 {
        border: 2px solid black;
        padding: 5px 5px 5px 5px;
    }  
    
</style>

<!-- Modal content-->
<script type=""text/javascript"">
    function getKhoa() {
        var id = $('#khoa option:selected').val();       
        $.ajax({
            type: ""GET"",
            url: ""/Home/GetKey"",
            data: { khoachinh: id },

            success: function (response) {

                if (response == 1) {

                    document.getElementById(""khoatongBtn"").value = ""Mở"";

            ");
            WriteLiteral(@"    } else {

                    document.getElementById(""khoatongBtn"").value = ""Khóa"";

                }
            },
            failure: function (response) {

                alert(response);
            },
            error: function (response) {

                alert(response);
            }


        });
    }
</script>
<script>
    $(""#khoatongBtn"").click(function () {
        var id = $('#khoa option:selected').val();
        var khoatong = document.getElementById(""khoatongBtn"").value;
        var nhapmk = document.getElementById(""nhapmk"").value;
        if (nhapmk == """") {
            alert(""Vui lòng nhập mã mật khẩu"");
            return;
        }
        if (id == ""0"") {
            alert(""Xin vui lòng chọn để khóa"");
            return;
        }
        $.ajax({
            type: ""POST"",
            url: ""/Home/Khoahoadon"",
            data: {
                nhapmk: nhapmk,
                id:id

            },
            success: function (respons");
            WriteLiteral(@"e) {
                if (response == true) {
                    if (khoatong == ""Khóa"") {
                        document.getElementById(""khoatongBtn"").value = ""Mở"";
                        alert(""KHÓA / MỞ KHÓA XUẤT HĐ THÀNH CÔNG!"");
                    } else {
                        document.getElementById(""khoatongBtn"").value = ""Khóa"";
                        alert(""KHÓA / MỞ KHÓA XUẤT HĐ THÀNH CÔNG!"");
                    }
                  
                } else {
                    alert(""Mật khẩu xác nhận không đúng!"");
                }
                
            },
            failure: function (response) {
                console.log(response);
                alert(response);
            },
            error: function (response) {
                console.log(response);
                alert(response);
            }
        });
    });
</script>
<script>
    $(""#Laydata"").click(function () {
        document.getElementById('txt_PVL1').readOnly = false;
        d");
            WriteLiteral(@"ocument.getElementById('txt_PVL2').readOnly = false;
        document.getElementById('txt_PVL3').readOnly = false;
        document.getElementById('txt_PVL4').readOnly = false;
        document.getElementById('khoaBtn1').disabled = false;        
    });
</script>
<script>
    $(""#khoaBtn1"").click(function () {
      
        var txt_PVL1 = document.getElementById(""txt_PVL1"").value;
        var txt_PVL2 = document.getElementById(""txt_PVL2"").value;
        var txt_PVL3 = document.getElementById(""txt_PVL3"").value;
        var txt_PVL4 = document.getElementById(""txt_PVL4"").value;
        var nhapmk = document.getElementById(""nhapmk"").value;
        $.ajax({
            type: ""POST"",
            url: ""/Home/KhoaPVL"",
            data: {
                txt_PVL1: txt_PVL1,
                txt_PVL2: txt_PVL2,
                txt_PVL3: txt_PVL3,
                txt_PVL4: txt_PVL4,
                nhapmk: nhapmk

            },
            success: function (response) {
                if (r");
            WriteLiteral(@"esponse == true) {
                    alert(""Khóa xuất hóa đơn PV THÀNH CÔNG!"");
                } else {
                    alert(""Mật khẩu xác nhận không đúng!"");
                }

            },
            failure: function (response) {
                console.log(response);
                alert(response);
            },
            error: function (response) {
                console.log(response);
                alert(response);
            }
        });
    });
</script>
<script>
    $(""#updateKHHD"").click(function () {

        var txt_KHHD_1 = document.getElementById(""txt_KHHD_1"").value;
        var txt_KHHD_2 = document.getElementById(""txt_KHHD_2"").value;
        var txt_KHHD_3 = document.getElementById(""txt_KHHD_3"").value;
        var txt_KHHD_4 = document.getElementById(""txt_KHHD_4"").value;

        var txt_Serial_L1 = document.getElementById(""txt_Serial_L1"").value;
        var txt_Serial_L2 = document.getElementById(""txt_Serial_L2"").value;
        var txt_Serial_L");
            WriteLiteral(@"3 = document.getElementById(""txt_Serial_L3"").value;
        var txt_Serial_L4 = document.getElementById(""txt_Serial_L4"").value;

        var nhapmk = document.getElementById(""nhapmk"").value;
        $.ajax({
            type: ""POST"",
            url: ""/Home/UpdateKHHD"",
            data: {
                txt_KHHD_1: txt_KHHD_1,
                txt_KHHD_2: txt_KHHD_2,
                txt_KHHD_3: txt_KHHD_3,
                txt_KHHD_4: txt_KHHD_4,
                txt_Serial_L1: txt_Serial_L1,
                txt_Serial_L2: txt_Serial_L2,
                txt_Serial_L3: txt_Serial_L3,
                txt_Serial_L4: txt_Serial_L4,
                nhapmk: nhapmk

            },
            success: function (response) {
                if (response == true) {
                    alert(""CẬP NHẬT KÝ HIỆU HĐ THÀNH CÔNG!"");
                } else {
                    alert(""Mật khẩu xác nhận không đúng!"");
                }

            },
            failure: function (response) {
       ");
            WriteLiteral(@"         console.log(response);
                alert(response);
            },
            error: function (response) {
                console.log(response);
                alert(response);
            }
        });
    });
</script>
<script>
    $(""#updatePhanmem"").click(function () {
        var khoaphanmem = $('#khoaphanmem option:selected').val();
        var nhapmk = document.getElementById(""nhapmk"").value;
        var noidung = document.getElementById(""Noidung"").innerHTML;
        $.ajax({
            type: ""POST"",
            url: ""/Home/UpdatePhanmem"",
            data: {
                khoaphanmem: khoaphanmem,
                noidung: noidung,
                nhapmk: nhapmk
            },
            success: function (response) {
                if (response == true) {
                    alert(""Đã lưu thành công!"");
                } else {
                    alert(""Mật khẩu xác nhận không đúng!"");
                }

            },
            failure: function ");
            WriteLiteral(@"(response) {
                console.log(response);
                alert(response);
            },
            error: function (response) {
                console.log(response);
                alert(response);
            }
        });
    });
</script>
<script type=""text/javascript"">
    function getPhanmem() {
        var khoaphanmem = $('#khoaphanmem option:selected').val();
        $.ajax({
            type: ""GET"",
            url: ""/Home/GetPhanMem"",
            data: { khoaphanmem: khoaphanmem },

            success: function (response) {

                document.getElementById(""Noidung"").innerHTML = response;
            },
            failure: function (response) {

                alert(response);
            },
            error: function (response) {

                alert(response);
            }


        });
    }
</script>
<script>
    $(""#Ngaykhoa"").click(function () {       
        var txt_NgayKhoa = document.getElementById(""txt_NgayKhoa"").value;
 ");
            WriteLiteral(@"       var nhapmk = document.getElementById(""nhapmk"").value;
        $.ajax({
            type: ""POST"",
            url: ""/Home/UpdateNgayKhoa"",
            data: {
                txt_NgayKhoa: txt_NgayKhoa,
                nhapmk: nhapmk
              
            },
            success: function (response) {
                if (response == true) {
                    alert(""Đã lưu thành công!"");
                } else {
                    alert(""Mật khẩu xác nhận không đúng!"");
                }

            },
            failure: function (response) {
                console.log(response);
                alert(response);
            },
            error: function (response) {
                console.log(response);
                alert(response);
            }
        });
    });
</script>
<script>
    $(""#Gioihanngay"").click(function () {
        var txt_GHTN = document.getElementById(""txt_GHTN"").value;
        var txt_ChuaL1 = document.getElementById(""txt_ChuaL1"").value");
            WriteLiteral(@";
        var txt_ChuaL2 = document.getElementById(""txt_ChuaL2"").value;
        var txt_ChuaL3 = document.getElementById(""txt_ChuaL3"").value;
        var txt_ChuaL4 = document.getElementById(""txt_ChuaL4"").value;
        var nhapmk = document.getElementById(""nhapmk"").value;
        $.ajax({
            type: ""POST"",
            url: ""/Home/UpdateGHN"",
            data: {
                txt_GHTN: txt_GHTN,
                txt_ChuaL1: txt_ChuaL1,
                txt_ChuaL2: txt_ChuaL2,
                txt_ChuaL3: txt_ChuaL3,
                txt_ChuaL4: txt_ChuaL4,
                nhapmk: nhapmk

            },
            success: function (response) {
                if (response == true) {
                    alert(""Đã lưu thành công!"");
                } else {
                    alert(""Mật khẩu xác nhận không đúng!"");
                }

            },
            failure: function (response) {
                console.log(response);
                alert(response);
            },");
            WriteLiteral("\r\n            error: function (response) {\r\n                console.log(response);\r\n                alert(response);\r\n            }\r\n        });\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.KhoaHoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
