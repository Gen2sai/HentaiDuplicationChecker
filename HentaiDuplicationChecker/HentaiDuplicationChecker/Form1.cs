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

            //string[] drives = Environment.GetLogicalDrives();
            //foreach (string drive in drives)
            //{
            //    TreeNode node = new TreeNode(drive);
            //    node.Tag = drive;
            //    //Set Disk Icon
            //    node.ImageIndex = 0;
            //    node.Tag = drive;
            //    treeView1.Nodes.Add(node);
            //    node.Nodes.Add(new TreeNode("?"));
            //}
            //treeView1.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count == 1) && (e.Node.Nodes[0].Text == "?"))
            {
                RecursiveDirWalk(e.Node);
            }
            foreach (System.Windows.Forms.TreeNode aNode in treeView1.Nodes)
            {
                //edit
                if (aNode.Checked)
                    foreach (TreeNode innerNode in aNode.Nodes)
                    {
                        if (innerNode.Checked)
                        {
                            Console.WriteLine(innerNode.FullPath);
                        }
                    }
            }
        }

        private TreeNode RecursiveDirWalk(TreeNode node)
        {
            string path = (string)node.Tag;
            node.Nodes.Clear();
            string[] dirs = System.IO.Directory.GetDirectories(path);
            for (int t = 0; t < dirs.Length; t++)
            {
                TreeNode n = new TreeNode(dirs[t].Substring(dirs[t].LastIndexOf('\\') + 1));
                n.ImageIndex = 1; // dir icon
                n.Tag = dirs[t];
                node.Nodes.Add(n);
                n.Nodes.Add(new TreeNode("?"));
            }

            // Optional if you want files as well:
            string[] files = System.IO.Directory.GetFiles(path);
            for (int t = 0; t < files.Length; t++)
            {
                TreeNode tn = new TreeNode(System.IO.Path.GetFileName(files[t]));
                tn.Tag = files[t];
                tn.ImageIndex = 2; // file icon
                node.Nodes.Add(tn);
            } // end of optional file part
            return node;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ann.getAllHentaiUrl();
            //SearchDisk();
        }

        private void SearchDisk()
        {
            string tempDir = "Z:/Hentai";
            //Consider adding file extension checking also.
            List<string> FileNameList = new List<string>();
            try
            {
                foreach (string p in Directory.GetFiles(tempDir))
                {
                    FileNameList.Add(p.Replace(tempDir + @"\", ""));
                }
                foreach (string p in Directory.GetDirectories(tempDir))
                {
                    foreach (string f in Directory.GetFiles(p))
                    {
                        FileNameList.Add(Path.GetFileName(f));
                    }
                }

                //writes to a log for debugging.
                writerHelper.WriterText(@"C:\Users\Genryu\Desktop\", @"MovieLog.txt", FileNameList);
            }
            catch
            {

            }
        }
    }
}
