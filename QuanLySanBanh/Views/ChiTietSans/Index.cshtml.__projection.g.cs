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

#line 1 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/_Layout2.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "MaCTS", rowsPerPage: 8);
    

#line default
#line hidden

#line 3 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Scripts.Render("~/Scripts/jquery-1.6.2.min.js");


#line default
#line hidden

#line 4 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
                                                    


#line default
#line hidden

#line 5 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
   __o = grid.GetHtml(
            tableStyle: "table table-bordered table-hover",
            footerStyle: "grid-footer",
            fillEmptyRows: true,
            mode: WebGridPagerModes.Numeric,
            alternatingRowStyle: "alternatingRowStyle",
              columns: new[]  // colums in grid
             {
         grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
        grid.Column("MaCTS","Mã chi tiết sân"),
        grid.Column("San.TenSan","Tên sân"),//the model fields to display
        grid.Column("SoSan","Vị trí sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Edit",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 7 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Details",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 8 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Delete",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 9 "C:\Users\pnt22\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\3\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
     })),

}
);


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

#line 1 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/_Layout2.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "MaCTS", rowsPerPage: 8);
    

#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Scripts.Render("~/Scripts/jquery-1.6.2.min.js");


#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
                                                    


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
   __o = grid.GetHtml(
            tableStyle: "table table-bordered table-hover",
            footerStyle: "grid-footer",
            fillEmptyRows: true,
            mode: WebGridPagerModes.Numeric,
            alternatingRowStyle: "alternatingRowStyle",
              columns: new[]  // colums in grid
             {
         grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
        grid.Column("MaCTS","Mã chi tiết sân"),
        grid.Column("San.TenSan","Tên sân"),//the model fields to display
        grid.Column("SoSan","Vị trí sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Edit",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Details",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Delete",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\0CF70F9A48B3FFD5BB2DF96D9BDD054EE47E\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
     })),

}
);


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

#line 1 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/_Layout2.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "MaCTS", rowsPerPage: 8);
    

#line default
#line hidden

#line 3 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Scripts.Render("~/Scripts/jquery-1.6.2.min.js");


#line default
#line hidden

#line 4 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
                                                    


#line default
#line hidden

#line 5 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
   __o = grid.GetHtml(
            tableStyle: "table table-bordered table-hover",
            footerStyle: "grid-footer",
            fillEmptyRows: true,
            mode: WebGridPagerModes.Numeric,
            alternatingRowStyle: "alternatingRowStyle",
              columns: new[]  // colums in grid
             {
         grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
        grid.Column("MaCTS","Mã chi tiết sân"),
        grid.Column("San.TenSan","Tên sân"),//the model fields to display
        grid.Column("SoSan","Vị trí sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Edit",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 7 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Details",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 8 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Delete",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 9 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\9\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
     })),

}
);


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

#line 1 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/_Layout2.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "MaCTS", rowsPerPage: 8);
    

#line default
#line hidden

#line 3 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Scripts.Render("~/Scripts/jquery-1.6.2.min.js");


#line default
#line hidden

#line 4 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
                                                    


#line default
#line hidden

#line 5 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
   __o = grid.GetHtml(
            tableStyle: "table table-bordered table-hover",
            footerStyle: "grid-footer",
            fillEmptyRows: true,
            mode: WebGridPagerModes.Numeric,
            alternatingRowStyle: "alternatingRowStyle",
              columns: new[]  // colums in grid
             {
         grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
        grid.Column("MaCTS","Mã chi tiết sân"),
        grid.Column("San.TenSan","Tên sân"),//the model fields to display
        grid.Column("SoSan","Vị trí sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Edit",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 7 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Details",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 8 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Delete",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 9 "C:\Users\pnt22\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\7\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
     })),

}
);


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

#line 1 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "DanhSachSan";
    Layout = "~/Views/Shared/_Layout2.cshtml";
    var grid = new WebGrid(Model, canPage: true, defaultSort: "MaCTS", rowsPerPage: 8);
    

#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Scripts.Render("~/Scripts/jquery-1.6.2.min.js");


#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
                                                    


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
   __o = grid.GetHtml(
            tableStyle: "table table-bordered table-hover",
            footerStyle: "grid-footer",
            fillEmptyRows: true,
            mode: WebGridPagerModes.Numeric,
            alternatingRowStyle: "alternatingRowStyle",
              columns: new[]  // colums in grid
             {
         grid.Column("STT",format: item => item.WebGrid.Rows.IndexOf(item) + 1 + Math.Round(Convert.ToDouble(grid.TotalRowCount / grid.PageCount) / grid.RowsPerPage) * grid.RowsPerPage * grid.PageIndex),
        grid.Column("MaCTS","Mã chi tiết sân"),
        grid.Column("San.TenSan","Tên sân"),//the model fields to display
        grid.Column("SoSan","Vị trí sân"),
/*grid.Column(format: (item) => Html.ActionLink("Cập nhật", "Edit", "Sans",new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xem chi tiết", "Details","Sans", new { id = item.MaSan },"SansController")),
grid.Column(format: (item) => Html.ActionLink("Xóa", "Delete","Sans", new { id = item.MaSan },"SansController")),*/
grid.Column("Chức năng", format: item => new System.Web.WebPages.HelperResult(__razor_template_writer => {


#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Edit",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Details",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
        __o = Url.Action("Delete",
                        new { id = item.MaCTS});


#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\E970E778DB381D80D9072D7381E603457014\2\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
     })),

}
);


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

#line 1 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";


#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Html.ActionLink("Create New", "Create");


#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.SoSan);


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.San.TenSan);


#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
foreach (var item in Model) {
    

#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.SoSan);


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.San.TenSan);


#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.ActionLink("Edit", "Edit", new { id=item.MaCTS });


#line default
#line hidden

#line 10 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.ActionLink("Details", "Details", new { id=item.MaCTS });


#line default
#line hidden

#line 11 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.ActionLink("Delete", "Delete", new { id=item.MaCTS });


#line default
#line hidden

#line 12 "C:\Users\anhla\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\18\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
         
}

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

#line 1 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";


#line default
#line hidden

#line 3 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
__o = Html.ActionLink("Create New", "Create");


#line default
#line hidden

#line 4 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.SoSan);


#line default
#line hidden

#line 5 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.San.TenSan);


#line default
#line hidden

#line 6 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
foreach (var item in Model) {
    

#line default
#line hidden

#line 7 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.SoSan);


#line default
#line hidden

#line 8 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.San.TenSan);


#line default
#line hidden

#line 9 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.ActionLink("Edit", "Edit", new { id=item.MaCTS });


#line default
#line hidden

#line 10 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.ActionLink("Details", "Details", new { id=item.MaCTS });


#line default
#line hidden

#line 11 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
       __o = Html.ActionLink("Delete", "Delete", new { id=item.MaCTS });


#line default
#line hidden

#line 12 "C:\Users\pnt22\AppData\Local\Temp\D2D4B59C055EA7F5079DE853175E0790F999\16\QuanLySanBanh\QuanLySanBanh\Views\ChiTietSans\Index.cshtml"
         
}

#line default
#line hidden
}
}
}
