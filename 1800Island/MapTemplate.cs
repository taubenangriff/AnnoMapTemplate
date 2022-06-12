using FileDBSerializing.ObjectSerializer;

namespace AnnoMaptemplate
{
    public class MapTemplateWrapper
    { 
        public MapTemplate MapTemplate { get; set; }
    }

    public class MapTemplate
    {
        public Int32[] Size { get; set; }
        public Int32[] PlayableArea { get; set; }
        public Dummy RandomlyPlacedThirdParties { get; set; }
        public int ElementCount { get; set; }

        [FlatArray]
        public TemplateElement[] TemplateElement { get; set; }

        public MapTemplate() { }

        public void OnSerialized() { }
    }

    public class Dummy
    { 
    
    }
}