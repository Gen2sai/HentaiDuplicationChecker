using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelperProject
{
    public class TitleRefactoringHelper
    {
        public List<string> titleRefactoring(List<string> FileNameList)
        {
            //take in the filename and remove header () and [].
            string SquareBracketPattern = "\\[(?<SquareBrackets>.*?)\\]";
            string BracketPattern = "\\((?<Brackets>.*?)\\)";
            List<string> newFileNameList = new List<string>();
            foreach(string title in FileNameList)
            {
                //splitting the title for the char $ as a delimiter
                string splitTitle = title.Split('$')[0];
                string tempTitle;

                tempTitle = Regex.Replace(splitTitle, SquareBracketPattern, "");
                if (string.IsNullOrEmpty(tempTitle))
                {
                    tempTitle = splitTitle;
                }
                tempTitle = Regex.Replace(tempTitle, BracketPattern, "");
                if (string.IsNullOrEmpty(tempTitle))
                {
                    tempTitle = splitTitle;
                }
                tempTitle = tempTitle.Trim().ToLower();
                if (tempTitle[0] == '_')
                {
                    tempTitle = tempTitle.Remove(0, 1);
                }

                //merge filtered title before adding back to list
                newFileNameList.Add(tempTitle + "$" + title.Split('$')[1]);
            }
            return newFileNameList;
        }
    }
}
