using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirDiff_GUI {
    public class FileWrapper: IFileWrapper {
        public bool Exists(string path) {
            return File.Exists(path);
        }

        public void Copy(string sourceFileName, string destFileName) {
            File.Copy(sourceFileName, destFileName);
        }
    }
}