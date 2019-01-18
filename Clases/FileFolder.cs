using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Archivos.Clases
{
    class FileFolder
    {
        public bool isFolder { get; set; }
        public string name { get; set; } //Nomvre unico del archivo
        public string fullName { get; set; } // Nombre completo + path

        public FileFolder(bool isFolder, string fullName, string name)
        {
            this.isFolder = isFolder;
            this.fullName = fullName;
            this.name = name;
        }

        


    }
}
