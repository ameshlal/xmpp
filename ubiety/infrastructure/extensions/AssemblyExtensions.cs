// AssemblyExtensions.cs
//
//Ubiety XMPP Library Copyright (C) 2006 - 2015 Dieter Lunn
//
//This library is free software; you can redistribute it and/or modify it under
//the terms of the GNU Lesser General Public License as published by the Free
//Software Foundation; either version 3 of the License, or (at your option)
//any later version.
//
//This library is distributed in the hope that it will be useful, but WITHOUT
//ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
//FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
//
//You should have received a copy of the GNU Lesser General Public License along
//with this library; if not, write to the Free Software Foundation, Inc., 59
//Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Collections.Generic;
using System.Reflection;

namespace ubiety.infrastructure.extensions
{
    /// <summary>
    /// </summary>
    public static class AssemblyExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="assembly"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetAttributes<T>(this Assembly assembly) where T : Attribute
        {
            var tags = new List<T>();
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                type.GetCustomAttributes<T>(true).Apply(tags.Add);
            }

            return tags;
        }
    }
}