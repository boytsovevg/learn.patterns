using System;
using adventure.bahavior;

namespace adventure.characters
{
    public abstract class Character
    {
        private IWeapon _weapon;
        private int Health { get; set; }
        private string Name { get; set; }

        protected Character(IWeapon weapon, string name)
        {
            this._weapon = weapon;
            this.Health = 100;
            this.Name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            this._weapon = weapon;
        }

        public void Attack(Character character)
        {
            var attackPoints = this._weapon.UseWeapon();

            Console.WriteLine($"{this.Name} attacks with {this._weapon.GetType().Name}");

            character.Health -= attackPoints;

            Console.WriteLine($"{character.Name} loses {attackPoints} health");

            if (character.Health <= 0)
            {
                Console.WriteLine($"{this.Name} give a death hit! {character.Name} died");
                
                return;
            }

            Console.WriteLine($"{character.Name} health is {character.Health}");
        }
    }
}