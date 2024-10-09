using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXBeditor.TXBeditor
{
    public partial class AFSFilePicker : Form
    {
        Form1 rootform;

        public AFSFilePicker(Form1 TXBEditor)
        {
            InitializeComponent();
            rootform = TXBEditor;
        }

        public void BuildTree(string afs_name, List<string> afs_files)
        {
            TreeAFSFileList.Nodes.Clear();

            // add icons to image list, should move this elsewhere
            ImageList IconList = new ImageList();
            IconList.Images.Add("Root", Properties.Resources.afspicker_root);
            IconList.Images.Add("File", Properties.Resources.afspicker_file);
            TreeAFSFileList.ImageList = IconList;

            // create root
            TreeNode rootNode = new TreeNode();
            rootNode.Text = afs_name;
            rootNode.ImageIndex = 0;
            TreeAFSFileList.Nodes.Add(rootNode);

            foreach (string file in afs_files)
            {
                TreeNode fileNode = new TreeNode();
                fileNode.Text = file;
                fileNode.ImageIndex = 1;
                fileNode.SelectedImageIndex = 1;

                TreeAFSFileList.Nodes[rootNode.Index].Nodes.Add(fileNode); // add to root
            }

            rootNode.Expand();
        }

        private void TreeAFSFileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected_file = TreeAFSFileList.SelectedNode;

            if (selected_file != null)
            {
                if (selected_file.Level == 1)
                {
                    rootform.LoadFileFromAFS(selected_file.Index);
                    this.Close();
                }
            }
        }
    }
}
