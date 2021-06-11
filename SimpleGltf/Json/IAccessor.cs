using System.Collections;
using System.IO;
using System.Text.Json.Serialization;
using SimpleGltf.Enums;
using SimpleGltf.Json.Converters;

namespace SimpleGltf.Json
{
    public interface IAccessor
    {
        [JsonIgnore] GltfAsset GltfAsset { get; }
        
        [JsonConverter(typeof(BufferViewConverter))]
        BufferView BufferView { get; }

        int? ByteOffset { get; }

        ComponentType ComponentType { get; }

        bool? Normalized { get; }

        int Count { get; }

        [JsonConverter(typeof(AccessorTypeConverter))]
        AccessorType Type { get; }

        IEnumerable Max { get; }

        IEnumerable Min { get; }

        string Name { get; }
    }
}