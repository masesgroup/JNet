﻿/*
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

using MASES.JNet;
using System;
using System.Collections.Generic;

namespace MASES.JNetPSCore
{
    public static class JNetPSCoreExtensions
    {
        static Type CheckOn(Type source, Type t)
        {
            if (t.IsGenericTypeDefinition)
            {
                if (source.IsGenericType)
                {
                    return source.GetGenericTypeDefinition();
                }
                else
                {
                    return source;
                }
            }
            return source;
        }

        public static Type TraverseUntil(this Type source, Type t)
        {
            var baseType = source;
            while(baseType != null && CheckOn(baseType, t) != t)
            {
                baseType = baseType.BaseType;
            }

            return baseType;
        }
    }

    /// <summary>
    /// Public entry point of <see cref="JNetPSCore{T}"/>
    /// </summary>
    public abstract class JNetPSCore<T> : JNetCore<T> where T : JNetPSCore<T>
    {
        #region Initialization
  
        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetPSCore()
        {
        }

        protected override IDictionary<string, string> Options => new Dictionary<string, string>();

        /// <inheritdoc cref="JNetCoreBase{T}.PathToParse"/>
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;
                //foreach (var item in _JarsToAnaylyze)
                //{
                //    lst.Add(Path.GetFullPath(item));
                //}        
                return lst;
            }
        }
        #endregion

#if DEBUG
        public override bool EnableDebug => true;
#endif
    }
    /// <summary>
    /// Concrete implementation of <see cref="JNetPSCore{T}"/>
    /// </summary>
    public class JNetPSCore : JNetPSCore<JNetPSCore>
    {
    }
}