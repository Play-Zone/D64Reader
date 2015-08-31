# D64Reader
C# to parse the contents of a .D64 (C64 Disk Image) file

Just open a file and pass it as a byte-array to the class

var data = System.IO.File.ReadAllBytes(Server.MapPath("~/App_Data/DemoDisk.d64"));

var reader = new D64Reader(data);

var diskName = reader.DiskName;

