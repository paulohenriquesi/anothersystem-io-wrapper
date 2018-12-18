using System.Collections.Generic;
using System.Linq;

namespace System.IO.Wrapper
{
    public class DirectoryInfoWrapper : DirectoryInfoBase
    {
        private readonly DirectoryInfo _directory;

        public DirectoryInfoWrapper(DirectoryInfo directoryInfo)
        {
            _directory = directoryInfo;
        }
        public override bool Exists => _directory.Exists;

        public override string Name => _directory.Name;

        public override DirectoryInfoBase Parent => _directory.Parent.ToWrapper();

        public override DirectoryInfoBase Root => _directory.Root.ToWrapper();

        public override void Create() => _directory.Create();

        public override DirectoryInfoBase CreateSubdirectory(string path) =>
            _directory.CreateSubdirectory(path).ToWrapper();

        public override void Delete() => _directory.Delete();

        public override void Delete(bool recursive) => _directory.Delete(recursive);

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories() =>
            _directory.EnumerateDirectories().ToWrapper();

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions) =>
            _directory.EnumerateDirectories(searchPattern, enumerationOptions).ToWrapper();

        public override IEnumerable<DirectoryInfoBase> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions) =>
            _directory.EnumerateDirectories(searchPattern, enumerationOptions).ToWrapper();

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern) =>
            _directory.EnumerateDirectories(searchPattern).ToWrapper();

        public override IEnumerable<FileInfoBase> EnumerateFiles() => _directory.EnumerateFiles().ToWrapper();

        public override IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern) =>
            _directory.EnumerateFiles(searchPattern).ToWrapper();

        public override IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern, SearchOption searchOption) =>
            _directory.EnumerateFiles(searchPattern, searchOption).ToWrapper();

        public override IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern,
            EnumerationOptions enumerationOptions) =>
            _directory.EnumerateFiles(searchPattern, enumerationOptions).ToWrapper();

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos() => 
            _directory.EnumerateFileSystemInfos().ToWrapper();

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern) =>
            _directory.EnumerateFileSystemInfos(searchPattern).ToWrapper();

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption) =>
            _directory.EnumerateFileSystemInfos(searchPattern, searchOption).ToWrapper();

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern, SearchOption searchOption) 
            => _directory.EnumerateDirectories(searchPattern, searchOption).ToWrapper();

        public override DirectoryInfoBase[] GetDirectories() => _directory.GetDirectories().ToWrapper();

        public override DirectoryInfoBase[] GetDirectories(string searchPattern) => 
            _directory.GetDirectories(searchPattern).ToWrapper();

        public override DirectoryInfoBase[] GetDirectories(string searchPattern, SearchOption searchOption) =>
            _directory.GetDirectories(searchPattern, searchOption).ToWrapper();

        public override DirectoryInfoBase[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions) => 
            _directory.GetDirectories(searchPattern, enumerationOptions).ToWrapper();

        public override FileInfoBase[] GetFiles() => _directory.GetFiles().ToWrapper();

        public override FileInfoBase[] GetFiles(string searchPattern) => _directory.GetFiles(searchPattern).ToWrapper();

        public override FileInfoBase[] GetFiles(string searchPattern, SearchOption searchOption) =>
            _directory.GetFiles(searchPattern, searchOption).ToWrapper();

        public override FileInfoBase[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions) =>
            _directory.GetFiles(searchPattern, enumerationOptions).ToWrapper();

        public override FileSystemInfoBase[] GetFileSystemInfos() =>
            _directory.GetFileSystemInfos().ToWrapper();

        public override FileSystemInfoBase[] GetFileSystemInfos(string searchPattern) =>
            _directory.GetFileSystemInfos(searchPattern).ToWrapper();

        public override FileSystemInfoBase[] GetFileSystemInfos(string searchPattern, SearchOption searchOption) =>
            _directory.GetFileSystemInfos(searchPattern, searchOption).ToWrapper();

        public override FileSystemInfoBase[] GetFileSystemInfos(string searchPattern,
            EnumerationOptions enumerationOptions) =>
            _directory.GetFileSystemInfos(searchPattern, enumerationOptions).ToWrapper();

        public override void MoveTo(string destDirName) => _directory.MoveTo(destDirName);

        public override string ToString() => _directory.ToString();
    }

    public static class DirectoryInfoWrapperExtensions
    {
        public static DirectoryInfoBase ToWrapper(this DirectoryInfo f) => new DirectoryInfoWrapper(f);
        public static DirectoryInfoBase[] ToWrapper(this DirectoryInfo[] fs) => fs.Select(x => new DirectoryInfoWrapper(x)).ToArray();
        public static IEnumerable<DirectoryInfoBase> ToWrapper(this IEnumerable<DirectoryInfo> fs) => fs.Select(x => new DirectoryInfoWrapper(x));
    }
}