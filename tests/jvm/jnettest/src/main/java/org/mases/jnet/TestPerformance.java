package org.mases.jnet;

import java.io.IOException;

public class TestPerformance {
	Predicate _predicate;

	public TestPerformance() {
	}

	public TestPerformance(Predicate predicate) throws IOException {
		_predicate = predicate;
	}

	public void executeStaticEmptyMethod()
	{

	}

	public void executeEmptyMethod()
	{

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
}
