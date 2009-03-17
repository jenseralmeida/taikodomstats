using System;
using System.Web;
using System.Web.UI;

public partial class SilverlightContainer : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }

    public string SilverlightSource
    {
        get; set;
    }

    protected string ResolveUrlSource()
    {
        //<param name="source" value='<%= ResolveUrlSource() %>' />
        var control = HttpContext.Current.Handler as Control;
        if (control == null)
        {
            return String.Empty;
        }
        return control.ResolveUrl(SilverlightSource);
    }
}

