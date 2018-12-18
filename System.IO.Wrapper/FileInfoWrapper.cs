using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnotherSystem.IO.Wrapper
{
    public class FileInfoWrapper : FileInfoBase
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrapper(string fileName)
        {
            _fileInfo = new FileInfo(fileName);
        }

        public FileInfoWrapper(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }

        public override DirectoryInfoBase Directory => _fileInfo.Directory.ToWrapper();

        public override string DirectoryName => _fileInfo.DirectoryName;

        public override bool Exists => _fileInfo.Exists;
        
        public override bool IsReadOnly { get => _fileInfo.IsReadOnly; set => _fileInfo.IsReadOnly = value; }
        
        public override long Length => _fileInfo.Length;

        public override string Name => _fileInfo.Name;

        public override StreamWriter AppendText() => _fileInfo.AppendText();

        public override FileInfoBase CopyTo(string destFileName) => _fileInfo.CopyTo(destFileName).ToWrapper();

        public override FileInfoBase CopyTo(string destFileName, bool overwrite) =>
            _fileInfo.CopyTo(destFileName, overwrite).ToWrapper();
        
        public override FileStream Create() => _fileInfo.Create();
        
        public override StreamWriter CreateText() => _fileInfo.CreateText();
        
        public override void Delete() => _fileInfo.Delete();

        public override void Decrypt() => _fileInfo.Decrypt();
        
        public override void Encrypt() => _fileInfo.Encrypt();

        public override void MoveTo(string destFileName) => _fileInfo.MoveTo(destFileName);

        public override FileStream Open(FileMode mode) => _fileInfo.Open(mode);

        public override FileStream Open(FileMode mode, FileAccess access) => _fileInfo.Open(mode, access);

        public override FileStream Open(FileMode mode, FileAccess access, FileShare share) =>
            _fileInfo.Open(mode, access, share);

        public override FileStream OpenRead() => _fileInfo.OpenRead();

        public override StreamReader OpenText() => _fileInfo.OpenText();

        public override FileStream OpenWrite() => _fileInfo.OpenWrite();

        public override FileInfoBase Replace(string destinationFileName, string destinationBackupFileName) =>
            _fileInfo.Replace(destinationFileName, destinationBackupFileName).ToWrapper();

        public override FileInfoBase Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
            => _fileInfo.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors).ToWrapper();
        
        public override string ToString() => _fileInfo.ToString();
    }

    public static class FileInfoWrapperExtensions
    {
        public static FileInfoBase ToWrapper(this FileInfo f) => new FileInfoWrapper(f);
        public static FileInfoBase[] ToWrapper(this FileInfo[] fs) => fs.Select(x => new FileInfoWrapper(x)).ToArray();
        public static IEnumerable<FileInfoBase> ToWrapper(this IEnumerable<FileInfo> fs) => fs.Select(x => new FileInfoWrapper(x));
    }
}
