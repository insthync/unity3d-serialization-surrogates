using System.Runtime.Serialization;
using UnityEngine;

public static class SurrogateSelectorExtension
{
    public static void AddAllUnitySurrogate(this SurrogateSelector surrogateSelector)
    {
        var colorSS = new ColorSerializationSurrogate();
        var quaternionSS = new QuaternionSerializationSurrogate();
        var vector2IntSS = new Vector2IntSerializationSurrogate();
        var vector2SS = new Vector2SerializationSurrogate();
        var vector3IntSS = new Vector3IntSerializationSurrogate();
        var vector3SS = new Vector3SerializationSurrogate();
        var vector4SS = new Vector4SerializationSurrogate();
        surrogateSelector.AddSurrogate(typeof(Color), new StreamingContext(StreamingContextStates.All), colorSS);
        surrogateSelector.AddSurrogate(typeof(Quaternion), new StreamingContext(StreamingContextStates.All), quaternionSS);
        surrogateSelector.AddSurrogate(typeof(Vector2Int), new StreamingContext(StreamingContextStates.All), vector2IntSS);
        surrogateSelector.AddSurrogate(typeof(Vector2), new StreamingContext(StreamingContextStates.All), vector2SS);
        surrogateSelector.AddSurrogate(typeof(Vector3Int), new StreamingContext(StreamingContextStates.All), vector3IntSS);
        surrogateSelector.AddSurrogate(typeof(Vector3), new StreamingContext(StreamingContextStates.All), vector3SS);
        surrogateSelector.AddSurrogate(typeof(Vector4), new StreamingContext(StreamingContextStates.All), vector4SS);
    }
}
