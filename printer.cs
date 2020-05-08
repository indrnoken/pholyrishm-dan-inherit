using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pholyrism
{
    class printer
    {
        public virtual void show()
        {
            Console.WriteLine("  ");
        }
        public virtual void print()
        {
            Console.WriteLine(" ");
        }

    }

    class canon : printer
    {
        public override void show()
        {
            base.show();
            Console.Write(" canon display dimension is 9.5 x 12");
        }
        public override void print()
        {
            base.print();
            Console.Write("canon printing.....");
        }
    }
        class epson : printer
        {
            public override void show()
            {
                base.show();
                Console.Write("epson display dimension : 10 x 11");
            }
            public override void print()
            {
                base.print();
                Console.Write(" epson printing ......");
            }

        }
        class laserjet : printer
        {
            public override void show()
            {
                base.show();
                Console.Write(" laserjet dimension : 12 x 12");
            }
            public override void print()
            {
                base.print();
                Console.Write(" laserjet is priting .....");
            }
        }
    }


