package org.mases.jnet;

import java.io.IOException;
import java.nio.ByteBuffer;

import org.mases.jcobridge.JCSharedBuffer;

public class TestArrayAndByteBuffer {
    int m_length;
    byte[] _array;
    ByteBuffer _buffer;

    public TestArrayAndByteBuffer() {
    }

    public TestArrayAndByteBuffer(int length) throws IOException {
        _array = new byte[length];
        for (int i = 0; i < length; i++)
        {
            _array[i] = (byte) (i % Byte.MAX_VALUE);
        }
        _buffer = JCSharedBuffer.Create(_array);
    }

    public void insertArray(byte[] array) {
        _array = array;
        m_length = array.length;
    }

    public void insertByteBuffer(ByteBuffer buf) {
        buf.rewind();
		byte[] array = new byte[buf.remaining()];
        buf.get(array, 0, array.length);
        m_length = array.length;
    }
	
    public void insertByteBufferNoNew(ByteBuffer buf) {
        buf.rewind();
        buf.get(_array, 0, _array.length);
        m_length = _array.length;
    }
	
    public void insertByteBufferNoGet(ByteBuffer buf) {
		buf.rewind();
        m_length = buf.remaining();
    }

    public byte[] getArray() {
        return _array;
    }

    public ByteBuffer getByteBuffer() {
        return _buffer;
    }
}
