using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMultitaskingApp
{
    class Program
    {
        private static string printMessage(string message)
        {
            return message.ToUpper();
        }

        static void Main(string[] args) 
         {
             Task<string[]> message = new Task<string[]>(() =>
             {
                 var result = new string[3];
                 new Task(() => result[0] = printMessage("Hello"),TaskCreationOptions.AttachedToParent).Start();
                 new Task(() => result[1] = printMessage("World"),TaskCreationOptions.AttachedToParent).Start();
                 new Task(() => result[2] = printMessage("Hello world!"),TaskCreationOptions.AttachedToParent).Start();
                 return result;
             });
             var cwt = message.ContinueWith(mes =>  Array.ForEach(mes.Result, Console.WriteLine));
             message.Start();
             Console.WriteLine("Главный метод завершен.");
             Console.ReadLine(); 
        } // eof main
    } // eof class
} // eof namespace

