using Gestor_de_Archivos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Archivos
{
   
    public partial class Form1 : Form
    {
        private FileManager fileManager;

        public Form1()
        {
            InitializeComponent();
            initProperties();
        }

        private void initProperties()
        {
            this.fileManager = new FileManager();
            this.fileManager.ChangePachEvent += OnManagerPachCanged;
            this.fileManager.TextFileOpenedEvent += TextFileOpenedAction;
            this.fileManager.ImageFileOpenedEvent += ImageFileOpenedAction;
            this.fileManager.setPath(Application.StartupPath);
        }

        private void ImageFileOpenedAction(Image image)
        {

            this.picture_imageContents.Visible = true;
            this.txt_fileContents.Visible = false;
            this.picture_imageContents.Image = image;
        }

        private void TextFileOpenedAction(string contents)
        {
            this.picture_imageContents.Visible = false;
            this.txt_fileContents.Visible = true;
            this.txt_fileContents.Text = contents;
        }

        private void OnManagerPachCanged()
        {
            this.list_archivos.Items.Clear();
            this.lbl_currentPath.Text = fileManager.getPath();
            this.list_archivos.Items.Add("..");
            foreach (FileFolder fileFolder in fileManager.GetFileFolders) {
                this.list_archivos.Items.Add(fileFolder.name);
            }    
        }

        private void list_archivos_DoubleClick(object sender, EventArgs e)
        {
            if (this.list_archivos.SelectedItems.Count == 0)
                return;

            string itemSelected = list_archivos.SelectedItems[0].Text;

            if (itemSelected == "..")
            {
                fileManager.gotoUp();
            }
            else {
                fileManager.OpenFile(itemSelected);
            }
        }

        
    }
}
