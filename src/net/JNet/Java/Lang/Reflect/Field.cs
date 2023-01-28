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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/reflect/Field.html"/>
    /// </summary>
    public class Field : AccessibleObject
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.reflect.Field";

        /// <summary>
        /// Returns the value of the field represented by this <see cref="Field"/>, on the specified object.
        /// </summary>
        public object Get(object obj) => IExecute("get", obj);
        /// <summary>
        /// Returns an <see cref="AnnotatedType"/> object that represents the use of a type to specify the declared type of the field represented by this <see cref="Field"/>.
        /// </summary>
        public AnnotatedType AnnotatedType => IExecute<AnnotatedType>("getAnnotatedType");
        /// <summary>
        /// Gets the value of a static or instance boolean field.
        /// </summary>
        public bool GetBoolean(object obj) => IExecute<bool>("getBoolean", obj);
        /// <summary>
        /// Gets the value of a static or instance byte field.
        /// </summary>
        public byte getByte(object obj) => IExecute<byte>("getByte", obj);
        /// <summary>
        /// Gets the value of a static or instance field of type char or of another primitive type convertible to type char via a widening conversion.
        /// </summary>
        public char getChar(object obj) => IExecute<char>("getChar", obj);
        /// <summary>
        /// Returns the <see cref="Class"/> object representing the class or interface that declares the field represented by this <see cref="Field"/> object.
        /// </summary>
        public Class DeclaringClass => IExecute<Class>("getDeclaringClass");
        /// <summary>
        /// Gets the value of a static or instance field of type double or of another primitive type convertible to type double via a widening conversion.
        /// </summary>
        public double GetDouble(object obj) => IExecute<double>("getDouble", obj);
        /// <summary>
        /// Gets the value of a static or instance field of type <see cref="float"/> or of another primitive type convertible to type <see cref="float"/> via a widening conversion.
        /// </summary>
        public float GetFloat(object obj) => IExecute<float>("getFloat", obj);
        /// <summary>
        /// Returns a <see cref="Type"/> object that represents the declared type for the field represented by this <see cref="Field"/> object.
        /// </summary>
        public Type GenericType => IExecute<Type>("getGenericType");
        /// <summary>
        /// Gets the value of a static or instance field of type int or of another primitive type convertible to type int via a widening conversion.
        /// </summary>
        public int getInt(object obj) => IExecute<int>("getInt", obj);
        /// <summary>
        /// Gets the value of a static or instance field of type long or of another primitive type convertible to type long via a widening conversion.
        /// </summary>
        public long getLong(object obj) => IExecute<long>("getLong", obj);
        /// <summary>
        /// Returns the Java language modifiers for the field represented by this Field object, as an integer.
        /// </summary>
        public int Modifiers => IExecute<int>("getModifiers");
        /// <summary>
        /// Returns the name of the field represented by this <see cref="Field"/> object.
        /// </summary>
        public string Name => IExecute<string>("getName");
        /// <summary>
        ///  Gets the value of a static or instance field of type short or of another primitive type convertible to type short via a widening conversion.
        /// </summary>
        public short GetShort(object obj) => IExecute<short>("getShort", obj);
        /// <summary>
        /// Returns a <see cref="Class"/> object that identifies the declared type for the field represented by this <see cref="Field"/> object.
        /// </summary>
        public Class Type => IExecute<Class>("getType");
        /// <summary>
        /// Returns true if this field represents an element of an enumerated type; returns false otherwise.
        /// </summary>
        public bool IsEnumConstant => IExecute<bool>("isEnumConstant");
        /// <summary>
        /// Returns true if this field is a synthetic field; returns false otherwise.
        /// </summary>
        public bool IsSynthetic => IExecute<bool>("isSynthetic");
        /// <summary>
        /// Sets the field represented by this Field object on the specified object argument to the specified new value.
        /// </summary>
        public void Set(object obj, object value) => IExecute("set", obj, value);
        /// <summary>
        /// Sets the value of a field as a boolean on the specified object.
        /// </summary>
        public void SetBoolean(object obj, bool z) => IExecute("setBoolean", obj, z);
        /// <summary>
        /// Sets the value of a field as a byte on the specified object.
        /// </summary>
        public void SetByte(object obj, byte b) => IExecute("setByte", obj, b);
        /// <summary>
        /// Sets the value of a field as a char on the specified object.
        /// </summary>
        public void SetChar(object obj, char c) => IExecute("setChar", obj, c);
        /// <summary>
        /// Sets the value of a field as a double on the specified object.
        /// </summary>
        public void SetDouble(object obj, double d) => IExecute("setDouble", obj, d);
        /// <summary>
        /// Sets the value of a field as a float on the specified object.
        /// </summary>
        public void SetFloat(object obj, float f) => IExecute("setFloat", obj, f);
        /// <summary>
        /// Sets the value of a field as an int on the specified object.
        /// </summary>
        public void SetInt(object obj, int i) => IExecute("setInt", obj, i);
        /// <summary>
        /// Sets the value of a field as a long on the specified object.
        /// </summary>
        public void SetLong(object obj, long l) => IExecute("setLong", obj, l);
        /// <summary>
        /// Sets the value of a field as a short on the specified object.
        /// </summary>
        public void SetShort(object obj, short s) => IExecute("setShort", obj, s);
        /// <summary>
        /// Returns a string describing this Field, including its generic type.
        /// </summary>
        public string GenericString => IExecute<string>("toGenericString");
    }
}
