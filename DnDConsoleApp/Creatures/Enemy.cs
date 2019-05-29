using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enemy : Creature
{
    public Enemy(int xpValue, string name, int health, int level) : base(xpValue, name, health, level)
    {
    }
}
