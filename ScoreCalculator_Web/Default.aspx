<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScoreCalculator_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Score Calculator</title>
    <link rel="stylesheet" href="styles.css">
    <!-- <Resources> -->
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.6.1.slim.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <!--</Resources>-->


</head>
<body>
    <form id="form1" runat="server">
        

        <div class="container">
            <div class="row">
                <div id="myDIV" class="col-md-6">
                    <span>
                        <asp:Label ID="Label1" runat="server" Text="Nomreh"></asp:Label>
                    &nbsp;&nbsp; Vahed<br />
                        <asp:TextBox ID="N1" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V1" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N2" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V2" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N3" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V3" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N4" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V4" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N5" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V5" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N6" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V6" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N7" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V7" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N8" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V8" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N9" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V9" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:TextBox ID="N10" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="V10" runat="server" Height="25px" MaxLength="6" Width="60px"></asp:TextBox>
                    <br />
                        <asp:Label ID="Answer" runat="server" CssClass="badge bg-primary text-wrap" Text="Answer" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />

                    <asp:Button ID="Clear" runat="server" CssClass="btn btn-secondary" Text="Clear" OnClick="Clear_Click" />
                    <asp:Button ID="Calculate" runat="server" CssClass="btn btn-success" Text="Calculate" OnClick="Calculate_Click" />

                    <br />

                    </span></div>
                <div class="col-md-6 col-lg-5"><span>

                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />

                    </span></div>
            </div>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-md-12">
                </div>
            </div>
        </div>

        <script src="assets/bootstrap/js/bootstrap.min.js"></script>



    </form>
</body>
</html>
