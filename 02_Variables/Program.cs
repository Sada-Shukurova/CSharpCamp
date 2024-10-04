using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double variables
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat  Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Apple Price for kg: " + applePrice+" TL");
            //Console.WriteLine("---- Orange Price for kg: " + orangePrice + " TL");
            //Console.WriteLine("---- Strawberry Price for kg: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Potato Price for kg: " + potatoPrice + " TL");
            //Console.WriteLine("---- Tomato Price for kg: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Product: Apple - " + "Price For 1kg is: " + applePrice + "TL" + "-Grams: " + appleGram + "gr" + "-Total Price is: " + appleTotalPrice + "TL");
            //Console.WriteLine("Product:orange" + "Price For 1kg is: " + orangePrice + "TL" + "-Grams: " + orangeGram + "gr" + "-Total Price is: " + orangeTotalPrice + "TL");
            //Console.WriteLine("strawberry Total price is: " + strawberryGram * strawberryPrice + "TL");
            //Console.WriteLine("potato total price is: " + potatoGram * potatoPrice + "TL");
            //Console.WriteLine("tomato total price is: " + tomatoGram * tomatoPrice + "TL");

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Total Price of today`s shopping: " + shoppingTotalPrice + " TL");


            #endregion


            #region Char variables

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);



            #endregion


            #region data entry from keyboard String variables

            //Console.WriteLine("**** CSharp Hava Yollari Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerId;


            //Console.Write("Yolcu adi: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu soyadi: ");
            //passengerSurname = Console.ReadLine();


            //Console.Write("District Name: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("City: ");
            //passengerCity = Console.ReadLine();


            //Console.Write("Age of passenger: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu ID: ");
            //passengerId = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge + "/" + passengerId);




            #endregion


            #region data entry from keyboard Integer Variables and conversion
            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount,tvCount;

            //Console.Write("write a count of shoes: ");
            //shoesCount = int.Parse(Console.ReadLine());


            //Console.Write("write a count of computers: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("write a count of chairs: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("write a count of tvs:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Total price is:" + totalPrice + "TL");








            #endregion


            #region data entry from keyboard decimals

            //double exam1, exam2, exam3, result;

            //Console.Write("write grade for 1st exam: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("write grade for 2ndexam: ");
            //exam2= double.Parse(Console.ReadLine());
            //Console.Write("write grade for 3rd exam: ");
            //exam3= double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("The average grade for 3 exam is: " + result);








            #endregion


            #region data entry from keyboard Char

            //char gender;
            //Console.Write("please enter your gender: ");

            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("your gender is: " + gender);




            #endregion

            Console.Read();
        }
    }
}
