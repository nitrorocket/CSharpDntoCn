using System;



namespace DNtoCN
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The purpse of this program is to filmerize my self with GitHub
                Make a Function that takes a DN or Distinguished Name.
          * 
          */

            string inputDN = Console.ReadLine();
            string outputCN = DNtoCNa(inputDN);
                
            Console.WriteLine(outputCN);
          
        }

        static public string DNtoCNa (String dn)
        {
            
            try {
            string cn = dn.Substring(dn.IndexOf("=")+1,dn.IndexOf(",")-3);
            return cn;
 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return  "None";
               
            }
                     
        }


    }
}
