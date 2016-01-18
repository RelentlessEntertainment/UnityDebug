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
    public const float TWO_PI = (float)(2.0f * Math.PI);

    public UnityDebug()
    {
    }

    public static void DrawSquare(Vector2 origin, float size, Color color, float duration)
    {
        DrawSquare(new Vector3(origin.x, origin.y, 0.0f), size, color, duration);
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

    public static void DrawCircle(Vector2 origin, float diameter, float quality, Color color, float duration)
    {
        DrawCircle(new Vector3(origin.x, origin.y, 0.0f), diameter, quality, color, duration);
    }

    public static void DrawCircle(Vector3 origin, float diameter, float quality, Color color, float duration)
    {
        quality = Mathf.Clamp(quality, 0.0f, 1.0f);
        int numSides = (int)(360.0f * quality);

        DrawShape(origin, diameter, numSides, color, duration);
    }

    public static void DrawShape(Vector3 origin, float diameter, int numSides, Color color, float duration)
    {
        float radius = diameter / 2.0f;

        Vector3 firstPoint = Vector3.zero;
        firstPoint.x = radius + origin.x;
        firstPoint.y = origin.y;

        Vector3 prevPoint = firstPoint;
        Vector3 curPoint = Vector3.zero;
        float angle = 0.0f;

        for (int i = 1; i < numSides; ++i)
        {
            angle = i * (TWO_PI / numSides);
            curPoint.x = (Mathf.Cos(angle) * radius) + origin.x;
            curPoint.y = (Mathf.Sin(angle) * radius) + origin.y;
            Debug.DrawLine(curPoint, prevPoint, color, duration);

            prevPoint = curPoint;
        }

        Debug.DrawLine(firstPoint, prevPoint, color, duration);
    }
}
