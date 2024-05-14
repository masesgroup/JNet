/*
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

package org.mases.jnet;

import java.nio.ByteBuffer;
import java.nio.CharBuffer;
import java.nio.DoubleBuffer;
import java.nio.FloatBuffer;
import java.nio.IntBuffer;
import java.nio.LongBuffer;
import java.nio.ShortBuffer;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class JNetHelper {
    public static List<?> listFromPrimitiveArray(Object input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");
		
        if (input instanceof boolean[]) {
			final List<Boolean> l = new ArrayList<Boolean>();
			for (final boolean s : (boolean[])input) {
				l.add(s);
			}
			return l;
		}
		else if (input instanceof byte[]) {
			final List<Byte> l = new ArrayList<Byte>();
			for (final byte s : (byte[])input) {
				l.add(s);
			}
			return l;
		}
		else if (input instanceof char[]) {
			final List<Character> l = new ArrayList<Character>();
			for (final char s : (char[])input) {
				l.add(s);
			}
			return l;
		}
		else if (input instanceof short[]) {
			final List<Short> l = new ArrayList<Short>();
			for (final short s : (short[])input) {
				l.add(s);
			}
			return l;
		}
		else if (input instanceof int[]) {
			Integer[] array = Arrays.stream((int[])input).boxed().toArray(Integer[]::new);
			return Arrays.asList(array);
		}
		else if (input instanceof long[]) {
			Long[] array = Arrays.stream((long[])input).boxed().toArray(Long[]::new);
			return Arrays.asList(array);
		}
		else if (input instanceof float[]) {
			final List<Float> l = new ArrayList<Float>();
			for (final float s : (float[])input) {
				l.add(s);
			}
			return l;
		}
		else if (input instanceof double[]) {
			Double[] array = Arrays.stream((double[])input).boxed().toArray(Double[]::new);
			return Arrays.asList(array);
		}

		if(!input.getClass().isArray()) throw new IllegalArgumentException("Input parameter is not an array");

		throw new ClassCastException(input.getClass().getName() + " cannot be converted with this function");
    }

    public static List<?> listFromByteBuffer(ByteBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");
		
		input.rewind();
		byte[] array = new byte[input.remaining()];
        input.get(array, 0, array.length);
		final List<Byte> l = new ArrayList<Byte>();
		for (final byte s : array) {
			l.add(s);
		}
		return l;
    }
	
    public static List<?> listFromCharBuffer(CharBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");

		input.rewind();
		char[] array = new char[input.remaining()];
        input.get(array, 0, array.length);
		final List<Character> l = new ArrayList<Character>();
		for (final char s : array) {
			l.add(s);
		}
		return l;
    }
	
    public static List<?> listFromDoubleBuffer(DoubleBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");

		input.rewind();
		double[] array = new double[input.remaining()];
        input.get(array, 0, array.length);
		Double[] array2 = Arrays.stream(array).boxed().toArray(Double[]::new);
		return Arrays.asList(array2);
    }
	
    public static List<?> listFromFloatBuffer(FloatBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");

		input.rewind();
		float[] array = new float[input.remaining()];
        input.get(array, 0, array.length);
		final List<Float> l = new ArrayList<Float>();
		for (final float s : array) {
			l.add(s);
		}
		return l;
    }
	
    public static List<?> listFromIntBuffer(IntBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");

		input.rewind();
		int[] array = new int[input.remaining()];
        input.get(array, 0, array.length);
		Integer[] array2 = Arrays.stream(array).boxed().toArray(Integer[]::new);
		return Arrays.asList(array2);
    }
	
    public static List<?> listFromLongBuffer(LongBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");

		input.rewind();
		long[] array = new long[input.remaining()];
        input.get(array, 0, array.length);
		Long[] array2 = Arrays.stream(array).boxed().toArray(Long[]::new);
		return Arrays.asList(array2);
    }
	
    public static List<?> listFromShortBuffer(ShortBuffer input) {
		if (input == null) throw new IllegalArgumentException("Input parameter is null");

		input.rewind();
		short[] array = new short[input.remaining()];
        input.get(array, 0, array.length);
		final List<Short> l = new ArrayList<Short>();
		for (final short s : array) {
			l.add(s);
		}
		return l;
    }
}
