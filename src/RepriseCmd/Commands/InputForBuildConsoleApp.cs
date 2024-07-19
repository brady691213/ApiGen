﻿using Oakton;

namespace RepriseCmd.Commands;

public record InputForBuildConsoleApp
{
    [FlagAlias('o')]
    [Description("Directory to write generated files to. Default is the current directory.")]
    public string OutputDirectory { get; set; } = Directory.GetCurrentDirectory();
}