#pragma checksum "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66454d289d268f403d326850a235181b6aa658a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_DetailBookerClub), @"mvc.1.0.view", @"/Views/Data/DetailBookerClub.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/DetailBookerClub.cshtml", typeof(AspNetCore.Views_Data_DetailBookerClub))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66454d289d268f403d326850a235181b6aa658a7", @"/Views/Data/DetailBookerClub.cshtml")]
    public class Views_Data_DetailBookerClub : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager_EV.Models.ThongTinBookerClubModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 334, true);
            WriteLiteral(@"


<div class=""modal-dialog modal-lg"">

    <!-- Modal content-->
    <div class=""modal-content"" style="" background: #2A3F54;"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" style="" color: #fff;"" data-dismiss=""modal"">&times;</button>
            <h1 style=""color: #FFF; font-size: 16px;"">");
            EndContext();
            BeginContext(385, 29, false);
#line 11 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                 Write(Model.ListBookerClub[0].Title);

#line default
#line hidden
            EndContext();
            BeginContext(414, 480, true);
            WriteLiteral(@"</h1>
        </div>
        <div class=""modal-body"" style=""border-radius:8px; background-color:#fff;"">
            <div class=""row"">
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label>Mã KH</label>
                        <input type=""text"" class=""form-control"" id=""MaKH"" name=""MaKH"" placeholder="""" value="""">
                        <input type=""hidden"" class=""form-control"" id=""ID"" name=""ID"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 894, "\"", 929, 1);
#line 19 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
WriteAttributeValue("", 902, Model.ListBookerClub[0].ID, 902, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(930, 3474, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label>Ticket Number</label>
                        <input type=""text"" class=""form-control"" id=""TicketNumber"" name=""TicketNumber"" placeholder="""" value="""">
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label>ID_Booker</label>
                        <input type=""text"" class=""form-control"" id=""ID_Booker"" name=""ID_Booker"" placeholder="""" value="""">
                    </div>
                </div>

                <div class=""col-sm-2"">
                    <div class=""form-group"">
                        <label>&nbsp;</label>
                        <div>
                            <button type=""button"" class=""btn btn-success btn-block"" onclick=""InsertDetail()"" name=""Save"" value=""Save"">Thêm</button>
                        ");
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""x_panel"">
                        <div class=""x_title"">
                            <h2>
                                Danh sách chi tiết
                            </h2>
                            <div class=""clearfix""></div>
                        </div>
                        <div class=""x_content"" style=""display: block;"">
                            <div class=""row"">
                                <div class=""col-sm-2"">
                                    <div class=""form-group"">
                                        <label>Mã KH</label>
                                        <input type=""text"" class=""form-control"" id=""MaKH_Search"" name=""MaKH_Search"" placeholder="""" value="""">
                                    </div>
                                </div>
                                <div class=""c");
            WriteLiteral(@"ol-sm-2"">
                                    <div class=""form-group"">
                                        <label>&nbsp;</label>
                                        <div>
                                            <button type=""button"" class=""btn btn-primary btn-block"" onclick=""SearchMaKH()"" name=""Search"" value=""Search"">Tìm kiếm</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""table-responsive"">
                                    <table id=""gridXoSoDetail"" class=""table table-striped jambo_table bulk_action"">
                                        <thead>
                                            <tr>
                                                <th class=""column-title"">STT </th>
                                                <th class=""column-title"">Mã KH </th>
     ");
            WriteLiteral(@"                                           <th class=""column-title"">Số vé </th>
                                                <th class=""column-title"">ID_Booker </th>
                                                <th class=""column-title""> </th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
            EndContext();
#line 83 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                               
                                                if(Model != null)
                                                {
                                                    if(Model.ListBookerClubDetail.Count > 0)
                                                    {
                                                        int stt = 1;
                                                        for (int i = 0; i < Model.ListBookerClubDetail.Count; i++)
                                                        {

#line default
#line hidden
            BeginContext(4965, 67, true);
            WriteLiteral("                                                                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5032, "\"", 5070, 1);
#line 91 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
WriteAttributeValue("", 5037, Model.ListBookerClubDetail[i].ID, 5037, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5071, 75, true);
            WriteLiteral(">\r\n                                                                    <td>");
            EndContext();
            BeginContext(5147, 3, false);
#line 92 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                                   Write(stt);

#line default
#line hidden
            EndContext();
            BeginContext(5150, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(5230, 34, false);
#line 93 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                                   Write(Model.ListBookerClubDetail[i].MaKH);

#line default
#line hidden
            EndContext();
            BeginContext(5264, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(5344, 42, false);
#line 94 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                                   Write(Model.ListBookerClubDetail[i].TicketNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5386, 79, true);
            WriteLiteral("</td>\r\n                                                                    <td>");
            EndContext();
            BeginContext(5466, 39, false);
#line 95 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                                   Write(Model.ListBookerClubDetail[i].ID_Booker);

#line default
#line hidden
            EndContext();
            BeginContext(5505, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 96 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                                      
                                                                        stt = stt + 1;
                                                                    

#line default
#line hidden
            BeginContext(5743, 109, true);
            WriteLiteral("                                                                    <td> <a class=\"Status\" style=\"color:red;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5852, "\"", 5914, 3);
            WriteAttributeValue("", 5862, "DeleteDetail(this,", 5862, 18, true);
#line 99 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
WriteAttributeValue("", 5880, Model.ListBookerClubDetail[i].ID, 5880, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 5913, ")", 5913, 1, true);
            EndWriteAttribute();
            BeginContext(5915, 173, true);
            WriteLiteral(" href=\"javascript:;\"><i class=\"fa fa-trash\" style=\"font-size:14px;\" aria-hidden=\"true\"></i></a></td>\r\n                                                                </tr>\r\n");
            EndContext();
#line 101 "D:\EnViet\SourceAzure\sys.airline24h.com\DaiLy_EV\Views\Data\DetailBookerClub.cshtml"
                                                        }
                                                    }
                                                }
                                            

#line default
#line hidden
            BeginContext(6300, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(6596, 4623, true);
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function InsertDetail() {
        var maKH = document.getElementById(""MaKH"").value;
        var id_booker = document.getElementById(""ID_Booker"").value;
        var ticketNumber = document.getElementById(""TicketNumber"").value;
        var id = document.getElementById(""ID"").value;
        $.ajax({
            type: ""POST"",
            url: ""/Data/InsertBookerClubDetail"",
            data: {
                MaKH: maKH,
                ID_Booker: id_booker,
                ID: id,
                TicketNumber: ticketNumber
            },
            success: function (response) {
                if (response == true) {
                    alert(""Lưu thành công !"");
       ");
            WriteLiteral(@"             document.getElementById(""MaKH"").value = """";
                    document.getElementById(""TicketNumber"").value = """";
                    document.getElementById(""ID_Booker"").value = """";
                }
                else {
                    alert(""Lưu thất bại !"")
                }
            },
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response);
            }
        });
    };
    function DeleteDetail(obj,ID) {
        var index = obj.parentNode.parentNode.rowIndex;
        let text;
        text = ""Bạn có chắc muốn xóa dòng này ?"";
        if (confirm(text) == true) {
            $.ajax({
                type: ""POST"",
                url: ""/Data/DeleteBookerClubDetail"",
                data: {
                    id: ID
                },
                success: function (response) {
                    if (response == true) {
                   ");
            WriteLiteral(@"     alert(""Xóa thành công !"");
                        document.getElementById(""gridXoSoDetail"").deleteRow(index);
                    }
                    else {
                        alert(""Xóa thất bại !"")
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

    };
    function SearchMaKH() {
        var maKH = document.getElementById(""MaKH_Search"").value;
        var id = document.getElementById(""ID"").value;
        var tbody = document.querySelector(""#gridXoSoDetail tbody"");
        $.ajax({
            type: ""POST"",
            url: ""/Data/SearchMaKHBookerClubDetail"",
            data: {
                MAKH: maKH,
                ID : id
            },
            success: function (response) {
                var table = document.getElementById(""gridXoSoD");
            WriteLiteral(@"etail"");
                var rowCount = table.rows.length;

                for (var i = rowCount - 1; i > 0; i--) {
                    table.deleteRow(i);
                }
                console.log(response);
                for (var i = 0; i < response.length; i++) {
                    var length = table.rows.length;
                    // Insert a new row at the end of the table
                    var newRow = tbody.insertRow();

                    // Add cells to the row
                    var cell1 = newRow.insertCell();
                    var cell2 = newRow.insertCell();
                    var cell3 = newRow.insertCell();
                    var cell4 = newRow.insertCell();
                    var cell5 = newRow.insertCell();

                    // Set the content of each cell
                    cell1.textContent = Number(length);
                    cell2.textContent = response[i].maKH;
                    cell3.textContent = response[i].ticketNumber;
                ");
            WriteLiteral(@"    cell4.textContent = response[i].iD_Booker;
                    cell5.innerHTML = ""<a class='Status' style='color:red;'  onclick='DeleteDetail(this,""+response[i].id+"")' href='javascript:;'><i class='fa fa-trash' style='font-size:14px;' aria-hidden='true'></i></a>"";
                }

            },
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response);
            }
        });


    };
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager_EV.Models.ThongTinBookerClubModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
