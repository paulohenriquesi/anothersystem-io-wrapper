using System.IO;

namespace AnotherSystem.IO.Wrapper
{
    public abstract class FileInfoBase
    {
        /// <summary>Gets an instance of the parent directory.</summary>
        /// <returns>A <see cref="System.IO.DirectoryInfo"></see> object representing the parent directory of this file.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract DirectoryInfoBase Directory { get; }

        /// <summary>Gets a string representing the directory&amp;#39;s full path.</summary>
        /// <returns>A string representing the directory&amp;#39;s full path.</returns>
        /// <exception cref="T:System.ArgumentNullException">null was passed in for the directory name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The fully qualified path is 260 or more characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract string DirectoryName { get; }

        /// <summary>Gets a value indicating whether a file exists.</summary>
        /// <returns>true if the file exists; false if the file does not exist or if the file is a directory.</returns>
        public abstract bool Exists { get; }

        /// <summary>Gets or sets a value that determines if the current file is read only.</summary>
        /// <returns>true if the current file is read only; otherwise, false.</returns>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException">The user does not have write permission, but attempted to set this property to false.</exception>
        public abstract bool IsReadOnly { get; set; }

        /// <summary>Gets the size, in bytes, of the current file.</summary>
        /// <returns>The size of the current file in bytes.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot update the state of the file or directory.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file does not exist.
        /// -or-
        /// The Length property is called for a directory.</exception>
        public abstract long Length { get; }

        /// <summary>Gets the name of the file.</summary>
        /// <returns>The name of the file.</returns>
        public abstract string Name { get; }

        /// <summary>Gets the full path of the directory or file.</summary>
        /// <returns>A string containing the full path.</returns>
        public abstract string FullName { get; }

        /// <summary>Creates a <see cref="T:System.IO.StreamWriter"></see> that appends text to the file represented by this instance of the <see cref="T:System.IO.FileInfo"></see>.</summary>
        /// <returns>A new StreamWriter.</returns>
        public abstract StreamWriter AppendText();

        /// <summary>Copies an existing file to a new file, disallowing the overwriting of an existing file.</summary>
        /// <param name="destFileName">The name of the new file to copy to.</param>
        /// <returns>A new file with a fully qualified path.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="destFileName">destFileName</paramref> is empty, contains only white spaces, or contains invalid characters.</exception>
        /// <exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="destFileName">destFileName</paramref> is null.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName">destFileName</paramref> does not exist.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="destFileName">destFileName</paramref> contains a colon (:) within the string but does not specify the volume.</exception>
        public abstract FileInfoBase CopyTo(string destFileName);

        /// <summary>Copies an existing file to a new file, allowing the overwriting of an existing file.</summary>
        /// <param name="destFileName">The name of the new file to copy to.</param>
        /// <param name="overwrite">true to allow an existing file to be overwritten; otherwise, false.</param>
        /// <returns>A new file, or an overwrite of an existing file if <paramref name="overwrite">overwrite</paramref> is true. If the file exists and <paramref name="overwrite">overwrite</paramref> is false, an <see cref="System.IO.IOException"></see> is thrown.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="destFileName">destFileName</paramref> is empty, contains only white spaces, or contains invalid characters.</exception>
        /// <exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists and <paramref name="overwrite">overwrite</paramref> is false.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="destFileName">destFileName</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName">destFileName</paramref> does not exist.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="destFileName">destFileName</paramref> contains a colon (:) in the middle of the string.</exception>
        public abstract FileInfoBase CopyTo(string destFileName, bool overwrite);

        /// <summary>Creates a file.</summary>
        /// <returns>A new file.</returns>
        public abstract FileStream Create();

        /// <summary>Creates a <see cref="T:System.IO.StreamWriter"></see> that writes a new text file.</summary>
        /// <returns>A new StreamWriter.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The file name is a directory.</exception>
        /// <exception cref="T:System.IO.IOException">The disk is read-only.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract StreamWriter CreateText();

        /// <summary>Permanently deletes a file.</summary>
        /// <exception cref="T:System.IO.IOException">The target file is open or memory-mapped on a computer running Microsoft Windows NT.
        /// -or-
        /// There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The path is a directory.</exception>
        public abstract void Delete();

        /// <summary>Decrypts a file that was encrypted by the current account using the <see cref="M:System.IO.FileInfo.Encrypt"></see> method.</summary>
        /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The file described by the current <see cref="System.IO.FileInfo"></see> object is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// The caller does not have the required permission.</exception>
        public abstract void Decrypt();

        /// <summary>Encrypts a file so that only the account used to encrypt the file can decrypt it.</summary>
        /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The file described by the current <see cref="System.IO.FileInfo"></see> object is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// The caller does not have the required permission.</exception>
        public abstract void Encrypt();

