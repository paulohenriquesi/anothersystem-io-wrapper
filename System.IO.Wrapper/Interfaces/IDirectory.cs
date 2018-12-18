using System;
using System.Collections.Generic;
using System.IO;

namespace AnotherSystem.IO.Wrapper
{
    /// <summary>Exposes static methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
    public interface IDirectory
    {
        /// <summary>Creates all directories and subdirectories in the specified path unless they already exist.</summary>
        /// <param name="path">The directory to create.</param>
        /// <returns>An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.</returns>
        /// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path">path</paramref> is a file.
        /// -or-
        /// The network name is not known.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// -or-
        /// <paramref name="path">path</paramref> is prefixed with, or contains, only a colon character (:).</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.NotSupportedException"><paramref name="path">path</paramref> contains a colon character (:) that is not part of a drive label (&amp;quot;C:\&amp;quot;).</exception>
        DirectoryInfoBase CreateDirectory(string path);

        /// <summary>Deletes an empty directory from a specified path.</summary>
        /// <param name="path">The name of the empty directory to remove. This directory must be writable and empty.</param>
        /// <exception cref="T:System.IO.IOException">A file with the same name and location specified by <paramref name="path">path</paramref> exists.
        /// -or-
        /// The directory is the application&amp;#39;s current working directory.
        /// -or-
        /// The directory specified by <paramref name="path">path</paramref> is not empty.
        /// -or-
        /// The directory is read-only or contains a read-only file.
        /// -or-
        /// The directory is being used by another process.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> does not exist or could not be found.
        /// -or-
        /// The specified path is invalid (for example, it is on an unmapped drive).</exception>
        void Delete(string path);

        /// <summary>Deletes the specified directory and, if indicated, any subdirectories and files in the directory.</summary>
        /// <param name="path">The name of the directory to remove.</param>
        /// <param name="recursive">true to remove directories, subdirectories, and files in path; otherwise, false.</param>
        /// <exception cref="T:System.IO.IOException">A file with the same name and location specified by <paramref name="path">path</paramref> exists.
        /// -or-
        /// The directory specified by <paramref name="path">path</paramref> is read-only, or <paramref name="recursive">recursive</paramref> is false and <paramref name="path">path</paramref> is not an empty directory.
        /// -or-
        /// The directory is the application&amp;#39;s current working directory.
        /// -or-
        /// The directory contains a read-only file.
        /// -or-
        /// The directory is being used by another process.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> does not exist or could not be found.
        /// -or-
        /// The specified path is invalid (for example, it is on an unmapped drive).</exception>
        void Delete(string path, bool recursive);

        /// <summary>Returns an enumerable collection of directory names in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by <paramref name="path">path</paramref>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateDirectories(string path);

        /// <summary>Returns an enumerable collection of directory names that match a search pattern in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of directories in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by <paramref name="path">path</paramref> and that match the specified search pattern.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);

        /// <summary>Returns an enumerable collection of directory names that match a search pattern in a specified path, and optionally searches subdirectories.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of directories in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.
        /// The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by <paramref name="path">path</paramref> and that match the specified search pattern and option.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);

        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns an enumerable collection of file names in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by <paramref name="path">path</paramref>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateFiles(string path);

        /// <summary>Returns an enumerable collection of file names that match a search pattern in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by <paramref name="path">path</paramref> and that match the specified search pattern.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);

        /// <summary>Returns an enumerable collection of file names that match a search pattern in a specified path, and optionally searches subdirectories.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.
        /// The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by <paramref name="path">path</paramref> and that match the specified search pattern and option.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);

        IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns an enumerable collection of file names and directory names in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by <paramref name="path">path</paramref>.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateFileSystemEntries(string path);

        /// <summary>Returns an enumerable collection of file names and directory names that  match a search pattern in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of file-system entries in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by <paramref name="path">path</paramref> and that match the specified search pattern.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);

        /// <summary>Returns an enumerable collection of file names and directory names that match a search pattern in a specified path, and optionally searches subdirectories.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against file-system entries in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values  that specifies whether the search operation should include only the current directory or should include all subdirectories.
        /// The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by <paramref name="path">path</paramref> and that match the specified search pattern and option.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);

        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Determines whether the given path refers to an existing directory on disk.</summary>
        /// <param name="path">The path to test.</param>
        /// <returns>true if <paramref name="path">path</paramref> refers to an existing directory; false if the directory does not exist or an error occurs when trying to determine if the specified directory exists.</returns>
        bool Exists(string path);

