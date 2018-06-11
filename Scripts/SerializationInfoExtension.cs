
using System.Collections.Generic;
using System.Runtime.Serialization;

public static class SerializationInfoExtension
{
    public static void AddListValue<T>(this SerializationInfo info, string dataName, IList<T> data)
    {
        var count = data.Count;
        info.AddValue(dataName + "_Count", count);
        for (var i = 0; i < count; ++i)
        {
            info.AddValue(dataName + "_[" + i + "]", data[i]);
        }
    }

    public static IList<T> GetListValue<T>(this SerializationInfo info, string dataName)
    {
        var result = new List<T>();
        var count = info.GetInt32(dataName + "_Count");
        for (var i = 0; i < count; ++i)
        {
            result.Add((T)info.GetValue(dataName + "_[" + i + "]", typeof(T)));
        }
        return result;
    }
}
