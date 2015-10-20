﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using ReportUnit.Core.Parser;

namespace ReportUnit.Core.Model
{
    public class Report
    {
        public List<Status> StatusList;

        public List<string> CategoryList;

        public List<TestSuite> TestSuiteList { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        /// <summary>
        /// File name generated that this data is for
        /// </summary>
        public string FileName { get; set; }

        public string GetHtmlFileName()
        {
            return Path.ChangeExtension(FileName, "html");
        }

        public TestRunner TestRunner { get; set; }

        public Dictionary<string, string> RunInfo { get; private set; }

        public void AddRunInfo(Dictionary<string, string> runInfo)
        {
            RunInfo = runInfo;
        }

        /// <summary>
        /// Name of the assembly that the tests are for
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Overall result of the test run (eg Passed, Failed)
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// How long the test suite took to run (in milliseconds)
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        /// Total number of tests run
        /// </summary>
        public int Total { get; set; }

        public int Passed { get; set; }

        public int Failed { get; set; }

        public int Inconclusive { get; set; }

        public int Skipped { get; set; }

        public int Errors { get; set; }

        public Report()
        {
            TestSuiteList = new List<TestSuite>();
            CategoryList = new List<string>();
            StatusList = new List<Status>();
        }
    }
}