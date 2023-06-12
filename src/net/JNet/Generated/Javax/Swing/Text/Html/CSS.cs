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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html
{
    #region CSS
    public partial class CSS
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.html#getAllAttributeKeys()"/> 
        /// </summary>
        public static Javax.Swing.Text.Html.CSS.Attribute[] AllAttributeKeys
        {
            get { return SExecuteArray<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "getAllAttributeKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.CSS.Attribute"/></returns>
        public static Javax.Swing.Text.Html.CSS.Attribute GetAttribute(string arg0)
        {
            return SExecute<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "getAttribute", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Attribute
        public partial class Attribute
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BACKGROUND"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_ATTACHMENT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_ATTACHMENT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BACKGROUND_ATTACHMENT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BACKGROUND_COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_IMAGE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_IMAGE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BACKGROUND_IMAGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_POSITION"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_POSITION { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BACKGROUND_POSITION"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BACKGROUND_REPEAT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BACKGROUND_REPEAT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BACKGROUND_REPEAT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_BOTTOM"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM_COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_BOTTOM_COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_BOTTOM_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_BOTTOM_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_BOTTOM_WIDTH { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_BOTTOM_WIDTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_LEFT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT_COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_LEFT_COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_LEFT_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_LEFT_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_LEFT_WIDTH { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_LEFT_WIDTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_RIGHT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT_COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_RIGHT_COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_RIGHT_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_RIGHT_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_RIGHT_WIDTH { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_RIGHT_WIDTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_TOP"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP_COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP_COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_TOP_COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_TOP_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_TOP_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_TOP_WIDTH { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_TOP_WIDTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#BORDER_WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute BORDER_WIDTH { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "BORDER_WIDTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#CLEAR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute CLEAR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "CLEAR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#COLOR"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute COLOR { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "COLOR"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#DISPLAY"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute DISPLAY { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "DISPLAY"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FLOAT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FLOAT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FLOAT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FONT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_FAMILY"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_FAMILY { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FONT_FAMILY"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_SIZE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_SIZE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FONT_SIZE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FONT_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_VARIANT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_VARIANT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FONT_VARIANT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#FONT_WEIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute FONT_WEIGHT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "FONT_WEIGHT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#HEIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute HEIGHT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "HEIGHT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LETTER_SPACING"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LETTER_SPACING { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "LETTER_SPACING"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LINE_HEIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LINE_HEIGHT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "LINE_HEIGHT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "LIST_STYLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE_IMAGE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE_IMAGE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "LIST_STYLE_IMAGE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE_POSITION"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE_POSITION { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "LIST_STYLE_POSITION"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#LIST_STYLE_TYPE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute LIST_STYLE_TYPE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "LIST_STYLE_TYPE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "MARGIN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_BOTTOM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_BOTTOM { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "MARGIN_BOTTOM"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_LEFT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_LEFT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "MARGIN_LEFT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_RIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_RIGHT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "MARGIN_RIGHT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#MARGIN_TOP"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute MARGIN_TOP { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "MARGIN_TOP"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "PADDING"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_BOTTOM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_BOTTOM { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "PADDING_BOTTOM"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_LEFT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_LEFT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "PADDING_LEFT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_RIGHT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_RIGHT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "PADDING_RIGHT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#PADDING_TOP"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute PADDING_TOP { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "PADDING_TOP"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_ALIGN"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_ALIGN { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "TEXT_ALIGN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_DECORATION"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_DECORATION { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "TEXT_DECORATION"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_INDENT"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_INDENT { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "TEXT_INDENT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#TEXT_TRANSFORM"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute TEXT_TRANSFORM { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "TEXT_TRANSFORM"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#VERTICAL_ALIGN"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute VERTICAL_ALIGN { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "VERTICAL_ALIGN"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#WHITE_SPACE"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute WHITE_SPACE { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "WHITE_SPACE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#WIDTH"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute WIDTH { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "WIDTH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#WORD_SPACING"/>
            /// </summary>
            public static Javax.Swing.Text.Html.CSS.Attribute WORD_SPACING { get { return SGetField<Javax.Swing.Text.Html.CSS.Attribute>(LocalBridgeClazz, "WORD_SPACING"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#getDefaultValue()"/> 
            /// </summary>
            public string DefaultValue
            {
                get { return IExecute<string>("getDefaultValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/CSS.Attribute.html#isInherited()"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsInherited()
            {
                return IExecute<bool>("isInherited");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}