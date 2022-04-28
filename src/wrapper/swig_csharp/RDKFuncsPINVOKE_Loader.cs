using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace GraphMolWrap
{
    partial class RDKFuncsPINVOKE
    {
        private const string DllBaseName = "RDKFuncs";
        internal static bool loaded = false;
        
        /// <summary>
        /// Implementation of DllImportResolver.
        /// </summary>
        /// <param name="libraryName">library name to load</param>
        /// <param name="assembly">assembly loading</param>
        /// <param name="searchPath"></param>
        /// <returns></returns>
        /// <see href="https://docs.microsoft.com/ja-jp/dotnet/standard/native-interop/cross-platform"/>
        private static IntPtr DllImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (libraryName == DllBaseName)
            {
                var cpuOsArch = RuntimeInformation.OSArchitecture.ToString().ToLowerInvariant();

                var osName = "unsupported_os";
                var suffix = ".unknown_dll_format";
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    osName = "win";
                    suffix = ".dll";
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    osName = "linux";
                    suffix = ".so";
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    osName = "macos";
                    suffix = ".so";
                }

                var filename = $"{DllBaseName}{suffix}";
                {
                    var pathToDll = Path.Combine(Path.GetDirectoryName(assembly.Location), "runtimes", $"{osName}-{cpuOsArch}", "native", filename);
                    
                    if (File.Exists(pathToDll))
                    {
                        return NativeLibrary.Load(pathToDll, assembly, searchPath);
                    }
                }
                {
                    // ASP.NET
                    var uri = new Uri(assembly.Location);
                    
                    if (uri.Scheme == "file")
                    {
                        var pathToDll = Path.Combine(Path.GetDirectoryName(uri.AbsolutePath), "runtimes", $"{osName}-{cpuOsArch}", "native", filename);
                        
                        if (File.Exists(pathToDll))
                        {
                            return NativeLibrary.Load(pathToDll, assembly, searchPath);
                        }
                    }
                }
            }
            return IntPtr.Zero;
        }

        internal static void LoadDll()
        {
            if (!loaded)
            {
                NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), DllImportResolver);
                loaded = true;
            }
        }
    }
}
