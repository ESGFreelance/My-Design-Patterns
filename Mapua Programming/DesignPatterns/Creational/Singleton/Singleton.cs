using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        public Singleton()
        {

        }

        public Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

//Other Reference:
//https://www.youtube.com/watch?v=DcbxFugk5pM&ab_channel=CodeRadiance
//https://www.dofactory.com/net/singleton-design-pattern