        /// <summary>Gets the creation date and time of a directory.</summary>
        /// <param name="path">The path of the directory.</param>
        /// <returns>A structure that is set to the creation date and time for the specified directory. This value is expressed in local time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        DateTime GetCreationTime(string path);

        /// <summary>Gets the creation date and time, in Coordinated Universal Time (UTC) format, of a directory.</summary>
        /// <param name="path">The path of the directory.</param>
        /// <returns>A structure that is set to the creation date and time for the specified directory. This value is expressed in UTC time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        DateTime GetCreationTimeUtc(string path);

        /// <summary>Gets the current working directory of the application.</summary>
        /// <returns>A string that contains the path of the current working directory, and does not end with a backslash (\).</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.NotSupportedException">The operating system is Windows CE, which does not have current directory functionality.
        /// This method is available in the .NET Compact Framework, but is not currently supported.</exception>
        string GetCurrentDirectory();

        /// <summary>Returns the names of subdirectories (including their paths) in the specified directory.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An array of the full names (including paths) of subdirectories in the specified path, or an empty array if no directories are found.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetDirectories(string path);

        /// <summary>Returns the names of subdirectories (including their paths) that match the specified search pattern in the specified directory.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of subdirectories in path. This parameter can contain a combination of valid literal and wildcard characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An array of the full names (including paths) of the subdirectories that match the search pattern in the specified directory, or an empty array if no directories are found.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using <see cref="System.IO.Path.GetInvalidPathChars"></see>.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> doesn&amp;#39;t contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> or <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetDirectories(string path, string searchPattern);

        /// <summary>Returns the names of the subdirectories (including their paths) that match the specified search pattern in the specified directory, and optionally searches subdirectories.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of subdirectories in path. This parameter can contain a combination of valid literal and wildcard characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
        /// <returns>An array of the full names (including paths) of the subdirectories that match the specified criteria, or an empty array if no directories are found.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> or <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);

        string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns the volume information, root information, or both for the specified path.</summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>A string that contains the volume information, root information, or both for the specified path.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with <see cref="System.IO.Path.GetInvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        string GetDirectoryRoot(string path);

        /// <summary>Returns the names of files (including their paths) in the specified directory.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An array of the full names (including paths) for the files in the specified directory, or an empty array if no files are found.</returns>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.
        /// -or-
        /// A network error has occurred.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetFiles(string path);

        /// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern, or an empty array if no files are found.</returns>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.
        /// -or-
        /// A network error has occurred.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using <see cref="System.IO.Path.GetInvalidPathChars"></see>.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> doesn&amp;#39;t contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> or <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetFiles(string path, string searchPattern);

        /// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory, using a value to determine whether to search subdirectories.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
        /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern and option, or an empty array if no files are found.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> or <paramref name="searchpattern">searchpattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.
        /// -or-
        /// A network error has occurred.</exception>
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);

        string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns the names of all files and subdirectories in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An array of the names of files and subdirectories in the specified directory, or an empty array if no files or subdirectories are found.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with <see cref="System.IO.Path.GetInvalidPathChars"></see>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetFileSystemEntries(string path);

        /// <summary>Returns an array of file names and directory names that that match a search pattern in a specified path.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of file and directories in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <returns>An array of file names and directory names that match the specified search criteria, or an empty array if no files or directories are found.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> or <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        string[] GetFileSystemEntries(string path, string searchPattern);

        /// <summary>Returns an array of all the file names and directory names that match a search pattern in a specified path, and optionally searches subdirectories.</summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files and directories in path.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn&amp;#39;t support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.
        /// The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"></see>.</param>
        /// <returns>An array of file the file names and directory names that match the specified search criteria, or an empty array if no files or directories are found.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.
        /// - or -
        /// <paramref name="searchPattern">searchPattern</paramref> does not contain a valid pattern.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.
        /// -or-
        /// <paramref name="searchPattern">searchPattern</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption">searchOption</paramref> is not a valid <see cref="System.IO.SearchOption"></see> value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="path">path</paramref> is invalid, such as referring to an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path">path</paramref> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);

        string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>Returns the date and time the specified file or directory was last accessed.</summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last accessed. This value is expressed in local time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException">The <paramref name="path">path</paramref> parameter is in an invalid format.</exception>
        DateTime GetLastAccessTime(string path);

