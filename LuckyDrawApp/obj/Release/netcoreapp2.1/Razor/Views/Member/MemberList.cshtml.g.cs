#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "822a6bb07360344b2f201b41531c72f61561a12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_MemberList), @"mvc.1.0.view", @"/Views/Member/MemberList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/MemberList.cshtml", typeof(AspNetCore.Views_Member_MemberList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"822a6bb07360344b2f201b41531c72f61561a12d", @"/Views/Member/MemberList.cshtml")]
    public class Views_Member_MemberList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.ViewModel.MemberListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
  
    ViewData["Title"] = "Member List";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(160, 11, true);
            WriteLiteral("\r\n\r\n<title>");
            EndContext();
            BeginContext(172, 17, false);
#line 10 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(189, 45, true);
            WriteLiteral(" </title>\r\n<h2> Danh Sách Hoàn Vé </h2>\r\n\r\n\r\n");
            EndContext();
#line 14 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
 using (Html.BeginForm("DanhSachHoanVe", "HoanVe", FormMethod.Get))
{




#line default
#line hidden
            BeginContext(312, 524, true);
            WriteLiteral(@"    <div class=""x_panel"">

        <div class=""x_content"">


            <div class=""row"">

                <div class=""item form-group col-md-4 col-sm-12 col-xs-12"">


                    <label class=""col-form-label pad-top-6 col-md-3 col-sm-3 col-xs-12 label-align"" for=""first-name"">
                        Tên đại lý
                    </label>
                    <div class=""col-md-9 col-sm-6 col-xs-12 "">

                        <input type=""text"" id=""TenDaiLy"" name=""TenDaiLy"" class=""form-control """);
            EndContext();
            BeginWriteAttribute("value", " value=\'", 836, "\'", 857, 1);
#line 34 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
WriteAttributeValue("", 844, ViewBag.SoVe, 844, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(858, 498, true);
            WriteLiteral(@">
                    </div>





                </div>


                <div class=""item form-group col-md-4 col-sm-12 col-xs-12"">


                    <label class=""col-form-label pad-top-6 col-md-3 col-sm-3 col-xs-12 label-align"" for=""first-name"">
                        Người LH
                    </label>
                    <div class=""col-md-9 col-sm-6 col-xs-12 "">

                        <input type=""text"" id=""NguoiLienHe"" name=""nguoilienhe"" class=""form-control """);
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1356, "\'", 1377, 1);
#line 52 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
WriteAttributeValue("", 1364, ViewBag.SoVe, 1364, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1378, 473, true);
            WriteLiteral(@">
                    </div>


                </div>

                <div class=""item form-group col-md-4 col-sm-12 col-xs-12"">


                    <label class=""col-form-label pad-top-6 col-md-3 col-sm-3 col-xs-12 label-align"" for=""first-name"">
                        Mã KH
                    </label>
                    <div class=""col-md-9 col-sm-6 col-xs-12 "">

                        <input type=""text"" id=""MaKH"" name=""MaKH"" class=""form-control """);
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1851, "\'", 1872, 1);
#line 66 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
WriteAttributeValue("", 1859, ViewBag.SoVe, 1859, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1873, 548, true);
            WriteLiteral(@">
                    </div>


                </div>









            </div>


            <div class=""row"">

                <div class=""item form-group col-md-4 col-sm-12 col-xs-12"">


                    <label class=""col-form-label pad-top-6 col-md-3 col-sm-3 col-xs-12 label-align"" for=""first-name"">
                        Email
                    </label>
                    <div class=""col-md-9 col-sm-6 col-xs-12 "">

                        <input type=""text"" id=""Email"" name=""Email"" class=""form-control """);
            EndContext();
            BeginWriteAttribute("value", " value=\'", 2421, "\'", 2442, 1);
