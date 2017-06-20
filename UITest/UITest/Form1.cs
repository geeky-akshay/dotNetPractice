using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITest
{
    public partial class Form1 : Form
    {
        List<Attachment> lstAttachments = null;
        enum ProductType
        {
            Products = 1,
            Services = 2
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void btnAddAttachments_Click(object sender, EventArgs e)
        {
            AddAttachments();
        }

        private void AddAttachments()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            List<FileInfo> lstFileInfo = new List<FileInfo>();
            foreach (var file in openFileDialog.FileNames)
            {
                lstFileInfo.Add(new FileInfo(file));
            }

            lstAttachments = new List<Attachment>();
            foreach (var fileInfo in lstFileInfo)
            {
                lstAttachments.Add(new Attachment
                {
                    Name = fileInfo.Name,
                    Path = fileInfo.FullName,
                    Extension = fileInfo.Extension,
                    SizeInMb = (float)fileInfo.Length / 1048576
                });
            }

            olvAttachments.SetObjects(lstAttachments);

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(32, 32);
            imgList.Images.Add("txt", Properties.Resources.txt);
            imgList.Images.Add("pdf", Properties.Resources.pdf);

            olvAttachments.LargeImageList = imgList;
            olvAttachments.OwnerDraw = true;
            olvColumnName.ImageGetter = delegate (object rowObject)
            {
                Attachment attachment = (Attachment)rowObject;
                if (attachment.Name.Contains("txt"))
                    return "txt";
                else
                    return "pdf";
            };
        }

        private void olvAttachments_CellClick(object sender, CellClickEventArgs e)
        {
            webBrowser1.Navigate(lstAttachments.Find(x => x.Name == e.SubItem.ModelValue.ToString()).Path);
        }
    }
}
