/*
*  Copyright 2023 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    public class Point2D : JVMBridgeBase<Point2D>
    {
        public override string ClassName => "java.awt.geom.Point2D";

        public Point2D() : base()
        {
        }

        protected Point2D(params object[] args) : base(args)
        {
        }

        /// <summary>
        /// Returns the distance between two points.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double Distance(double x1, double y1, double x2, double y2) => SExecute<double>("distance", x1, y1, x2, y2);
        /// <summary>
        /// Returns the square of the distance between two points.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double DistanceSq(double x1, double y1, double x2, double y2) => SExecute<double>("distanceSq", x1, y1, x2, y2);
        /// <summary>
        /// Returns the distance from this <see cref="Point2D"/> to a specified point.
        /// </summary>
        /// <param name="px"></param>
        /// <param name="py"></param>
        /// <returns></returns>
        public double Distance(double px, double py) => IExecute<double>("distance", px, py);
        /// <summary>
        /// Returns the distance from this <see cref="Point2D"/> to a specified <see cref="Point2D"/>.
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public double Distance(Point2D pt) => IExecute<double>("distance", pt);
        /// <summary>
        /// Returns the square of the distance from this <see cref="Point2D"/> to a specified point.
        /// </summary>
        /// <param name="px"></param>
        /// <param name="py"></param>
        /// <returns></returns>
        public double DistanceSq(double px, double py) => IExecute<double>("distanceSq", px, py);
        /// <summary>
        /// Returns the square of the distance from this <see cref="Point2D"/> to a specified <see cref="Point2D"/>.
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        public double DistanceSq(Point2D pt) => IExecute<double>("distanceSq", pt);
        /// <summary>
        /// Returns the X coordinate of this <see cref="Point2D"/> in double precision.
        /// </summary>
        public double X => IExecute<double>("getX");
        /// <summary>
        /// Returns the Y coordinate of this <see cref="Point2D"/> in double precision.
        /// </summary>
        public double Y => IExecute<double>("getY");
        /// <summary>
        /// Sets the location of this <see cref="Point2D"/> to the specified double coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetLocation(double x, double y) => IExecute("setLocation", x, y);
        /// <summary>
        /// Sets the location of this <see cref="Point2D"/> to the same coordinates as the specified <see cref="Point2D"/> object.
        /// </summary>
        /// <param name="p"></param>
        public void SetLocation(Point2D p) => IExecute("setLocation", p);
    }
}
