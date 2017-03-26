<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Rae.Website.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Page</title>
    <link href="styles/jquery.json-viewer.css" rel="stylesheet" />
    <style type="text/css">
        .result.success {
            background: #eeffdd;
        }

        .result {
            padding: 6px;
        }

        .result.error {
            background: #ffeeee;
        }

        body {
            font-family: Arial;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Portfolio Tests</h2>
        <div id="TestResults"></div>
    </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/jquery.json-viewer.js"></script>
    <script type="text/javascript">
        var urlsToTest = [
            'http://localhost:57723/api/Projects',
            'http://localhost:57723/api/Projects/1',
            'http://localhost:57723/api/Projects/1/Media',
            'http://localhost:57723/api/Projects/2/Images',
            'http://localhost:57723/api/Projects/Category/Website',
            'http://localhost:57723/api/Albums',
            'http://localhost:57723/api/Albums/1/Media',
            'http://localhost:57723/api/Media',
            'http://localhost:57723/api/Fail',
            'http://localhost:57723/api/Images',
            'http://localhost:57723/api/Audio',
            'http://localhost:57723/api/Video',
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
                    var result = $('<div class="result success"><div class="result-title">' + this.url + '</div><pre class="result-data" style="display:none;"></pre></div>');
                    result.children('.result-data').jsonViewer(data);
                    $('#TestResults').append(result);
                    result.children('.result-title').click(function () {
                        $(this).next().toggle();
                    });
                },
                error: function (x, y, z) {
                    var result = $('<div class="result error"><div class="result-title">' + this.url + '</div><pre class="result-data" style="display:none;"></pre></div>');
                    result.children('.result-data').jsonViewer({ x: x, y: y, z: z });
                    $('#TestResults').append(result);
                    result.children('.result-title').click(function () {
                        $(this).next().toggle();
                    });
                }
            });
        }
    </script>
</body>
</html>
