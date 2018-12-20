using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класс
{
    class Pulya
    {
        public int damage;
        public Pulya()
        {
            damage = 50;
        }
    }
    class Plane
    {
        public int hp;
        private int magazine;
        public Plane()
        {
            hp = 1000;
            magazine = 500;
        }
        public Pulya GetPulya()
        {
            Pulya bullet = new Pulya();
            magazine--;
            return bullet;
        }
        public void takedamage(int damaga)
        {
            hp -= damaga;
        }
    }

    class YA
    {
        public int type;
        public YA(int yach)
        {
            type = yach;
        }
    }
    class pole
    {
        YA[,] polee;
        public pole()
        {
            polee = new YA[11, 15];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    polee[i, j] = new YA(1);
                }

            }

            polee[6, 10].type = 3;            
        }
        
        public void Tick()
        {
            for(int i = 14; i > 0; i--)
            {
                for(int j = 0; j < 11; j++)
                {
                    polee[i + 1, j] = polee[i, j];
                }
            }
        }

        
    }
}
