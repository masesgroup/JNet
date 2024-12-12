#include <iostream>
#include "jni.h"

void print_error(jint ret)
{
	switch (ret)
	{
		case -1: std::cout << "failed - unknown error" << std::endl; return;
		case -2: std::cout << "failed - thread detached from the VM" << std::endl; return;
		case -3: std::cout << "failed - JNI version error" << std::endl; return;
		case -4: std::cout << "failed - not enough memory" << std::endl; return;
		case -5: std::cout << "failed - VM already created" << std::endl; return;
		case -6: std::cout << "failed - invalid arguments" << std::endl; return;
		default: break;
	}	
}

int main()
{
	const int arguments = 4;
	
    std::cout << "Starting JNI_CreateJavaVM test" << std::endl;
	
    JavaVM *jvm;       /* denotes a Java VM */
    JNIEnv *env;       /* pointer to native method interface */
	
	int numVms = 0;
	
	jint ret = JNI_GetCreatedJavaVMs(&jvm, 1, &numVms);
	if (ret != JNI_OK)
	{
		print_error(ret);
		return 1;
	}
	
	if (numVms >= 1)
	{
		std::cout << "JNI_GetCreatedJavaVMs returned with an already created JVM" << std::endl;
		return 1;
	}
	
    JavaVMInitArgs vm_args; /* JDK/JRE 6 VM initialization arguments */
	
	ret = JNI_GetDefaultJavaVMInitArgs(&vm_args);
	if (ret != JNI_OK)
	{
		print_error(ret);
		return 1;
	}
	
    JavaVMOption* options = new JavaVMOption[arguments];
    options[0].optionString = "-Djava.class.path=/usr/lib/java";
    options[1].optionString = "--add-opens=java.base/java.nio=ALL-UNNAMED";
    options[2].optionString = "-Xmx4G";
    options[3].optionString = "-Xms1G";
    vm_args.version = JNI_VERSION_1_6;
    vm_args.nOptions = arguments;
    vm_args.options = options;
    vm_args.ignoreUnrecognized = true;
    /* load and initialize a Java VM, return a JNI interface
     * pointer in env */
    ret = JNI_CreateJavaVM(&jvm, (void**)&env, &vm_args);
	if (ret != JNI_OK)
	{
		print_error(ret);
		return 1;
	}
	
    delete[] options;
    /* invoke the Main.test method using the JNI */
    // jclass cls = env->FindClass("Main");
    // jmethodID mid = env->GetStaticMethodID(cls, "test", "(I)V");
    // env->CallStaticVoidMethod(cls, mid, 100);
    /* We are done. */
    jvm->DestroyJavaVM();
	
    std::cout << "Ending JNI_CreateJavaVM test" << std::endl;
}