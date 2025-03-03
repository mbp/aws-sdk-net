/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PutSession operation.
    /// Creates a new session or modifies an existing session with an Amazon Lex bot. Use
    /// this operation to enable your application to set the state of the bot.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/how-session-api.html">Managing
    /// Sessions</a>.
    /// </para>
    /// </summary>
    public partial class PutSessionRequest : AmazonLexRequest
    {
        private string _accept;
        private string _botAlias;
        private string _botName;
        private DialogAction _dialogAction;
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The message that Amazon Lex returns in the response can be either text or speech based
        /// depending on the value of this field.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <code>text/plain; charset=utf-8</code>, Amazon Lex returns text in
        /// the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value begins with <code>audio/</code>, Amazon Lex returns speech in the response.
        /// Amazon Lex uses Amazon Polly to generate the speech in the configuration that you
        /// specify. For example, if you specify <code>audio/mpeg</code> as the value, Amazon
        /// Lex returns speech in the MPEG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <code>audio/pcm</code>, the speech is returned as <code>audio/pcm</code>
        /// in 16-bit, little endian format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following are the accepted values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>audio/mpeg</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>audio/ogg</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>audio/pcm</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>audio/*</code> (defaults to mpeg)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>text/plain; charset=utf-8</code> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// The alias in use for the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotAlias
        {
            get { return this._botAlias; }
            set { this._botAlias = value; }
        }

        // Check to see if BotAlias property is set
        internal bool IsSetBotAlias()
        {
            return this._botAlias != null;
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property DialogAction. 
        /// <para>
        /// Sets the next action that the bot should take to fulfill the conversation.
        /// </para>
        /// </summary>
        public DialogAction DialogAction
        {
            get { return this._dialogAction; }
            set { this._dialogAction = value; }
        }

        // Check to see if DialogAction property is set
        internal bool IsSetDialogAction()
        {
            return this._dialogAction != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing the session-specific context information. It contains
        /// application information passed between Amazon Lex and a client application.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && this._sessionAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}