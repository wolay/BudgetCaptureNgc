﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncomeProRpt.aspx.cs" Inherits="BudgetCapture.Reports.IncomeProRpt" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>BugetCapture:: Income Projection Report</title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <table style="vertical-align: bottom; border-width: 0px; margin-top: 0px; margin-bottom: 0px; width: 100%; height: 99.3%; padding: 0px,0px,0px,0px;" cellspacing="0" cellpadding="0">
    <tr>
        <td>
            <table width="100%" cellpadding="0" cellspacing="0" border="0" >
             <tr>
              <td style="width:80%; background-color:White;">
                   <img src="../img/budget-smart.png" alt="Budget Capture Logo"/> </td>
              <td style="padding:5px;font-family:Arial, Helvetica, sans-serif;color:#5b5b5b;font-size:11px;"><a href="../Default.aspx">DashBoard </a> | <a href="ReportHome.aspx">Report</a></td>
             </tr>
             </table>
          </td>
     </tr>
     <tr>
          <td>
          <div style="border-top: black 1px solid; background-color: #ece9d8; border-bottom-width: 1px; border-bottom-color: #d4d0c8; padding-bottom: 10px; margin-bottom:0px;">
           <table width="100%" style="padding:2px;font-family:Arial, Helvetica, sans-serif;color:#5b5b5b;font-size:11px;">
            <tr>
             <td>Filter By BudgetYear:</td><td>
             <asp:DropDownList ID="ddlbudyr" runat="server" AppendDataBoundItems="true">
              <asp:ListItem Value="" Selected="True">..Select Year..</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" InitialValue=""  runat="server" ForeColor=Maroon ControlToValidate="ddlbudyr" Display="Dynamic" Text="Required!"></asp:RequiredFieldValidator>  
                </td>
            </tr>
            <tr>
            <td>Filter By Department:</td>
            <td>
               <asp:DropDownList Id="ddlDept" runat="server" CssClass="" 
                                AppendDataBoundItems="true" Enabled="true">
                 <asp:ListItem Value="" Selected="True">..Select Department..</asp:ListItem>
             </asp:DropDownList>
            </td>
            </tr>
               <tr>
                 <td >
                     <asp:Button ID="btnGenerate" runat="server" Text="Generate Report" 
                         CssClass="btns btn-submit" ValidationGroup="cat" onclick="btnGenerate_Click"/></td>
                    <td>
                        <asp:Label ID="lbMsg" runat="server" Text="" ForeColor="Maroon"></asp:Label></td>
                 </tr>
                 </table>
            </div>
          </td>
      </tr>
      <tr>
        <td>
            <table border="0" width="100%">
             <tr>
              <td colspan="2">
                  <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Width="100%" Height="100%"
                      Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
                      WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
                      <localreport reportpath="Reports\IncomeProRpt.rdlc">
                          <datasources>
                              <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsBudget" />
                          </datasources>
                      </localreport>
                  </rsweb:ReportViewer>
                  <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                      OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                      
                      
                      
                      TypeName="BudgetCapture.Reports.dsBudgetRptTableAdapters.bc_rpt_IncomeProjectionTableAdapter">
                      <SelectParameters>
                          <asp:Parameter Name="deptId" Type="Int32" />
                          <asp:Parameter Name="budgetYrId" Type="Int32" />
                      </SelectParameters>
                  </asp:ObjectDataSource>
                 </td>
               </tr>
               </table>
             </td>
         </tr> 
    </table>
    </form>
</body>
</html>
