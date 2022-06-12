using FileDBSerializing.EncodingAwareStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoMaptemplate
{
    public class Element
    {
        public Int32[] Position { get; set; }
        public Int16 Size { get; set; }
        public RandomIslandConfig? RandomIslandConfig { get; set; }
        public Config? Config { get; set; }
        public UnicodeString? MapFilePath { get; set; }
        public UTF8String? IslandLabel { get; set; }
        public Byte Rotation90 { get; set; }
        public Difficulty Difficulty { get; set; }
        public bool RandomizeFertilities { get; set; }
        public Int32[] FertilityGuids { get; set; }

        public Element() { }
    }
}
