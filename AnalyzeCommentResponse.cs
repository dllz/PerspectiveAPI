using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enforcer5.Models.Perspective
{
    public class AnalyzeCommentResponse
    {
        public SummaryScore SummaryScore;
        public SpanScore SpanScore;
        public string[] languages;
        public string clientToken;
    }
}
