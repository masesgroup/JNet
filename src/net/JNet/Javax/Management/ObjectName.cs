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

using Java.Util;
using MASES.JCOBridge.C2JBridge;

namespace JavaX.Management
{
    public class ObjectName : JVMBridgeBase<ObjectName>
    {
        public override string ClassName => "javax.management.ObjectName";

        public static explicit operator Java.Lang.Comparable<ObjectName>(ObjectName o) => o.Cast<Java.Lang.Comparable<ObjectName>>();

        public static explicit operator QueryExp(ObjectName o) => o.Cast<QueryExp>();

        public ObjectName() { }

        protected ObjectName(params object[] args) : base(args) { }
        /// <summary>
        /// Construct an object name from the given string.
        /// </summary>
        public ObjectName(string name) : base(name) { }
        /// <summary>
        /// Construct an object name with exactly one key property.
        /// </summary>
        public ObjectName(string domain, string key, string value) : base(domain, key, value) { }
        /// <summary>
        /// Construct an object name with several key properties from a <see cref="Hashtable"/>.
        /// </summary>
        public ObjectName(string domain, Hashtable<string, string> table) : base(domain, table) { }

        /// <summary>
        /// Return an instance of ObjectName that can be used anywhere an object obtained with new ObjectName(name) can be used.
        /// </summary>
        public static ObjectName GetInstance(string name) => SExecute<ObjectName>("getInstance", name);
        /// <summary>
        /// Return an instance of ObjectName that can be used anywhere an object obtained with new ObjectName(domain, key, value) can be used.
        /// </summary>
        public static ObjectName GetInstance(string domain, string key, string value) => SExecute<ObjectName>("getInstance", domain, key, value);
        /// <summary>
        /// Return an instance of ObjectName that can be used anywhere an object obtained with new ObjectName(domain, table) can be used.
        /// </summary>
        public static ObjectName GetInstance(string domain, Hashtable<string, string> table) => SExecute<ObjectName>("getInstance", domain, table);
        /// <summary>
        /// Return an instance of ObjectName that can be used anywhere the given object can be used.
        /// </summary>
        public static ObjectName GetInstance(ObjectName name) => SExecute<ObjectName>("getInstance", name);
        /// <summary>
        /// Returns a quoted form of the given String, suitable for inclusion in an ObjectName.
        /// </summary>
        public static string Quote(string s) => SExecute<string>("quote", s);
        /// <summary>
        /// Returns an unquoted form of the given String.
        /// </summary>
        public static string Unquote(string q) => SExecute<string>("unquote", q);
        /// <summary>
        /// Test whether this ObjectName, which may be a pattern, matches another ObjectName.
        /// </summary>
        public bool Apply(ObjectName name) => IExecute<bool>("apply", name);
        /// <summary>
        /// Compares two ObjectName instances.
        /// </summary>
        public int CompareTo(ObjectName name) => IExecute<int>("compareTo", name);
        /// <summary>
        /// Returns a string representation of the list of key properties, in which the key properties are sorted in lexical order.
        /// </summary>
        public string CanonicalKeyPropertyListString => IExecute<string>("getCanonicalKeyPropertyListString");
        /// <summary>
        /// Returns the canonical form of the name; that is, a string representation where the properties are sorted in lexical order.
        /// </summary>
        public string CanonicalName => IExecute<string>("getCanonicalName");
        /// <summary>
        /// Returns the domain part.
        /// </summary>
        public string Domain => IExecute<string>("getDomain");
        /// <summary>
        /// Obtains the value associated with a key in a key property.
        /// </summary>
        public string GetKeyProperty(string property) => IExecute<string>("getKeyProperty", property);
        /// <summary>
        /// Returns the key properties as a Hashtable.
        /// </summary>
        public Hashtable<string, string> KeyPropertyList => IExecute<Hashtable<string, string>>("getKeyPropertyList");
        /// <summary>
        /// Returns a string representation of the list of key properties specified at creation time.
        /// </summary>
        public string KeyPropertyListString => IExecute<string>("getKeyPropertyListString");
        /// <summary>
        /// Checks whether the object name is a pattern on the domain part. 
        /// </summary>
        public bool IsDomainPattern => IExecute<bool>("isDomainPattern");
        /// <summary>
        /// Checks whether the object name is a pattern.
        /// </summary>
        public bool IsPattern => IExecute<bool>("isPattern");
        /// <summary>
        /// Checks whether the object name is a pattern on the key property list.
        /// </summary>
        public bool IsPropertyListPattern => IExecute<bool>("isPropertyListPattern");
        /// <summary>
        /// Checks whether the object name is a pattern on the key properties.
        /// </summary>
        public bool IsPropertyPattern => IExecute<bool>("isPropertyPattern");
        /// <summary>
        /// Checks whether the object name is a pattern on the value part of at least one of the key properties.
        /// </summary>
        public bool IsPropertyValuePattern() => IExecute<bool>("isPropertyValuePattern");
        /// <summary>
        /// Checks whether the value associated with a key in a key property is a pattern.
        /// </summary>
        public bool IsPropertyValuePattern(string property) => IExecute<bool>("isPropertyValuePattern", property);
        /// <summary>
        /// Sets the MBean server on which the query is to be performed.
        /// </summary>
        public void SetMBeanServer(MBeanServer mbs) => IExecute<bool>("setMBeanServer", mbs);
    }
}
