using System;
using System.IO;
using System.Runtime.Serialization;

namespace AnotherSystem.IO.Wrapper
{
    public abstract class FileSystemInfoBase
    {
        /// <summary>Gets or sets the attributes for the current file or directory.</summary>
        /// <returns><see cref="System.IO.FileAttributes"></see> of the current <see cref="System.IO.FileSystemInfo"></see>.</returns>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified file doesn&amp;#39;t exist. Only thrown when setting the property value.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid. For example, it&amp;#39;s on an unmapped drive. Only thrown when setting the property value.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller doesn&amp;#39;t have the required permission.</exception>
        /// <exception cref="T:System.ArgumentException">The caller attempts to set an invalid file attribute.
        /// -or-
        /// The user attempts to set an attribute value but doesn&amp;#39;t have write permission.</exception>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        public abstract FileAttributes Attributes { get; set; }

        /// <summary>Gets or sets the creation time of the current file or directory.</summary>
        /// <returns>The creation date and time of the current <see cref="System.IO.FileSystemInfo"></see> object.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid; for example, it is on an unmapped drive.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid creation time.</exception>
        public abstract DateTime CreationTime { get; set; }

        /// <summary>Gets or sets the creation time, in coordinated universal time (UTC), of the current file or directory.</summary>
        /// <returns>The creation date and time in UTC format of the current <see cref="System.IO.FileSystemInfo"></see> object.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid; for example, it is on an unmapped drive.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid access time.</exception>
        public abstract DateTime CreationTimeUtc { get; set; }

        /// <summary>Gets a value indicating whether the file or directory exists.</summary>
        /// <returns>true if the file or directory exists; otherwise, false.</returns>
        public abstract bool Exists { get; }

        /// <summary>Gets the string representing the extension part of the file.</summary>
        /// <returns>A string containing the <see cref="System.IO.FileSystemInfo"></see> extension.</returns>
        public abstract string Extension { get; }

        /// <summary>Gets the full path of the directory or file.</summary>
        /// <returns>A string containing the full path.</returns>
        /// <exception cref="T:System.IO.PathTooLongException">The fully qualified path and file name is 260 or more characters.</exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
        public abstract string FullName { get; }

        /// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> object with the file name and additional exception information.</summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        public abstract void GetObjectData(SerializationInfo info, StreamingContext context);

        /// <summary>Gets or sets the time the current file or directory was last accessed.</summary>
        /// <returns>The time that the current file or directory was last accessed.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid access time</exception>
        public abstract DateTime LastAccessTime { get; set; }

        /// <summary>Gets or sets the time, in coordinated universal time (UTC), that the current file or directory was last accessed.</summary>
        /// <returns>The UTC time that the current file or directory was last accessed.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid access time.</exception>
        public abstract DateTime LastAccessTimeUtc { get; set; }

        /// <summary>Gets or sets the time when the current file or directory was last written to.</summary>
        /// <returns>The time the current file was last written.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid write time.</exception>
        public abstract DateTime LastWriteTime { get; set; }

        /// <summary>Gets or sets the time, in coordinated universal time (UTC), when the current file or directory was last written to.</summary>
        /// <returns>The UTC time when the current file was last written to.</returns>
        /// <exception cref="T:System.IO.IOException"><see cref="System.IO.FileSystemInfo.Refresh"></see> cannot initialize the data.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The caller attempts to set an invalid write time.</exception>
        public abstract DateTime LastWriteTimeUtc { get; set; }

        /// <summary>For files, gets the name of the file. For directories, gets the name of the last directory in the hierarchy if a hierarchy exists. Otherwise, the Name property gets the name of the directory.</summary>
        /// <returns>A string that is the name of the parent directory, the name of the last directory in the hierarchy, or the name of a file, including the file name extension.</returns>
        public abstract string Name { get; }

        /// <summary>Deletes a file or directory.</summary>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid; for example, it is on an unmapped drive.</exception>
        /// <exception cref="T:System.IO.IOException">There is an open handle on the file or directory, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
        public abstract void Delete();

        /// <summary>Refreshes the state of the object.</summary>
        /// <exception cref="T:System.IO.IOException">A device such as a disk drive is not ready.</exception>
        public abstract void Refresh();
    }
}