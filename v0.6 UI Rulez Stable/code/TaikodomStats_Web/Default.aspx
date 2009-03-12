<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Default.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" EnableViewState="false" %>

<%@ OutputCache Duration="600" VaryByParam="none" %>
<%@ Register Assembly="System.Web.Silverlight" Namespace="System.Web.UI.SilverlightControls"
    TagPrefix="asp" %>
<%@ Register src="SilverlightContainer.ascx" tagname="SilverlightContainer" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">

    <uc1:SilverlightContainer ID="SilverlightContainer1" runat="server" />

</asp:Content>
