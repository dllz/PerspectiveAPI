using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enforcer5.Models.Perspective
{
    public class RequestedAttributes
    {
        public string scoreType;
        public float scoreThreshold;

        public RequestedAttributes(string scoretype = "PROBABILITY", float scorethreshold = 0)
        {
            scoreType = scoretype;
            scoreThreshold = scorethreshold;
        }
    }
}
