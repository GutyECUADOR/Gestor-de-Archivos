using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Gestor_de_Archivos.Clases
{
    public delegate void ChangedPathHandler();
    public delegate void TextFileOpened(string contents);
    public delegate void ImageFileOpened(Image image);

    class FileManager
    {
        public event ChangedPathHandler ChangePachEvent;
        public event TextFileOpened TextFileOpenedEvent;
        public event ImageFileOpened ImageFileOpenedEvent;

        public string currentPath;
        private List<FileFolder> contentPath = new List<FileFolder>();

        public string getPath() {
            return this.currentPath;
        }

        public void setPath(string path) {
            this.currentPath = path;
            loadContentPath();

            //Lanzamos evento de cambio de path
            if (ChangePachEvent != null) {
                ChangePachEvent();
            }
        }

        public List<FileFolder> GetFileFolders {
            get{
                return contentPath;
            }
        }
         
        private void loadContentPath()
        {
            contentPath.Clear();
            String[] carpetas = System.IO.Directory.GetDirectories(this.currentPath);
            String[] archivos = Directory.GetFiles(this.currentPath);
            foreach (string carpeta in carpetas) {
                FileFolder fileFolder = new FileFolder(true, carpeta, Path.GetFileName(carpeta));
                this.contentPath.Add(fileFolder);
            }

            foreach (string archivo in archivos) {
                FileFolder fileFolder = new FileFolder(false, archivo, Path.GetFileName(archivo));
                this.contentPath.Add(fileFolder);
            }
        }

        public void gotoUp()
        {
            // obtenemos informacion del directorio padre.
            DirectoryInfo directoryInfo = Directory.GetParent(this.currentPath);
            this.setPath(directoryInfo.FullName);
        }

        public void OpenFile(string FileName) {
            string extension = Path.GetExtension(FileName);

            if (extension == ".txt") {
                string fileText = File.ReadAllText(Path.Combine(this.currentPath, FileName));
                if (TextFileOpenedEvent != null)
                {
                    TextFileOpenedEvent(fileText);
                }
            }
            else if (extension == ".jpg" || extension == ".png") {
                Image imagen = Image.FromFile(Path.Combine(this.currentPath, FileName));
                if (ImageFileOpenedEvent != null)
                {
                    ImageFileOpenedEvent(imagen);
                }
            }
               
        }
    }
}
