﻿namespace PuppeteerSharp.Abstractions.PageCoverage
{
    // TODO: clean this:
    public class CoverageResponseRange
    {
        public int StartOffset { get; set; }
        public int EndOffset { get; set; }
        public int Count { get; set; }
        public string StyleSheetId { get; set; }
    }
}