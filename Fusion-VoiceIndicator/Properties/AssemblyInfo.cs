using System;
using System.Reflection;
using FusionVoiceIndicator;
using LabFusion.SDK.Modules;
using MelonLoader;


[assembly: MelonInfo(typeof(FusionVoiceIndicatorMod), FusionVoiceIndicator.BuildInfo.Name, FusionVoiceIndicator.BuildInfo.Version, FusionVoiceIndicator.BuildInfo.Author, FusionVoiceIndicator.BuildInfo.DownloadLink)]
[assembly: ModuleInfo(typeof(ModuleClass), FusionVoiceIndicator.BuildInfo.ModuleName, FusionVoiceIndicator.BuildInfo.Version, FusionVoiceIndicator.BuildInfo.Author, "fusionvoiceindicator", true, ConsoleColor.Cyan)]

[assembly: AssemblyTitle(FusionVoiceIndicator.BuildInfo.Description)]
[assembly: AssemblyDescription(FusionVoiceIndicator.BuildInfo.Description)]
[assembly: AssemblyCompany(FusionVoiceIndicator.BuildInfo.Company)]
[assembly: AssemblyProduct(FusionVoiceIndicator.BuildInfo.Name)]
[assembly: AssemblyCopyright("Developed by " + FusionVoiceIndicator.BuildInfo.Author)]
[assembly: AssemblyVersion(FusionVoiceIndicator.BuildInfo.Version)]
[assembly: AssemblyFileVersion(FusionVoiceIndicator.BuildInfo.Version)]
[assembly: MelonColor(System.ConsoleColor.White)]

[assembly: MelonGame("Stress Level Zero", "BONELAB")]