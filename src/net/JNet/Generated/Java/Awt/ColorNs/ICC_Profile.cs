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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ColorNs
{
    #region ICC_Profile
    public partial class ICC_Profile
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ColorNs.ICC_Profile"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.ColorNs.ICC_Profile t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_ABSTRACT"/>
        /// </summary>
        public static int CLASS_ABSTRACT => Clazz.GetField<int>("CLASS_ABSTRACT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_COLORSPACECONVERSION"/>
        /// </summary>
        public static int CLASS_COLORSPACECONVERSION => Clazz.GetField<int>("CLASS_COLORSPACECONVERSION");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_DEVICELINK"/>
        /// </summary>
        public static int CLASS_DEVICELINK => Clazz.GetField<int>("CLASS_DEVICELINK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_DISPLAY"/>
        /// </summary>
        public static int CLASS_DISPLAY => Clazz.GetField<int>("CLASS_DISPLAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_INPUT"/>
        /// </summary>
        public static int CLASS_INPUT => Clazz.GetField<int>("CLASS_INPUT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_NAMEDCOLOR"/>
        /// </summary>
        public static int CLASS_NAMEDCOLOR => Clazz.GetField<int>("CLASS_NAMEDCOLOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#CLASS_OUTPUT"/>
        /// </summary>
        public static int CLASS_OUTPUT => Clazz.GetField<int>("CLASS_OUTPUT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icAbsoluteColorimetric"/>
        /// </summary>
        public static int icAbsoluteColorimetric => Clazz.GetField<int>("icAbsoluteColorimetric");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icCurveCount"/>
        /// </summary>
        public static int icCurveCount => Clazz.GetField<int>("icCurveCount");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icCurveData"/>
        /// </summary>
        public static int icCurveData => Clazz.GetField<int>("icCurveData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrAttributes"/>
        /// </summary>
        public static int icHdrAttributes => Clazz.GetField<int>("icHdrAttributes");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrCmmId"/>
        /// </summary>
        public static int icHdrCmmId => Clazz.GetField<int>("icHdrCmmId");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrColorSpace"/>
        /// </summary>
        public static int icHdrColorSpace => Clazz.GetField<int>("icHdrColorSpace");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrCreator"/>
        /// </summary>
        public static int icHdrCreator => Clazz.GetField<int>("icHdrCreator");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrDate"/>
        /// </summary>
        public static int icHdrDate => Clazz.GetField<int>("icHdrDate");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrDeviceClass"/>
        /// </summary>
        public static int icHdrDeviceClass => Clazz.GetField<int>("icHdrDeviceClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrFlags"/>
        /// </summary>
        public static int icHdrFlags => Clazz.GetField<int>("icHdrFlags");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrIlluminant"/>
        /// </summary>
        public static int icHdrIlluminant => Clazz.GetField<int>("icHdrIlluminant");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrMagic"/>
        /// </summary>
        public static int icHdrMagic => Clazz.GetField<int>("icHdrMagic");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrManufacturer"/>
        /// </summary>
        public static int icHdrManufacturer => Clazz.GetField<int>("icHdrManufacturer");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrModel"/>
        /// </summary>
        public static int icHdrModel => Clazz.GetField<int>("icHdrModel");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrPcs"/>
        /// </summary>
        public static int icHdrPcs => Clazz.GetField<int>("icHdrPcs");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrPlatform"/>
        /// </summary>
        public static int icHdrPlatform => Clazz.GetField<int>("icHdrPlatform");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrProfileID"/>
        /// </summary>
        public static int icHdrProfileID => Clazz.GetField<int>("icHdrProfileID");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrRenderingIntent"/>
        /// </summary>
        public static int icHdrRenderingIntent => Clazz.GetField<int>("icHdrRenderingIntent");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrSize"/>
        /// </summary>
        public static int icHdrSize => Clazz.GetField<int>("icHdrSize");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icHdrVersion"/>
        /// </summary>
        public static int icHdrVersion => Clazz.GetField<int>("icHdrVersion");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icICCAbsoluteColorimetric"/>
        /// </summary>
        public static int icICCAbsoluteColorimetric => Clazz.GetField<int>("icICCAbsoluteColorimetric");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icMediaRelativeColorimetric"/>
        /// </summary>
        public static int icMediaRelativeColorimetric => Clazz.GetField<int>("icMediaRelativeColorimetric");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icPerceptual"/>
        /// </summary>
        public static int icPerceptual => Clazz.GetField<int>("icPerceptual");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icRelativeColorimetric"/>
        /// </summary>
        public static int icRelativeColorimetric => Clazz.GetField<int>("icRelativeColorimetric");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSaturation"/>
        /// </summary>
        public static int icSaturation => Clazz.GetField<int>("icSaturation");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigAbstractClass"/>
        /// </summary>
        public static int icSigAbstractClass => Clazz.GetField<int>("icSigAbstractClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigAToB0Tag"/>
        /// </summary>
        public static int icSigAToB0Tag => Clazz.GetField<int>("icSigAToB0Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigAToB1Tag"/>
        /// </summary>
        public static int icSigAToB1Tag => Clazz.GetField<int>("icSigAToB1Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigAToB2Tag"/>
        /// </summary>
        public static int icSigAToB2Tag => Clazz.GetField<int>("icSigAToB2Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigBlueColorantTag"/>
        /// </summary>
        public static int icSigBlueColorantTag => Clazz.GetField<int>("icSigBlueColorantTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigBlueMatrixColumnTag"/>
        /// </summary>
        public static int icSigBlueMatrixColumnTag => Clazz.GetField<int>("icSigBlueMatrixColumnTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigBlueTRCTag"/>
        /// </summary>
        public static int icSigBlueTRCTag => Clazz.GetField<int>("icSigBlueTRCTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigBToA0Tag"/>
        /// </summary>
        public static int icSigBToA0Tag => Clazz.GetField<int>("icSigBToA0Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigBToA1Tag"/>
        /// </summary>
        public static int icSigBToA1Tag => Clazz.GetField<int>("icSigBToA1Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigBToA2Tag"/>
        /// </summary>
        public static int icSigBToA2Tag => Clazz.GetField<int>("icSigBToA2Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigCalibrationDateTimeTag"/>
        /// </summary>
        public static int icSigCalibrationDateTimeTag => Clazz.GetField<int>("icSigCalibrationDateTimeTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigCharTargetTag"/>
        /// </summary>
        public static int icSigCharTargetTag => Clazz.GetField<int>("icSigCharTargetTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigChromaticAdaptationTag"/>
        /// </summary>
        public static int icSigChromaticAdaptationTag => Clazz.GetField<int>("icSigChromaticAdaptationTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigChromaticityTag"/>
        /// </summary>
        public static int icSigChromaticityTag => Clazz.GetField<int>("icSigChromaticityTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigCmyData"/>
        /// </summary>
        public static int icSigCmyData => Clazz.GetField<int>("icSigCmyData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigCmykData"/>
        /// </summary>
        public static int icSigCmykData => Clazz.GetField<int>("icSigCmykData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigColorantOrderTag"/>
        /// </summary>
        public static int icSigColorantOrderTag => Clazz.GetField<int>("icSigColorantOrderTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigColorantTableTag"/>
        /// </summary>
        public static int icSigColorantTableTag => Clazz.GetField<int>("icSigColorantTableTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigColorSpaceClass"/>
        /// </summary>
        public static int icSigColorSpaceClass => Clazz.GetField<int>("icSigColorSpaceClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigCopyrightTag"/>
        /// </summary>
        public static int icSigCopyrightTag => Clazz.GetField<int>("icSigCopyrightTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigCrdInfoTag"/>
        /// </summary>
        public static int icSigCrdInfoTag => Clazz.GetField<int>("icSigCrdInfoTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigDeviceMfgDescTag"/>
        /// </summary>
        public static int icSigDeviceMfgDescTag => Clazz.GetField<int>("icSigDeviceMfgDescTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigDeviceModelDescTag"/>
        /// </summary>
        public static int icSigDeviceModelDescTag => Clazz.GetField<int>("icSigDeviceModelDescTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigDeviceSettingsTag"/>
        /// </summary>
        public static int icSigDeviceSettingsTag => Clazz.GetField<int>("icSigDeviceSettingsTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigDisplayClass"/>
        /// </summary>
        public static int icSigDisplayClass => Clazz.GetField<int>("icSigDisplayClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigGamutTag"/>
        /// </summary>
        public static int icSigGamutTag => Clazz.GetField<int>("icSigGamutTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigGrayData"/>
        /// </summary>
        public static int icSigGrayData => Clazz.GetField<int>("icSigGrayData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigGrayTRCTag"/>
        /// </summary>
        public static int icSigGrayTRCTag => Clazz.GetField<int>("icSigGrayTRCTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigGreenColorantTag"/>
        /// </summary>
        public static int icSigGreenColorantTag => Clazz.GetField<int>("icSigGreenColorantTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigGreenMatrixColumnTag"/>
        /// </summary>
        public static int icSigGreenMatrixColumnTag => Clazz.GetField<int>("icSigGreenMatrixColumnTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigGreenTRCTag"/>
        /// </summary>
        public static int icSigGreenTRCTag => Clazz.GetField<int>("icSigGreenTRCTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigHead"/>
        /// </summary>
        public static int icSigHead => Clazz.GetField<int>("icSigHead");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigHlsData"/>
        /// </summary>
        public static int icSigHlsData => Clazz.GetField<int>("icSigHlsData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigHsvData"/>
        /// </summary>
        public static int icSigHsvData => Clazz.GetField<int>("icSigHsvData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigInputClass"/>
        /// </summary>
        public static int icSigInputClass => Clazz.GetField<int>("icSigInputClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigLabData"/>
        /// </summary>
        public static int icSigLabData => Clazz.GetField<int>("icSigLabData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigLinkClass"/>
        /// </summary>
        public static int icSigLinkClass => Clazz.GetField<int>("icSigLinkClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigLuminanceTag"/>
        /// </summary>
        public static int icSigLuminanceTag => Clazz.GetField<int>("icSigLuminanceTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigLuvData"/>
        /// </summary>
        public static int icSigLuvData => Clazz.GetField<int>("icSigLuvData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigMeasurementTag"/>
        /// </summary>
        public static int icSigMeasurementTag => Clazz.GetField<int>("icSigMeasurementTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigMediaBlackPointTag"/>
        /// </summary>
        public static int icSigMediaBlackPointTag => Clazz.GetField<int>("icSigMediaBlackPointTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigMediaWhitePointTag"/>
        /// </summary>
        public static int icSigMediaWhitePointTag => Clazz.GetField<int>("icSigMediaWhitePointTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigNamedColor2Tag"/>
        /// </summary>
        public static int icSigNamedColor2Tag => Clazz.GetField<int>("icSigNamedColor2Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigNamedColorClass"/>
        /// </summary>
        public static int icSigNamedColorClass => Clazz.GetField<int>("icSigNamedColorClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigOutputClass"/>
        /// </summary>
        public static int icSigOutputClass => Clazz.GetField<int>("icSigOutputClass");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigOutputResponseTag"/>
        /// </summary>
        public static int icSigOutputResponseTag => Clazz.GetField<int>("icSigOutputResponseTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPreview0Tag"/>
        /// </summary>
        public static int icSigPreview0Tag => Clazz.GetField<int>("icSigPreview0Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPreview1Tag"/>
        /// </summary>
        public static int icSigPreview1Tag => Clazz.GetField<int>("icSigPreview1Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPreview2Tag"/>
        /// </summary>
        public static int icSigPreview2Tag => Clazz.GetField<int>("icSigPreview2Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigProfileDescriptionTag"/>
        /// </summary>
        public static int icSigProfileDescriptionTag => Clazz.GetField<int>("icSigProfileDescriptionTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigProfileSequenceDescTag"/>
        /// </summary>
        public static int icSigProfileSequenceDescTag => Clazz.GetField<int>("icSigProfileSequenceDescTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPs2CRD0Tag"/>
        /// </summary>
        public static int icSigPs2CRD0Tag => Clazz.GetField<int>("icSigPs2CRD0Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPs2CRD1Tag"/>
        /// </summary>
        public static int icSigPs2CRD1Tag => Clazz.GetField<int>("icSigPs2CRD1Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPs2CRD2Tag"/>
        /// </summary>
        public static int icSigPs2CRD2Tag => Clazz.GetField<int>("icSigPs2CRD2Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPs2CRD3Tag"/>
        /// </summary>
        public static int icSigPs2CRD3Tag => Clazz.GetField<int>("icSigPs2CRD3Tag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPs2CSATag"/>
        /// </summary>
        public static int icSigPs2CSATag => Clazz.GetField<int>("icSigPs2CSATag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigPs2RenderingIntentTag"/>
        /// </summary>
        public static int icSigPs2RenderingIntentTag => Clazz.GetField<int>("icSigPs2RenderingIntentTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigRedColorantTag"/>
        /// </summary>
        public static int icSigRedColorantTag => Clazz.GetField<int>("icSigRedColorantTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigRedMatrixColumnTag"/>
        /// </summary>
        public static int icSigRedMatrixColumnTag => Clazz.GetField<int>("icSigRedMatrixColumnTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigRedTRCTag"/>
        /// </summary>
        public static int icSigRedTRCTag => Clazz.GetField<int>("icSigRedTRCTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigRgbData"/>
        /// </summary>
        public static int icSigRgbData => Clazz.GetField<int>("icSigRgbData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigScreeningDescTag"/>
        /// </summary>
        public static int icSigScreeningDescTag => Clazz.GetField<int>("icSigScreeningDescTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigScreeningTag"/>
        /// </summary>
        public static int icSigScreeningTag => Clazz.GetField<int>("icSigScreeningTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace2CLR"/>
        /// </summary>
        public static int icSigSpace2CLR => Clazz.GetField<int>("icSigSpace2CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace3CLR"/>
        /// </summary>
        public static int icSigSpace3CLR => Clazz.GetField<int>("icSigSpace3CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace4CLR"/>
        /// </summary>
        public static int icSigSpace4CLR => Clazz.GetField<int>("icSigSpace4CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace5CLR"/>
        /// </summary>
        public static int icSigSpace5CLR => Clazz.GetField<int>("icSigSpace5CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace6CLR"/>
        /// </summary>
        public static int icSigSpace6CLR => Clazz.GetField<int>("icSigSpace6CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace7CLR"/>
        /// </summary>
        public static int icSigSpace7CLR => Clazz.GetField<int>("icSigSpace7CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace8CLR"/>
        /// </summary>
        public static int icSigSpace8CLR => Clazz.GetField<int>("icSigSpace8CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpace9CLR"/>
        /// </summary>
        public static int icSigSpace9CLR => Clazz.GetField<int>("icSigSpace9CLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpaceACLR"/>
        /// </summary>
        public static int icSigSpaceACLR => Clazz.GetField<int>("icSigSpaceACLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpaceBCLR"/>
        /// </summary>
        public static int icSigSpaceBCLR => Clazz.GetField<int>("icSigSpaceBCLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpaceCCLR"/>
        /// </summary>
        public static int icSigSpaceCCLR => Clazz.GetField<int>("icSigSpaceCCLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpaceDCLR"/>
        /// </summary>
        public static int icSigSpaceDCLR => Clazz.GetField<int>("icSigSpaceDCLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpaceECLR"/>
        /// </summary>
        public static int icSigSpaceECLR => Clazz.GetField<int>("icSigSpaceECLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigSpaceFCLR"/>
        /// </summary>
        public static int icSigSpaceFCLR => Clazz.GetField<int>("icSigSpaceFCLR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigTechnologyTag"/>
        /// </summary>
        public static int icSigTechnologyTag => Clazz.GetField<int>("icSigTechnologyTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigUcrBgTag"/>
        /// </summary>
        public static int icSigUcrBgTag => Clazz.GetField<int>("icSigUcrBgTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigViewingCondDescTag"/>
        /// </summary>
        public static int icSigViewingCondDescTag => Clazz.GetField<int>("icSigViewingCondDescTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigViewingConditionsTag"/>
        /// </summary>
        public static int icSigViewingConditionsTag => Clazz.GetField<int>("icSigViewingConditionsTag");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigXYZData"/>
        /// </summary>
        public static int icSigXYZData => Clazz.GetField<int>("icSigXYZData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigYCbCrData"/>
        /// </summary>
        public static int icSigYCbCrData => Clazz.GetField<int>("icSigYCbCrData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icSigYxyData"/>
        /// </summary>
        public static int icSigYxyData => Clazz.GetField<int>("icSigYxyData");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icTagReserved"/>
        /// </summary>
        public static int icTagReserved => Clazz.GetField<int>("icTagReserved");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icTagType"/>
        /// </summary>
        public static int icTagType => Clazz.GetField<int>("icTagType");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#icXYZNumberX"/>
        /// </summary>
        public static int icXYZNumberX => Clazz.GetField<int>("icXYZNumberX");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getInstance(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Awt.ColorNs.ICC_Profile"/></returns>
        public static Java.Awt.ColorNs.ICC_Profile GetInstance(byte[] arg0)
        {
            return SExecute<Java.Awt.ColorNs.ICC_Profile>("getInstance", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getInstance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ColorNs.ICC_Profile"/></returns>
        public static Java.Awt.ColorNs.ICC_Profile GetInstance(int arg0)
        {
            return SExecute<Java.Awt.ColorNs.ICC_Profile>("getInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getInstance(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Awt.ColorNs.ICC_Profile"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ColorNs.ICC_Profile GetInstance(Java.Io.InputStream arg0)
        {
            return SExecute<Java.Awt.ColorNs.ICC_Profile>("getInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Awt.ColorNs.ICC_Profile"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ColorNs.ICC_Profile GetInstance(string arg0)
        {
            return SExecute<Java.Awt.ColorNs.ICC_Profile>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getColorSpaceType()"/> 
        /// </summary>
        public int ColorSpaceType
        {
            get { return IExecute<int>("getColorSpaceType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getData()"/> 
        /// </summary>
        public byte[] Data
        {
            get { return IExecuteArray<byte>("getData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getMajorVersion()"/> 
        /// </summary>
        public int MajorVersion
        {
            get { return IExecute<int>("getMajorVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getMinorVersion()"/> 
        /// </summary>
        public int MinorVersion
        {
            get { return IExecute<int>("getMinorVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getNumComponents()"/> 
        /// </summary>
        public int NumComponents
        {
            get { return IExecute<int>("getNumComponents"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getPCSType()"/> 
        /// </summary>
        public int PCSType
        {
            get { return IExecute<int>("getPCSType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getProfileClass()"/> 
        /// </summary>
        public int ProfileClass
        {
            get { return IExecute<int>("getProfileClass"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#getData(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetData(int arg0)
        {
            return IExecuteArray<byte>("getData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#setData(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void SetData(int arg0, byte[] arg1)
        {
            IExecute("setData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#write(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Io.OutputStream arg0)
        {
            IExecute("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/color/ICC_Profile.html#write(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(string arg0)
        {
            IExecute("write", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}