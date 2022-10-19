/*
*  Copyright 2022 MASES s.r.l.
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

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System;

namespace MASES.JNetReflector.Templates
{
    public class Template
    {
        static string[] templateStrings = new string[]
        {
                AllPackageClassesTemplate,
                AllPackageClassesStubClassTemplate,
                AllPackageClassesStubExceptionTemplate,
                AllPackageClassesStubNestedClassTemplate,
                AllPackageClassesStubNestedExceptionTemplate,

                SingleClassTemplate,
                SingleNestedClassTemplate,
        };

        static Template()
        {
            foreach (var item in templateStrings)
            {
                string template = string.Empty;
                using (var stream = typeof(Template).Assembly.GetManifestResourceStream(typeof(Template).Namespace + "." + item))
                {
                    using (var sr = new StreamReader(stream))
                    {
                        template = sr.ReadToEnd();
                    }
                }
                templates.Add(item, template);
            }
        }

        static IDictionary<string, string> templates = new ConcurrentDictionary<string, string>();
        public static string GetTemplate(string templateName)
        {
            string template = string.Empty;
            if (!templates.TryGetValue(templateName, out template))
            {
                throw new InvalidOperationException(string.Format("Missing template {0}", templateName));
            }
            return template;
        }

        public const string AllPackageClassesTemplate = "AllPackageClasses.template";
        public const string AllPackageClassesStubClassTemplate = "AllPackageClassesStubClass.template";
        public const string AllPackageClassesStubExceptionTemplate = "AllPackageClassesStubException.template";
        public const string AllPackageClassesStubNestedClassTemplate = "AllPackageClassesStubNestedClass.template";
        public const string AllPackageClassesStubNestedExceptionTemplate = "AllPackageClassesStubNestedException.template";

        public const string SingleClassTemplate = "SingleClass.template";
        public const string SingleNestedClassTemplate = "SingleNestedClass.template";
    }

    public class Usings
    {
        public const string USING = "using {0};";
    }

    public class AllPackageClasses
    {
        public const string VERSION_PLACEHOLDER = "ALLPACKAGE_VERSION_PLACEHOLDER";
        public const string JAR_PLACEHOLDER = "ALLPACKAGE_JAR_PLACEHOLDER";
        public const string NAMESPACE_PLACEHOLDER = "ALLPACKAGE_NAMESPACE_PLACEHOLDER";
        public const string CLASSES_PLACEHOLDER = "// ALLPACKAGE_CLASSES_PLACEHOLDER";

        public class ClassStub
        {
            public const string HELP_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_CLASS_HELP_PLACEHOLDER";
            public const string CLASS_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_CLASS_PLACEHOLDER";
            public const string BASECLASS_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_BASECLASS_PLACEHOLDER";
            public const string JAVACLASS_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_JAVACLASS_PLACEHOLDER";
            public const string NESTED_CLASSES_PLACEHOLDER = "// ALLPACKAGE_CLASSES_STUB_NESTED_CLASSES_PLACEHOLDER";

            public const string ISABSTRACT_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_ISABSTRACT_PLACEHOLDER";
            public const string ISCLOSEABLE_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_ISCLOSEABLE_PLACEHOLDER";
            public const string ISINTERFACE_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_ISINTERFACE_PLACEHOLDER";
            public const string ISSTATIC_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_ISSTATIC_PLACEHOLDER";

            public class NestedClassStub
            {
                public const string HELP_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_CLASS_HELP_PLACEHOLDER";
                public const string CLASS_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_CLASS_PLACEHOLDER";
                public const string BASECLASS_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_BASECLASS_PLACEHOLDER";
                public const string JAVACLASS_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_JAVACLASS_PLACEHOLDER";

                public const string ISABSTRACT_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_ISABSTRACT_PLACEHOLDER";
                public const string ISCLOSEABLE_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_ISCLOSEABLE_PLACEHOLDER";
                public const string ISINTERFACE_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_ISINTERFACE_PLACEHOLDER";
                public const string ISSTATIC_PLACEHOLDER = "ALLPACKAGE_CLASSES_STUB_NESTED_ISSTATIC_PLACEHOLDER";
            }
        }
    }
}
