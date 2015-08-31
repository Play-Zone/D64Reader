using System.Collections.Generic;

namespace d64Reader
{
    public class DiskImage
    {
        public string DiskType { get; set; }
        public List<DirectoryItem> DirectoryItems { get; set; }
        public string DiskName { get; set; }
        public string DiskId { get; set; }
        public int FreeBlocks { get; set; }         
    }
}
