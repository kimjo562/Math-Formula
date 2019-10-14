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
            float pVarx, qVarx;
            float pVary, qVary;
            float pVarz, qVarz;

            Console.WriteLine(" ");
            Console.WriteLine("Here is the Inner Point Formula");
            Console.WriteLine("Inner(P,Q) = PxQx + PyQy + PzQz\n");

            Console.WriteLine("Add an Px, Py, Pz input (Press Enter after each input)");            
            pVarx = Convert.ToSingle(Console.ReadLine());    pVary = Convert.ToSingle(Console.ReadLine());    pVarz = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Add an Qx, Qy, Qz input (Press Enter after each input)");
            qVarx = Convert.ToSingle(Console.ReadLine());    qVary = Convert.ToSingle(Console.ReadLine());    qVarz = Convert.ToSingle(Console.ReadLine());
            
            answer = (pVarx * qVarx) + (pVary + qVary) + (pVarz + qVarz);

            Console.WriteLine("Inner(P,Q) = " + pVarx + "*" + qVarx + " + " + pVary + "*" + qVary + " + " + pVarz + "*" + qVarz);
            Console.WriteLine("Answer: " + answer);
        }

        public void PlanePoint()
        {
            float aVar, bVar, cVar, dVar;
            float xVar, yVar, zVar;

            Console.WriteLine(" ");
            Console.WriteLine("Here is the Plane Point Formula");
            Console.WriteLine("D(P,X0) =(ax0 + by0 + cz0 + d)/(√a^2 + b^2 + c^2)");

            Console.WriteLine("Add an Px, Py, Pz input (Press Enter after each input)");
            aVar = Convert.ToSingle(Console.ReadLine());     bVar = Convert.ToSingle(Console.ReadLine());     cVar = Convert.ToSingle(Console.ReadLine());   dVar = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Add an x, y, z input (Press Enter after each input)");
            xVar = Convert.ToSingle(Console.ReadLine());     yVar = Convert.ToSingle(Console.ReadLine());     zVar = Convert.ToSingle(Console.ReadLine());

            answer = ((aVar * xVar) + (bVar * yVar) + (cVar * zVar) + dVar) / Math.Sqrt(Math.Pow(aVar, 2) + Math.Pow(bVar, 2) + Math.Pow(cVar, 2));

            Console.WriteLine("D(P,X0) = (" + aVar + "*" + xVar + ") + (" + bVar + "*" + cVar + ") + (" + cVar + "*" + zVar + ") + " + dVar + " / " + aVar + "^2 + " + bVar + "^2 + " + cVar + "^2");
            Console.WriteLine("Answer: " + answer);
        }

        public void CubicBeizerCurve()
        {
            float pVar0;
            float pVar1;
            float pVar2;
            float pVar3;
            float tVar;
   
            Console.WriteLine(" ");
            Console.WriteLine("Here is the Cubic Beizer Curve Formula");
            Console.WriteLine("B(t, P0, P1, P2, P3) = (1 − t)^3P0 + 3(1 − t)^2tP1 + 3(1 − t)t^2P2 + t^3P3");

            Console.WriteLine("Add an P0 input");
            pVar0 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an P1 input");
            pVar1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an P2 input");
            pVar2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an P3 input");
            pVar3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add an t input");
            tVar = Convert.ToSingle(Console.ReadLine());

            answer = ((Math.Pow((1 - tVar), 3) * pVar0) + (3 * Math.Pow((1 - tVar), 2) * tVar * pVar1) + (3 * (1 - tVar)* (tVar * tVar) * pVar2) +(Math.Pow(tVar, 3) * pVar3));

            Console.WriteLine("Print Cubic Beizer Curve Formula.exe has stopped responding.");
            Console.WriteLine("Answer: " + answer);
        }
    }
}
