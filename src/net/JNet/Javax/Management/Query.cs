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

namespace Javax.Management
{
    public class Query : JVMBridgeBase<Query>
    {
        public override string ClassName => "javax.management.Query";
        /// <summary>
        /// A code representing the div(javax.management.ValueExp, javax.management.ValueExp) expression.
        /// </summary>
        public static int DIV => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the eq(javax.management.ValueExp, javax.management.ValueExp) query.
        /// </summary>
        public static int EQ => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the geq(javax.management.ValueExp, javax.management.ValueExp) query.
        /// </summary>
        public static int GE => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the gt(javax.management.ValueExp, javax.management.ValueExp) query.
        /// </summary>
        public static int GT => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the leq(javax.management.ValueExp, javax.management.ValueExp) query.
        /// </summary>
        public static int LE => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the lt(javax.management.ValueExp, javax.management.ValueExp) query.
        /// </summary>
        public static int LT => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the minus(javax.management.ValueExp, javax.management.ValueExp) expression.
        /// </summary>
        public static int MINUS => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the plus(javax.management.ValueExp, javax.management.ValueExp) expression.
        /// </summary>
        public static int PLUS => Clazz.GetField<int>("DIV");
        /// <summary>
        /// A code representing the times(javax.management.ValueExp, javax.management.ValueExp) expression.
        /// </summary>
        public static int TIMES => Clazz.GetField<int>("DIV");
        /// <summary>
        /// Returns a query expression that is the conjunction of two other query expressions.
        /// </summary>
        public static QueryExp And(QueryExp q1, QueryExp q2) => SExecute<QueryExp>("and", q1, q2);
        /// <summary>
        /// Returns a query expression that represents a matching constraint on a string argument.
        /// </summary>
        public static QueryExp AnySubString(AttributeValueExp a, StringValueExp s) => SExecute<QueryExp>("anySubString", a, s);
        /// <summary>
        /// Returns a new attribute expression.
        /// </summary>
        public static AttributeValueExp Attr(string name) => SExecute<AttributeValueExp>("attr", name);
        /// <summary>
        /// Returns a new qualified attribute expression.
        /// </summary>
        public static AttributeValueExp Attr(string className, string name) => SExecute<AttributeValueExp>("attr", className, name);
        /// <summary>
        /// Returns a query expression that represents the constraint that one value is between two other values.
        /// </summary>
        public static QueryExp Between(ValueExp v1, ValueExp v2, ValueExp v3) => SExecute<QueryExp>("between", v1, v2, v3);
        /// <summary>
        /// Returns a new class attribute expression which can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static AttributeValueExp Classattr() => SExecute<AttributeValueExp>("classattr");
        /// <summary>
        /// Returns a binary expression representing the quotient of two numeric values.
        /// </summary>
        public static ValueExp Div(ValueExp value1, ValueExp value2) => SExecute<ValueExp>("div", value1, value2);
        /// <summary>
        /// Returns a query expression that represents an equality constraint on two values.
        /// </summary>
        public static QueryExp Eq(ValueExp v1, ValueExp v2) => SExecute<QueryExp>("eq", v1, v2);
        /// <summary>
        /// Returns a query expression that represents a matching constraint on a string argument.
        /// </summary>
        public static QueryExp FinalSubString(AttributeValueExp a, StringValueExp s) => SExecute<QueryExp>("finalSubString", a, s);
        /// <summary>
        /// Returns a query expression that represents a "greater than or equal to" constraint on two values.
        /// </summary>
        public static QueryExp Geq(ValueExp v1, ValueExp v2) => SExecute<QueryExp>("geq", v1, v2);
        /// <summary>
        /// Returns a query expression that represents a "greater than" constraint on two values.
        /// </summary>
        public static QueryExp Gt(ValueExp v1, ValueExp v2) => SExecute<QueryExp>("gt", v1, v2);
        /// <summary>
        /// Returns an expression constraining a value to be one of an explicit list.
        /// </summary>       
        public static QueryExp In(ValueExp val, ValueExp[] valueList) => SExecute<QueryExp>("in", val, valueList);
        /// <summary>
        /// Returns a query expression that represents a matching constraint on a string argument.
        /// </summary>
        public static QueryExp InitialSubString(AttributeValueExp a, StringValueExp s) => SExecute<QueryExp>("initialSubString", a, s);
        /// <summary>
        /// Returns a query expression that represents an inheritance constraint on an MBean class.
        /// </summary>
        public static QueryExp IsInstanceOf(StringValueExp classNameValue) => SExecute<QueryExp>("isInstanceOf", classNameValue);
        /// <summary>
        /// Returns a query expression that represents a "less than or equal to" constraint on two values.
        /// </summary>
        public static QueryExp Leq(ValueExp v1, ValueExp v2) => SExecute<QueryExp>("leq", v1, v2);
        /// <summary>
        /// Returns a query expression that represents a "less than" constraint on two values.
        /// </summary>
        public static QueryExp Lt(ValueExp v1, ValueExp v2) => SExecute<QueryExp>("lt", v1, v2);
        /// <summary>
        /// Returns a query expression that represents a matching constraint on a string argument.
        /// </summary>
        public static QueryExp Match(AttributeValueExp a, StringValueExp s) => SExecute<QueryExp>("match", a, s);
        /// <summary>
        /// Returns a binary expression representing the difference between two numeric values.
        /// </summary>
        public static ValueExp Minus(ValueExp value1, ValueExp value2) => SExecute<ValueExp>("minus", value1, value2);
        /// <summary>
        /// Returns a constraint that is the negation of its argument.
        /// </summary>
        public static QueryExp Not(QueryExp queryExp) => SExecute<QueryExp>("not", queryExp);
        /// <summary>
        /// Returns a query expression that is the disjunction of two other query expressions.
        /// </summary>
        public static QueryExp Or(QueryExp q1, QueryExp q2) => SExecute<QueryExp>("or", q1, q2);
        /// <summary>
        /// Returns a binary expression representing the sum of two numeric values, or the concatenation of two string values.
        /// </summary>
        public static ValueExp Plus(ValueExp value1, ValueExp value2) => SExecute<ValueExp>("plus", value1, value2);
        /// <summary>
        /// Returns a binary expression representing the product of two numeric values.
        /// </summary>
        public static ValueExp Times(ValueExp value1, ValueExp value2) => SExecute<ValueExp>("times", value1, value2);
        /// <summary>
        /// Returns a boolean value expression that can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static ValueExp Value(bool val) => SExecute<ValueExp>("value", val);
        /// <summary>
        /// Returns a numeric value expression that can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static ValueExp Value(double val) => SExecute<ValueExp>("value", val);
        /// <summary>
        /// Returns a numeric value expression that can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static ValueExp Value(float val) => SExecute<ValueExp>("avaluend", val);
        /// <summary>
        /// Returns a numeric value expression that can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static ValueExp Value(int val) => SExecute<ValueExp>("value", val);
        /// <summary>
        /// Returns a numeric value expression that can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static ValueExp Value(long val) => SExecute<ValueExp>("value", val);
        /// <summary>
        /// Returns a numeric value expression that can be used in any Query call that expects a ValueExp.
        /// </summary>
        public static ValueExp Value(Java.Lang.Number val) => SExecute<ValueExp>("value", val);
        /// <summary>
        /// Returns a new string expression.
        /// </summary>
        public static StringValueExp Value(string val) => SExecute<StringValueExp>("value", val);
    }
}
