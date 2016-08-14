﻿using System;

namespace DokanNet
{
    /// <summary>
    /// Defines File System Attribute Extensions
    /// </summary>
    /// <a href="https://msdn.microsoft.com/en-us/library/cc246323.aspx">File System Attribute Extensions</a>
    [Flags]
#pragma warning disable 3009
    public enum FileSystemFeatures : uint
#pragma warning restore 3009
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// File system supports case-sensitive file names.
        /// </summary>
        CaseSensitiveSearch = 1,

        /// <summary>
        /// File system preserves the case of file names when it stores the name on disk.
        /// </summary>
        CasePreservedNames = 2,

        /// <summary>
        /// File system supports Unicode in file names.
        /// </summary>
        UnicodeOnDisk = 4,

        /// <summary>
        /// File system preserves and enforces access control lists.
        /// </summary>
        PersistentAcls = 8,

        /// <summary>
        /// File system supports remote storage.
        /// </summary>
        SupportsRemoteStorage = 256,

        /// <summary>
        /// File system supports per-user quotas.
        /// </summary>
        VolumeQuotas = 32,

        /// <summary>
        /// File system supports sparse files.
        /// 
        /// This feature allows programs to create very large files, but to consume disk space only as needed.
        /// A sparse file is a file that contains much of zeros, and a file system that support
        /// this are removing repeating zeros to save space.
        /// </summary>
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365564(v=vs.85).aspx">Sparse Files (MSDN)</a>
        SupportsSparseFiles = 64,

        /// <summary>
        /// File system supports reparse points.
        /// 
        /// Programs can trap open operations against objects in the file system and run their
        /// own code before returning file data. This feature can be used to extend file 
        /// system features such as mount points, which you can use to redirect data read
        /// and written from a folder to another volume or physical disk.
        /// </summary>
        SupportsReparsePoints = 128,

        /// <summary>
        /// Volume is a compressed volume. This flag is incompatible with FILE_FILE_COMPRESSION.
        /// This does not affect how data is transferred over the network.
        /// </summary>
        VolumeIsCompressed = 32768,

        /// <summary>
        /// File system supports object identifiers.
        /// </summary>
        SupportsObjectIDs = 65536,

        /// <summary>
        /// File system supports encryption.
        /// </summary>
        SupportsEncryption = 131072,

        /// <summary>
        /// File system supports multiple named data streams for a file.
        /// 
        /// The unnamed data stream is the stream where the content in the file is stored.
        /// A named stream is a stream where extra data can be stored. The data is connected to the file
        /// and if the file is moved, the data is copied to the new place if that file system support it.
        /// \see <a href="https://blogs.technet.microsoft.com/askcore/2013/03/24/alternate-data-streams-in-ntfs/">Alternate Data Streams in NTFS (TechNet)</a>
        /// </summary>
        NamedStreams = 262144,

        /// <summary>
        /// Specified volume is read-only.
        /// </summary>
        ReadOnlyVolume = 524288,

        /// <summary>
        /// Specified volume can be written to one time only.  The write MUST be performed in sequential order.
        /// </summary>
        SequentialWriteOnce = 1048576,

        /// <summary>
        /// File system supports transaction processing to group changes to files into a transaction.
        /// The transaction will guarantee that all changes happens, or none of them.
        /// \see <a href="https://msdn.microsoft.com/en-us/library/windows/desktop/aa365993(v=vs.85).aspx">About KTM (MSDN)</a>
        /// </summary>
        SupportsTransactions = 2097152
    }
}