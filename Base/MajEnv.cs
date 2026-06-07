using System;
using System.IO;

namespace MajdataEdit_Neo.Base;

public static class MajEnv
{
    public static string MajBase => AppDomain.CurrentDomain.BaseDirectory;
    public static string GetPath(string relativePath) => Path.Combine(MajBase, relativePath);
}