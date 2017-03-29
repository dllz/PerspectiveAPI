using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enforcer5.Models.Perspective
{
    public class AnalyzeCommentRequest
    {   
        public Comment comment;
        public Dictionary<string, RequestedAttributes> requestedAttributes;
        public string[] languages = { "en" };
        public bool doNotStore;
        public string clientToken;

        public AnalyzeCommentRequest(string comment, Dictionary<string, RequestedAttributes> requestedAttributeses = null,  bool doNotStore = true, string clienttoken = null)
        {
            this.comment = new Comment(comment);
            this.doNotStore = doNotStore;
            if(requestedAttributeses == null)
                requestedAttributes.Add("TOXICITY", new RequestedAttributes());
            else
            {
                requestedAttributes = requestedAttributeses;
            }
            clientToken = clienttoken;
        }  
    }
}
