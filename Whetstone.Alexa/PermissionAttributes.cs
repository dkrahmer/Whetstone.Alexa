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

namespace Whetstone.Alexa
{

    /// <summary>
    /// Alexa permission attributes coming in on an Alexa request. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// This will be present if the user has granted the skill permission to access user information like the user name, email, etc.
    /// </para>
    /// <para>For more information, the <see cref="Whetstone.Alexa.Security.AlexaUserDataManager">AlexaUserDataManager</see></para>
    /// </remarks>
    [JsonObject("permissions")]
    public  class PermissionAttributes
    {
        /// <summary>
        /// This is used with the Alexa List management API.
        /// </summary>
        /// <remarks>If consent has not been granted, this value will not be present in the request.</remarks>
        [JsonProperty( PropertyName ="consentToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsentToken { get; set; }

    }
}