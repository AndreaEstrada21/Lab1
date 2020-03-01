<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DeleteRepro</title>
    <link href="C:\Users\Andrea\Desktop\Lab1\Content\Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
 <form action="/Video/DeleteRepro" method="post">
    <fieldset>   
    <legend>Eliminación videos por reproducciones</legend>
    <label for = "reproducciones">reproducciones</label>
    <input type = "text" name = "reproducciones" />
    <input type = "submit" value = "Eliminar" />
    </fieldset>
    </form>
</body>
</html>
