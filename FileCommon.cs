using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dirDiff_GUI {
    public class FileCommon {
        IFileWrapper fileWrapper;

        public FileCommon(IFileWrapper fileWrapper) {
            this.fileWrapper = fileWrapper;
        }

        internal void ExistsAndCopy(string file, string moveTo, string folder1) {
            // Checks that the file does not already exists
            // Passes directory location then concatenates the file name onto it
            // Also passes target directory and concatenates file name
            if (!fileWrapper.Exists($"{moveTo}\\{file}")) {
                fileWrapper.Copy($"{folder1}\\{file}", $"{moveTo}\\{file}");
            }
        }
    }
}
