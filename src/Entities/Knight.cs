namespace RPG_OOP_example.src.Entities
{
	public class Knight : Hero
	{
        public Knight(
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
            this.classType = "Knight";
        }
        public string agir(int value)
        {
            return $"{this.name} levantou o escudo e absorveu {value} pontos de dano";
        }
	}
}