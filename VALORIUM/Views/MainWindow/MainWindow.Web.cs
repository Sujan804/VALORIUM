using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VALORIUM
{
    public partial class MainWindow
    {
       

        // Load the file into the WebView2 control
        
        void LoadWebView()
        {
            string htmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "Web", "index.html");
            //webView.Address = htmlFilePath;
        }
    }
}
