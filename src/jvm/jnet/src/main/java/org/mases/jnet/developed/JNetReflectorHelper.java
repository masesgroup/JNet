/*
 *  Copyright 2025 MASES s.r.l.
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

package org.mases.jnet.developed;

import org.burningwave.core.assembler.ComponentContainer;
import org.burningwave.core.assembler.ComponentSupplier;
import org.burningwave.core.assembler.StaticComponentContainer;
import org.burningwave.core.classes.ClassCriteria;
import org.burningwave.core.classes.ClassHunter;
import org.burningwave.core.classes.SearchConfig;
import org.burningwave.core.classes.ClassHunter.SearchResult;
import org.burningwave.core.io.PathHelper;

import java.util.Collection;

public class JNetReflectorHelper {
    public static boolean getLoggingState() {
        return StaticComponentContainer.ManagedLoggerRepository.isEnabled();
    }

    public static void setLoggingState(boolean value) {
        if (value) {
            StaticComponentContainer.ManagedLoggerRepository.enableLogging();
        } else {
            StaticComponentContainer.ManagedLoggerRepository.disableLogging();
        }
    }

    public static boolean isOverrideOrConcrete(java.lang.reflect.Method entry) {
		try {
			java.lang.Class superClass = entry.getDeclaringClass().getSuperclass();
			if (superClass == null) return false;
			if (superClass.getTypeName().equals("java.lang.Object")) return false;
			java.lang.reflect.Method method = superClass.getMethod(entry.getName(), entry.getParameterTypes());
			return true;
		}
		catch (java.lang.NoSuchMethodException e) {
			return false;
		}
    }
	
    public static boolean isFromSuperInterface(java.lang.reflect.Method entry) {
		for( Class interfaceToCheck : entry.getDeclaringClass().getInterfaces()) {
			try {
				java.lang.reflect.Method method = interfaceToCheck.getMethod(entry.getName(), entry.getParameterTypes());
				if (!method.getReturnType().equals(entry.getReturnType()))
				{
					return true;
				}
			}
			catch (java.lang.NoSuchMethodException e) {
				
			}
		}
		
		return false;
    }

    public static Collection<Class<?>> find() {
        ComponentSupplier componentSupplier = ComponentContainer.getInstance();
        PathHelper pathHelper = componentSupplier.getPathHelper();
        ClassHunter classHunter = componentSupplier.getClassHunter();
        SearchConfig searchConfig = SearchConfig.forPaths(
                //Here you can add all absolute path you want:
                //both folders, zip, jar, war, ear and jmod will be recursively scanned.
                //For example you can add: "C:\\Users\\user\\.m2"
                //With the row below the search will be executed on runtime Classpaths
                pathHelper.getMainClassPaths()
        );
        try (ClassHunter.SearchResult searchResult = classHunter.findBy(searchConfig)) {
            return searchResult.getClasses();
        }
    }

    public static Collection<Class<?>> find(String packageOrModuleName, boolean isModule) {
        ComponentSupplier componentSupplier = ComponentContainer.getInstance();

        if (isModule) {
            PathHelper pathHelper = componentSupplier.getPathHelper();
            ClassHunter classHunter = componentSupplier.getClassHunter();
            try (ClassHunter.SearchResult searchResult = classHunter.findBy(
                    SearchConfig.forPaths(
                            pathHelper.getAllMainClassPaths()
                    ).by(
                            ClassCriteria.create().allThoseThatMatch((currentScannedClass) ->
                                    currentScannedClass.getModule().getName() != null &&
                                            currentScannedClass.getModule().getName().equals(packageOrModuleName)
                            )
                    )
            )
            ) {
                return searchResult.getClasses();
            }
        } else {
            ClassHunter classHunter = componentSupplier.getClassHunter();
            SearchConfig searchConfig = SearchConfig.byCriteria(
                    ClassCriteria.create().allThoseThatMatch((cls) -> {
                        String packageName = cls.getPackage().getName();
                        return packageName != null && packageName.matches(packageOrModuleName);
                    })
            );
            try (ClassHunter.SearchResult searchResult = classHunter.findBy(searchConfig)) {
                return searchResult.getClasses();
            }
        }
    }
}
