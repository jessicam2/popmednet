﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.General.QueryComposer.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    
    #line 1 "..\..\Views\Config.cshtml"
    using Lpp.Dns;
    
    #line default
    #line hidden
    using Lpp.Dns.Model;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Config.cshtml")]
    public partial class Config : System.Web.Mvc.WebViewPage<ConfigModel>
    {
        public Config()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Config.cshtml"
  
    Layout = null;
    var id = Html.UniqueId();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"Value ModelConfigForm\"");

WriteAttribute("id", Tuple.Create(" id=\"", 130), Tuple.Create("\"", 138)
            
            #line 8 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 135), Tuple.Create<System.Object, System.Int32>(id
            
            #line default
            #line hidden
, 135), false)
);

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"Link\"");

WriteLiteral(">[configure]</a>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var dlg = $(\"#");

            
            #line 12 "..\..\Views\Config.cshtml"
                      Write(id);

            
            #line default
            #line hidden
WriteLiteral(" > .ModelConfig\");\r\n            var link = $(\"#");

            
            #line 13 "..\..\Views\Config.cshtml"
                       Write(id);

            
            #line default
            #line hidden
WriteLiteral(" > a.Link\");\r\n            link.click(function () {\r\n                dlg.dialog({\r" +
"\n                    modal: true, title: \"");

            
            #line 16 "..\..\Views\Config.cshtml"
                                    Write(Model.Model.Name);

            
            #line default
            #line hidden
