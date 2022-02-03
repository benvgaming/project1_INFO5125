/*
 * Author: Manh Cuong Nguyen - 0970973
 * Class: HeavyObject.cs
 */

using System;

namespace Assi1
{
    internal class HeavyObject
    {
        public HeavyObject(float width = 1000f, float length = 1000f, float height = 1000f, float density = 1f) {
            Width = width;
            Length = length;
            Height = height;
            Density = density;
        }// c'tor

        public float Width;
        public float Length;
        public float Height;
        public float Density;
        
        // Volume = Width * Height * Length
        public float Volume {
            get { return Width * Height * Length; }
            set { }
        }//Volume

        // Mass = Volume * Density
        public float Mass {
            get { return Volume * Density; }
            set { }
        }//Mass

        public void Print() {
            Console.WriteLine("HeavyObject: (" + Width + "x" + Length + "x" + Height + "), density = " + Density + ", mass = " + Mass);
        }//Print()
    }//End of Class
}//End of Namespace
