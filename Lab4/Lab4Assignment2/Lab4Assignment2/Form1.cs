using System.Net;

namespace Lab4Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] driver = Environment.GetLogicalDrives();

            foreach (string driver2 in driver)
            {
                DriveInfo di = new DriveInfo(driver2);
                int driveImage;

                switch (di.DriveType)
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;

                    case DriveType.Network:
                        driveImage = 6;
                        break;

                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;

                    case DriveType.Unknown:
                        driveImage = 9;
                        break;

                    default:
                        driveImage = 10;
                        break;
                }

                TreeNode node = new TreeNode(driver2.Substring(0, 1), driveImage, driveImage);
                node.Tag = driver2;

                if (di.IsReady == true)
                {
                    node.Nodes.Add("...");
                }
                txtTreeView.Nodes.Add(node);
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    string[] directory = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (var dir in directory)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            node.Tag = dir;

                            if (di.GetDirectories().Count() > 0)
                            {
                                node.Nodes.Add(null, "...", 0, 0);
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }   

        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lbFolder.Items.Clear();
            lbFile.Items.Clear();
            txtPath1.Text = e.Node.Tag.ToString();

            try
            {
                string[] fileEntries = Directory.GetFiles(e.Node.Tag.ToString());
                foreach (string fileEntry in fileEntries)
                {
                    lbFile.Items.Add(Path.GetFileName(fileEntry));
                }

                string[] directoryEntries = Directory.GetDirectories(e.Node.Tag.ToString());
                foreach (string directory in directoryEntries)
                {
                    lbFolder.Items.Add(Path.GetFileName(directory));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetFileAndFolders(txtServer.Text, txtUserName.Text, txtPassWord.Text, txtPath.Text);
        }
        private void GetFileAndFolders(string _server, string _user, string _pass, string _path)
        {
            lbFolder1.Items.Clear();
            lbFile1.Items.Clear();

            string url = _server + ":" + txtPort.Text + _path;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);

            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(_user, _pass);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string s = reader.ReadToEnd();
            txtStatus.Text = response.StatusDescription;

            reader.Close();
            response.Close();

            string[] ls = s.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            foreach (string l in ls)
            {
                if (l.Length > 38)
                {
                    if (l.IndexOf("<DIR>", 0, 38) > 0)
                    {
                        lbFolder1.Items.Add(l.Substring(39));
                        txtPath.Text = l.Substring(39);
                    }
                    else
                    {
                        lbFile1.Items.Add(l.Substring(39));
                        txtPath.Text = l.Substring(39);
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lbFile.SelectedItems != null)
            {
                string _path = txtTreeView.SelectedNode.Tag.ToString() + "\\"
                    + lbFile.GetItemText(lbFile.SelectedItem);

                FileInfo fi = new FileInfo(_path);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(
                    new Uri(txtServer.Text + "/" + fi.Name));

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(txtUserName.Text, txtPassWord.Text);
                byte[] bytes = File.ReadAllBytes(fi.FullName);
                request.ContentLength = bytes.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(bytes, 0, bytes.Length);
                    reqStream.Close();
                }
                MessageBox.Show("File uploaded");
            }
        }


    }
}

