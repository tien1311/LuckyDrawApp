#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3799d1d995ebc52ceb6ee3c4f6ea2302b142bce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KinhDoanh_GuiMailDaiLy_KD), @"mvc.1.0.view", @"/Views/KinhDoanh/GuiMailDaiLy_KD.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KinhDoanh/GuiMailDaiLy_KD.cshtml", typeof(AspNetCore.Views_KinhDoanh_GuiMailDaiLy_KD))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3799d1d995ebc52ceb6ee3c4f6ea2302b142bce6", @"/Views/KinhDoanh/GuiMailDaiLy_KD.cshtml")]
    public class Views_KinhDoanh_GuiMailDaiLy_KD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.GuiMailDaiLyModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PhongVe/GuiMailDaiLyKinhDoanh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
  
    ViewBag.Title = "Gửi mail đại lý kinh doanh";
    Layout = "~/Views/Shared/MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(156, 80, true);
            WriteLiteral("\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title>");
            EndContext();
            BeginContext(237, 13, false);
#line 9 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
  Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(250, 6564, true);
            WriteLiteral(@"</title>
<h2>Gửi mail đại lý</h2>
<form asp-controller=""KinhDoanh"" asp-action=""GuiMailDaiLy_KD"" method=""post"" enctype=""multipart/form-data"">

    <div class=""row"">
        <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""x_panel"">

                <div class=""row"">
                    <div class=""col-md-6 col-sm-12 col-xs-12"">
                        <div class=""row"" style=""line-height:28px;"">
                            <br>
                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                                    <label class=""col-form-label col-md-12 col-sm-12 col-xs-12"">
                                        Mã KH
                                    </label>

                                </div>
                            </div>
                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                      ");
            WriteLiteral(@"              <div class="" col-sm-9 col-xs-7"">
                                        <input type=""text"" id=""MAKH"" asp-for=""MAKH"" name=""MAKH"" class=""form-control col-md-7 col-xs-12"">
                                    </div>
                                    <div class="" col-sm-3 col-xs-5"">
                                        <button type=""submit"" class=""btn btn-primary btn-block"" style=""width:100px;"" name=""searchBtn"" value=""searchBtn"">Tìm Kiếm</button>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                                    <label class=""col-form-label col-md-12 col-sm-12 col-xs-12"">
                                        Đại lý
                                    </label>

                                </div>
                            </div>
                           ");
            WriteLiteral(@" <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">

                                    <div class=""col-md-12 col-sm-12 col-xs-12"">

                                        <input type=""text"" id=""DAILY"" readonly asp-for=""DAILY"" name=""DAILY"" class=""form-control col-md-7 col-xs-12"">
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                                    <label class=""col-form-label col-md-12 col-sm-12 col-xs-12 label-align"">
                                        MAIL
                                    </label>

                                </div>
                            </div>

                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
      ");
            WriteLiteral(@"                              <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <input type=""text"" id=""MAIL"" asp-for=""MAIL"" name=""MAIL"" class=""form-control "">
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                                    <label class=""col-form-label c ol-md-12 col-sm-12 col-xs-12 label-align"">
                                        MAIL CC
                                    </label>

                                </div>
                            </div>

                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <input type=""text"" id=""MAILCC""");
            WriteLiteral(@" placeholder=""abc@gmail.com,xyz@gmail.com"" asp-for=""MAILCC"" name=""MAILCC"" class=""form-control "">
                                    </div>
                                </div>
                            </div>

                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">
                                    <label class=""col-form-label col-md-12 col-sm-12 col-xs-12"">
                                        FILE ĐÍNH KÈM
                                    </label>

                                </div>
                            </div>

                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""item form-group"">

                                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <input type=""file"" class=""form-control-file btn btn-primary"" id=""files"" name=""files"" />

                                    </d");
            WriteLiteral(@"iv>
                                </div>
                            </div>
                            <br />
                            <div>
                                <div class=""col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""item form-group"">
                                        <label class=""col-form-label col-md-12 col-sm-12 col-xs-12"">
                                            Các Loại Tài Khoản
                                        </label>
                                    </div>
                                </div>
                                <div class=""col-md-12 col-sm-12 col-xs-12 form-group"" style=""margin-top:10px;"" id=""idNoiDungCha"">                                   
                                    <div class=""item form-group"" id=""idNoiDungCon"">
                                        <div class=""row"">
                                            <div class=""col-md-11 col-sm-11 col-xs-11"" id=""cbChuDe0"">
               ");
            WriteLiteral(@"                                 <input type=""hidden"" class=""form-control noiDungKhoa"" id=""IDNoiDungKhoa0"" name=""IDNoiDungKhoa0"" placeholder="""" value="""">
                                                <select id=""ChuDe0"" name=""ChuDe0"" asp-for=""ChuDe"" class=""select2_single form-control"" onchange=""getNoiDung(this)"">
                                                    <option value=""0"">-- Chọn Tài Khoản --</option>
");
            EndContext();
#line 123 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                     foreach (var item in Model.ListNoiDung)
                                                    {

#line default
#line hidden
            BeginContext(6963, 63, true);
            WriteLiteral("                                                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7026, "\"", 7045, 1);
#line 125 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
WriteAttributeValue("", 7034, item.RowID, 7034, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7046, 16, true);
            WriteLiteral(" class=\"tieude\">");
            EndContext();
            BeginContext(7063, 11, false);
#line 125 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                                                              Write(item.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(7074, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 126 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(7140, 3642, true);
            WriteLiteral(@"                                                </select>
                                            </div>
                                            <div class=""col-md-1 col-sm-1 col-xs-1"">
                                                <input class=""cong btn btn-primary"" type=""button""  id=""cong"" name=""cong"" value=""+"" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""item form-group"" id=""idnoidungtieude"">
                                        <div class=""row"">
                                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                                <input type=""text"" class=""form-control Account"" id=""Account0"" asp-for=""Account0"" name=""Account0"" row=""6"" />
                                            </div>
                                            <div>
                                                <inp");
            WriteLiteral(@"ut type=""hidden"" class=""form-control noiDungKhoatxt"" id=""noiDungKhoatxt0"" asp-for=""noiDungKhoatxt"" name=""noiDungKhoatxt"" row=""6"" />
                                            </div>
                                            <div>
                                                <input type=""hidden"" class=""form-control tieude0"" id=""tieude0"" asp-for=""tieude0"" name=""tieude0"" row=""6"" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-12"" style=""text-align:right;"">
                                <input hidden id=""noiDungTong"" name=""noiDungTong"" />
                                <button type=""submit"" class=""btn btn-primary"" onclick=""LuuBaoCao(this);"" name=""saveBtn"" value=""saveBtn"">Gửi ");
            WriteLiteral(@"Mail</button>
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-6 col-sm-12 col-xs-12"">

                        <div class=""x_panel"">
                            <div class=""x_title"">
                                <h2>Đại lý</h2>
                                <ul class=""nav navbar-right panel_toolbox"">
                                    <li style=""float:right;"">
                                        <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                                    </li>
                                </ul>
                                <div class=""clearfix""></div>
                            </div>
                            <div class=""x_content"">
                                <div id=""cty"" class=""cty table-responsive"" style=""height:270px;"">
                                    <table id=""datatable1"" class=""table table-bordered table-hover"">
                     ");
            WriteLiteral(@"                   <thead>
                                            <tr>
                                                <th></th>
                                                <th>Mã KH</th>
                                                <th>Tên đại lý</th>
                                                <th>Mail</th>
                                                <th style=""display:none"">Email</th>
                                            </tr>
                                        </thead>
                                        <tbody>

");
            EndContext();
#line 185 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                             if (Model != null)
                                            {
                                                

#line default
#line hidden
#line 187 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                 if (Model.Guimailkinhdoanh != null)
                                                {
                                                    foreach (var item in Model.Guimailkinhdoanh)
                                                    {

#line default
#line hidden
            BeginContext(11184, 321, true);
            WriteLiteral(@"                                                        <tr onclick=""DL(this)"" style=""cursor:pointer"">
                                                            <td style=""text-align:center""><i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i></td>
                                                            <td>");
            EndContext();
            BeginContext(11506, 9, false);
#line 193 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                           Write(item.MAKH);

#line default
#line hidden
            EndContext();
            BeginContext(11515, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(11587, 10, false);
#line 194 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                           Write(item.DAILY);

#line default
#line hidden
            EndContext();
            BeginContext(11597, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(11669, 9, false);
#line 195 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                           Write(item.MAIL);

#line default
#line hidden
            EndContext();
            BeginContext(11678, 92, true);
            WriteLiteral("</td>\r\n                                                            <td style=\"display:none\">");
            EndContext();
            BeginContext(11771, 9, false);
#line 196 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                                                Write(item.MAIL);

#line default
#line hidden
            EndContext();
            BeginContext(11780, 70, true);
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 198 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                    }

                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(12063, 473, true);
            WriteLiteral(@"                                                    <tr>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                        <td style=""display:none""></td>
                                                    </tr>
");
            EndContext();
#line 210 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                }

#line default
#line hidden
#line 210 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                                 
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(12731, 445, true);
            WriteLiteral(@"                                                <tr>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td style=""display:none""></td>
                                                </tr>
");
            EndContext();
#line 221 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                                            }

#line default
#line hidden
            BeginContext(13223, 351, true);
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <br />

            </div>
        </div>

    </div>

</form>



");
            EndContext();
            BeginContext(13574, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f96343c9c8eb42438de4e00076312932", async() => {
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
            BeginContext(13635, 2815, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    var count = 1;
    $(document).ready(function () {

        $(document).on(""click"", "".cong"", function () {
            var cbChuDe = $(""#cbChuDe0"");
            $(""#idNoiDungCha"").append(""  <div class='col - md - 12 col - sm - 12 col - xs - 12 form - group' style='margin - top: 10px; ' id='idNoiDungCha"" + count + ""'> <div class='item form-group' id='idNoiDungCon"" + count + ""'><div class='row'><div class='col-md-11 col-sm-11 col-xs-11' id='cbChuDe"" + count + ""'></div><div class='col-md-1 col-sm-1 col-xs-1'><input class='tru btn btn-danger' name='tru' id='tru' onclick='XoaDong("" + count + "")'  type='button' value='-'/></div></div></div><div class='item form-group' id='idnoidungtieude"" + count + ""'><div class='row'><div><input type='hidden' class='form-control noiDungKhoatxt' id ='noiDungKhoatxt"" + count + ""' asp-for='noiDungKhoatxt' name='noiDungKhoatxt"" + count + ""' row = '6'/></div><div><input type='");
            WriteLiteral(@"hidden' class='form-control tieude' id ='tieude"" + count + ""' asp-for='tieude' name='tieude"" + count + ""' row = '6'/></div><div class='col-md-12 col-sm-12 col-xs-12'><input type = 'text' class='form-control Account' id = 'Account"" + count + ""' asp-for='Account' name = 'Account"" + count + ""' row = '6' /></div></div></div></div>"");
            var result = cbChuDe.html();
            var result1 = result.replace(/ChuDe0/g, ""ChuDe"" + count + """");
            var result2 = result1.replace(/IDNoiDungKhoa0/g, ""IDNoiDungKhoa"" + count + """");
            $(""#cbChuDe"" + count).append(result2);        
           
            count++;
        });
    });


    function LuuBaoCao() {

        console.log(""abc"");
        var noiDungKhoaTong = """";      
        var e = 1;
       // const tieude_i = document.getElementsByClassName(""tieude"");
        for (var i = 0; i < count; i++) {
            
            var tieude = ""tieude"" + i;
            var noiDungKhoatxt = ""noiDungKhoatxt"" + i;
            var");
            WriteLiteral(@" account = ""Account"" + i;

            var isDuLieu = document.getElementById(noiDungKhoatxt);
            if (isDuLieu) {
                var noidung_i = document.getElementById(noiDungKhoatxt).value;
                var account_i = document.getElementById(account).value;
                var tieude_i = document.getElementById(tieude).value;

                noiDungKhoaTong = noiDungKhoaTong + e + ""."" +""<strong>""+ tieude_i+""</strong>"" +"" ""+"":""+"" ""+ account_i+ ""\n\n"" + noidung_i + ""\n\n\n"";

              //  noiDungKhoaTong = noiDungKhoaTong + e + ""."" + account_i + ""\n"" + noidung_i  + ""\n\n"";
                e++;

    
            }     
        }
        document.getElementById(""noiDungTong"").value = noiDungKhoaTong;
    }

</script>

");
            EndContext();
#line 291 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
 if (ViewBag.msg != "" && ViewBag.msg != null)
{



#line default
#line hidden
            BeginContext(16505, 55, true);
            WriteLiteral("    <script charset=\"UTF-8\">\r\n\r\n                alert(\'");
            EndContext();
            BeginContext(16561, 21, false);
#line 297 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"
                  Write(Html.Raw(ViewBag.msg));

#line default
#line hidden
            EndContext();
            BeginContext(16582, 22, true);
            WriteLiteral("\');\r\n\r\n    </script>\r\n");
            EndContext();
#line 300 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\KinhDoanh\GuiMailDaiLy_KD.cshtml"

}

#line default
#line hidden
            BeginContext(16609, 1655, true);
            WriteLiteral(@"<script type=""text/javascript"">
    function getNoiDung(obj) {
        var i = obj.id.replace(/^\D+/g, '');
        var id = $('#ChuDe' + i + ' option:selected').val();
       

        $.ajax({
            type: ""GET"",
            url: ""/KinhDoanh/GetNoiDung"",
            data: { khoachinh : id},
            success: function (response) {
                
              
                document.getElementById(""IDNoiDungKhoa"" + i).value = id;
                document.getElementById(""noiDungKhoatxt"" + i).value = response.noiDungTimKiem;
                document.getElementById(""tieude"" + i).value = response.tieuDe;
              
              //  document.getElementById(""noiDung"" + i).value = response;
                return;
              
               
            },
            failure: function (response) {

                alert(response);
            },
            error: function (response) {

                alert(response);
            }
        });
        return this");
            WriteLiteral(@";
    }
    function DL(ctrl) {
        document.getElementById(""MAKH"").value = ctrl.getElementsByTagName('td')[1].textContent;
        document.getElementById(""DAILY"").value = ctrl.getElementsByTagName('td')[2].textContent;
        document.getElementById(""MAIL"").value = ctrl.getElementsByTagName('td')[3].textContent;
        document.getElementById(""SoDT"").value = ctrl.getElementsByTagName('td')[4].textContent;
    }
    function XoaDong(SoDong) {
        var e = 'idNoiDungCha' + SoDong;
        const element = document.getElementById(e);
        element.remove();
        countGetTieude
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.GuiMailDaiLyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591