#line 93 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
WriteAttributeValue("", 2429, ViewBag.SoVe, 2429, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2443, 488, true);
            WriteLiteral(@">
                    </div>





                </div>


                <div class=""item form-group col-md-4 col-sm-12 col-xs-12"">


                    <label class=""col-form-label pad-top-6 col-md-3 col-sm-3 col-xs-12 label-align"" for=""first-name"">
                        ĐT
                    </label>
                    <div class=""col-md-9 col-sm-6 col-xs-12 "">

                        <input type=""text"" id=""DienThoai"" name=""DienThoai"" class=""form-control """);
            EndContext();
            BeginWriteAttribute("value", " value=\'", 2931, "\'", 2952, 1);
#line 111 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
WriteAttributeValue("", 2939, ViewBag.SoVe, 2939, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2953, 210, true);
            WriteLiteral(">\r\n                    </div>\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"item form-group col-md-4 col-sm-12 col-xs-12\">\r\n\r\n\r\n\r\n                    <div class=\"col-md-12 col-sm-6 col-xs-12 \">\r\n\r\n");
            EndContext();
            BeginContext(3362, 1341, true);
            WriteLiteral(@"
                        <select id=""sodong"" onchange=""ThemDong(this)"" class=""form-control"" style="" float:left; margin-right: 5%"" name=""sodong"">

                            <option value=""1"">1</option>
                            <option value=""2"">2</option>
                            <option value=""3"">3</option>
                            <option value=""4"">4</option>
                            <option value=""5"">5</option>
                            <option value=""6"">6</option>
                            <option value=""7"">7</option>
                            <option value=""8"">8</option>
                            <option value=""9"">9 </option>

                        </select>


                    </div>


                </div>

            </div>










            <div class=""row"" style=""float:left;margin-left:31px;"">

                <div class=""form-group col-md-12 col-sm-12 col-xs-12"">
                    <div class=""col-md-offset-3 col-md-12"">
          ");
            WriteLiteral(@"              <button class=""btn btn-primary"" onclick=""myFunction()"">Làm mới</button>
                        <button class=""btn btn-primary"" onclick=""myFunction()"">Tìm kiếm</button>
                    </div>

                </div>


            </div>









        </div>




    </div>
");
            EndContext();
#line 183 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
}

#line default
#line hidden
            BeginContext(4706, 966, true);
            WriteLiteral(@"
<div class=""x_panel"">

    <div class=""x_content"">

        <div class=""table-responsive"">
            <table id=""gridHoanVe"" class=""table table-striped jambo_table bulk_action"">
                <thead>
                    <tr class=""headings"">

                        <th class=""column-title"">STT </th>
                        <th class=""column-title"">Tên đại lý</th>
                        <th class=""column-title"">Người đại diện</th>
                        <th class=""column-title"">Tài khoản</th>
                        <th class=""column-title"">Email</th>
                        <th class=""column-title"">Địa chỉ</th>

                        <th class=""bulk-actions"" colspan=""7"">
                            <a class=""antoo"" style=""color:#fff; font-weight:500;"">Bulk Actions ( <span class=""action-cnt""> </span> ) <i class=""fa fa-chevron-down""></i></a>
                        </th>
                    </tr>
                </thead>

");
            EndContext();
#line 207 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#line 209 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                     foreach (var item in Model.MemberList)
                    {


#line default
#line hidden
            BeginContext(5814, 64, true);
            WriteLiteral("                        <tbody>\r\n                            <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5878, "\"", 5891, 1);
#line 213 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
WriteAttributeValue("", 5883, item.ID, 5883, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5892, 73, true);
            WriteLiteral(" class=\"even pointer\">\r\n\r\n\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(5966, 8, false);
#line 216 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                                        Write(item.STT);

#line default
#line hidden
            EndContext();
            BeginContext(5974, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(6027, 13, false);
#line 217 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                                        Write(item.TenDaiLy);

#line default
#line hidden
            EndContext();
            BeginContext(6040, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(6093, 17, false);
#line 218 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                                        Write(item.NguoiDaiDien);

#line default
#line hidden
            EndContext();
            BeginContext(6110, 55, true);
            WriteLiteral(" </td>\r\n\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(6166, 13, false);
#line 220 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                                        Write(item.TaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(6179, 52, true);
            WriteLiteral("</td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(6232, 10, false);
#line 221 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                                        Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(6242, 53, true);
            WriteLiteral(" </td>\r\n                                <td class=\"\">");
            EndContext();
            BeginContext(6296, 11, false);
#line 222 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                                        Write(item.DiaChi);

#line default
#line hidden
            EndContext();
            BeginContext(6307, 503, true);
            WriteLiteral(@" </td>
                                <td class="""">
                                    <a onclick=""HuyHoanVe(this);"" href=""javascript:;""> <img src=""/../images/del.gif"" /></a>
                                </td>
                                <td class="""">
                                    <a onclick=""HuyHoanVe(this);"" href=""javascript:;""> <img src=""/../images/del.gif"" /></a>
                                </td>

                            </tr>

                        </tbody>
");
            EndContext();
#line 233 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                    }

#line default
#line hidden
#line 233 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Member\MemberList.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(6852, 2571, true);
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
            url: ""/HoanVe/ThongTinVe"",
            data: { khoachinh: subject_id },


            success: function (response) {


                $('#openPopup').html(response);

                $('#openPopup').modal('show');

            },
            failure: function (response) {

                ");
            WriteLiteral(@"alert(response.responseText);
            },
            error: function (response) {

                alert(response.responseText);
            }


        });
    });



    function DanhDauTinhTrangVe(obj) {
        var table = document.getElementById(""gridHoanVe"");
        var index = obj.parentNode.parentNode.rowIndex;
        var subject_id = document.getElementById(""gridHoanVe"").getElementsByTagName('tr')[index].id;



        var danhdau = document.getElementById(""gridHoanVe"").rows[index].cells[7].getElementsByTagName(""input"")[0].checked;

        if (confirm(""Bạn có chắc muốn đánh dấu"")) {
            $.ajax({
                url: '/HoanVe/DanhDauTinhTrangVe',
                data: { id: subject_id, tinhtrang: danhdau },
                method: 'POST'
            })
                .done(function () {


                })
        }
    }




    function HuyHoanVe(obj) {
        var table = document.getElementById(""gridHoanVe"");
        var index = obj.parentNo");
            WriteLiteral(@"de.parentNode.rowIndex;
        var subject_id = document.getElementById(""gridHoanVe"").getElementsByTagName('tr')[index].id;

        if (confirm(""Bạn có chắc muốn hủy"")) {
            $.ajax({ url: '/HoanVe/HuyHoanVe', data: { id: subject_id }, method: 'POST' })
                .done(function () {
                    location.reload(true);

                })


        }



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.ViewModel.MemberListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591