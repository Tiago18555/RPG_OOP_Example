namespace RPG_OOP_example.src.Entities
{
    public class Wizard: Hero
    {
        public Wizard(
            string _name, 
            byte _level, 
            ushort _hp, 
            ushort _mp
        )
        {
            this.name = _name;
            this.level = _level;
            this.hp = _hp;
            this.mp = _mp;
            this.classType = "Wizard";
        }
        public string agir(int value)
        {
            return $"{this.name} Usou magia de fogo e causou {value} pontos de dano";
        }
    }
}