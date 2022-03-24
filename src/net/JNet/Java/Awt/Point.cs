/*
*  Copyright 2022 MASES s.r.l.
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

using Java.Awt.Geom;

namespace Java.Awt
{
    public class Point : Point2D
    {
        public override string ClassName => "java.awt.Point";
        /// <summary>
        /// Constructs and initializes a point at the origin(0, 0) of the coordinate space.
        /// </summary>
        public Point() { }
        /// <summary>
        /// Constructs and initializes a point at the specified(x, y) location in the coordinate space.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y) : base(x, y) { }
        /// <summary>
        /// Constructs and initializes a point with the same location as the specified <see cref="Point"/> object.
        /// </summary>
        /// <param name="p"></param>
        public Point(Point p) : base(p) { }
        /// <summary>
        /// Returns the location of this point.
        /// </summary>
        public Point Location => IExecute<Point>("getLocation");
        /// <summary>
        /// Moves this point to the specified location in the (x, y) coordinate plane.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(int x, int y) => IExecute("move", x, y);
        /// <summary>
        /// Changes the point to have the specified location.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetLocation(int x, int y) => IExecute("setLocation", x, y);
        /// <summary>
        /// Sets the location of the point to the specified location.
        /// </summary>
        /// <param name="p"></param>
        public void SetLocation(Point p) => IExecute("setLocation", p);
        /// <summary>
        /// Translates this point, at location (x, y), by dx along the x axis and dy along the y axis so that it now represents the point (x+dx, y+dy).
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public void Translate(int dx, int dy) => IExecute("translate", dx, dy);
    }
}
