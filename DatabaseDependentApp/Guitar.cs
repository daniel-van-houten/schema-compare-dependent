using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseDependentApp
{
    public class Guitar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string BodyStyle { get; set; }
        public int StringCount { get; set; }
        public float ScaleLength { get; set; }

        public override string ToString()
        {
            return $"{Id} | {StringCount} String {Brand} {Model} | {ScaleLength} Scale";
        }
    }
}
