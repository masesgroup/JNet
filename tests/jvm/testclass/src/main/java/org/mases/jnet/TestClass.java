package org.mases.jnet;

public class TestClass {
    public static void main(String[] args)
    {
        Class c = org.hamcrest.Description.class;
        if (c.isInterface())
            System.out.println("Is Interface");
    }
}
