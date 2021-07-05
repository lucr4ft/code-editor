using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lucraft.CodeEditor.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtensionManager
    {
        public static List<ExtensionEntry> Extensions { get; } = new List<ExtensionEntry>();

        /// <summary>
        /// 
        /// </summary>
        public static void LoadExtensions()
        {
            string extensionsFolder = Path.Combine(Directory.GetCurrentDirectory(), "extensions");
            
            if (!Directory.Exists(extensionsFolder))
            {
                Debug.WriteLine("Extensions folder does not exist");
                return;
            }

            string[] extensionsAssemblies = Directory.GetFiles(extensionsFolder, "*.dll");
            var assemblies = new List<Assembly>();

            foreach (string extensionAssembly in extensionsAssemblies)
            {
                Debug.WriteLine($"Loading Assembly '{extensionAssembly}'...");
                assemblies.Add(Assembly.LoadFile(extensionAssembly));
                Debug.WriteLine($"Loaded Assembly '{extensionAssembly}'!");
            }

            try
            {

                foreach (var assembly in assemblies)
                {
                    string[] strings = assembly.GetManifestResourceNames();

                    foreach (var s in strings)
                    {
                        //var rm = new ResourceManager(s, assembly);

                        // Get the fully qualified resource type name
                        // Resources are suffixed with .resource
                        var rst = s.Substring(0, s.IndexOf(".json"));
                        var type = assembly.GetType(rst, false);

                        // if type is null then its not .resx resource
                        if (null != type)
                        {
                            var resources = type.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                            foreach (var res in resources)
                            {
                                // collect string type resources
                                if (res.PropertyType == typeof(string))
                                {
                                    // get value from static property
                                    string myResourceString = res.GetValue(null, null) as string;
                                }
                            }
                        }

                    }
                }
            }
            catch { }
        }

        public static void EnableExtensions() => Extensions.ForEach(extension => extension.OnEnable());
        public static void ReloadExtensions() => Extensions.ForEach(extension => extension.OnReload());
        public static void DisableExtensions() => Extensions.ForEach(extension => extension.OnDisable());

        //public static void EnableExtension(string id)
        //public static void ReloadExtension(string id)
        //public static void DisabeExtension(string id)

        public static void InstallExtension(string id) { }
        public static void UninstallExtension(string id) { }
    }
}
