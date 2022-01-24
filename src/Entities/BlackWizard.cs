namespace RPG_OOP_example.src.Entities
{
    public class BlackWizard: Hero
    {
        public BlackWizard(
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
            this.classType = "Black Wizard";
        }

        public string agir(int value)
        {
            return $"{this.name} usou magia das trevas e causou {value} pontos de dano";
        }
    }
}