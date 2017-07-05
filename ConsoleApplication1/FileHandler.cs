using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class FileHandler
    {
        public static Sub[] SubHandler() {

            
           
             string[] readText = File.ReadAllLines(@"..\..\subs.txt");

            Sub[] subs = new Sub[readText.Length];
            for (int i = 0; i < subs.Length; i++)
            {
                string[] splitData = readText[i].Trim().Split('.', ',', ';');
                subs[i] = new Sub(int.Parse(splitData[0]), int.Parse(splitData[2]), int.Parse(splitData[3]));
              
            }
            return subs;
            }

        public static Players[] PHandler() {
            string[] readText = File.ReadAllLines(@"..\..\Players.txt");
            int a 
             Players[] players = new Players[a];
            for (int i = 3; i < players.Length; i++)
            {
               
                

            }
            return players;
        }
       
         
               
        

    }
}
