using System;

namespace RPG_OOP_example.src.Entities
{
    public class Hero
    {
        public byte level { get; set; }
        public string name {get; set; }
        public ushort hp { get; set; }
        public ushort mp { get; set; }
        public string classType { get; set; }
        public Hero()
        {

        }
        public override string ToString()
        {
            return String.Format(@$"
                Class:  {this.classType}
                Name:   {this.name}
                Level:  {this.level}
                HP:     {this.hp}
                MP:     {this.mp}            
            ");
        }  
    }
}