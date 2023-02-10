/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using Java.Io;
using Java.Lang;
using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Net
{
    public sealed class URL : JVMBridgeBase<URL>
    {
        public override string ClassName => "java.net.URL";
        public URL() { }
        /// <summary>
        /// Creates a <see cref="URL"/> object from the String representation.
        /// </summary>
        public URL(string spec) : base(spec) { }
        /// <summary>
        /// Creates a <see cref="URL"/> object from the specified protocol, host, port number, and file.
        /// </summary>
        public URL(string protocol, string host, int port, string file) : base(protocol, host, port, file) { }
        ///// <summary>
        ///// Creates a <see cref="URL"/> object from the specified protocol, host, port number, file, and handler.
        ///// </summary>
        //public URL(string protocol, string host, int port, string file, URLStreamHandler handler) : base(protocol, host, port, file, handler) { }
        /// <summary>
        /// Creates a <see cref="URL"/> from the specified protocol name, host name, and file name.
        /// </summary>
        public URL(string protocol, string host, string file) : base(protocol, host, file) { }
        /// <summary>
        /// Creates a <see cref="URL"/> by parsing the given spec within a specified context.
        /// </summary>
        public URL(URL context, string spec) : base(context, spec) { }
        ///// <summary>
        ///// Creates a <see cref="URL"/> by parsing the given spec with the specified handler within a specified context.
        ///// </summary>
        //public URL(URL context, string spec, URLStreamHandler handler) : base(context, spec, handler) { }

        /// <summary>
        /// Gets the authority part of this URL.
        /// </summary>
        public string Authority => IExecute<string>("getAuthority");
        /// <summary>
        /// Gets the contents of this URL.
        /// </summary>
        public object GetContent() => IExecute("getContent");
        /// <summary>
        /// Gets the contents of this URL.
        /// </summary>
        public object GetContent(Class[] classes) => IExecute("getContent", classes);
        /// <summary>
        /// Gets the default port number of the protocol associated with this URL.
        /// </summary>
        public int DefaultPort => IExecute<int>("getDefaultPort");
        /// <summary>
        /// Gets the file name of this URL.
        /// </summary>
        public string File => IExecute<string>("getFile");
        /// <summary>
        /// Gets the host name of this URL, if applicable.
        /// </summary>
        public string Host => IExecute<string>("getHost");
        /// <summary>
        /// Gets the path part of this URL.
        /// </summary>
        public string Path => IExecute<string>("getPath");
        /// <summary>
        /// Gets the port number of this URL.
        /// </summary>
        public int Port => IExecute<int>("getPort");
        /// <summary>
        /// Gets the protocol name of this URL.
        /// </summary>
        public string Protocol => IExecute<string>("getProtocol");
        /// <summary>
        /// Gets the query part of this URL.
        /// </summary>
        public string Query => IExecute<string>("getQuery");
        /// <summary>
        /// Gets the anchor (also known as the "reference") of this URL.
        /// </summary>
        public string Ref => IExecute<string>("getRef");
        /// <summary>
        /// Gets the userInfo part of this URL.
        /// </summary>
        public string UserInfo => IExecute<string>("getUserInfo");
        /// <summary>
        /// Returns a URLConnection instance that represents a connection to the remote object referred to by the URL.
        /// </summary>
        public URLConnection OpenConnection() => IExecute<URLConnection>("openConnection");
        /// <summary>
        /// Same as openConnection(), except that the connection will be made through the specified proxy; Protocol handlers that do not support proxing will ignore the proxy parameter and make a normal connection.
        /// </summary>
        public URLConnection OpenConnection(Proxy proxy) => IExecute<URLConnection>("openConnection", proxy);
        /// <summary>
        /// Opens a connection to this URL and returns an InputStream for reading from that connection.
        /// </summary>
        public InputStream OpenStream() => IExecute<InputStream>("openStream");
        /// <summary>
        /// Compares two URLs, excluding the fragment component.
        /// </summary>
        public bool SameFile(URL other) => IExecute<bool>("sameFile", other);
        ///// <summary>
        ///// Sets an application's URLStreamHandlerFactory.
        ///// </summary>
        //public static void SetURLStreamHandlerFactory(URLStreamHandlerFactory fac) => SExecute("setURLStreamHandlerFactory", fac);
        /// <summary>
        /// Constructs a string representation of this URL.
        /// </summary>
        public string ToExternalForm() => IExecute<string>("toExternalForm");
        /// <summary>
        /// Returns a URI equivalent to this URL.
        /// </summary>
        public URI ToURI() => IExecute<URI>("toURI");
    }
}
