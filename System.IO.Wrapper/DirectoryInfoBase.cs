using System.Collections.Generic;
using System.IO;


namespace AnotherSystem.IO.Wrapper
{
    /// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
    public abstract class DirectoryInfoBase
    {
        /// <summary>Gets a value indicating whether the directory exists.</summary>
        /// <returns>true if the directory exists; otherwise, false.</returns>
        public abstract bool Exists { get; }

        /// <summary>Gets the name of this <see cref="T:System.IO.DirectoryInfo"></see> instance.</summary>
        /// <returns>The directory name.</returns>
        public abstract string Name { get; }

        /// <summary>Gets the parent directory of a specified subdirectory.</summary>
        /// <returns>The parent directory, or null if the path is null or if the file path denotes a root (such as &amp;quot;\&amp;quot;, &amp;quot;C:&amp;quot;, or * &amp;quot;\\server\share&amp;quot;).</returns>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract DirectoryInfoBase Parent { get; }

        /// <summary>Gets the root portion of the directory.</summary>
        /// <returns>An object that represents the root of the directory.</returns>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract DirectoryInfoBase Root { get; }

        /// <summary>Creates a directory.</summary>
        /// <exception cref="T:System.IO.IOException">The directory cannot be created.</exception>
        public abstract void Create();

        /// <summary>Creates a subdirectory or subdirectories on the specified path. The specified path can be relative to this instance of the <see cref="T:System.IO.DirectoryInfo"></see> class.</summary>
        /// <param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name.</param>
        /// <returns>The last directory specified in <paramref name="path">path</paramref>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> does not specify a valid file path or contains invalid DirectoryInfo characters.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">The subdirectory cannot be created.
        /// -or-
        /// A file or directory already has the name specified by <paramref name="path">path</paramref>.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have code access permission to create the directory.
        /// -or-
        /// The caller does not have code access permission to read the directory described by the returned <see cref="System.IO.DirectoryInfo"></see> object.  This can occur when the <paramref name="path">path</paramref> parameter describes an existing directory.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> contains a colon character (:) that is not part of a drive label (&amp;quot;C:\&amp;quot;).</exception>
        public abstract DirectoryInfoBase CreateSubdirectory(string path);

        /// <summary>Deletes this <see cref="T:System.IO.DirectoryInfo"></see> if it is empty.</summary>
        /// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="System.IO.DirectoryInfo"></see> object does not exist or could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">The directory is not empty.
        /// -or-
        /// The directory is the application&amp;#39;s current working directory.
        /// -or-
        /// There is an open handle on the directory, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories. For more information, see How to: Enumerate Directories and Files.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract void Delete();

        /// <summary>Deletes this instance of a <see cref="T:System.IO.DirectoryInfo"></see>, specifying whether to delete subdirectories and files.</summary>
        /// <param name="recursive">true to delete this directory, its subdirectories, and all files; otherwise, false.</param>
        /// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="System.IO.DirectoryInfo"></see> object does not exist or could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">The directory is read-only.
        /// -or-
        /// The directory contains one or more files or subdirectories and <paramref name="recursive">recursive</paramref> is false.
        /// -or-
        /// The directory is the application&amp;#39;s current working directory.
        /// -or-
        /// There is an open handle on the directory or on one of its files, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract void Delete(bool recursive);

        /// <summary>Returns an enumerable collection of directory information in the current directory.</summary>
        /// <returns>An enumerable collection of directories in the current directory.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories();

        public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions);

