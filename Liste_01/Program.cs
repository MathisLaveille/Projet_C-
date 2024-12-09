namespace Liste_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste & Tableau");
            Console.WriteLine("===============");
            Console.WriteLine();
            //---- Liste
            List l1 = new List(); // créer une liste vide 

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0) l1.add(i);   // en queue
                else l1.push(i);  // en tête
            }

            l1.write();
            //---- Tableau
            Array t1 = new Array(); // créer un tableau vide 

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) t1.add(i);   // en queue
                else t1.push(i);  // en tête
            }

            t1.write();

            //Console.WriteLine("Tableau.length : " + t1.getNbr());
            //Console.WriteLine("Tableau[2]     : " + t1.getEle(2));
            //Console.WriteLine("Tableau[20]    : " + t1.getEle(20));

            Console.WriteLine("Tableau.length : " + l1.getNbr());
            Console.WriteLine("Tableau[2]     : " + l1.getEle(2));
            Console.WriteLine("Tableau[20]    : " + l1.getEle(20));

        }
    }

}
