namespace WidgetForm.Models {
    public enum WidgetType { 
        One = 1,
        Two = 2,
        A,
        B,
    }

    public enum WidgetSubtype {
        Apple,
        Aardvark,
        Astronaut,
        Bear,
        Bobcat,
        Beaver,
        First,
        One,
        Primary,
        Uno,
        Second,
        Two,
        Secondary,
        Dos
    }

    public class Widget {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Date { get; set; }   // YYYY-MM-DD
        public string? Time { get; set; }   // HH:MM
        public WidgetType Type { get; set; }
        public WidgetSubtype Subtype { get; set; }
    }
}