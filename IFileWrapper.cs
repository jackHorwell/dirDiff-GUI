namespace dirDiff_GUI {
    public interface IFileWrapper {
        bool Exists(string path);
        void Copy(string sourceFileName, string destFileName);
    }
}