<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script type="text/javascript">

        var nj = $.noConflict();
        nj("document").ready(function () {
            alert("Hello This is me.");
        });

        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
       
        
    </div>
    </form>
</body>
</html>