        /// <summary>Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.</summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.NotSupportedException">The <paramref name="path">path</paramref> parameter is in an invalid format.</exception>
        DateTime GetLastAccessTimeUtc(string path);

        /// <summary>Returns the date and time the specified file or directory was last written to.</summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last written to. This value is expressed in local time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        DateTime GetLastWriteTime(string path);

        /// <summary>Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last written to.</summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        DateTime GetLastWriteTimeUtc(string path);

        /// <summary>Retrieves the names of the logical drives on this computer in the form &amp;quot;&amp;lt;drive letter&amp;gt;:\&amp;quot;.</summary>
        /// <returns>The logical drives on this computer.</returns>
        /// <exception cref="T:System.IO.IOException">An I/O error occured (for example, a disk error).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        string[] GetLogicalDrives();

        /// <summary>Retrieves the parent directory of the specified path, including both absolute and relative paths.</summary>
        /// <param name="path">The path for which to retrieve the parent directory.</param>
        /// <returns>The parent directory, or null if <paramref name="path">path</paramref> is the root directory, including the root of a UNC server or share name.</returns>
        /// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path">path</paramref> is read-only.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path was not found.</exception>
        DirectoryInfoBase GetParent(string path);

        /// <summary>Moves a file or a directory and its contents to a new location.</summary>
        /// <param name="sourceDirName">The path of the file or directory to move.</param>
        /// <param name="destDirName">The path to the new location for sourceDirName. If sourceDirName is a file, then destDirName must also be a file name.</param>
        /// <exception cref="T:System.IO.IOException">An attempt was made to move a directory to a different volume.
        /// -or-
        /// <paramref name="destDirName">destDirName</paramref> already exists.
        /// -or-
        /// The <paramref name="sourceDirName">sourceDirName</paramref> and <paramref name="destDirName">destDirName</paramref> parameters refer to the same file or directory.
        /// -or-
        /// The directory or a file within it is being used by another process.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="sourceDirName">sourceDirName</paramref> or <paramref name="destDirName">destDirName</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="sourceDirName">sourceDirName</paramref> or <paramref name="destDirName">destDirName</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified by <paramref name="sourceDirName">sourceDirName</paramref> is invalid (for example, it is on an unmapped drive).</exception>
        void Move(string sourceDirName, string destDirName);

        /// <summary>Sets the creation date and time for the specified file or directory.</summary>
        /// <param name="path">The file or directory for which to set the creation date and time information.</param>
        /// <param name="creationTime">The date and time the file or directory was last written to. This value is expressed in local time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="creationTime">creationTime</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        void SetCreationTime(string path, DateTime creationTime);

        /// <summary>Sets the creation date and time, in Coordinated Universal Time (UTC) format, for the specified file or directory.</summary>
        /// <param name="path">The file or directory for which to set the creation date and time information.</param>
        /// <param name="creationTimeUtc">The date and time the directory or file was created. This value is expressed in local time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="creationTime">creationTime</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);

        /// <summary>Sets the application&amp;#39;s current working directory to the specified directory.</summary>
        /// <param name="path">The path to which the current working directory is set.</param>
        /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to access unmanaged code.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified directory was not found.</exception>
        void SetCurrentDirectory(string path);

        /// <summary>Sets the date and time the specified file or directory was last accessed.</summary>
        /// <param name="path">The file or directory for which to set the access date and time information.</param>
        /// <param name="lastAccessTime">An object that contains the value to set for the access date and time of path. This value is expressed in local time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastAccessTime">lastAccessTime</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastAccessTime(string path, DateTime lastAccessTime);

        /// <summary>Sets the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.</summary>
        /// <param name="path">The file or directory for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">An object that  contains the value to set for the access date and time of path. This value is expressed in UTC time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastAccessTimeUtc">lastAccessTimeUtc</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);

        /// <summary>Sets the date and time a directory was last written to.</summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTime">The date and time the directory was last written to. This value is expressed in local time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastWriteTime">lastWriteTime</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastWriteTime(string path, DateTime lastWriteTime);

        /// <summary>Sets the date and time, in Coordinated Universal Time (UTC) format, that a directory was last written to.</summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTimeUtc">The date and time the directory was last written to. This value is expressed in UTC time.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified path was not found.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="path">path</paramref> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="System.IO.Path.GetInvalidPathChars"></see> method.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path">path</paramref> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="lastWriteTimeUtc">lastWriteTimeUtc</paramref> specifies a value outside the range of dates or times permitted for this operation.</exception>
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
    }
}
