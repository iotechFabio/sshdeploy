﻿using Unosquare.Swan.Attributes;

namespace Unosquare.Labs.SshDeploy.Options
{
    public class PushVerbOptions : CliVerbOptionsBase
    {
        [ArgumentOption('t', "target", HelpText = "The target path of the files to transfer", Required = true)]
        public string TargetPath { get; set; }

        [ArgumentOption("pre", HelpText = "Command to execute prior file transfer to target", Required = false)]
        public string PreCommand { get; set; }

        [ArgumentOption("post", HelpText = "Command to execute after file transfer to target", Required = false)]
        public string PostCommand { get; set; }

        [ArgumentOption("clean", DefaultValue = false, HelpText = "Deletes all files and folders on the target before pushing the new files.  0 to disable, any other number to enable.", Required = false)]
        public bool CleanTarget { get; set; }

        [ArgumentOption("exclude", Separator ='|', DefaultValue = ".ready|.vshost.exe|.vshost.exe.config", HelpText = "a pipe (|) separated list of file suffixes to ignore while deploying.", Required = false)]
        public string[] ExcludeFileSuffixes { get; set; }

        [ArgumentOption('c', "configuration", DefaultValue = "Debug",
            HelpText = "Target configuration. The default for most projects is 'Debug'.", Required = false)]
        public string Configuration { get; set; }

        [ArgumentOption('f', "framework", HelpText = "The target framework has to be specified in the project file.", Required = true)]
        public string Framework { get; set; }

    }
}
