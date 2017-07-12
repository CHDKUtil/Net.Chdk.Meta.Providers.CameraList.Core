using Net.Chdk.Meta.Model.CameraList;
using System.Collections.Generic;

namespace Net.Chdk.Meta.Providers.CameraList
{
    public interface IInnerCameraListProvider
    {
        IDictionary<string, ListPlatformData> GetCameraList(string path, string categoryName);
        string Extension { get; }
    }
}
