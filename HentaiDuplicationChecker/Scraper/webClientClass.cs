using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHtmlUnit;
using NHtmlUnit.Html;

namespace Scraper
{
    class webClientClass
    {
        
        public string runWebClient(bool debugMode, int siteType, string url)
        {
            //siteType is not handles as getting from only one source.
            WebClient webClient = new WebClient();

            if (debugMode)
            {
                //ip and port points to fiddler for webClient.
                webClient = new WebClient(BrowserVersion.CHROME, "127.0.0.1", 8888)
                {
                    JavaScriptEnabled = false,
                    ThrowExceptionOnScriptError = false,
                    ThrowExceptionOnFailingStatusCode = false,
                    CssEnabled = false
                };
            }
            else
            {
                //Without running with fiddler.
                webClient = new WebClient(BrowserVersion.CHROME)
                {
                    JavaScriptEnabled = false,
                    ThrowExceptionOnScriptError = false,
                    ThrowExceptionOnFailingStatusCode = false,
                    CssEnabled = false,
                };
            }
            HtmlPage Page = (HtmlPage)webClient.GetPage(url);
            string htmlPage = Page.WebResponse.ContentAsString;

            return htmlPage;
        }

        public string runWebClientXML(bool debugMode, int siteType, string url)
        {
            //siteType is not handles as getting from only one source.
            WebClient webClient = new WebClient();

            if (debugMode)
            {
                //ip and port points to fiddler for webClient.
                webClient = new WebClient(BrowserVersion.CHROME, "127.0.0.1", 8888)
                {
                    JavaScriptEnabled = false,
                    ThrowExceptionOnScriptError = false,
                    ThrowExceptionOnFailingStatusCode = false,
                    CssEnabled = false
                };
            }
            else
            {
                //Without running with fiddler.
                webClient = new WebClient(BrowserVersion.CHROME)
                {
                    JavaScriptEnabled = false,
                    ThrowExceptionOnScriptError = false,
                    ThrowExceptionOnFailingStatusCode = false,
                    CssEnabled = false,
                };
            }
            var s = new com.sun.org.apache.xerces.@internal.jaxp.SAXParserFactoryImpl();
            //XHtmlPage Page = (XHtmlPage)webClient.GetPage(url);

            string htmlPage = webClient.GetPage(url).WebResponse.ContentAsString;

            return htmlPage;
        }
    }
}
