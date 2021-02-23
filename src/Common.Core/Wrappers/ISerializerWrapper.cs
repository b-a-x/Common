﻿using System.Text.Json;

namespace Common.Core.Wrappers
{
    public interface ISerializerWrapper
    {
        public string Serialize<T>(T source);
        public T Deserialize<T>(string source);
    }

    public class JsonTextSerializer : ISerializerWrapper
    {
        public string Serialize<T>(T source) => JsonSerializer.Serialize(source);
        public T Deserialize<T>(string source) => JsonSerializer.Deserialize<T>(source);
    }
}