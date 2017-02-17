using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HentaiDuplicationChecker
{
    public partial class Form1 : Form
    {
        Scraper.ANN ann = new Scraper.ANN();
        HelperProject.WriterHelper writerHelper = new HelperProject.WriterHelper();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //i should return a list from the function below.
            List<string> AnimeList = ann.getAllHentaiUrl();
            List<string> FileNameList = SearchDisk();

            SearchDuplication(AnimeList, FileNameList);
        }

        private List<string> SearchDisk()
        {
            string tempDir = "Z:/Hentai";

            //Consider adding file extension checking also.
            List<string> FileNameList = new List<string>();
            Dictionary<string, string> FileNameDictionary = new Dictionary<string, string>();

            //Gets all files in root folder
            foreach (string files in Directory.GetFiles(tempDir))
            {
                FileNameList.Add(Path.GetFileNameWithoutExtension(files) + "$" + files);
            }

            //Gets all files inside folder inside root folder
            foreach (string folder in Directory.GetDirectories(tempDir))
            {
                foreach (string files in Directory.GetFiles(folder))
                {
                    FileNameList.Add(Path.GetFileNameWithoutExtension(files) + "$" + files);
                }
            }

            HelperProject.TitleRefactoringHelper TRH = new HelperProject.TitleRefactoringHelper();
            FileNameList = TRH.titleRefactoring(FileNameList);

            //writes to a log for debugging.
            //writerHelper.WriterText(@"C:\Users\Genryu\Desktop\", @"MovieLog1.txt", FileNameList);

            return FileNameList;
            
        }

        private void SearchDuplication(List<string> AnimeList, List<string> FileNameList)
        {
            List<string> foundList = new List<string>();

            foreach (string wholeAnimeLine in AnimeList)
            {
                //delimit line in animelist
                string[] animeNamesArray = new string[wholeAnimeLine.Split('$').Count() - 1];
                int episodes = wholeAnimeLine.Split('$').Length - 1;
                for (int i = 0; i < wholeAnimeLine.Split('$').Count()-1; i++)
                {
                    animeNamesArray[i] = wholeAnimeLine.Split('$')[i];
                }

                //loop the delimited strings inside folder list
                for(int x = 0; x < FileNameList.Count(); x++)
                {
                    for (int i = 0; i < animeNamesArray.Count() - 1; i++)
                    {
                        if (FileNameList[x].Split('$')[0].ToLower().Contains(animeNamesArray[i].ToLower()))
                        {
                            foundList.Add(FileNameList[x].Split('$')[1].ToLower() + " found with " + animeNamesArray[i].ToLower());
                        }
                    }
                }
                writerHelper.WriterText(@"C:\Users\Genryu\Desktop\", @"FoundLog.txt", foundList);
            }
        }
    }
}
