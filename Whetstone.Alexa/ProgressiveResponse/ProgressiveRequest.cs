﻿// Copyright (c) 2018 Whetstone Technologies
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Whetstone.Alexa.ProgressiveResponse
{
    public class ProgressiveRequest
    {
        //        { 
        //  "header":{ 
        //    "requestId":"amzn1.echo-api.request.xxxxxxx"
        //  },
        //  "directive":{ 
        //    "type":"VoicePlayer.Speak",
        //    "speech":"This text is spoken while your skill processes the full response."
        //  }
        //}

        public ProgressiveRequest()
        {

        }

        public ProgressiveRequest(string requestId, string speech) : this()
        {
            Header = new ProgressiveRequestHeader(requestId);
            Directive = new ProgressiveRequestDirective(speech);

        }

        [JsonProperty("header")]
        public ProgressiveRequestHeader Header { get; set; }

        [JsonProperty("directive")]
        public ProgressiveRequestDirective Directive { get; set; }

    }
}
