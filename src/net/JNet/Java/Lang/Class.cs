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

using Java.Lang.Reflect;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Class.html"/>
    /// </summary>
    public class Class : JVMBridgeBase<Class>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.Class";
        /// <summary>
        /// Returns the <see cref="Class"/> object associated with the class or interface with the given string name.
        /// </summary>
        /// <param name="className">The fully qualified name of the desired class.</param>
        /// <returns>The <see cref="Class"/> object for the class with the specified name.</returns>
        public static Class ForName(string className)
        {
            return SExecute<Class>("forName", className);
        }
        /// <summary>
        /// Returns the <see cref="Class"/> object associated with the class or interface with the given string name.
        /// </summary>
        /// <param name="className">The fully qualified name of the desired class.</param>
        /// <param name="initialize">If <see langword="true"/> the class will be initialized. See Section 12.4 of The Java Language Specification.</param>
        /// <param name="loader">Class loader from which the class must be loaded</param>
        /// <returns>The <see cref="Class"/> object for the class with the specified name.</returns>
        public static Class ForName(string className, bool initialize, ClassLoader loader)
        {
            return SExecute<Class>("forName", className, initialize, loader);
        }
        /// <summary>
        /// Returns the <see cref="Class"/> object associated with the class or interface with the given string name.
        /// </summary>
        /// <typeparam name="T">The type implementing <see cref="IJVMBridgeBase"/></typeparam>
        /// <returns>The <see cref="Class{T}"/> object for the class with the specified name.</returns>
        public static Class<T> Of<T>() where T : IJVMBridgeBase, new()
        {
            return SExecute<Class<T>>("forName", ClassNameOf<T>());
        }

        /// <summary>
        /// Casts this <see cref="Class"/> object to represent a subclass of the class represented by the specified class object. 
        /// Checks that the cast is valid, and throws a ClassCastException if it is not. If this method succeeds, it always returns a reference to this class object. 
        /// </summary>
        /// <typeparam name="U">The type implementing <see cref="IJVMBridgeBase"/></typeparam>
        /// <param name="clazz">The class of the type to cast this class object to</param>
        /// <returns>This <see cref="Class"/> object, cast to represent a subclass of the specified class object.</returns>
        public Class<U> AsSubclass<U>(Class<U> clazz) where U : IJVMBridgeBase, new() => IExecute<Class<U>>("asSubclass", clazz);
        /// <summary>
        /// Returns the assertion status that would be assigned to this class if it were to be initialized at the time this method is invoked. 
        /// If this class has had its assertion status set, the most recent setting will be returned; 
        /// otherwise, if any package default assertion status pertains to this class, the most recent setting for the most specific pertinent package default assertion status is returned; otherwise, if this class is not a system class (i.e., it has a class loader) its class loader's default assertion status is returned; otherwise, the system class default assertion status is returned. 
        /// </summary>
        public bool DesiredAssertionStatus => IExecute<bool>("desiredAssertionStatus");
        /// <summary>
        /// Returns an array of <see cref="AnnotatedType"/> objects that represent the use of types to specify superinterfaces of the entity represented by this <see cref="Class"/> object.
        /// </summary>
        /// <returns></returns>
        public AnnotatedType[] AnnotatedInterfaces => this.IExecuteArray<AnnotatedType>("getAnnotatedInterfaces");
        /// <summary>
        /// Returns an <see cref="AnnotatedType"/> object that represents the use of a type to specify the superclass of the entity represented by this <see cref="Class"/> object.
        /// </summary>
        public AnnotatedType AnnotatedSuperclass => IExecute<AnnotatedType>("getAnnotatedSuperclass");
        /// <summary>
        /// Returns this element's annotation for the specified type if such an annotation is present, else null.
        /// </summary>
        public A GetAnnotation<A>(Class<A> annotationClass) where A : Annotation.Annotation => IExecute<A>("getAnnotation", annotationClass);
        /// <summary>
        /// Returns annotations that are present on this element.
        /// </summary>
        /// <returns></returns>
        public Annotation.Annotation[] Annotations => this.IExecuteArray<Annotation.Annotation>("getAnnotations");
        /// <summary>
        /// Returns annotations that are associated with this element.
        /// </summary>
        public A[] GetAnnotationsByType<A>(Class<A> annotationClass) where A : Annotation.Annotation => this.IExecuteArray<A>("getAnnotationsByType", annotationClass);
        /// <summary>
        /// Returns the canonical name of the underlying class as defined by the Java Language Specification.
        /// Returns null if the underlying class does not have a canonical name (i.e., if it is a local or anonymous class or an array whose component type does not have a canonical name).
        /// </summary>
        public string CanonicalName => IExecute<string>("getCanonicalName");
        /// <summary>
        /// Returns an array containing <see cref="Class"/> objects representing all the public classes and interfaces that are members of the class represented by this <see cref="Class"/> object.
        /// </summary>
        public Class[] Classes => this.IExecuteArray<Class>("getClasses");
        /// <summary>
        /// Returns the class loader for the class. Some implementations may use null to represent the bootstrap class loader. This method will return null in such implementations if this class was loaded by the bootstrap class loader. 
        /// </summary>
        public ClassLoader ClassLoader => IExecute<ClassLoader>("getClassLoader");
        /// <summary>
        /// Returns the <see cref="Class"/> representing the component type of an array.
        /// </summary>
        public Class ComponentType => IExecute<Class>("getComponentType");
        /// <summary>
        /// Returns a Constructor object that reflects the specified public constructor of the class represented by this Class object.
        /// </summary>
        public Constructor GetConstructor(params Class[] parameterTypes) => IExecute<Constructor>("getConstructor", parameterTypes);
        /// <summary>
        /// Returns an array containing <see cref="Constructor"/> objects reflecting all the public constructors of the class represented by this <see cref="Class"/> object..
        /// </summary>
        public Constructor[] Constructors => this.IExecuteArray<Constructor>("getConstructors");
        /// <summary>
        /// Returns all annotations that are directly present on this element.
        /// </summary>
        public Annotation.Annotation[] DeclaredAnnotations => this.IExecuteArray<Annotation.Annotation>("getDeclaredAnnotations");
        /// <summary>
        /// Returns an array of <see cref="Class"/> objects reflecting all the classes and interfaces declared as members of the class represented by this <see cref="Class"/> object.
        /// </summary>
        public Class[] DeclaredClasses => this.IExecuteArray<Class>("getDeclaredClasses");
        /// <summary>
        /// Returns a Constructor object that reflects the specified constructor of the class or interface represented by this Class object.
        /// </summary>
        public Constructor GetDeclaredConstructor(params Class[] parameterTypes) => IExecute<Constructor>("getDeclaredConstructor", parameterTypes);
        /// <summary>
        /// Returns an array of <see cref="Constructor"/> objects reflecting all the constructors declared by the class represented by this <see cref="Class"/> object.
        /// </summary>
        public Constructor[] DeclaredConstructors => this.IExecuteArray<Constructor>("getDeclaredConstructors");
        /// <summary>
        /// Returns a <see cref="Field"/> object that reflects the specified declared field of the class or interface represented by this <see cref="Class"/> object.
        /// </summary>
        public Field GetDeclaredField(string name) => IExecute<Field>("getDeclaredField", name);
        /// <summary>
        /// Returns a <see cref="Method"/> object that reflects the specified declared method of the class or interface represented by this <see cref="Class"/> object.
        /// </summary>
        public Method GetDeclaredMethod(string name) => IExecute<Method>("getDeclaredMethod", name);
        /// <summary>
        /// Returns an array of <see cref="Method"/> objects reflecting all the methods declared by the class or interface represented by this <see cref="Class"/> object.
        /// </summary>
        public Method[] DeclaredMethods => this.IExecuteArray<Method>("getDeclaredMethods");
        /// <summary>
        /// If the class or interface represented by this <see cref="Class"/> object is a member of another class, returns the <see cref="Class"/> object representing the class in which it was declared.
        /// </summary>
        public Class DeclaringClass => IExecute<Class>("getDeclaringClass");
        /// <summary>
        /// Returns the immediately enclosing class of the underlying class.
        /// </summary>
        public Class EnclosingClass => IExecute<Class>("getEnclosingClass");
        /// <summary>
        /// If this <see cref="Class"/> object represents a local or anonymous class within a constructor, returns a <see cref="Constructor"/> object representing the immediately enclosing constructor of the underlying class.
        /// </summary>
        public Constructor EnclosingConstructor => IExecute<Constructor>("getEnclosingConstructor");
        /// <summary>
        /// If this <see cref="Class"/> object represents a local or anonymous class within a method, returns a <see cref="Method"/> object representing the immediately enclosing method of the underlying class.
        /// </summary>
        public Method EnclosingMethod => IExecute<Method>("getEnclosingMethod");
        /// <summary>
        /// Returns the elements of this enum class or null if this <see cref="Class"/> object does not represent an enum type.
        /// </summary>
        public object[] EnumConstants => this.IExecuteArray<object>("getEnumConstants");
        /// <summary>
        /// Returns a <see cref="Field"/> object that reflects the specified public member field of the class or interface represented by this <see cref="Class"/> object.
        /// </summary>
        public Field GetField(string name) => IExecute<Field>("getField", name);
        /// <summary>
        /// Returns an array containing <see cref="Field"/> objects reflecting all the accessible public fields of the class or interface represented by this <see cref="Class"/> object.
        /// </summary>
        public Field[] Fields => this.IExecuteArray<Field>("getFields");
        /// <summary>
        /// Returns the <see cref="Type"/>s representing the interfaces directly implemented by the class or interface represented by this object.
        /// </summary>
        public Type[] GenericInterfaces => this.IExecuteArray<Type>("getGenericInterfaces");
        /// <summary>
        /// Returns the <see cref="Type"/> representing the direct superclass of the entity (class, interface, primitive type or void) represented by this <see cref="Class"/>.
        /// </summary>
        public Type GenericSuperClass => IExecute<Type>("getGenericSuperclass");
        /// <summary>
        /// Determines the interfaces implemented by the class or interface represented by this object.
        /// </summary>
        public Class[] Interfaces => this.IExecuteArray<Class>("getInterfaces");
        /// <summary>
        /// Returns a <see cref="Method"/> object that reflects the specified public member method of the class or interface represented by this <see cref="Class"/> object.
        /// </summary>
        public Method GetMethod(string name, params Class[] parameterTypes) => IExecute<Method>("getMethod", name, parameterTypes);
        /// <summary>
        /// Returns an array containing Method objects reflecting all the public member methods of the class or interface represented by this <see cref="Class"/> object, including those declared by the class or interface and those inherited from superclasses and superinterfaces.
        /// </summary>
        public Method[] Methods => this.IExecuteArray<Method>("getMethods");
        /// <summary>
        /// Returns the Java language modifiers for this class or interface, encoded in an integer.
        /// </summary>
        public int Modifiers => IExecute<int>("getModifiers");
        /// <summary>
        /// Returns the name of the entity (class, interface, array class, primitive type, or void) represented by this <see cref="Class"/> object, as a <see cref="string"/>.
        /// </summary>
        public string Name => IExecute<string>("getName");
        /// <summary>
        /// Gets the package for this class.
        /// </summary>
        public Package Package => IExecute<Package>("getPackage");
        /// <summary>
        /// Returns the simple name of the underlying class as given in the source code. Returns an empty string if the underlying class is anonymous. 
        /// </summary>
        public string SimpleName => IExecute<string>("getSimpleName");
        /// <summary>
        /// Returns the <see cref="Class"/> representing the superclass of the entity (class, interface, primitive type or void) represented by this <see cref="Class"/>. 
        /// </summary>
        public Class SuperClass => IExecute<Class>("getSuperclass");
        /// <summary>
        /// Return an informative string for the name of this type.
        /// </summary>
        public string TypeName => IExecute<string>("getTypeName");
        /// <summary>
        /// Returns an array of <see cref="TypeVariable"/> objects that represent the type variables declared by the generic declaration represented by this <see cref="GenericDeclaration"/> object, in declaration order.
        /// </summary>
        public TypeVariable[] TypeParameters => this.IExecuteArray<TypeVariable>("getTypeParameters");
        /// <summary>
        /// Returns <see langword="true"/> if an annotation for the specified type is present on this element, else <see langword="false"/>. This method is designed primarily for convenient access to marker annotations. 
        /// </summary>
        /// <typeparam name="TAnnotation">The <see cref="Annotation.Annotation"/> class</typeparam>
        /// <param name="annotationClass">the <see cref="Class"/> object corresponding to the annotation type</param>
        /// <returns><see langword="true"/> if an annotation for the specified annotation type is present on this element, else <see langword="false"/></returns>
        public bool IsAnnotationPresent<TAnnotation>(Class<TAnnotation> annotationClass)
            where TAnnotation : Annotation.Annotation, IJVMBridgeBase, new()
        {
            return IExecute<bool>("isAnnotationPresent", annotationClass);
        }
        /// <summary>
        /// Returns true if this Class object represents an annotation type.
        /// </summary>
        public bool IsAnnotation => IExecute<bool>("isAnnotation");
        /// <summary>
        /// Returns true if and only if the underlying class is an anonymous class.
        /// </summary>
        public bool IsAnonymousClass => IExecute<bool>("isAnonymousClass");
        /// <summary>
        /// Determines if this Class object represents an array class.
        /// </summary>
        public bool IsArray => IExecute<bool>("isArray");
        /// <summary>
        /// Determines if the class or interface represented by this Class object is either the same as, or is a superclass or superinterface of, the class or interface represented by the specified Class parameter.
        /// </summary>
        /// <param name="cls">The <see cref="Class"/> object to be checked</param>
        /// <returns>The boolean value indicating whether objects of the type cls can be assigned to objects of this class</returns>
        public bool IsAssignableFrom(Class cls) => IExecute<bool>("isAssignableFrom", cls);
        /// <summary>
        /// Returns true if and only if this class was declared as an enum in the source code.
        /// </summary>
        public bool IsEnum => IExecute<bool>("isEnum");
        /// <summary>
        /// Determines if the specified Object is assignment-compatible with the object represented by this <see cref="Class"/>. 
        /// </summary>
        /// <param name="obj">The object to check</param>
        /// <returns><see langword="true"/> if obj is an instance of this class</returns>
        public bool IsInstance(object obj) => IExecute<bool>("isInstance", obj);
        /// <summary>
        /// Determines if the specified Class object represents an interface type.
        /// </summary>
        public new bool IsInterface => IExecute<bool>("isInterface");
        /// <summary>
        /// Returns true if and only if the underlying class is a local class.
        /// </summary>
        public bool IsLocalClass => IExecute<bool>("isLocalClass");
        /// <summary>
        /// Returns true if and only if the underlying class is a member class.
        /// </summary>
        public bool IsMemberClass => IExecute<bool>("isMemberClass");
        /// <summary>
        /// Determines if the specified Class object represents a primitive type.
        /// </summary>
        public bool IsPrimitive => IExecute<bool>("isPrimitive");
        /// <summary>
        /// Returns true if this class is a synthetic class; returns false otherwise.
        /// </summary>
        public bool IsSynthetic => IExecute<bool>("isSynthetic");
        /// <summary>
        /// Returns a string describing this <see cref="Class"/>, including information about modifiers and type parameters. 
        /// </summary>
        public string GenericString => IExecute<string>("toGenericString");
    }
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Class.html"/>
    /// </summary>
    /// <typeparam name="T">the type of the class modeled by this <see cref="Class{T}"/> object.</typeparam>
    public class Class<T> : Class where T : IJVMBridgeBase
    {
        /// <summary>
        /// Casts an object to the class or interface represented by this Class object.
        /// </summary>
        /// <param name="obj">The object to be cast</param>
        /// <returns>The object after casting, or null if obj is null</returns>
        public T Cast(object obj) => IExecute<T>("cast", obj);
        /// <summary>
        /// Creates a new instance of the class represented by this <see cref="Class"/> object.
        /// </summary>
        /// <returns>A newly allocated instance of the class represented by this object.</returns>
        public T NewInstance() => IExecute<T>("newInstance");
    }

}
