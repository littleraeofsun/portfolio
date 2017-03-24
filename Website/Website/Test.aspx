<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Rae.Website.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Project count: <%= projectCount %></p>
    </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script type="text/javascript">
        var urlsToTest = [
            'http://localhost:57723/api/Project',
            'http://localhost:57723/api/Album',
            'http://localhost:57723/api/Image/GetAllImages',
            'http://localhost:57723/api/Media/GetAllMedia',
            'http://localhost:57723/api/Photo/GetAllPhotos',
            'http://localhost:57723/api/Image/GetProjectImages/1',
            'http://localhost:57723/api/Photo/GetAlbumPhotos/1',
        ];
        $(document).ready(function () {
            for (var i = 0; i < urlsToTest.length; i++) {
                TestUrl(urlsToTest[i]);
            }
        });
        function TestUrl(url) {
            $.ajax({
                url: url,
                type: 'GET',
                dataType: 'json',
                success: function (data) {
                    console.info("Succesful result for '" + this.url + "':");
                    console.info(data);
                },
                error: function (x, y, z) {
                    console.warn("Unsuccessful result for '" + this.url + "':");
                    console.warn(x + '\n' + y + '\n' + z);
                }
            });
        }
    </script>
</body>
</html>
