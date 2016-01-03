/*
 * Unity Game Engine Debug Tools
 * 
 * The MIT License (MIT)

 * Copyright (c) 2016 Scott Velasquez, Relentless Entertainment

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using UnityEngine;
using System;

public class UnityDebug
{
    public UnityDebug()
    {
    }

    public static void DrawSquare(Vector3 origin, float size, Color color, float duration)
    {
        float halfSize = size / 2.0f;
        
        Vector3 topLeft = Vector3.zero;
        topLeft.x = origin.x - halfSize;
        topLeft.y = origin.y + halfSize;

        Vector3 topRight = Vector3.zero;
        topRight.x = origin.x + halfSize;
        topRight.y = origin.y + halfSize;

        Vector3 bottomLeft = Vector3.zero;
        bottomLeft.x = origin.x - halfSize;
        bottomLeft.y = origin.y - halfSize;

        Vector3 bottomRight = Vector3.zero;
        bottomRight.x = origin.x + halfSize;
        bottomRight.y = origin.y - halfSize;

        Debug.DrawLine(topLeft, topRight, color, duration);
        Debug.DrawLine(topRight, bottomRight, color, duration);
        Debug.DrawLine(bottomRight, bottomLeft, color, duration);
        Debug.DrawLine(bottomLeft, topLeft, color, duration);
    }
}
