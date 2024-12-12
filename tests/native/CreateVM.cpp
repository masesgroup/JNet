#include <iostream>
#include "jni.h"

int main()
{
	const int arguments = 1;
	
    std::cout << "Starting JNI_CreateJavaVM test" << std::endl;
	
    JavaVM *jvm;       /* denotes a Java VM */
    JNIEnv *env;       /* pointer to native method interface */
    JavaVMInitArgs vm_args; /* JDK/JRE 6 VM initialization arguments */
    JavaVMOption* options = new JavaVMOption[arguments];
    options[0].optionString = "-Djava.class.path=/usr/lib/java";
    vm_args.version = JNI_VERSION_1_6;
    vm_args.nOptions = arguments;
    vm_args.options = options;
    vm_args.ignoreUnrecognized = true;
    /* load and initialize a Java VM, return a JNI interface
     * pointer in env */
    JNI_CreateJavaVM(&jvm, (void**)&env, &vm_args);
    delete options;
    /* invoke the Main.test method using the JNI */
    // jclass cls = env->FindClass("Main");
    // jmethodID mid = env->GetStaticMethodID(cls, "test", "(I)V");
    // env->CallStaticVoidMethod(cls, mid, 100);
    /* We are done. */
    jvm->DestroyJavaVM();
}