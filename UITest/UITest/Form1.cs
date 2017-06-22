using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITest
{
    public partial class Form1 : Form
    {
        private List<FileInfo> lstAttachments = null;
        private ImageList lstIcons = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeListObjects();
        }

        private void InitializeListObjects()
        {
            // Attachments
            lstAttachments = new List<FileInfo>();

            // Icons
            lstIcons = new ImageList();
            lstIcons.ImageSize = new Size(32, 32);
            lstIcons.Images.Add("txt", Properties.Resources.txt);
            lstIcons.Images.Add("pdf", Properties.Resources.pdf);
        }

        private void btnAddAttachments_Click(object sender, EventArgs e)
        {
            AddAttachments();
        }

        private void AddAttachments()
        {
            // Browse for files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            foreach (var file in openFileDialog.FileNames)
            {
                lstAttachments.Add(new FileInfo(file));
            }
            
            // Set list object
            olvAttachments.SetObjects(lstAttachments);

            olvAttachments.LargeImageList = lstIcons;
            olvAttachments.OwnerDraw = true;
            olvColumnName.ImageGetter = delegate (object rowObject)
            {
                FileInfo attachment = (FileInfo)rowObject;
                if (attachment.Name.Contains("txt"))
                    return "txt";
                else
                    return "pdf";
            };
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            //string path = @"d:\practice\web_practice\invoice\default_order.html";
            //var html = System.IO.File.ReadAllText(path);
            //WebPreviewDialog webPreviewDialog = new WebPreviewDialog(html);
            //webPreviewDialog.Show();
            ShowPrintPreview();
        }

        private void ShowPrintPreview()
        {
            var previewDialog = new PrintPreviewDialog();
            var document = new PrintDocument();

            previewDialog.Document = document;
            previewDialog.Document.DocumentName = "ABC";

            previewDialog.ShowDialog();
        }

        private void olvAttachments_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            MenuItem[] menuItems = new MenuItem[] { new MenuItem("Delete", OnMenuDelete_Clicked) };
            olvAttachments.ContextMenu = new ContextMenu(menuItems);
        }

        private void OnMenuDelete_Clicked(object sender, EventArgs e)
        {
            var selectedObject = olvAttachments.SelectedObject;
            var selectedIndex = olvAttachments.SelectedIndex;
            
            olvAttachments.RemoveObject(selectedObject);
            lstAttachments.RemoveAt(selectedIndex);

            if (selectedIndex - 1 == -1)
            {
                webBrowser1.Navigate("about:blank");
            }
            else
            {
                webBrowser1.Navigate(lstAttachments[selectedIndex - 1].FullName);
            }
        }

        private void olvAttachments_CellClick(object sender, CellClickEventArgs e)
        {
            webBrowser1.Navigate(lstAttachments.Find(x => x.FullName == olvAttachments.SelectedObject.ToString()).FullName);
        }
    }
}
