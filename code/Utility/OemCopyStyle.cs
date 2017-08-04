﻿

namespace XiaoMiFlash.code.Utility
{
  public enum OemCopyStyle
  {
    SP_COPY_DELETESOURCE = 1,
    SP_COPY_REPLACEONLY = 2,
    SP_COPY_NEWER = 4,
    SP_COPY_NEWER_OR_SAME = 4,
    SP_COPY_NOOVERWRITE = 8,
    SP_COPY_NODECOMP = 16,
    SP_COPY_LANGUAGEAWARE = 32,
    SP_COPY_SOURCE_ABSOLUTE = 64,
    SP_COPY_SOURCEPATH_ABSOLUTE = 128,
    SP_COPY_IN_USE_NEEDS_REBOOT = 256,
    SP_COPY_FORCE_IN_USE = 512,
    SP_COPY_NOSKIP = 1024,
    SP_FLAG_CABINETCONTINUATION = 2048,
    SP_COPY_FORCE_NOOVERWRITE = 4096,
    SP_COPY_FORCE_NEWER = 8192,
    SP_COPY_WARNIFSKIP = 16384,
    SP_COPY_NOBROWSE = 32768,
    SP_COPY_NEWER_ONLY = 65536,
    SP_COPY_SOURCE_SIS_MASTER = 131072,
    SP_COPY_OEMINF_CATALOG_ONLY = 262144,
    SP_COPY_REPLACE_BOOT_FILE = 524288,
    SP_COPY_NOPRUNE = 1048576,
  }
}
