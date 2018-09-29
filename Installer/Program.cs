using System;
using WixSharp;
using WixSharp.CommonTasks;

namespace Installer
{
    internal static class Program
    {
        #region Properties

        private static string CompanyName { get; } = @"Company";
        private static string ProgramName { get; } = @"Mp3Mashup";
        private static string ProgramShortName { get; } = @"Mp3Mashup";
        private static string ProgramFilesPath { get; } = $@"%ProgramFiles%\{CompanyName}\{ProgramName}";
        private static string ApplicationPath { get; } = @"..\Application\bin\Release\";

        #endregion

        #region Main

        private static void Main()
        {
            try
            {
                CreateMsi();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Methods

        private static void CreateMsi()
        {
            var mainExe = new File(ApplicationPath + ProgramShortName + ".exe")
            {
                Shortcuts = new[]
                {
                    new FileShortcut(ProgramName, "%ProgramMenu%"),
                    new FileShortcut(ProgramName, "%Desktop%")
                }
            };
            var project = new Project(
                ProgramShortName,
                new Dir(
                    ProgramFilesPath,
                    new DirFiles(ApplicationPath + "*.dll"),
                    new DirFiles(ApplicationPath + "*.config"),
                    mainExe
                )
            )
            {
                GUID = new Guid("156E51BF-AB4B-4077-9FCA-E397887C30E3"),
                ControlPanelInfo =
                {
                    Manufacturer = CompanyName,
                    //ProductIcon = @"..\Application\icon.ico",
                },
                Version = new Version(1, 0, 0),
                UI = WUI.WixUI_ProgressOnly,
                MajorUpgrade = MajorUpgrade.Default
            };

            project.SetNetFxPrerequisite(Condition.Net461_Installed, "Please install .NET 4.6.1 first.");

            Compiler.WixLocation = @"..\packages\WixSharp.wix.bin.3.11.0\tools\bin";
            Compiler.BuildMsi(project);
        }

        #endregion
    }
}