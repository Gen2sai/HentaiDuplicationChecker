using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Scraper
{
    public class ANN
    {
        HelperProject.WriterHelper writerHelper = new HelperProject.WriterHelper();
        webClientClass wcc = new webClientClass();
        ann annSerializer = new ann();

        //variable section
        string url = "http://www.animenewsnetwork.com/";
        bool debugMode = true;

        public void getAllHentaiUrl()
        {
            //regex method in region currently unused.
            #region
            //get total pages
            //int pages = getTotalPages();

            //List<string> tempList = new List<string>();
            //for (int i = 0; i < pages; i++)
            //{
            //    string htmlPage = wcc.runWebClient(debugMode, 0, url + "encyclopedia/search/genreresults?w=series&a=AO&g=erotica&o=rating&pg=" + i);

            //    if (!String.IsNullOrEmpty(htmlPage))
            //    {
            //        string pattern = "<a href=\"(?<Url>.*?)\">(?<HentaiName>.*?)</a>\\s*<small class=\"de-emphasized\">(?<ReleaseDate>.*?)</small>";

            //        MatchCollection m = Regex.Matches(htmlPage, pattern);

            //        List<string> urlList = new List<string>();

            //        foreach (Match match in m)
            //        {
            //            urlList.Add(match.Groups["Url"].Value);
            //        }

            //        if (urlList.Count > 0)
            //        {

            //            Parallel.ForEach(urlList, internalUrl =>
            //            {
            //                Console.WriteLine(url + internalUrl);
            //                string tempPage = wcc.runWebClient(debugMode, 0, url + internalUrl);
            //                //string pattern old. Without Episode pattern.
            //                //string tempPattern = "<h1 id=\"page_header\">(?<EnglishTitle>.*?)</h1>[\\s\\S]*?<strong>Alternative title:</strong>[\\s\\S]*?<div class=\"tab\">(?<JapaneseTitle>[\\s\\S]*?)</div>\\s*</div>";
            //                //string pattern new. With Episode pattern.
            //                string tempPattern = "<h1 id=\"page_header\">(?<EnglishTitle>.*?)</h1>[\\s\\S]*?<strong>Alternative title:</strong>[\\s\\S]*?<div class=\"tab\">(?<JapaneseTitle>[\\s\\S]*?)</div>\\s*</div>[\\s\\S]*?<strong>Number of episodes:</strong>[\\s\\S]*?<span>(?<EpisodeCount>[\\s\\S]*?)</span>";
            //                MatchCollection mc = Regex.Matches(tempPage, tempPattern);

            //                foreach (Match match in mc)
            //                {
            //                    if (match.Groups["JapaneseTitle"].Value.Trim().Contains(@"</div>"))
            //                    {
            //                        tempList.Add(match.Groups["EnglishTitle"].Value.Trim() + "$" + match.Groups["JapaneseTitle"].Value.Trim().ToString().Replace("</div>\n\t<div class=\"tab\">", "$"));
            //                        //tempList.Add(match.Groups["EnglishTitle"].Value.Trim() + "$" + match.Groups["JapaneseTitle"].Value.Trim().ToString().Replace("</div>\n\t<div class=\"tab\">", "$") + "$" + match.Groups["EpisodeCount"].Value.Trim());
            //                    }
            //                    else
            //                    {
            //                        tempList.Add(match.Groups["EnglishTitle"].Value.Trim() + "$" + match.Groups["JapaneseTitle"].Value.Trim());
            //                        //tempList.Add(match.Groups["EnglishTitle"].Value.Trim() + "$" + match.Groups["JapaneseTitle"].Value.Trim() + "$" + match.Groups["EpisodeCount"].Value.Trim());
            //                    }
            //                }
            //            });
            //        }
            //    }
            //}
            //debug purpose only
            //writerHelper.WriterText(@"C:\Users\Genryu\Desktop\", @"log.txt", tempList);
            #endregion

            //using ANN api instead
            //note to self benchmark regex againts api
            int pages = getTotalPages();
            //List<string> AnimeList = new List<string>();

            List<string> urlList = new List<string>();
            for (int i = 0; i < pages; i++)
            {
                string htmlPage = wcc.runWebClient(debugMode, 0, url + "encyclopedia/search/genreresults?w=series&a=AO&g=erotica&o=rating&pg=" + i);

                if (!String.IsNullOrEmpty(htmlPage))
                {
                    string pattern = "<a href=\".*id=(?<Url>.*?)\">(?<HentaiName>.*?)</a>\\s*<small class=\"de-emphasized\">(?<ReleaseDate>.*?)</small>";

                    MatchCollection m = Regex.Matches(htmlPage, pattern);

                    foreach (Match match in m)
                    {
                        urlList.Add(match.Groups["Url"].Value);
                    }
                }
            }

            if (urlList.Count > 0)
            {
                //what to do with all urls
                //sample http://cdn.animenewsnetwork.com/encyclopedia/api.xml?anime=11374&anime=11374
                List<string> AnimeList = new List<string>();
                for (int i = 0; i <= urlList.Count / 50; i++)
                {
                    string allID = @"encyclopedia/api.xml?";
                    if(i == urlList.Count / 50)
                    {
                        foreach (string ID in urlList.GetRange(i * 50, urlList.Count - (i * 50)))
                        {
                            allID += "anime=" + ID + @"&";
                        }
                    }
                    else
                    {
                        foreach (string ID in urlList.GetRange(i * 50, 50))
                        {
                            allID += "anime=" + ID + @"&";
                        }
                    }
                    
                    string htmlPage = wcc.runWebClientXML(debugMode, 0, url + allID);
                    XmlTextReader reader = new XmlTextReader(new System.IO.StringReader(htmlPage));
                    XmlSerializer serializer = new XmlSerializer(typeof(ann));
                    while (reader.Read())
                    {
                        ann ana = (ann)(serializer.Deserialize(reader));
                        int animeCount = ana.anime.Length;
                        
                        for (int y = 0; y < animeCount; y++)
                        {
                            //Name
                            //Alternative Names
                            //episode
                            string oneLine = "";
                            //first add the titlename
                            oneLine += ana.anime[y].name + "$";
                            //loop each info for other languages
                            foreach (var item in ana.anime[y].info)
                            {
                                if(!string.IsNullOrEmpty(item.type.ToString()))
                                {
                                    if(item.type.ToString().ToLower() == "main title" || item.type.ToString().ToLower() == "alternative title")
                                    {
                                        oneLine += item.Text[0].ToString() + "$";
                                    }
                                    else if (item.type.ToString().ToLower() == "Number of episodes")
                                    {
                                        oneLine += item.Text[0].ToString();
                                    }
                                }
                            }
                            AnimeList.Add(oneLine);
                        }
                        
                    }
                }
                writerHelper.WriterText(@"C:\Users\Genryu\Desktop\", @"log.txt", AnimeList);
            }
        }

        private int getTotalPages()
        {
            //get number of total page (pagination on animenewsnetwork)
            string htmlPage = wcc.runWebClient(debugMode, 0, url + "encyclopedia/search/genreresults?w=series&a=AO&g=erotica&o=rating");

            string pattern = "<p>Page:[\\s\\S]*?>(?<Page>.*?)</a></p>";

            Match m = Regex.Match(htmlPage, pattern);

            return Int32.Parse(m.ToString().Substring(m.ToString().Length - 9, 1));
        }
    }
}
