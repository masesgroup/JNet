package org.mases.jnet;

import java.io.IOException;

public class TestPerformance {

    Predicate _predicate;

    public TestPerformance() {
    }

    public TestPerformance(Predicate predicate) throws IOException {
        _predicate = predicate;
    }

    public static void executeStaticEmptyMethod()
    {
    }

    public static boolean executeStaticFeedbackMethod(boolean value)
    {
        return value;
    }

    public void executeEmptyMethod()
    {
    }

    public boolean executeFeedbackMethod(boolean value)
    {
        return value;
    }

    public int executeIntMethod(int value)
    {
        return value;
    }

    public int executeStringMethod(String value)
    {
        return value == null ? -1 : value.length();
    }

    public int executeIntArrayMethod(int[] values)
    {
        int sum = 0;
        for (int v : values) sum += v;
        return sum;
    }

    public int executeStringArrayMethod(String[] values)
    {
        int sum = 0;
        for (String v : values) sum += v == null ? 0 : v.length();
        return sum;
    }

    public int executeVarArgsMethod(int... values)
    {
        int sum = 0;
        for (int v : values) sum += v;
        return sum;
    }

    public int executeVarArgsObjectMethod(Object... values)
    {
        return values.length;
    }

    public boolean executePredicateIndex()
    {
        if (_predicate == null) throw new UnsupportedOperationException("Predicate is null");
        return _predicate.testIndex(new Object());
    }

    public boolean executePredicate()
    {
        if (_predicate == null) throw new UnsupportedOperationException("Predicate is null");
        return _predicate.test(new Object());
    }

    public boolean executePredicateIndex(int iterations)
    {
        if (_predicate == null) throw new UnsupportedOperationException("Predicate is null");
        boolean result = false;
        for(int i = 0; i < iterations; i++) {
            result |= _predicate.testIndex(new Object());
        }
        return result;
    }

    public boolean executePredicate(int iterations)
    {
        if (_predicate == null) throw new UnsupportedOperationException("Predicate is null");
        boolean result = false;
        for(int i = 0; i < iterations; i++) {
            result |= _predicate.test(new Object());
        }
        return result;
    }
}