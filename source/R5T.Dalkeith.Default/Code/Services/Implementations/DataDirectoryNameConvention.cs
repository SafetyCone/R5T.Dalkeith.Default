using System;


namespace R5T.Dalkeith.Default
{
    public class DataDirectoryNameConvention : IDataDirectoryNameConvention
    {
        public const string DataDirectoryName = "Data";


        public string GetDataDirectoryName()
        {
            return DataDirectoryNameConvention.DataDirectoryName;
        }
    }
}
