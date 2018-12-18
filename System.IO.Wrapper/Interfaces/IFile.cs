using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Wrapper
{
    /// <summary>Provides methods for the creation, copying, deletion, moving, and opening of a single file, and aids in the creation of <see cref="T:System.IO.FileStream"></see> objects.</summary>
    public interface IFile
    {
        /// <summary>Appends lines to a file, and then closes the file. If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.</summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn&amp;#39;t already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path">path</paramref> or <paramref name="contents">contents</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path">path</paramref> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have permission to write to the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.</exception>
        void AppendAllLines(string path, IEnumerable<string> contents);

        /// <summary>Appends lines to a file by using a specified encoding, and then closes the file. If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.</summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn&amp;#39;t already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path">path</paramref>, <paramref name="contents">contents</paramref>, or <paramref name="encoding">encoding</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path">path</paramref> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Opens a file, appends the specified string to the file, and then closes the file. If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.</summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void AppendAllText(string path, string contents);

        /// <summary>Appends the specified string to the file, creating the file if it does not already exist.</summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void AppendAllText(string path, string contents, Encoding encoding);

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Creates a <see cref="T:System.IO.StreamWriter"></see> that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.</summary>
        /// <param name="path">The path to the file to append to.</param>
        /// <returns>A stream writer that appends UTF-8 encoded text to the specified file or to a new file.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, the directory doesn’t exist or it is on an unmapped drive).</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        StreamWriter AppendText(string path);

        /// <summary>Copies an existing file to a new file. Overwriting a file of the same name is not allowed.</summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file.</param>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.
        /// -or-
        /// <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> specifies a directory.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException"><paramref name="sourceFileName">sourceFileName</paramref> was not found.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="destFileName">destFileName</paramref> exists.
        /// -or-
        /// An I/O error has occurred.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is in an invalid format.</exception>
        void Copy(string sourceFileName, string destFileName);

        /// <summary>Copies an existing file to a new file. Overwriting a file of the same name is allowed.</summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory.</param>
        /// <param name="overwrite">true if the destination file can be overwritten; otherwise, false.</param>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.
        /// -or-
        /// <paramref name="destFileName">destFileName</paramref> is read-only.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.
        /// -or-
        /// <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> specifies a directory.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException"><paramref name="sourceFileName">sourceFileName</paramref> was not found.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="destFileName">destFileName</paramref> exists and <paramref name="overwrite">overwrite</paramref> is false.
        /// -or-
        /// An I/O error has occurred.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is in an invalid format.</exception>
        void Copy(string sourceFileName, string destFileName, bool overwrite);

        /// <summary>Creates or overwrites a file in the specified path.</summary>
        /// <param name="path">The path and name of the file to create.</param>
        /// <returns>A <see cref="System.IO.FileStream"></see> that provides read/write access to the file specified in <paramref name="path">path</paramref>.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.
        /// -or-
        /// <paramref name="path">path</paramref> specified a file that is read-only.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while creating the file.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream Create(string path);

        /// <summary>Creates or overwrites the specified file.</summary>
        /// <param name="path">The name of the file.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <returns>A <see cref="System.IO.FileStream"></see> with the specified buffer size that provides read/write access to the file specified in <paramref name="path">path</paramref>.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.
        /// -or-
        /// <paramref name="path">path</paramref> specified a file that is read-only.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while creating the file.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream Create(string path, int bufferSize);

        /// <summary>Creates or overwrites the specified file, specifying a buffer size and a <see cref="T:System.IO.FileOptions"></see> value that describes how to create or overwrite the file.</summary>
        /// <param name="path">The name of the file.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <param name="options">One of the <see cref="T:System.IO.FileOptions"></see> values that describes how to create or overwrite the file.</param>
        /// <returns>A new file with the specified buffer size.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.
        /// -or-
        /// <paramref name="path">path</paramref> specified a file that is read-only.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while creating the file.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream Create(string path, int bufferSize, FileOptions options);

        /// <summary>Creates or opens a file for writing UTF-8 encoded text. If the file already exists, its contents are overwritten.</summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>A <see cref="System.IO.StreamWriter"></see> that writes to the specified file using UTF-8 encoding.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        StreamWriter CreateText(string path);

        /// <summary>Deletes the specified file.</summary>
        /// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">The specified file is in use.
        /// -or-
        /// There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.
        /// -or-
        /// The file is an executable file that is in use.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.
        /// -or-
        /// <paramref name="path">path</paramref> specified a read-only file.</exception>
        void Delete(string path);

        /// <summary>Decrypts a file that was encrypted by the current account using the <see cref="M:System.IO.File.Encrypt(System.String)"></see> method.</summary>
        /// <param name="path">A path that describes a file to decrypt.</param>
        /// <exception cref="T:System.ArgumentException">The <paramref name="path">path</paramref> parameter is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="path">path</paramref> parameter is null.</exception>
        /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the <paramref name="path">path</paramref> parameter could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file. For example, the encrypted file is already open.
        /// -or-
        /// This operation is not supported on the current platform.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="path">path</paramref> parameter specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// The <paramref name="path">path</paramref> parameter specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void Decrypt(string path);

        /// <summary>Encrypts a file so that only the account used to encrypt the file can decrypt it.</summary>
        /// <param name="path">A path that describes a file to encrypt.</param>
        /// <exception cref="T:System.ArgumentException">The <paramref name="path">path</paramref> parameter is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="path">path</paramref> parameter is null.</exception>
        /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the <paramref name="path">path</paramref> parameter could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.
        /// -or-
        /// This operation is not supported on the current platform.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="path">path</paramref> parameter specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// The <paramref name="path">path</paramref> parameter specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void Encrypt(string path);

        /// <summary>Determines whether the specified file exists.</summary>
        /// <param name="path">The file to check.</param>
        /// <returns>true if the caller has the required permissions and <paramref name="path">path</paramref> contains the name of an existing file; otherwise, false. This method also returns false if <paramref name="path">path</paramref> is null, an invalid path, or a zero-length string. If the caller does not have sufficient permissions to read the specified file, no exception is thrown and the method returns false regardless of the existence of <paramref name="path">path</paramref>.</returns>
        bool Exists(string path);

        /// <summary>Gets the <see cref="T:System.IO.FileAttributes"></see> of the file on the path.</summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>The <see cref="System.IO.FileAttributes"></see> of the file on the path.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is empty, contains only white spaces, or contains invalid characters.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException"><paramref name="path">path</paramref> represents a file and is invalid, such as being on an unmapped drive, or the file cannot be found.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> represents a directory and is invalid, such as being on an unmapped drive, or the directory cannot be found.</exception>
        /// <exception cref="T:System.IO.IOException">This file is being used by another process.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        FileAttributes GetAttributes(string path);

        /// <summary>Returns the creation date and time of the specified file or directory.</summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A <see cref="System.DateTime"></see> structure set to the creation date and time for the specified file or directory. This value is expressed in local time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        DateTime GetCreationTime(string path);

        /// <summary>Returns the creation date and time, in coordinated universal time (UTC), of the specified file or directory.</summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A <see cref="System.DateTime"></see> structure set to the creation date and time for the specified file or directory. This value is expressed in UTC time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        DateTime GetCreationTimeUtc(string path);

        /// <summary>Returns the date and time the specified file or directory was last accessed.</summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A <see cref="System.DateTime"></see> structure set to the date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        DateTime GetLastAccessTime(string path);

        /// <summary>Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last accessed.</summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A <see cref="System.DateTime"></see> structure set to the date and time that the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        DateTime GetLastAccessTimeUtc(string path);

        /// <summary>Returns the date and time the specified file or directory was last written to.</summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A <see cref="System.DateTime"></see> structure set to the date and time that the specified file or directory was last written to. This value is expressed in local time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        DateTime GetLastWriteTime(string path);

        /// <summary>Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last written to.</summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A <see cref="System.DateTime"></see> structure set to the date and time that the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        DateTime GetLastWriteTimeUtc(string path);

        /// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
        /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
        /// <param name="destFileName">The new path and name for the file.</param>
        /// <exception cref="T:System.IO.IOException">The destination file already exists.
        /// -or-
        /// <paramref name="sourceFileName">sourceFileName</paramref> was not found.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is a zero-length string, contains only white space, or contains invalid characters as defined in <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified in <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destFileName">destFileName</paramref> is in an invalid format.</exception>
        void Move(string sourceFileName, string destFileName);

        /// <summary>Opens a <see cref="T:System.IO.FileStream"></see> on the specified path with read/write access.</summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A <see cref="T:System.IO.FileMode"></see> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <returns>A <see cref="System.IO.FileStream"></see> opened in the specified mode and path, with read/write access and not shared.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.
        /// -or-
        /// <paramref name="mode">mode</paramref> is <see cref="System.IO.FileMode.Create"></see> and the specified file is a hidden file.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="mode">mode</paramref> specified an invalid value.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream Open(string path, FileMode mode);

        /// <summary>Opens a <see cref="T:System.IO.FileStream"></see> on the specified path, with the specified mode and access.</summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A <see cref="T:System.IO.FileMode"></see> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A <see cref="T:System.IO.FileAccess"></see> value that specifies the operations that can be performed on the file.</param>
        /// <returns>An unshared <see cref="System.IO.FileStream"></see> that provides access to the specified file, with the specified mode and access.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.
        /// -or-
        /// <paramref name="access">access</paramref> specified Read and <paramref name="mode">mode</paramref> specified Create, CreateNew, Truncate, or Append.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only and <paramref name="access">access</paramref> is not Read.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.
        /// -or-
        /// <paramref name="mode">mode</paramref> is <see cref="System.IO.FileMode.Create"></see> and the specified file is a hidden file.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="mode">mode</paramref> or <paramref name="access">access</paramref> specified an invalid value.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream Open(string path, FileMode mode, FileAccess access);

        /// <summary>Opens a <see cref="T:System.IO.FileStream"></see> on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A <see cref="T:System.IO.FileMode"></see> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A <see cref="T:System.IO.FileAccess"></see> value that specifies the operations that can be performed on the file.</param>
        /// <param name="share">A <see cref="T:System.IO.FileShare"></see> value specifying the type of access other threads have to the file.</param>
        /// <returns>A <see cref="System.IO.FileStream"></see> on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.
        /// -or-
        /// <paramref name="access">access</paramref> specified Read and <paramref name="mode">mode</paramref> specified Create, CreateNew, Truncate, or Append.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only and <paramref name="access">access</paramref> is not Read.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.
        /// -or-
        /// <paramref name="mode">mode</paramref> is <see cref="System.IO.FileMode.Create"></see> and the specified file is a hidden file.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="mode">mode</paramref>, <paramref name="access">access</paramref>, or <paramref name="share">share</paramref> specified an invalid value.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);

        /// <summary>Opens an existing file for reading.</summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A read-only <see cref="System.IO.FileStream"></see> on the specified path.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        FileStream OpenRead(string path);

        /// <summary>Opens an existing UTF-8 encoded text file for reading.</summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A <see cref="System.IO.StreamReader"></see> on the specified path.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        StreamReader OpenText(string path);

        /// <summary>Opens an existing file or creates a new file for writing.</summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>An unshared <see cref="System.IO.FileStream"></see> object on the specified path with <see cref="System.IO.FileAccess.Write"></see> access.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.
        /// -or-
        /// <paramref name="path">path</paramref> specified a read-only file or directory.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        FileStream OpenWrite(string path);

        /// <summary>Opens a binary file, reads the contents of the file into a byte array, and then closes the file.</summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A byte array containing the contents of the file.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        byte[] ReadAllBytes(string path);

        /// <param name="path"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Opens a text file, reads all lines of the file, and then closes the file.</summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        string[] ReadAllLines(string path);

        /// <summary>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        string[] ReadAllLines(string path, Encoding encoding);

        /// <param name="path"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Opens a text file, reads all lines of the file, and then closes the file.</summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string containing all lines of the file.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        string ReadAllText(string path);

        /// <summary>Opens a file, reads all lines of the file with the specified encoding, and then closes the file.</summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns>A string containing all lines of the file.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified in <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        string ReadAllText(string path, Encoding encoding);

        /// <param name="path"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Reads the lines of a file.</summary>
        /// <param name="path">The file to read.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path">path</paramref> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        IEnumerable<string> ReadLines(string path);

        /// <summary>Read the lines of a file that has a specified encoding.</summary>
        /// <param name="path">The file to read.</param>
        /// <param name="encoding">The encoding that is applied to the contents of the file.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified by <paramref name="path">path</paramref> was not found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path">path</paramref> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        IEnumerable<string> ReadLines(string path, Encoding encoding);

        /// <summary>Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file.</summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destinationFileName">destinationFileName</paramref> parameter was not of a legal form.
        /// -or-
        /// The path described by the <paramref name="destinationBackupFileName">destinationBackupFileName</paramref> parameter was not of a legal form.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationFileName">destinationFileName</paramref> parameter is null.</exception>
        /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.
        /// -or-
        /// The file described by the <paramref name="destinationBackupFileName">destinationBackupFileName</paramref> parameter could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.
        /// - or -
        /// The <paramref name="sourceFileName">sourceFileName</paramref> and <paramref name="destinationFileName">destinationFileName</paramref> parameters specify the same file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The operating system is Windows 98 Second Edition or earlier and the files system is not NTFS.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destinationFileName">destinationFileName</paramref> parameter specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// Source or destination parameters specify a directory instead of a file.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);

        /// <summary>Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file and optionally ignores merge errors.</summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and access control lists (ACLs)) from the replaced file to the replacement file; otherwise, false.</param>
        /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destinationFileName">destinationFileName</paramref> parameter was not of a legal form.
        /// -or-
        /// The path described by the <paramref name="destinationBackupFileName">destinationBackupFileName</paramref> parameter was not of a legal form.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationFileName">destinationFileName</paramref> parameter is null.</exception>
        /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="System.IO.FileInfo"></see> object could not be found.
        /// -or-
        /// The file described by the <paramref name="destinationBackupFileName">destinationBackupFileName</paramref> parameter could not be found.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.
        /// - or -
        /// The <paramref name="sourceFileName">sourceFileName</paramref> and <paramref name="destinationFileName">destinationFileName</paramref> parameters specify the same file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The operating system is Windows 98 Second Edition or earlier and the files system is not NTFS.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="sourceFileName">sourceFileName</paramref> or <paramref name="destinationFileName">destinationFileName</paramref> parameter specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// Source or destination parameters specify a directory instead of a file.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

        /// <summary>Sets the specified <see cref="T:System.IO.FileAttributes"></see> of the file on the specified path.</summary>
        /// <param name="path">The path to the file.</param>
        /// <param name="fileAttributes">A bitwise combination of the enumeration values.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is empty, contains only white spaces, contains invalid characters, or the file attribute is invalid.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void SetAttributes(string path, FileAttributes fileAttributes);

        /// <summary>Sets the date and time the file was created.</summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTime">A <see cref="T:System.DateTime"></see> containing the value to set for the creation date and time of path. This value is expressed in local time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while performing the operation.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="creationTime">creationTime</paramref> specifies a value outside the range of dates, times, or both permitted for this operation.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        void SetCreationTime(string path, DateTime creationTime);

        /// <summary>Sets the date and time, in coordinated universal time (UTC), that the file was created.</summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTimeUtc">A <see cref="T:System.DateTime"></see> containing the value to set for the creation date and time of path. This value is expressed in UTC time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while performing the operation.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="creationTime">creationTime</paramref> specifies a value outside the range of dates, times, or both permitted for this operation.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);

        /// <summary>Sets the date and time the specified file was last accessed.</summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTime">A <see cref="T:System.DateTime"></see> containing the value to set for the last access date and time of path. This value is expressed in local time.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastAccessTime">lastAccessTime</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastAccessTime(string path, DateTime lastAccessTime);

        /// <summary>Sets the date and time, in coordinated universal time (UTC), that the specified file was last accessed.</summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">A <see cref="T:System.DateTime"></see> containing the value to set for the last access date and time of path. This value is expressed in UTC time.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastAccessTimeUtc">lastAccessTimeUtc</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);

        /// <summary>Sets the date and time that the specified file was last written to.</summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTime">A <see cref="T:System.DateTime"></see> containing the value to set for the last write date and time of path. This value is expressed in local time.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastWriteTime">lastWriteTime</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastWriteTime(string path, DateTime lastWriteTime);

        /// <summary>Sets the date and time, in coordinated universal time (UTC), that the specified file was last written to.</summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTimeUtc">A <see cref="T:System.DateTime"></see> containing the value to set for the last write date and time of path. This value is expressed in UTC time.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastWriteTimeUtc">lastWriteTimeUtc</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);

        /// <summary>Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="bytes">The bytes to write to the file.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null or the byte array is empty.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void WriteAllBytes(string path, byte[] bytes);

        /// <param name="path"></param>
        /// <param name="bytes"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Creates a new file, write the specified string array to the file, and then closes the file.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string array to write to the file.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path">path</paramref> or <paramref name="contents">contents</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void WriteAllLines(string path, string[] contents);

        /// <summary>Creates a new file, writes a collection of strings to the file, and then closes the file.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The lines to write to the file.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path">path</paramref> or <paramref name="contents">contents</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path">path</paramref> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void WriteAllLines(string path, IEnumerable<string> contents);

        /// <summary>Creates a new file, writes the specified string array to the file by using the specified encoding, and then closes the file.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string array to write to the file.</param>
        /// <param name="encoding">An <see cref="T:System.Text.Encoding"></see> object that represents the character encoding applied to the string array.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path">path</paramref> or <paramref name="contents">contents</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void WriteAllLines(string path, string[] contents, Encoding encoding);

        /// <summary>Creates a new file by using the specified encoding, writes a collection of strings to the file, and then closes the file.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The lines to write to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException">Either <paramref name="path">path</paramref>, <paramref name="contents">contents</paramref>, or <paramref name="encoding">encoding</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path">path</paramref> exceeds the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specifies a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> is a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string to write to the file.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null or <paramref name="contents">contents</paramref> is empty.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void WriteAllText(string path, string contents);

        /// <summary>Creates a new file, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.</summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string to write to the file.</param>
        /// <param name="encoding">The encoding to apply to the string.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="System.IO.Path.InvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null or <paramref name="contents">contents</paramref> is empty.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path">path</paramref> specified a file that is read-only.
        /// -or-
        /// This operation is not supported on the current platform.
        /// -or-
        /// <paramref name="path">path</paramref> specified a directory.
        /// -or-
        /// The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> is in an invalid format.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        void WriteAllText(string path, string contents, Encoding encoding);

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="encoding"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));
    }
}