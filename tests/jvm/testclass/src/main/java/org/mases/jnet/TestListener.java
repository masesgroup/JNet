package org.mases.jnet;

import java.util.concurrent.*;

public class TestListener {
    java.util.function.Function<String, String> _func;

    public TestListener(java.util.function.Function<String, String> func) {
        _func = func;
    }

    public String apply(String str) throws InterruptedException {
        String result = _func.apply(str);
        return result;
    }
}