WriteLiteral(@""",
                    width: 540, buttons: {
                        OK: function () {
                            dlg.dialog(""close"");
                        },
                        Cancel: function () { dlg.dialog(""close""); }
                    }
                });
                return false;
            });
            var initialDataProvider = $(""#");

            
            #line 26 "..\..\Views\Config.cshtml"
                                      Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_DataProvider\").val();\r\n            showParameters_");

            
            #line 27 "..\..\Views\Config.cshtml"
                       Write(Model.Model.ID.ToString("N"));

            
            #line default
            #line hidden
WriteLiteral("(initialDataProvider);\r\n        });\r\n\r\n        function showParameters_");

            
            #line 30 "..\..\Views\Config.cshtml"
                            Write(Model.Model.ID.ToString("N"));

            
            #line default
            #line hidden
WriteLiteral("(value) {\r\n            $(\"#");

            
            #line 31 "..\..\Views\Config.cshtml"
            Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_DataProvider\").val(value);\r\n            switch (value) {\r\n                case \"" +
"ODBC\":\r\n                    $(\"#");

            
            #line 34 "..\..\Views\Config.cshtml"
                    Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_divODBC\").show();\r\n                    $(\"#");

            
            #line 35 "..\..\Views\Config.cshtml"
                    Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_divSQLServer\").hide();\r\n                    break;\r\n\r\n                case \"SQLS" +
"erver\":\r\n                    $(\"#");

            
            #line 39 "..\..\Views\Config.cshtml"
                    Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_divODBC\").hide();\r\n                    $(\"#");

            
            #line 40 "..\..\Views\Config.cshtml"
                    Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_divSQLServer\").show();\r\n                    break;\r\n\r\n                case \"Post" +
"greSQL\":\r\n                    $(\"#");

            
            #line 44 "..\..\Views\Config.cshtml"
                    Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_divODBC\").hide();\r\n                    $(\"#");

            
            #line 45 "..\..\Views\Config.cshtml"
                    Write(Model.Model.ID);

            
            #line default
            #line hidden
WriteLiteral("_divSQLServer\").show();\r\n                    break;\r\n            }\r\n        }\r\n  " +
"  </script>\r\n\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 1771), Tuple.Create("\"", 1791)
            
            #line 51 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 1776), Tuple.Create<System.Object, System.Int32>(Model.Model.ID
            
            #line default
            #line hidden
, 1776), false)
);

WriteLiteral(" class=\"ModelConfig\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui-groupbox\"");

WriteLiteral(" style=\"height: 305px;\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui-dialog-groupbox-header\"");

WriteLiteral("><span>Data Source</span></div>\r\n            <div");

WriteLiteral(" class=\"ui-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Data Provider</label>\r\n                    <select");

WriteAttribute("id", Tuple.Create(" id=\"", 2128), Tuple.Create("\"", 2169)
            
            #line 57 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 2133), Tuple.Create<System.Object, System.Int32>(Model.Model.ID
            
            #line default
            #line hidden
, 2133), false)
, Tuple.Create(Tuple.Create("", 2150), Tuple.Create("_DataProviderSelect", 2150), true)
);

WriteLiteral(" name=\"DataProviderSelect\"");

WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2196), Tuple.Create("\"", 2269)
, Tuple.Create(Tuple.Create("", 2207), Tuple.Create("showParameters_", 2207), true)
            
            #line 57 "..\..\Views\Config.cshtml"
                                          , Tuple.Create(Tuple.Create("", 2222), Tuple.Create<System.Object, System.Int32>(Model.Model.ID.ToString("N")
            
            #line default
            #line hidden
, 2222), false)
, Tuple.Create(Tuple.Create("", 2253), Tuple.Create("($(this).val());", 2253), true)
);

WriteLiteral(">\r\n                        <option");

WriteLiteral(" value=\"SQLServer\"");

WriteLiteral(" ");

            
            #line 58 "..\..\Views\Config.cshtml"
                                              Write(Model.Properties.ContainsKey("DataProvider") && Model.Properties["DataProvider"] == "SQLServer" ? "selected=\"selected\"" : "");

            
            #line default
            #line hidden
WriteLiteral(">SQL Server</option>\r\n                        <option");

WriteLiteral(" value=\"PostgreSQL\"");

WriteLiteral(" ");

            
            #line 59 "..\..\Views\Config.cshtml"
                                               Write(Model.Properties.ContainsKey("DataProvider") && Model.Properties["DataProvider"] == "PostgreSQL" ? "selected=\"selected\"" : "");

            
            #line default
            #line hidden
WriteLiteral(">PostgreSQL</option>\r\n                        <option");

WriteLiteral(" value=\"ODBC\"");

WriteLiteral(" ");

            
            #line 60 "..\..\Views\Config.cshtml"
                                         Write(Model.Properties.ContainsKey("DataProvider") && Model.Properties["DataProvider"] == "ODBC" ? "selected=\"selected\"" : "");

            
            #line default
            #line hidden
WriteLiteral(">ODBC</option>\r\n                    </select>\r\n                    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 2919), Tuple.Create("\"", 2954)
            
            #line 62 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 2924), Tuple.Create<System.Object, System.Int32>(Model.Model.ID
            
            #line default
            #line hidden
, 2924), false)
, Tuple.Create(Tuple.Create("", 2941), Tuple.Create("_DataProvider", 2941), true)
);

WriteLiteral(" name=\"DataProvider\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2989), Tuple.Create("\"", 3093)
            
            #line 62 "..\..\Views\Config.cshtml"
                         , Tuple.Create(Tuple.Create("", 2997), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("DataProvider") ? Model.Properties["DataProvider"] : "SQLServer"
            
            #line default
            #line hidden
, 2997), false)
);

WriteLiteral(" />\r\n                </div>\r\n                <br />\r\n            </div>\r\n        " +
"    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 3183), Tuple.Create("\"", 3213)
            
            #line 66 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 3188), Tuple.Create<System.Object, System.Int32>(Model.Model.ID
            
            #line default
            #line hidden
, 3188), false)
, Tuple.Create(Tuple.Create("", 3205), Tuple.Create("_divODBC", 3205), true)
);

WriteLiteral(" class=\"ui-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>DataMart ODBC Data Source Name</label>\r\n           " +
"         <input");

WriteLiteral(" id=\"DataSourceName\"");

WriteLiteral(" name=\"DataSourceName\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3417), Tuple.Create("\"", 3516)
            
            #line 69 "..\..\Views\Config.cshtml"
         , Tuple.Create(Tuple.Create("", 3425), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("DataSourceName") ? Model.Properties["DataSourceName"] : ""
            
            #line default
            #line hidden
, 3425), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div");

WriteAttribute("id", Tuple.Create(" id=\"", 3582), Tuple.Create("\"", 3617)
            
            #line 72 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 3587), Tuple.Create<System.Object, System.Int32>(Model.Model.ID
            
            #line default
            #line hidden
, 3587), false)
, Tuple.Create(Tuple.Create("", 3604), Tuple.Create("_divSQLServer", 3604), true)
);

WriteLiteral(" class=\"ui-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Server</label>\r\n                    <input");

WriteLiteral(" id=\"Server\"");

WriteLiteral(" name=\"Server\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3781), Tuple.Create("\"", 3864)
            
            #line 75 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 3789), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("Server") ? Model.Properties["Server"] : ""
            
            #line default
            #line hidden
, 3789), false)
);

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Port</label>\r\n                    <input");

WriteLiteral(" id=\"Port\"");

WriteLiteral(" name=\"Port\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4032), Tuple.Create("\"", 4111)
            
            #line 79 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 4040), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("Port") ? Model.Properties["Port"] : ""
            
            #line default
            #line hidden
, 4040), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>User ID</label>\r\n                    <input");

WriteLiteral(" id=\"UserId\"");

WriteLiteral(" name=\"UserId\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4288), Tuple.Create("\"", 4371)
            
            #line 84 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 4296), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("UserId") ? Model.Properties["UserId"] : ""
            
            #line default
            #line hidden
, 4296), false)
);

WriteLiteral(" />\r\n                </div>\r\n                <br />\r\n\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Password</label>\r\n                    <input");

WriteLiteral(" id=\"Password\"");

WriteLiteral(" name=\"Password\"");

WriteLiteral(" type=\"password\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4581), Tuple.Create("\"", 4668)
            
            #line 90 "..\..\Views\Config.cshtml"
 , Tuple.Create(Tuple.Create("", 4589), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("Password") ? Model.Properties["Password"] : ""
            
            #line default
            #line hidden
, 4589), false)
);

WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Confirm Password</label>\r\n                    <inpu" +
"t");

WriteLiteral(" id=\"ConfirmPassword\"");

WriteLiteral(" name=\"ConfirmPassword\"");

WriteLiteral(" type=\"password\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4874), Tuple.Create("\"", 4975)
            
            #line 94 "..\..\Views\Config.cshtml"
               , Tuple.Create(Tuple.Create("", 4882), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("ConfirmPassword") ? Model.Properties["ConfirmPassword"] : ""
            
            #line default
            #line hidden
, 4882), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Database</label>\r\n                    <input");

WriteLiteral(" id=\"Database\"");

WriteLiteral(" name=\"Database\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5157), Tuple.Create("\"", 5244)
            
            #line 99 "..\..\Views\Config.cshtml"
, Tuple.Create(Tuple.Create("", 5165), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("Database") ? Model.Properties["Database"] : ""
            
            #line default
            #line hidden
, 5165), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"ui-form\"");

WriteLiteral(">\r\n                <br />\r\n\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Connection Timeout</label>\r\n                    <in" +
"put");

WriteLiteral(" id=\"ConnectionTimeout\"");

WriteLiteral(" name=\"ConnectionTimeout\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5533), Tuple.Create("\"", 5640)
            
            #line 107 "..\..\Views\Config.cshtml"
               , Tuple.Create(Tuple.Create("", 5541), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("ConnectionTimeout") ? Model.Properties["ConnectionTimeout"] : "15"
            
            #line default
            #line hidden
, 5541), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"Field\"");

WriteLiteral(">\r\n                    <label>Command Timeout</label>\r\n                    <input" +
"");

WriteLiteral(" id=\"CommandTimeout\"");

WriteLiteral(" name=\"CommandTimeout\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5841), Tuple.Create("\"", 5943)
            
            #line 112 "..\..\Views\Config.cshtml"
         , Tuple.Create(Tuple.Create("", 5849), Tuple.Create<System.Object, System.Int32>(Model.Properties.ContainsKey("CommandTimeout") ? Model.Properties["CommandTimeout"] : "120"
            
            #line default
            #line hidden
, 5849), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</di" +
"v>\r\n");

        }
    }
}
#pragma warning restore 1591