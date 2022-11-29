using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSpells
{
    public class ExceptionHttpStatus : Exception
    {
        public readonly HttpStatusCode HttpStatusCode; 
        
            public ExceptionHttpStatus(string message, HttpStatusCode httpStatusCode) : base(message)
            {
            HttpStatusCode = httpStatusCode;
            }
    }
}
