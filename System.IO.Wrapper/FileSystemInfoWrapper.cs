using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace AnotherSystem.IO.Wrapper
{
    public class FileSystemInfoWrapper : FileSystemInfoBase
    {
        private readonly FileSystemInfo _fileSystemInfo;

        public FileSystemInfoWrapper(FileSystemInfo fileSystemInfo)
        {
            _fileSystemInfo = fileSystemInfo;
        }
        
        public override FileAttributes Attributes { get => _fileSystemInfo.Attributes; set => _fileSystemInfo.Attributes = value; }
        
        public override DateTime CreationTime { get => _fileSystemInfo.CreationTime; set => _fileSystemInfo.CreationTime = value; }
        
        public override DateTime CreationTimeUtc { get => _fileSystemInfo.CreationTimeUtc; set => _fileSystemInfo.CreationTimeUtc = value; }
        
        public override bool Exists => _fileSystemInfo.Exists;
        
        public override string Extension => _fileSystemInfo.Extension;
        
        public override string FullName => _fileSystemInfo.FullName;
        
        public override void GetObjectData(SerializationInfo info, StreamingContext context) => _fileSystemInfo.GetObjectData(info, context);
        
        public override DateTime LastAccessTime { get => _fileSystemInfo.LastAccessTime; set => _fileSystemInfo.LastAccessTime = value; }

        public override DateTime LastAccessTimeUtc { get => _fileSystemInfo.LastAccessTimeUtc; set => _fileSystemInfo.LastAccessTimeUtc = value; }

        public override DateTime LastWriteTime { get => _fileSystemInfo.LastWriteTime; set => _fileSystemInfo.LastWriteTime = value; }

        public override DateTime LastWriteTimeUtc { get => _fileSystemInfo.LastWriteTimeUtc; set => _fileSystemInfo.LastWriteTimeUtc = value; }

        public override string Name => _fileSystemInfo.Name;

        public override void Delete() => _fileSystemInfo.Delete();
        
        public override void Refresh() => _fileSystemInfo.Refresh();
    }

    public static class FileSystemInfoWrapperExtensions
    {
        public static FileSystemInfoBase ToWrapper(this FileSystemInfo f) => new FileSystemInfoWrapper(f);
        public static FileSystemInfoBase[] ToWrapper(this FileSystemInfo[] fs) => fs.Select(x => new FileSystemInfoWrapper(x)).ToArray();
        public static IEnumerable<FileSystemInfoBase> ToWrapper(this IEnumerable<FileSystemInfo> fs) => fs.Select(x => new FileSystemInfoWrapper(x));
    }
}

