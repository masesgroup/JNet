﻿/*
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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Awt.Dnd
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html"/>
    /// </summary>
    public interface IDragSourceAdapter : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragEnter(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DragEnter(DragSourceDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragOver(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DragOver(DragSourceDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dropActionChanged(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DropActionChanged(DragSourceDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragExit(java.awt.dnd.DragSourceEvent)"/>
        /// </summary>
        void DragExit(DragSourceEvent dte);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragDropEnd(java.awt.dnd.DragSourceDropEvent)"/>
        /// </summary>
        void DragDropEnd(DragSourceDropEvent dsde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragMouseMoved(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DragMouseMoved(DragSourceDragEvent dsde);
    }

    /// <summary>
    /// Listener for DragSourceAdapter. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="IDragSourceAdapter"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class DragSourceAdapter : IDragSourceAdapter
    {

    }
}