        /// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
        /// <param name="destFileName">The path to move the file to, which can specify a different file name.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurs, such as the destination file already exists or the destination device is not ready.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="destFileName">destFileName</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="destFileName">destFileName</paramref> is empty, contains only white spaces, or contains invalid characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="destFileName">destFileName</paramref> is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file is not found.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="destFileName">destFileName</paramref> contains a colon (:) in the middle of the string.</exception>
        public abstract void MoveTo(string destFileName);

        /// <summary>Opens a file in the specified mode.</summary>
        /// <param name="mode">A <see cref="T:System.IO.FileMode"></see> constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <returns>A file opened in the specified mode, with read/write access and unshared.</returns>
        /// <exception cref="T:System.IO.FileNotFoundException">The file is not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The file is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">The file is already open.</exception>
        public abstract FileStream Open(FileMode mode);

        /// <summary>Opens a file in the specified mode with read, write, or read/write access.</summary>
        /// <param name="mode">A <see cref="T:System.IO.FileMode"></see> constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <param name="access">A <see cref="T:System.IO.FileAccess"></see> constant specifying whether to open the file with Read, Write, or ReadWrite file access.</param>
        /// <returns>A <see cref="System.IO.FileStream"></see> object opened in the specified mode and access, and unshared.</returns>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file is not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">The file is already open.</exception>
        public abstract FileStream Open(FileMode mode, FileAccess access);

        /// <summary>Opens a file in the specified mode with read, write, or read/write access and the specified sharing option.</summary>
        /// <param name="mode">A <see cref="T:System.IO.FileMode"></see> constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <param name="access">A <see cref="T:System.IO.FileAccess"></see> constant specifying whether to open the file with Read, Write, or ReadWrite file access.</param>
        /// <param name="share">A <see cref="T:System.IO.FileShare"></see> constant specifying the type of access other FileStream objects have to this file.</param>
        /// <returns>A <see cref="System.IO.FileStream"></see> object opened with the specified mode, access, and sharing options.</returns>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file is not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">The file is already open.</exception>
        public abstract FileStream Open(FileMode mode, FileAccess access, FileShare share);

        /// <summary>Creates a read-only <see cref="T:System.IO.FileStream"></see>.</summary>
        /// <returns>A new read-only <see cref="System.IO.FileStream"></see> object.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">The file is already open.</exception>
        public abstract FileStream OpenRead();

        /// <summary>Creates a <see cref="T:System.IO.StreamReader"></see> with UTF8 encoding that reads from an existing text file.</summary>
        /// <returns>A new StreamReader with UTF8 encoding.</returns>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file is not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        public abstract StreamReader OpenText();

        /// <summary>Creates a write-only <see cref="T:System.IO.FileStream"></see>.</summary>
        /// <returns>A write-only unshared <see cref="System.IO.FileStream"></see> object for a new or existing file.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The path specified when creating an instance of the <see cref="System.IO.FileInfo"></see> object is read-only or is a directory.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified when creating an instance of the <see cref="System.IO.FileInfo"></see> object is invalid, such as being on an unmapped drive.</exception>
        public abstract FileStream OpenWrite();

        /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo"></see> object, deleting the original file, and creating a backup of the replaced file.</summary>
        /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
        /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the destFileName parameter.</param>
        /// <returns>A <see cref="System.IO.FileInfo"></see> object that encapsulates information about the file described by the <paramref name="destFileName">destFileName</paramref> parameter.</returns>
        /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName">destFileName</paramref> parameter was not of a legal form.
        /// -or-
        /// The path described by the <paramref name="destBackupFileName">destBackupFileName</paramref> parameter was not of a legal form.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="destFileName">destFileName</paramref> parameter is null.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.
        /// -or-
        /// The file described by the <paramref name="destinationFileName">destinationFileName</paramref> parameter could not be found.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
        public abstract FileInfoBase Replace(string destinationFileName, string destinationBackupFileName);

        /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo"></see> object, deleting the original file, and creating a backup of the replaced file.  Also specifies whether to ignore merge errors.</summary>
        /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
        /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the destFileName parameter.</param>
        /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and ACLs) from the replaced file to the replacement file; otherwise false.</param>
        /// <returns>A <see cref="System.IO.FileInfo"></see> object that encapsulates information about the file described by the <paramref name="destFileName">destFileName</paramref> parameter.</returns>
        /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName">destFileName</paramref> parameter was not of a legal form.
        /// -or-
        /// The path described by the <paramref name="destBackupFileName">destBackupFileName</paramref> parameter was not of a legal form.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="destFileName">destFileName</paramref> parameter is null.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.
        /// -or-
        /// The file described by the <paramref name="destinationFileName">destinationFileName</paramref> parameter could not be found.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
        public abstract FileInfoBase Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

        /// <summary>Returns the path as a string.</summary>
        /// <returns>A string representing the path.</returns>
        public new abstract string ToString();
    }
}