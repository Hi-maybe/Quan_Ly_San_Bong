﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
      
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "TenSan", rowsPerPage: 5);
    

#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                using (Html.BeginForm("Index", "Sans", FormMethod.Get))

            {
                

#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
           __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                        
                

#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                      __o = ViewBag.maSan;


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                       __o = ViewBag.tenSan;


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                      
                

#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                               
            }

#line default
#line hidden

#line 10 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
       __o = grid.GetHtml(
                tableStyle: "table table-bordered table-hover",
                footerStyle: "grid-footer",
                fillEmptyRows: true,
                mode: WebGridPagerModes.Numeric,
                alternatingRowStyle: "alternatingRowStyle",
                  columns: new[]  // colums in grid
                 {
             grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
            grid.Column("MaSan","Mã sân"), //the model fields to display
            grid.Column("TenSan","Tên sân"),
    grid.Column("AnhSan","Ảnh sân",format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 11 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                          __o = item.AnhSan;


#line default
#line hidden

#line 12 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                             })),
grid.Column("DiaChi","Địa chỉ"),
grid.Column("SoLuongSan","Số lượng sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 13 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Edit",
                        new { id = item.MaSan});


#line default
#line hidden

#line 14 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Details",
                        new { id = item.MaSan});


#line default
#line hidden

#line 15 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Delete",
                        new { id = item.MaSan});


#line default
#line hidden

#line 16 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
     })),

}
);


#line default
#line hidden

#line 17 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\8\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                           __o = ViewBag.TB;


#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
      
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "TenSan", rowsPerPage: 5);
    

#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                using (Html.BeginForm("Index", "Sans", FormMethod.Get))

            {
                

#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
           __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                        
                

#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                      __o = ViewBag.maSan;


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                       __o = ViewBag.tenSan;


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                      
                

#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                               
            }

#line default
#line hidden

#line 10 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
       __o = grid.GetHtml(
                tableStyle: "table table-bordered table-hover",
                footerStyle: "grid-footer",
                fillEmptyRows: true,
                mode: WebGridPagerModes.Numeric,
                alternatingRowStyle: "alternatingRowStyle",
                  columns: new[]  // colums in grid
                 {
             grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
            grid.Column("MaSan","Mã sân"), //the model fields to display
            grid.Column("TenSan","Tên sân"),
    grid.Column("AnhSan","Ảnh sân",format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 11 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                          __o = item.AnhSan;


#line default
#line hidden

#line 12 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                             })),
grid.Column("DiaChi","Địa chỉ"),
grid.Column("SoLuongSan","Số lượng sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 13 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Edit",
                        new { id = item.MaSan});


#line default
#line hidden

#line 14 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Details",
                        new { id = item.MaSan});


#line default
#line hidden

#line 15 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Delete",
                        new { id = item.MaSan});


#line default
#line hidden

#line 16 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
     })),

}
);


#line default
#line hidden

#line 17 "C:\Users\anhla\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                           __o = ViewBag.TB;


#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
      
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "TenSan", rowsPerPage: 5);
    

#line default
#line hidden

#line 3 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                using (Html.BeginForm("Index", "Sans", FormMethod.Get))

            {
                

#line default
#line hidden

#line 4 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
           __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                        
                

#line default
#line hidden

#line 6 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                      __o = ViewBag.maSan;


#line default
#line hidden

#line 7 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                       __o = ViewBag.tenSan;


#line default
#line hidden

#line 8 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                      
                

#line default
#line hidden

#line 9 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                               
            }

#line default
#line hidden

#line 10 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
       __o = grid.GetHtml(
                tableStyle: "table table-bordered table-hover",
                footerStyle: "grid-footer",
                fillEmptyRows: true,
                mode: WebGridPagerModes.Numeric,
                alternatingRowStyle: "alternatingRowStyle",
                  columns: new[]  // colums in grid
                 {
             grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
            grid.Column("MaSan","Mã sân"), //the model fields to display
            grid.Column("TenSan","Tên sân"),
    grid.Column("AnhSan","Ảnh sân",format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 11 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                          __o = item.AnhSan;


#line default
#line hidden

#line 12 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                             })),
grid.Column("DiaChi","Địa chỉ"),
grid.Column("SoLuongSan","Số lượng sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 13 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Edit",
                        new { id = item.MaSan});


#line default
#line hidden

#line 14 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Details",
                        new { id = item.MaSan});


#line default
#line hidden

#line 15 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = Url.Action("Delete",
                        new { id = item.MaSan});


#line default
#line hidden

#line 16 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
     })),

}
);


#line default
#line hidden

#line 17 "C:\Users\pnt22\AppData\Local\Temp\E7EF3028A6C26D38B647971724414B0927E9\6\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                           __o = ViewBag.TB;


#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
      

#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                      __o = ;


#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                       __o = ;


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                            __o = ;


#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                 __o = ;


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = ;


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = ;


#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                    __o = ;


#line default
#line hidden

#line 10 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
                                                                                           __o = ;


#line default
#line hidden
}
}
}
e 2 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
  

#line default
#line hidden

#line 3 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtm       __o = grid.GetHtml(
                tableStyle: "table table-bordered table-hover",
                footerStyle: "grid-footer",
                fillEmptyRows: true,
                mode: WebGridPagerModes.Numeric,
                alternatingRowStyle: "alternatingRowStyle",
                  columns: new[]  // colums in grid
                 {
             grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),

    grid.Column("AnhSan","Ảnh sân",format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 4 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\Quan                                                                                                                      __o = item.AnhSan;


#line default
#line hidden

#line 5 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\Quan                                                                                                                                         })),
grid.Column("DiaChi","Địa chỉ"),
grid.Column("SoLuongSan","Số lượng sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\Quan                n\Views\Sans\Index.cshtml"
                    __o = Url.Action("Edit",
                        new { id = item.MaSan});


#line default
#line hidden

#line 7 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\Quan                n\Views\Sans\Index.cshtml"
                    __o = Url.Action("Details",
                        new { id = item.MaSan});


#line default
#line hidden

#line 8 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\Quan                n\Views\Sans\Index.cshtml"
                    __o = Url.Action("Delete",
                        new { id = item.MaSan});


#line default
#line hidden

#line 9 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
     })),

}
);


#line default
#line hidden
}
}
}
model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";


#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF9

#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtm       __o = grid.GetHtml(
                tableStyle: "table table-bordered table-hover",
                footerStyle: "grid-footer",
                fillEmptyRows: true,
                mode: WebGridPagerModes.Numeric,
                alternatingRowStyle: "alternatingRowStyle",
                  columns: new[]  // colums in grid
                 {
             grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cs
    grid.Column("AnhSan","Ảnh sân",format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\Quan                                                                                                                      __o = item.AnhSan;


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\Quan                                                                                                                                         })),
grid.Column("DiaChi","Địa chỉ"),
grid.Column("SoLuongSan","Số lượng sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) =>nLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
       __o =  },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\Quan                n\Views\Sans\Index.cshtml"
                    __o = Url.Action("Edit",
                        new { id = item.MaSan});


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\Quan                n\Views\Sans\Index.cshtml"
                    __o = Url.Action("Details",
                        new { id = item.MaSan});


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\Quan                n\Views\Sans\Index.cshtml"
                    __o = Url.Action("Delete",
                        new { id = item.MaSan});


#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Areas\Admin\Views\Sans\Index.cshtml"
     })),

}
);


#line default
#line hidden
}
}
}
anBanh\Areas\Admin\Views\Sans\Index.cshtml"
         
}

#line default
#line hidden
}
}
}
