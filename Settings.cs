using System.Xml.Serialization;
using System.Collections.Generic;

namespace RedisAdmin
{
    public class Settings
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int SplitterDistance { get; set; }

        public bool SaveHostPort { get; set; }
        public bool SavePasswords { get; set; }

        public List<RedisCredentials> RedisCredentials { get; set; }
    }

    public class RedisCredentials
    {
        public string Name { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        [XmlIgnore]
        public string Password { get; set; }

        public string EncryptedPassword { get; set; }
    }
}
