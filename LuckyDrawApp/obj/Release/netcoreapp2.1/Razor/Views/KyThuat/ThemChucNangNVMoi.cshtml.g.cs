#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KyThuat\ThemChucNangNVMoi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4150f2cef9f0d9e1f04cb0e037c5ac528085c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KyThuat_ThemChucNangNVMoi), @"mvc.1.0.view", @"/Views/KyThuat/ThemChucNangNVMoi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KyThuat/ThemChucNangNVMoi.cshtml", typeof(AspNetCore.Views_KyThuat_ThemChucNangNVMoi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4150f2cef9f0d9e1f04cb0e037c5ac528085c0", @"/Views/KyThuat/ThemChucNangNVMoi.cshtml")]
    public class Views_KyThuat_ThemChucNangNVMoi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.Chitietnhanvien>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 1421, true);
            WriteLiteral(@"

<div class=""modal-dialog"">

    <!-- Modal content-->
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            <h1 style=""color:red"">Thêm chức năng nhân viên mới</h1>
        </div>
        <div class=""modal-body"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""row"">
                          <div class=""col-xs-12 form-group"">
                                <div class=""row"">
                                    <label for="""" class=""col-sm-2 control-label"">NV mới</label>
                                    <div class=""col-sm-3"">
                                        <div class=""item form-group"">
                                            <div class=""input-group"">
                                                <input type=""text"" class=""form-control"" id=""manv"" name=""manv"">
                                                <span");
            WriteLiteral(@" class=""input-group-btn"">
                                                    <button id=""btnSearch""  class=""btn btn-info"" type=""button""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
");
            EndContext();
            BeginContext(1855, 15638, true);
            WriteLiteral(@"                                    <label for=""""  style=""color: teal; font-weight: 500; font-size:14px;"" class=""col-sm-4 control-label"" id=""searchten""></label>                                                                  
                                </div>
                               </div>                       
                        <br />
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <label for="""" class=""col-sm-8 control-label"">Tính năng mới</label>
                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""tinhnangmoi"">
                                            </div>
                             ");
            WriteLiteral(@"           </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Thông báo</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""thongbao"">
                                            </div>
                                        </div>
                                    </div>
                                ");
            WriteLiteral(@"</div>

                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Báo cáo vé</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""baocaove"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                  ");
            WriteLiteral(@"      <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Nội bộ</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""noibo"">
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
             ");
            WriteLiteral(@"                   <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Đại lí</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""daili"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                 ");
            WriteLiteral(@"               <label for="""" class=""col-sm-8 control-label"">Kế toán</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""ketoan"">
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Kinh doanh</label>

                 ");
            WriteLiteral(@"               <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""kinhdoanh"">
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Phòng vé</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-");
            WriteLiteral(@"group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""phongve"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">BP đoàn</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                           ");
            WriteLiteral(@"                 <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""bpdoan"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Hóa đơn</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                            ");
            WriteLiteral(@"                    <input type=""checkbox"" id=""hoadon"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">CA</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""ca"">
                                            </div>
 ");
            WriteLiteral(@"                                       </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Yến sào</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""yensao"">
                                            </div>
                                        </div>
                                    </div>
          ");
            WriteLiteral(@"                      </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">CS</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""cs"">
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
          ");
            WriteLiteral(@"              <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Data</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""data"">
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
        ");
            WriteLiteral(@"                        <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
                                <label for="""" class=""col-sm-8 control-label"">Setting</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""setting"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xs-3 form-group"">
                            <div class=""row"">
                                <input type=""hidden"" class=""form-control"" id="""" name="""" value="""">
         ");
            WriteLiteral(@"                       <label for="""" class=""col-sm-8 control-label"">Kỹ thuật</label>

                                <div class=""col-sm-4"">
                                    <div class=""control-group"">
                                        <div class=""controls"">
                                            <div class="" xdisplay_inputx form-group has-feedback"">
                                                <input type=""checkbox"" id=""kythuat"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-12 form-group"">
                            <div class=""row"">
                                <div style=""text-align: right; margin-right:20px; "">
                                    <input type=""submit"" class=""btn btn-primary"" id=""Savechucnang"" value=""Lưu"" name=""sav");
            WriteLiteral(@"eBtn"" />
                                </div>
                            </div>
                        </div>
                    </div>
                        </div>
            </div>
        </div>
    </div>

    <!-- Modal content-->

    <style>
        ");
            EndContext();
            BeginContext(17494, 5381, true);
            WriteLiteral(@"@media(min-width: 768px) {
            .modal-dialog {
                width: 700px;
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
    <script>

        $(""#Savechucnang"").click(function () {
            var manv = document.getElementById(""manv"").value;
            var tinhnangmoi = document.getElementById(""tinhnangmoi"").checked;
            var thongbao = document.getElementById(""thongbao"").checked;
            var baocaove = document.getElementById(""baocaove"").checked;
            var noibo = document.getElementById(""noibo"").checked;
            var daili = document.getElementById(""daili"").checked;
            var ketoan = document.getElementById(""ketoan"").checked;
            var kinhdoanh = document.getElementById(""kinhdoanh"").checked;
           ");
            WriteLiteral(@" var phongve = document.getElementById(""phongve"").checked;
            var bpdoan = document.getElementById(""bpdoan"").checked;
            var hoadon = document.getElementById(""hoadon"").checked;
            var ca = document.getElementById(""ca"").checked;
            var yensao = document.getElementById(""yensao"").checked;
            var cs = document.getElementById(""cs"").checked;
            var data = document.getElementById(""data"").checked;
            var setting = document.getElementById(""setting"").checked;
            var kythuat = document.getElementById(""kythuat"").checked;
            if (manv=="""" ) {
                alert(""Vui lòng nhập mã NV"");
                return;
            } if (tinhnangmoi == false && thongbao == false && baocaove == false && noibo == false && daili == false && ketoan == false && kinhdoanh == false && phongve == false && bpdoan == false && hoadon == false && ca == false && yensao == false && cs == false && data == false && setting == false && kythuat == false) {
");
            WriteLiteral(@"                alert(""Vui lòng chọn ít nhất 1 chức năng"");
                return;
            }
            $.ajax({
                type: ""POST"",
                url: ""/KyThuat/Savephanquyenmembermoi"",
                data: {
                    manv: manv,
                    tinhnangmoi: tinhnangmoi,
                    thongbao: thongbao,
                    baocaove: baocaove,
                    noibo: noibo,
                    daili: daili,
                    ketoan: ketoan,
                    kinhdoanh: kinhdoanh,
                    phongve: phongve,
                    bpdoan: bpdoan,
                    hoadon: hoadon,
                    ca: ca,
                    yensao: yensao,
                    cs: cs,
                    data: data,
                    setting: setting,
                    kythuat: kythuat
                },
                success: function (response) {


                    if (response == true) {
                        alert(""Lưu thành ");
            WriteLiteral(@"công"");
                        location.reload();
                    } else {
                        alert(""Mã nhân viên không tồn tại hoặc đã được phân quyền"");
                       
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

        $(""#btnSearch"").click(function () {
            var manv = document.getElementById(""manv"").value;
            if (manv == """") {
                alert(""Vui lòng nhập mã NV"");
                return;
            }

            $.ajax({
                type: ""POST"",
                url: ""/KyThuat/SearchMember"",
                data: {
                    manv: manv
                   
                },
                success: funct");
            WriteLiteral(@"ion (response) {
                    if (response.maNV == null || response.maNV == """") {
                        alert(""Mã nhân viên không tồn tại"");
                    } else {
                        console.log(response);
                        console.log(response.dschucnangmember);
                      
                        if (response.dschucnangmember != null) {
                            document.getElementById(""searchten"").innerHTML = response.maNV +"" ""+ ""-"" +"" ""+ response.tennhanvien;
                           
                            alert(""Mã nhân viên đã được phân quyền"");
                        } else {
                            document.getElementById(""searchten"").innerHTML = response.maNV + "" "" + ""-"" + "" "" + response.tennhanvien;
                         
                            return;
                        }
                    }
                },
                failure: function (response) {
                    console.log(response);
              ");
            WriteLiteral(@"      alert(response);
                },
                error: function (response) {
                    console.log(response);
                    alert(response);
                }
            });
        });
    </script>
    <div class=""row"">

");
            EndContext();
#line 449 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KyThuat\ThemChucNangNVMoi.cshtml"
         if (ViewBag.thongbao != null)
        {

#line default
#line hidden
            BeginContext(22926, 69, true);
            WriteLiteral("            <script charset=\"UTF-8\">\r\n\r\n                      alert(\'");
            EndContext();
            BeginContext(22996, 26, false);
#line 453 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KyThuat\ThemChucNangNVMoi.cshtml"
                        Write(Html.Raw(ViewBag.thongbao));

#line default
#line hidden
            EndContext();
            BeginContext(23022, 28, true);
            WriteLiteral("\');\r\n            </script>\r\n");
            EndContext();
#line 455 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KyThuat\ThemChucNangNVMoi.cshtml"

        }

#line default
#line hidden
            BeginContext(23063, 56, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.Chitietnhanvien> Html { get; private set; }
    }
}
#pragma warning restore 1591
