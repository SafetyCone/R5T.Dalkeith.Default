using System;using R5T.T0064;


namespace R5T.Dalkeith.Default
{[ServiceImplementationMarker]
    public class DataDirectoryNameConvention : IDataDirectoryNameConvention,IServiceImplementation
    {
        public const string DataDirectoryName = "Data";


        public string GetDataDirectoryName()
        {
            return DataDirectoryNameConvention.DataDirectoryName;
        }
    }
}
