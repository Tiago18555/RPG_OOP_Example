namespace RPG_OOP_example.src.Entities
{
    public class Ninja: Hero
    {
        public Ninja(
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
            this.classType = "Ninja";
        }
        public string agir(int value)
        {
            int damage = value * 2;
            return $"{this.name} sorrateiramente deu um golpe furtivo e causou {damage} pontos de dano crítico";
        }
    }
}