        public abstract IEnumerable<DirectoryInfoBase> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns an enumerable collection of directory information that matches a specified search pattern.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An enumerable collection of directories that matches <paramref name="searchPattern">searchPattern</paramref>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern);

        /// <summary>Returns an enumerable collection of file information in the current directory.</summary>
        /// <returns>An enumerable collection of the files in the current directory.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<FileInfoBase> EnumerateFiles();

        /// <summary>Returns an enumerable collection of file information that matches a search pattern.</summary>
        /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An enumerable collection of files that matches <paramref name="searchPattern">searchPattern</paramref>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern);

        /// <summary>Returns an enumerable collection of file information that matches a specified search pattern and search subdirectory option.</summary>
        /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An enumerable collection of files that matches <paramref name="searchPattern">searchPattern</paramref> and <paramref name="searchOption">searchOption</paramref>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern, SearchOption searchOption);

        public abstract IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns an enumerable collection of file system information in the current directory.</summary>
        /// <returns>An enumerable collection of file system information in the current directory.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos();

        /// <summary>Returns an enumerable collection of file system information that matches a specified search pattern.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern">searchPattern</paramref>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern);

        /// <summary>Returns an enumerable collection of file system information that matches a specified search pattern and search subdirectory option.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern">searchPattern</paramref> and <paramref name="searchOption">searchOption</paramref>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);

        /// <summary>Returns an enumerable collection of directory information that matches a specified search pattern and search subdirectory option.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An enumerable collection of directories that matches <paramref name="searchPattern">searchPattern</paramref> and <paramref name="searchOption">searchOption</paramref>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern, SearchOption searchOption);

        /// <summary>Returns the subdirectories of the current directory.</summary>
        /// <returns>An array of <see cref="System.IO.DirectoryInfo"></see> objects.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="System.IO.DirectoryInfo"></see> object is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        public abstract DirectoryInfoBase[] GetDirectories();

        /// <summary>Returns an array of directories in the current <see cref="T:System.IO.DirectoryInfo"></see> matching the given search criteria.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An array of type DirectoryInfo matching <paramref name="searchPattern">searchPattern</paramref>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="searchPattern">searchPattern</paramref> contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the DirectoryInfo object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        public abstract DirectoryInfoBase[] GetDirectories(string searchPattern);

        /// <summary>Returns an array of directories in the current <see cref="T:System.IO.DirectoryInfo"></see> matching the given search criteria and using a value to determine whether to search subdirectories.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param>
        /// <returns>An array of type DirectoryInfo matching <paramref name="searchPattern">searchPattern</paramref>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="searchPattern">searchPattern</paramref> contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the DirectoryInfo object is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        public abstract DirectoryInfoBase[] GetDirectories(string searchPattern, SearchOption searchOption);

        public abstract DirectoryInfoBase[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns a file list from the current directory.</summary>
        /// <returns>An array of type <see cref="System.IO.FileInfo"></see>.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid, such as being on an unmapped drive.</exception>
        public abstract FileInfoBase[] GetFiles();

        /// <summary>Returns a file list from the current directory matching the given search pattern.</summary>
        /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An array of type <see cref="System.IO.FileInfo"></see>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="searchPattern">searchPattern</paramref> contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract FileInfoBase[] GetFiles(string searchPattern);

        /// <summary>Returns a file list from the current directory matching the given search pattern and using a value to determine whether to search subdirectories.</summary>
        /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param>
        /// <returns>An array of type <see cref="System.IO.FileInfo"></see>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="searchPattern">searchPattern</paramref> contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract FileInfoBase[] GetFiles(string searchPattern, SearchOption searchOption);

        public abstract FileInfoBase[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns an array of strongly typed <see cref="T:System.IO.FileSystemInfo"></see> entries representing all the files and subdirectories in a directory.</summary>
        /// <returns>An array of strongly typed <see cref="System.IO.FileSystemInfo"></see> entries.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive).</exception>
        public abstract FileSystemInfoBase[] GetFileSystemInfos();

        /// <summary>Retrieves an array of strongly typed <see cref="T:System.IO.FileSystemInfo"></see> objects representing the files and subdirectories that match the specified search criteria.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories and files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An array of strongly typed FileSystemInfo objects matching the search criteria.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="searchPattern">searchPattern</paramref> contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract FileSystemInfoBase[] GetFileSystemInfos(string searchPattern);

        /// <summary>Retrieves an array of <see cref="T:System.IO.FileSystemInfo"></see> objects that represent the files and subdirectories matching the specified search criteria.</summary>
        /// <param name="searchPattern">The search string to match against the names of directories and filesa.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An array of file system entries that match the search criteria.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="searchPattern">searchPattern</paramref> contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract FileSystemInfoBase[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);

        public abstract FileSystemInfoBase[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Moves a <see cref="T:System.IO.DirectoryInfo"></see> instance and its contents to a new path.</summary>
        /// <param name="destDirName">The name and path to which to move this directory. The destination cannot be another disk volume or a directory with the identical name. It can be an existing directory to which you want to add this directory as a subdirectory.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="destDirName">destDirName</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="destDirName">destDirName</paramref> is an empty string (&amp;#39;&amp;#39;&amp;quot;).</exception>
        /// <exception cref="T:System.IO.IOException">An attempt was made to move a directory to a different volume.
        /// -or-
        /// <paramref name="destDirName">destDirName</paramref> already exists.
        /// -or-
        /// You are not authorized to access this path.
        /// -or-
        /// The directory being moved and the destination directory have the same name.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The destination directory cannot be found.</exception>
        public abstract void MoveTo(string destDirName);

        /// <summary>Returns the original path that was passed by the user.</summary>
        /// <returns>Returns the original path that was passed by the user.</returns>
        public new abstract string ToString();
    }
}