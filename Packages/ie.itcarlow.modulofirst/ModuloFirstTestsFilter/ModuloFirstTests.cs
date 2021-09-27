using NUnit.Framework;
using UnityEngine;

namespace ModuloTests
{
    public class ModuloFirstTests
    {
        [Test]
        public void moduloFirstSample()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = ModuloFirst.moduloFirst(input);
            int[] expected = { 0, 2, 0, 3, 1, 0, 2, 1, 3, 2 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}