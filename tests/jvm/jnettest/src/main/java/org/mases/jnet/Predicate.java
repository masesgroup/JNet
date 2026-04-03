package org.mases.jnet;

import org.mases.jcobridge.*;

public final class Predicate extends JCListener implements java.util.function.Predicate {
    public Predicate(String key) throws JCNativeException {
        super(key);
    }

    int _testIndex = 0;
    public boolean testIndex(Object e) {
        if (_testIndex <= 0) _testIndex = getEventIndex("test");
        raiseEvent(1, e);
        Object retVal = getReturnData();
        return retVal != null ? (boolean) retVal : false;
    }

    @Override
    public boolean test(Object e) {
        raiseEvent("test", e);
        Object retVal = getReturnData();
        return retVal != null ? (boolean) retVal : false;
    }
}