using System.Net;
using System.Windows.Forms;

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
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
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
                        driveImage = 2;
                        break;
                }
                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;


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
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach (string dir in dirs)
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
            txtFolderLocal.Clear();
            txtFile.Clear();
            txtPath1.Text = e.Node.Tag.ToString();
            try
            {
                string[] fileEntries = Directory.GetFiles(e.Node.Tag.ToString());
                foreach (string fileEntry in fileEntries)
                {
                    txtFile.Text = Path.GetFileName(fileEntry);
                }
                string[] folderEntries = Directory.GetDirectories(e.Node.Tag.ToString());
                foreach (string folderEntry in folderEntries)
                {
                    txtFolderLocal.Text = Path.GetFileName(folderEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Directiory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetFileAndFolders(txtServer.Text, txtUserName.Text, txtPassWord.Text, "/");
        }
        private void GetFileAndFolders(string _server, string _user, string _pass, string _path)
        {
            txtFiles1.Clear();
            txtFolders1.Clear();
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
            foreach (string line in ls)
            {
                if (line.Length > 38)
                {
                    if (line.IndexOf("<DIR>", 0, 30) > 0)
                    {
                        txtFolders1.Text = line.Substring(39);

                    }
                    else
                    {
                        txtFiles1.Text = line.Substring(39);
                    }
                }
            }
        }
    }
}

