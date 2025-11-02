using System;

namespace YanickSenn.ProjectInitializer.Editor.Shared {
    [Serializable]
    public class PackageJson {
        public string name;
        public string version;
        public string displayName;
        public string description;
        public string unity;
        public string unityRelease;
        public Author author;
    }
        
    [Serializable]
    public class Author {
        public string name;
        public string email;
        public string url;
    }
}
