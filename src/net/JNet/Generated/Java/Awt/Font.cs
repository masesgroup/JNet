/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Font
    public partial class Font
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#%3Cinit%3E(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Font(string arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public Font(Java.Util.Map arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#BOLD"/>
        /// </summary>
        public static int BOLD { get { if (!_BOLDReady) { _BOLDContent = SGetField<int>(LocalBridgeClazz, "BOLD"); _BOLDReady = true; } return _BOLDContent; } }
        private static int _BOLDContent = default;
        private static bool _BOLDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#CENTER_BASELINE"/>
        /// </summary>
        public static int CENTER_BASELINE { get { if (!_CENTER_BASELINEReady) { _CENTER_BASELINEContent = SGetField<int>(LocalBridgeClazz, "CENTER_BASELINE"); _CENTER_BASELINEReady = true; } return _CENTER_BASELINEContent; } }
        private static int _CENTER_BASELINEContent = default;
        private static bool _CENTER_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#HANGING_BASELINE"/>
        /// </summary>
        public static int HANGING_BASELINE { get { if (!_HANGING_BASELINEReady) { _HANGING_BASELINEContent = SGetField<int>(LocalBridgeClazz, "HANGING_BASELINE"); _HANGING_BASELINEReady = true; } return _HANGING_BASELINEContent; } }
        private static int _HANGING_BASELINEContent = default;
        private static bool _HANGING_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#ITALIC"/>
        /// </summary>
        public static int ITALIC { get { if (!_ITALICReady) { _ITALICContent = SGetField<int>(LocalBridgeClazz, "ITALIC"); _ITALICReady = true; } return _ITALICContent; } }
        private static int _ITALICContent = default;
        private static bool _ITALICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#LAYOUT_LEFT_TO_RIGHT"/>
        /// </summary>
        public static int LAYOUT_LEFT_TO_RIGHT { get { if (!_LAYOUT_LEFT_TO_RIGHTReady) { _LAYOUT_LEFT_TO_RIGHTContent = SGetField<int>(LocalBridgeClazz, "LAYOUT_LEFT_TO_RIGHT"); _LAYOUT_LEFT_TO_RIGHTReady = true; } return _LAYOUT_LEFT_TO_RIGHTContent; } }
        private static int _LAYOUT_LEFT_TO_RIGHTContent = default;
        private static bool _LAYOUT_LEFT_TO_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#LAYOUT_NO_LIMIT_CONTEXT"/>
        /// </summary>
        public static int LAYOUT_NO_LIMIT_CONTEXT { get { if (!_LAYOUT_NO_LIMIT_CONTEXTReady) { _LAYOUT_NO_LIMIT_CONTEXTContent = SGetField<int>(LocalBridgeClazz, "LAYOUT_NO_LIMIT_CONTEXT"); _LAYOUT_NO_LIMIT_CONTEXTReady = true; } return _LAYOUT_NO_LIMIT_CONTEXTContent; } }
        private static int _LAYOUT_NO_LIMIT_CONTEXTContent = default;
        private static bool _LAYOUT_NO_LIMIT_CONTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#LAYOUT_NO_START_CONTEXT"/>
        /// </summary>
        public static int LAYOUT_NO_START_CONTEXT { get { if (!_LAYOUT_NO_START_CONTEXTReady) { _LAYOUT_NO_START_CONTEXTContent = SGetField<int>(LocalBridgeClazz, "LAYOUT_NO_START_CONTEXT"); _LAYOUT_NO_START_CONTEXTReady = true; } return _LAYOUT_NO_START_CONTEXTContent; } }
        private static int _LAYOUT_NO_START_CONTEXTContent = default;
        private static bool _LAYOUT_NO_START_CONTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#LAYOUT_RIGHT_TO_LEFT"/>
        /// </summary>
        public static int LAYOUT_RIGHT_TO_LEFT { get { if (!_LAYOUT_RIGHT_TO_LEFTReady) { _LAYOUT_RIGHT_TO_LEFTContent = SGetField<int>(LocalBridgeClazz, "LAYOUT_RIGHT_TO_LEFT"); _LAYOUT_RIGHT_TO_LEFTReady = true; } return _LAYOUT_RIGHT_TO_LEFTContent; } }
        private static int _LAYOUT_RIGHT_TO_LEFTContent = default;
        private static bool _LAYOUT_RIGHT_TO_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#PLAIN"/>
        /// </summary>
        public static int PLAIN { get { if (!_PLAINReady) { _PLAINContent = SGetField<int>(LocalBridgeClazz, "PLAIN"); _PLAINReady = true; } return _PLAINContent; } }
        private static int _PLAINContent = default;
        private static bool _PLAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#ROMAN_BASELINE"/>
        /// </summary>
        public static int ROMAN_BASELINE { get { if (!_ROMAN_BASELINEReady) { _ROMAN_BASELINEContent = SGetField<int>(LocalBridgeClazz, "ROMAN_BASELINE"); _ROMAN_BASELINEReady = true; } return _ROMAN_BASELINEContent; } }
        private static int _ROMAN_BASELINEContent = default;
        private static bool _ROMAN_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#TRUETYPE_FONT"/>
        /// </summary>
        public static int TRUETYPE_FONT { get { if (!_TRUETYPE_FONTReady) { _TRUETYPE_FONTContent = SGetField<int>(LocalBridgeClazz, "TRUETYPE_FONT"); _TRUETYPE_FONTReady = true; } return _TRUETYPE_FONTContent; } }
        private static int _TRUETYPE_FONTContent = default;
        private static bool _TRUETYPE_FONTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#TYPE1_FONT"/>
        /// </summary>
        public static int TYPE1_FONT { get { if (!_TYPE1_FONTReady) { _TYPE1_FONTContent = SGetField<int>(LocalBridgeClazz, "TYPE1_FONT"); _TYPE1_FONTReady = true; } return _TYPE1_FONTContent; } }
        private static int _TYPE1_FONTContent = default;
        private static bool _TYPE1_FONTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#DIALOG"/>
        /// </summary>
        public static string DIALOG { get { if (!_DIALOGReady) { _DIALOGContent = SGetField<string>(LocalBridgeClazz, "DIALOG"); _DIALOGReady = true; } return _DIALOGContent; } }
        private static string _DIALOGContent = default;
        private static bool _DIALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#DIALOG_INPUT"/>
        /// </summary>
        public static string DIALOG_INPUT { get { if (!_DIALOG_INPUTReady) { _DIALOG_INPUTContent = SGetField<string>(LocalBridgeClazz, "DIALOG_INPUT"); _DIALOG_INPUTReady = true; } return _DIALOG_INPUTContent; } }
        private static string _DIALOG_INPUTContent = default;
        private static bool _DIALOG_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#MONOSPACED"/>
        /// </summary>
        public static string MONOSPACED { get { if (!_MONOSPACEDReady) { _MONOSPACEDContent = SGetField<string>(LocalBridgeClazz, "MONOSPACED"); _MONOSPACEDReady = true; } return _MONOSPACEDContent; } }
        private static string _MONOSPACEDContent = default;
        private static bool _MONOSPACEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#SANS_SERIF"/>
        /// </summary>
        public static string SANS_SERIF { get { if (!_SANS_SERIFReady) { _SANS_SERIFContent = SGetField<string>(LocalBridgeClazz, "SANS_SERIF"); _SANS_SERIFReady = true; } return _SANS_SERIFContent; } }
        private static string _SANS_SERIFContent = default;
        private static bool _SANS_SERIFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#SERIF"/>
        /// </summary>
        public static string SERIF { get { if (!_SERIFReady) { _SERIFContent = SGetField<string>(LocalBridgeClazz, "SERIF"); _SERIFReady = true; } return _SERIFContent; } }
        private static string _SERIFContent = default;
        private static bool _SERIFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#textRequiresLayout(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool TextRequiresLayout(char[] arg0, int arg1, int arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "textRequiresLayout", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createFont(int,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        /// <exception cref="Java.Awt.FontFormatException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.Font CreateFont(int arg0, Java.Io.File arg1)
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "createFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createFont(int,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        /// <exception cref="Java.Awt.FontFormatException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.Font CreateFont(int arg0, Java.Io.InputStream arg1)
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "createFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font Decode(string arg0)
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "decode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFont(java.lang.String,java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont(string arg0, Java.Awt.Font arg1)
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "getFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFont(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont(string arg0)
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "getFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFont(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></typeparam>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Map<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute, object> arg0) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute: Java.Text.AttributedCharacterIterator.Attribute
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "getFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createFonts(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        /// <exception cref="Java.Awt.FontFormatException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.Font[] CreateFonts(Java.Io.File arg0)
        {
            return SExecuteArray<Java.Awt.Font>(LocalBridgeClazz, "createFonts", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createFonts(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        /// <exception cref="Java.Awt.FontFormatException"/>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.Font[] CreateFonts(Java.Io.InputStream arg0)
        {
            return SExecuteArray<Java.Awt.Font>(LocalBridgeClazz, "createFonts", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map<Java.Awt.FontNs.TextAttribute, object> Attributes
        {
            get { return IExecute<Java.Util.Map<Java.Awt.FontNs.TextAttribute, object>>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getAvailableAttributes()"/> 
        /// </summary>
        public Java.Text.AttributedCharacterIterator.Attribute[] AvailableAttributes
        {
            get { return IExecuteArray<Java.Text.AttributedCharacterIterator.Attribute>("getAvailableAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFamily()"/> 
        /// </summary>
        public string Family
        {
            get { return IExecute<string>("getFamily"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFontName()"/> 
        /// </summary>
        public string FontName
        {
            get { return IExecute<string>("getFontName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getItalicAngle()"/> 
        /// </summary>
        public float ItalicAngle
        {
            get { return IExecute<float>("getItalicAngle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getMissingGlyphCode()"/> 
        /// </summary>
        public int MissingGlyphCode
        {
            get { return IExecute<int>("getMissingGlyphCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getNumGlyphs()"/> 
        /// </summary>
        public int NumGlyphs
        {
            get { return IExecute<int>("getNumGlyphs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getPSName()"/> 
        /// </summary>
        public string PSName
        {
            get { return IExecute<string>("getPSName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getSize()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("getSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getSize2D()"/> 
        /// </summary>
        public float Size2D
        {
            get { return IExecute<float>("getSize2D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getStyle()"/> 
        /// </summary>
        public int Style
        {
            get { return IExecute<int>("getStyle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#canDisplay(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanDisplay(char arg0)
        {
            return IExecute<bool>("canDisplay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#canDisplay(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanDisplay(int arg0)
        {
            return IExecute<bool>("canDisplay", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#hasLayoutAttributes()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasLayoutAttributes()
        {
            return IExecute<bool>("hasLayoutAttributes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#hasUniformLineMetrics()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasUniformLineMetrics()
        {
            return IExecute<bool>("hasUniformLineMetrics");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#isBold()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBold()
        {
            return IExecute<bool>("isBold");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#isItalic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsItalic()
        {
            return IExecute<bool>("isItalic");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#isPlain()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPlain()
        {
            return IExecute<bool>("isPlain");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#isTransformed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTransformed()
        {
            return IExecute<bool>("isTransformed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getBaselineFor(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte GetBaselineFor(char arg0)
        {
            return IExecute<byte>("getBaselineFor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#canDisplayUpTo(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CanDisplayUpTo(char[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("canDisplayUpTo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#canDisplayUpTo(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int CanDisplayUpTo(string arg0)
        {
            return IExecute<int>("canDisplayUpTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#canDisplayUpTo(java.text.CharacterIterator,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CanDisplayUpTo(Java.Text.CharacterIterator arg0, int arg1, int arg2)
        {
            return IExecute<int>("canDisplayUpTo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#deriveFont(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveFont(float arg0)
        {
            return IExecute<Java.Awt.Font>("deriveFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#deriveFont(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveFont(int arg0, float arg1)
        {
            return IExecute<Java.Awt.Font>("deriveFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#deriveFont(int,java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveFont(int arg0, Java.Awt.Geom.AffineTransform arg1)
        {
            return IExecute<Java.Awt.Font>("deriveFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#deriveFont(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveFont(int arg0)
        {
            return IExecute<Java.Awt.Font>("deriveFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#deriveFont(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveFont(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecute<Java.Awt.Font>("deriveFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#deriveFont(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></typeparam>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public Java.Awt.Font DeriveFont<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Map<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute, object> arg0) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute: Java.Text.AttributedCharacterIterator.Attribute
        {
            return IExecute<Java.Awt.Font>("deriveFont", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createGlyphVector(java.awt.font.FontRenderContext,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphVector"/></returns>
        public Java.Awt.FontNs.GlyphVector CreateGlyphVector(Java.Awt.FontNs.FontRenderContext arg0, char[] arg1)
        {
            return IExecute<Java.Awt.FontNs.GlyphVector>("createGlyphVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createGlyphVector(java.awt.font.FontRenderContext,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphVector"/></returns>
        public Java.Awt.FontNs.GlyphVector CreateGlyphVector(Java.Awt.FontNs.FontRenderContext arg0, int[] arg1)
        {
            return IExecute<Java.Awt.FontNs.GlyphVector>("createGlyphVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createGlyphVector(java.awt.font.FontRenderContext,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphVector"/></returns>
        public Java.Awt.FontNs.GlyphVector CreateGlyphVector(Java.Awt.FontNs.FontRenderContext arg0, string arg1)
        {
            return IExecute<Java.Awt.FontNs.GlyphVector>("createGlyphVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#createGlyphVector(java.awt.font.FontRenderContext,java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="Java.Text.CharacterIterator"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphVector"/></returns>
        public Java.Awt.FontNs.GlyphVector CreateGlyphVector(Java.Awt.FontNs.FontRenderContext arg0, Java.Text.CharacterIterator arg1)
        {
            return IExecute<Java.Awt.FontNs.GlyphVector>("createGlyphVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#layoutGlyphVector(java.awt.font.FontRenderContext,char[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphVector"/></returns>
        public Java.Awt.FontNs.GlyphVector LayoutGlyphVector(Java.Awt.FontNs.FontRenderContext arg0, char[] arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<Java.Awt.FontNs.GlyphVector>("layoutGlyphVector", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getLineMetrics(char[],int,int,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(char[] arg0, int arg1, int arg2, Java.Awt.FontNs.FontRenderContext arg3)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getLineMetrics(java.lang.String,int,int,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(string arg0, int arg1, int arg2, Java.Awt.FontNs.FontRenderContext arg3)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getLineMetrics(java.lang.String,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(string arg0, Java.Awt.FontNs.FontRenderContext arg1)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getLineMetrics(java.text.CharacterIterator,int,int,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(Java.Text.CharacterIterator arg0, int arg1, int arg2, Java.Awt.FontNs.FontRenderContext arg3)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getMaxCharBounds(java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetMaxCharBounds(Java.Awt.FontNs.FontRenderContext arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getMaxCharBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getStringBounds(char[],int,int,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(char[] arg0, int arg1, int arg2, Java.Awt.FontNs.FontRenderContext arg3)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getStringBounds(java.lang.String,int,int,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(string arg0, int arg1, int arg2, Java.Awt.FontNs.FontRenderContext arg3)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getStringBounds(java.lang.String,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(string arg0, Java.Awt.FontNs.FontRenderContext arg1)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getStringBounds(java.text.CharacterIterator,int,int,java.awt.font.FontRenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(Java.Text.CharacterIterator arg0, int arg1, int arg2, Java.Awt.FontNs.FontRenderContext arg3)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFamily(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetFamily(Java.Util.Locale arg0)
        {
            return IExecute<string>("getFamily", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Font.html#getFontName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetFontName(Java.Util.Locale arg0)
        {
            return IExecute<string>("getFontName", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}