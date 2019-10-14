using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Formula
{
    class Calculator
    {
        string choice = " ";
        double answer;
        public void Start()
        {
            Console.WriteLine("It's just a really bad calculator.");
            Console.WriteLine("Here are your options.");
            HomeMenu();
        }

        public void HomeMenu()
        {
            while (choice != "Q")
            {
                Console.WriteLine(" ");
                Console.WriteLine("1.) Basic Quadratic \n2.) Quadratic Function \n3.) Linear Blend \n4.) Distance Formula \n5.) Inner Two Points \n6.) Plane Points \n7.) Cubic Beizer Curve \nQ.) Quit");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    BasicQuad();
                }
                else if(choice == "2")
                {
                    QuadFormula();
                }
                else if(choice == "3")
                {
                    LinearBlend();
                }
                else if(choice == "4")
                {
                    DistanceForm();
                }
                else if(choice == "5")
                {
                    InnerTwoPoint();
                }
                else if(choice == "6")
                {
                    PlanePoint();
                }
                else if(choice == "7")
                {
                    CubicBeizerCurve();
                }
                else if(choice == "Q")
                {
                    Console.WriteLine("Shutting Down...");
                }

            }
        }

        public void BasicQuad()
        {
            float xVar;

            Console.WriteLine(" ");
            Console.WriteLine("f(x) = x^2 + 2x - 7");
            Console.WriteLine("Add an X input.");
            xVar = Convert.ToSingle(Console.ReadLine());
            
            answer = (xVar * xVar) + (xVar * 2) - 7;
            Console.WriteLine("\nf("+ xVar + ") = " + xVar + "^2 + 2(" + xVar + ") - 7");
            Console.WriteLine("Answer: " + answer);
        }

        public void QuadFormula()
        {
            float aVar;
            float bVar;
            float cVar;

            Console.WriteLine(" ");
            Console.WriteLine("Here is the Quadratic Formula");
            Console.WriteLine("f(a,b,c) = −b± √b2−4ac 2a");
            Console.WriteLine("Add an A input");
            aVar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an B input");
            bVar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an C input");
            cVar = Convert.ToSingle(Console.ReadLine());

            answer = Math.Sqrt((bVar * bVar) - (4 * aVar * cVar));

            Console.WriteLine("\nf("+ aVar + "," + bVar + "," + cVar + ") = -" + bVar + "± √(" + bVar +"^2 - 4(" +aVar+ ")(" +cVar + ")) / 2(" + aVar +")");
            Console.WriteLine("Answer: " + answer);
            if(answer <= 0)
            {
                Console.WriteLine("The polynomial has no roots");
            }
        }

        public void LinearBlend()
        {
            float sVar;
            float eVar;
            float tVar;

            Console.WriteLine(" ");
            Console.WriteLine("Here is the Linear Blend Formula");
            Console.WriteLine("L(s,e,t) = s + t(e-s)");
            Console.WriteLine("Add an S input");
            sVar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an E input");
            eVar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an T input");
            tVar = Convert.ToSingle(Console.ReadLine());


            answer = sVar + tVar * (eVar - sVar);

            Console.WriteLine("\nL(" + sVar + "," + eVar + "," + tVar + ") = " + sVar +"+" + tVar + "(" + eVar +"-" + sVar +")");
            Console.WriteLine("Answer: " + answer);

        }

        public void DistanceForm()
        {
            float xVar1;
            float xVar2;
            float yVar1;
            float yVar2;

            Console.WriteLine(" ");
            Console.WriteLine("Here is the Distance Formula");
            Console.WriteLine("D(P1,P2) = √(x2 − x1)^2 + (y2 − y1)^2");
            Console.WriteLine("Add an X1 input");
            xVar1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an X2 input");
            xVar2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an Y1 input");
            yVar1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an Y2 input");
            yVar2 = Convert.ToSingle(Console.ReadLine());

            answer = Math.Sqrt(Math.Pow((xVar2 - xVar1), 2) + Math.Pow((yVar2 - yVar1),2));

            Console.WriteLine("D(P1,P2) = √("+ xVar2 + "−" + xVar1 +")^2 + (" + yVar2 + "−" + yVar1 +")^2");
            Console.WriteLine("Answer: " + answer);
        }

        public void InnerTwoPoint()
        {

        }

        public void PlanePoint()
        {

        }

        public void CubicBeizerCurve()
        {

        }
    }
}
