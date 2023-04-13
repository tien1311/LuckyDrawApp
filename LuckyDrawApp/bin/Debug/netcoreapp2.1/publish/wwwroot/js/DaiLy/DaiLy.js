


function selectedRow(){
                
                var index;
                var hdDieuChinh;
                    table = document.getElementById("datatable1");
            
                for(var i = 1; i < table.rows.length; i++)
                {
                    table.rows[i].onclick = function()
                    {
                         // remove the background from the previous selected row
                        if(typeof index !== "undefined"){
                           table.rows[index].classList.toggle("selected");
                        }
                        console.log(typeof index);
                        // get the selected row index
                        index = this.rowIndex;
                        // add class selected to the row
                        this.classList.toggle("selected");
                        console.log(typeof index);
                        var maKH = table.rows[index].cells.item(0).innerHTML;
                     
                   
                    

                                    $.ajax({
                                type: "POST",
                                url: "/DaiLy/ChiTietDaiLy",
         
                                data: { maKH: maKH },
                                dataType: "json",
                                beforeSend: function () {
                                    //show loading
                                },
                                complete: function () {
                                    //hide loading
                                },
                                        success: function (resultData) {

                                            console.log(resultData);
                                          
                                            document.getElementById('member_company').innerHTML = resultData.thongTinDaiLy.member_company;
                                            
                                            document.getElementById('member_kh').innerHTML = resultData.thongTinDaiLy.member_kh;
                                            document.getElementById('member_address').innerHTML = resultData.thongTinDaiLy.member_address;
                                            document.getElementById('member_email').innerHTML = resultData.thongTinDaiLy.member_email;
                                            document.getElementById('member_tel').innerHTML = resultData.thongTinDaiLy.member_tel;
                                            document.getElementById('NVKinhDoanh').innerHTML = resultData.thongTinDaiLy.nhanVienKD;
                                            document.getElementById('KeToan').innerHTML = resultData.thongTinDaiLy.keToanEV;
                                            document.getElementById('SoDu').innerHTML = resultData.thongTinDaiLy.soDu;
                                            document.getElementById('Hang').innerHTML = resultData.thongTinDaiLy.hang;
                                            document.getElementById('AmQuyChoPhep').innerHTML = resultData.thongTinDaiLy.amQuyChoPhep;
                                            document.getElementById('TienBaoLanh').innerHTML = resultData.thongTinDaiLy.tienBaoLanh;
                                            document.getElementById('tinhtrang').innerHTML = resultData.thongTinDaiLy.tinhtrang;
                                            document.getElementById('lydo').innerHTML = resultData.thongTinDaiLy.lydo;

                                        //Clear datatable2
                                        var table2 = document.getElementById("datatable2");
                                         var tableHeaderRowCount = 1;
                                         var rowCount = table2.rows.length;
                                        for (var i = tableHeaderRowCount; i < rowCount; i++) {
                                            table2.deleteRow(tableHeaderRowCount);
                                        }
                                        //Add data datatable2

                                            for (var i = 0; i < resultData.dsLienHe.length; i++)
                                        {

                
                                           
                                          
                                          
                                            var item = resultData.dsLienHe[i];
                                            var row = table2.insertRow(i+1);
                                            var cell0 = row.insertCell(0);

                                            var cell1 = row.insertCell(1);
                                            var cell2 = row.insertCell(2);
                                            var cell3 = row.insertCell(3);
                                           


                                            cell0.innerHTML = item.nick;
                                            cell0.style.textAlign = "center";
                                                cell1.innerHTML = item.hoTen;
                                            cell1.style.textAlign = "center";
                                                cell2.innerHTML = item.ngayCapNhat;
                                            cell2.style.textAlign = "center";
                                                cell3.innerHTML = item.tinhTrang;
                                            cell3.style.textAlign = "center";
                                           
                                            
                                        }
                
                     
        
                 
                                },
                                error: function (xhr, status, p3, p4) {
                                    var err = "Error " + " " + status + " " + p3 + " " + p4;
                                    if (xhr.responseText)
                                        err = xhr.responseText;
                                    alert(err);
                                }
                            })
                     };
                }
            
                
            }


 function formatNumber(number) {
        number = number.toFixed(0) + '';
        x = number.split('.');
        x1 = x[0];
        x2 = x.length > 1 ? '.' + x[1] : '';
        var rgx = /(\d+)(\d{3})/;
        while (rgx.test(x1)) {
            x1 = x1.replace(rgx, '$1' + ',' + '$2');
        }
        return x1 + x2;
    }


            selectedRow();