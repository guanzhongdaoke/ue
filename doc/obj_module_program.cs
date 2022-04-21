using System;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Android下生成.o，通过
            if (false)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "C:\\Users\\guanzhongdaoke\\AppData\\Local\\Android\\Sdk\\ndk\\21.4.7075529\\toolchains\\llvm\\prebuilt\\windows-x86_64\\bin\\clang++.exe";
                FrameworkProcess.StartInfo.Arguments = "@D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Android\\MyProject2\\Development\\MyProject2\\MyProject2.cppa7.o.rsp";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:\\Source\\UE\\UnrealEngine-4.26.2-release\\Engine\\Source";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }
 
            // Android下生成.so，可以通过
            if (false)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "C:\\Users\\guanzhongdaoke\\AppData\\Local\\Android\\Sdk\\ndk\\21.4.7075529\\toolchains\\llvm\\prebuilt\\windows-x86_64\\bin\\clang++.exe";
                FrameworkProcess.StartInfo.Arguments = " -no-canonical-prefixes -shared -Wl,-Bsymbolic -Wl,--no-undefined -Wl,--gc-sections --target=armv7-none-linux-androideabi21 --gcc-toolchain=\"C:/Users/guanzhongdaoke/AppData/Local/Android/Sdk/ndk/21.4.7075529/toolchains/llvm/prebuilt/windows-x86_64\" --sysroot=\"C:/Users/guanzhongdaoke/AppData/Local/Android/Sdk/ndk/21.4.7075529/toolchains/llvm/prebuilt/windows-x86_64/sysroot\" -DANDROID=1 -march=armv7-a -Wl,-no-pie -fuse-ld=lld -Wl,-soname,libUE4.so    -Wl,--exclude-libs,libgcc_real.a -Wl,--exclude-libs,libatomic.a -Wl,--build-id=sha1 -o \"D:/UE4Simple/MyProject2/Binaries/Android/MyProject2-armv7.so\" @\"D:/UE4Simple/MyProject2/Intermediate/Build/Android/MyProject2/Development/MyProject2-armv7.so.response\"";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Android\\MyProject2\\Development";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }

            // Win编辑器模式下，生成.obj，失败
            if (false)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "D:\\Source\\UE\\UnrealEngine-4.26.2-release\\Engine\\Build\\Windows\\cl-filter\\cl-filter.exe";
                FrameworkProcess.StartInfo.Arguments = " -dependencies=D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\UE4Editor\\Debug\\MyProject2\\MyPawn.cpp.txt -compiler=\"C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\cl.exe\" -- \"C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\cl.exe\"  @\"D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\UE4Editor\\Debug\\MyProject2\\MyPawn.cpp.obj.response\" /showIncludes";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:/Source/UE/UnrealEngine-4.26.2-release/Engine/Source";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }

            // Win编辑器模式下，生成.lib，成功
            if (false)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\lib.exe";
                FrameworkProcess.StartInfo.Arguments = "@\"D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\UE4Editor\\Debug\\MyProject2\\UE4Editor-MyProject2-Win64-Debug.lib.response\"";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:/Source/UE/UnrealEngine-4.26.2-release/Engine/Source";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }

            // Win编辑器模式下，生成.dll，失败
            if (false)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "D:\\Source\\UE\\UnrealEngine-4.26.2-release\\Engine\\Build\\Windows\\link-filter\\link-filter.exe";
                FrameworkProcess.StartInfo.Arguments = "-- \"C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\link.exe\" @\"D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\UE4Editor\\Debug\\MyProject2\\UE4Editor-MyProject2-Win64-Debug.dll.response\"";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:/Source/UE/UnrealEngine-4.26.2-release/Engine/Source";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }

            // Win非编辑器模式下，生成.obj，失败
            if (false)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "D:\\Source\\UE\\UnrealEngine-4.26.2-release\\Engine\\Build\\Windows\\cl-filter\\cl-filter.exe";
                FrameworkProcess.StartInfo.Arguments = "-dependencies=D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\MyProject2\\Debug\\MyProject2\\MyPawn.cpp.txt -compiler=\"C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\cl.exe\" -- \"C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\cl.exe\"  @\"D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\MyProject2\\Debug\\MyProject2\\MyPawn.cpp.obj.response\" /showIncludes";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:/Source/UE/UnrealEngine-4.26.2-release/Engine/Source";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }


            // Win非编辑器模式下，生成.exe，失败
            if (true)
            {
                Process FrameworkProcess = new Process();
                FrameworkProcess.StartInfo.FileName = "D:\\Source\\UE\\UnrealEngine-4.26.2-release\\Engine\\Build\\Windows\\link-filter\\link-filter.exe";
                FrameworkProcess.StartInfo.Arguments = "-- \"C:\\Program Files(x86)\\Microsoft Visual Studio\\2019\\Professional\\VC\\Tools\\MSVC\\14.29.30133\\bin\\HostX64\\x64\\link.exe\" @\"D:\\UE4Simple\\MyProject2\\Intermediate\\Build\\Win64\\MyProject2\\Debug\\MyProject2-Win64-Debug.exe.response\"";
                FrameworkProcess.StartInfo.WorkingDirectory = "D:/Source/UE/UnrealEngine-4.26.2-release/Engine/Source";
                FrameworkProcess.StartInfo.RedirectStandardInput = true;
                FrameworkProcess.StartInfo.RedirectStandardOutput = true;
                FrameworkProcess.StartInfo.UseShellExecute = false;
                FrameworkProcess.StartInfo.CreateNoWindow = true;

                FrameworkProcess.Start();
                try
                {
                    FrameworkProcess.PriorityClass = ProcessPriorityClass.Normal;
                }
                catch
                {

                }
                FrameworkProcess.WaitForExit();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
