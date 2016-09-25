using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            workerThread.WorkerReportsProgress = true;
            workerThread.WorkerSupportsCancellation = true;
            workerThread.DoWork += new DoWorkEventHandler(bw_DoWork);
            workerThread.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            workerThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            loadDataFromFile();
        }

        private BackgroundWorker workerThread = new BackgroundWorker();
        private string[] sizesToSearchFor;
        private string[] stylesToSearchFor;
        private string[] exclusionPatternsToSearchFor;
        private bool addAlbumCoversSelected = false;
        private bool addSizeCardsSelected = false;
        private string albumCoverLocations;
        private string sizeCardLocation;
        private string inventoryImageLocation;
        private string outPutFileLocation;
        private string settingsFile = "settings.xml";

        private void loadDataFromFile()
        {
            StyleNamesToLookFor.Text = "amelia,dds";
            SizesToLookFor.Text = "2,3,4,5,6,7,8,9,10,11,12,13,14,xxs,xs,s,m,l,xl,xxl,xxxl";
            addAlbumCovers.Checked = true;
            addSizeCards.Checked = true;
            AlbumCoverLocation.Text = "C:\\LLR\\albumCovers";
            AlbumSizeCardsLocation.Text = "C:\\LLR\\sizeCards";
            pictureAlbumLocation.Text = "C:\\LLR\\Inventory";
            outputLocation.Text = "c:\\LLR\\picturesOutput";
            exclusionPatterns.Text = "_ignore,_forget";


            if (File.Exists(settingsFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(settingsFile);                
                foreach (XmlNode settingNode in doc.DocumentElement.ChildNodes)
                {
                    if (settingNode.Name.Equals("SizesToLookFor"))
                    {
                        SizesToLookFor.Text = settingNode.InnerText;
                    }
                    else if (settingNode.Name.Equals("StyleNamesToLookFor"))
                    {
                        StyleNamesToLookFor.Text = settingNode.InnerText;
                    }
                    else if (settingNode.Name.Equals("addAlbumCovers"))
                    {
                        Boolean.TryParse(settingNode.InnerText, out addAlbumCoversSelected);
                        addAlbumCovers.Checked = addAlbumCoversSelected;
                    }
                    else if (settingNode.Name.Equals("addSizeCards"))
                    {
                        Boolean.TryParse(settingNode.InnerText, out addSizeCardsSelected);
                        addSizeCards.Checked = addSizeCardsSelected;
                    }
                    else if (settingNode.Name.Equals("AlbumCoverLocation"))
                    {
                        AlbumCoverLocation.Text = settingNode.InnerText;
                    }
                    else if (settingNode.Name.Equals("AlbumSizeCardsLocation"))
                    {
                        AlbumSizeCardsLocation.Text = settingNode.InnerText;
                    }
                    else if (settingNode.Name.Equals("pictureAlbumLocation"))
                    {
                        pictureAlbumLocation.Text = settingNode.InnerText;
                    }
                    else if (settingNode.Name.Equals("outputLocation"))
                    {
                        outputLocation.Text = settingNode.InnerText;
                    }
                    else if (settingNode.Name.Equals("exclusionPatterns"))
                    {
                        exclusionPatterns.Text = settingNode.InnerText;
                    }
                }                 
            }
            else
            {
                writeSettingsFile();
            }
        }

        private void writeSettingsFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings(); //Format xml output to be easier to read
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            using (XmlWriter writer = XmlWriter.Create(settingsFile, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Settings");         
                       
                writer.WriteElementString("SizesToLookFor", SizesToLookFor.Text);
                writer.WriteElementString("StyleNamesToLookFor", StyleNamesToLookFor.Text);
                writer.WriteElementString("addAlbumCovers", addAlbumCovers.Checked.ToString());
                writer.WriteElementString("addSizeCards", addSizeCards.Checked.ToString());
                writer.WriteElementString("AlbumCoverLocation", AlbumCoverLocation.Text);
                writer.WriteElementString("AlbumSizeCardsLocation", AlbumSizeCardsLocation.Text);
                writer.WriteElementString("pictureAlbumLocation", pictureAlbumLocation.Text);
                writer.WriteElementString("outputLocation", outputLocation.Text);
                writer.WriteElementString("exclusionPatterns", exclusionPatterns.Text);
                
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void updateSettingsFile()
        {
            if (File.Exists(settingsFile))
            {
                File.Delete(settingsFile);
            }
            writeSettingsFile();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            //Load Data so that user can't change while running
            StyleNamesToLookFor.Text = StyleNamesToLookFor.Text.Replace(" ", "");
            SizesToLookFor.Text = SizesToLookFor.Text.Replace(" ", "");
            exclusionPatterns.Text = exclusionPatterns.Text.Replace(" ", "");
            addAlbumCoversSelected = addAlbumCovers.Checked;
            addSizeCardsSelected = addSizeCards.Checked;
            albumCoverLocations = AlbumCoverLocation.Text;
            sizeCardLocation = AlbumSizeCardsLocation.Text;
            inventoryImageLocation = pictureAlbumLocation.Text;
            outPutFileLocation = outputLocation.Text;
            //error checking
            if (StyleNamesToLookFor.Text.Equals(""))
            {
                throw new InvalidOperationException("No Styles To Build");
            }            
            if (SizesToLookFor.Text.Equals(""))
            {
                throw new InvalidOperationException("No Sizes To Build");
            }            
            if (addAlbumCovers.Checked)
            {
                if (!Directory.Exists(albumCoverLocations))
                {
                    throw new InvalidOperationException("Invalid Album Cover Location.");
                }
            }            
            if (addSizeCards.Checked)
            {
                if (!Directory.Exists(sizeCardLocation))
                {
                    throw new InvalidOperationException("Invalid Size Cards Location.");
                }                
            }            
            if (!Directory.Exists(inventoryImageLocation))
            {
                throw new InvalidOperationException("Invalid Inventory Location.");
            }
            
            if (Directory.Exists(outPutFileLocation))
            {
                try
                {
                    Directory.Delete(outPutFileLocation, true);
                }
                catch (Exception) { } //ignore full directory
            }

            //Split strings appart after error checking
            stylesToSearchFor = StyleNamesToLookFor.Text.Split(',');
            sizesToSearchFor = SizesToLookFor.Text.Split(',');            
            exclusionPatternsToSearchFor = exclusionPatterns.Text.Split(',');
            
            //create output directory
            Directory.CreateDirectory(outputLocation.Text);
            worker.ReportProgress(0);
            for (int styleIterator = 0; styleIterator < stylesToSearchFor.Length; styleIterator++)                
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    Directory.Delete(outputLocation.Text, true); //cleanup output
                    break;
                }
                else
                {
                    //Build Folder
                    bool addedAlbumCover = false;
                    bool createdFolder = false;
                    string styleName = stylesToSearchFor[styleIterator];
                    
                    int imageNameIntger = 0;
                    for (int sizeIterator = 0; sizeIterator < sizesToSearchFor.Length; sizeIterator++) //find all subfolders and add them to main folder
                    {
                        string size = sizesToSearchFor[sizeIterator]; 
                        addAllImagesForSize(ref imageNameIntger, size ,styleName, ref addedAlbumCover, ref createdFolder); //will return location for next size
                    }
                    //Report progress
                    worker.ReportProgress(((styleIterator + 1) * 100) / stylesToSearchFor.Length);
                }
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs args)
        {
            runStatusLabel.Text = string.Format("{0}% Completed", args.ProgressPercentage);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                runStatusLabel.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                runStatusLabel.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                runStatusLabel.Text = "Done!";
            }
        }

        private void buildFolderButton_Click(object sender, EventArgs e)
        {
            if (workerThread.IsBusy != true)
            {
                workerThread.RunWorkerAsync();
            }
        }

        private void cancelBuild_Click(object sender, EventArgs e)
        {
            if (workerThread.WorkerSupportsCancellation == true)
            {
                workerThread.CancelAsync();
            }
        }
        
        private void addAlbumCover(ref int location, string style) //always 0 don't need to know where currently at since should be first image
        {
            string outputFileName = Path.Combine(outPutFileLocation + "\\" + style, 0.ToString().PadLeft(4, '0'));
            string[] files = Directory.GetFiles(albumCoverLocations);
            foreach (string file in files)
            {
                string styleSubString = file.Replace(albumCoverLocations + "\\", "");
                if (styleSubString.ToLower().StartsWith(style.ToLower()))
                {
                    outputFileName = outputFileName + getExtension(file);
                    System.IO.File.Copy(files[0], outputFileName, true);
                    location++;
                    return;
                }
            }
            return;            
        }

        private string getExtension(string fileName)
        {
            if (!fileName.Equals("")) //if not empty search
            {
                string[] parts = fileName.Split('.');
                if (parts.Length > 1) //found at least one
                {
                    return "." + parts[parts.Length - 1]; //add . back in and send it back
                }
                return "";
            }
            return "";
        }

        private void addSizeCover(ref int location, string size, string style)
        {
            string outputFileName = Path.Combine(outPutFileLocation + "\\" + style, location.ToString().PadLeft(4, '0'));
            string[] files = Directory.GetFiles(sizeCardLocation);
            foreach (string file in files)
            {
                string sizeSubString = file.Replace(sizeCardLocation + "\\", "");
                if (sizeSubString.ToLower().StartsWith(size.ToLower()))
                {
                    outputFileName = outputFileName + getExtension(file);
                    System.IO.File.Copy(files[0], outputFileName, true);
                    location++;
                    return;
                }
            }
            return;
            
        }

        private void addAllImagesForSize(ref int location, string size, string style, ref bool addedAlbumCover,ref bool createdFolder)
        {
            bool alreadyAddedSizeCard = false;            
            string inventoryPath = inventoryImageLocation + "\\" + style + "\\" + size;
            if (System.IO.Directory.Exists(inventoryPath))
            {
                string[] files = System.IO.Directory.GetFiles(inventoryPath);
                foreach (string fileName in files)
                {
                    bool ignoreFile = false;                    
                    foreach (string exclusion in exclusionPatternsToSearchFor) //if has exclusion pattern
                    {
                        if (exclusion.Equals(""))
                        {
                            break;
                        }
                        string exclusionFile = fileName.Replace(inventoryPath + "\\", "");
                        if (exclusionFile.ToLower().Contains(exclusion.ToLower()))                            
                        {
                            ignoreFile = true;
                            break;
                        }
                    }
                    if (!ignoreFile)
                    {
                        if (!createdFolder) //if we haven't created the folder yet
                        {
                            Directory.CreateDirectory(outPutFileLocation + "/" + style);
                            createdFolder = true;
                        }

                        if (addAlbumCoversSelected && !addedAlbumCover) //if we haven't add the album cover yet and enabled
                        {
                            addAlbumCover(ref location, style);
                            addedAlbumCover = true;
                        }

                        if (addSizeCardsSelected && !alreadyAddedSizeCard) //only add if we have an item in that size
                        {
                            addSizeCover(ref location, size, style);
                            alreadyAddedSizeCard = true;
                        }
                        string outputFileName = Path.Combine(outPutFileLocation + "\\" + style, location.ToString().PadLeft(4, '0'));
                        outputFileName = outputFileName + getExtension(fileName);
                        System.IO.File.Copy(fileName, outputFileName, true);
                        location++;
                    }
                }
            }
            return;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            updateSettingsFile();
        }
        
    }
}
