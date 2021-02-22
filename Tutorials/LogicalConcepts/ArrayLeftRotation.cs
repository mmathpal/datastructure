using System;
namespace LogicalConcepts
{
    public class ArrayLeftRotation
    {
        public ArrayLeftRotation()
        {
        }

        /// <summary>
        /// Rotate array left
        /// </summary>
        /// <param name="a">array to be totated</param>
        /// <param name="d">number of rotations</param>
        /// <returns></returns>
        private static int[] RotateLeft(int[] a, int d)
        {
            int[] temp = new int[a.Length];

            Array.Copy(a, temp, d);
            Array.Copy(a, d, a, 0, a.Length - d);
            Array.Copy(temp, 0, a, a.Length - d, d);

            return a;
        }

        public static void PerformLeftRotation()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before Rotation: " + string.Join(" ", a));
             var rtn = RotateLeft(a, 4);
            Console.WriteLine("After Rotation: " + string.Join(" ", rtn));

        }
    }
}
