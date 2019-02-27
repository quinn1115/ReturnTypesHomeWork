using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           



        }


        //Opdracht 1
        double Opdr1_OppCirkel(double straal)
        {
            return straal * straal * Math.PI;
        }

        //Opdracht 2
        int Opdr2_ArrowDamageCalculator(int distance, int damage)
        {
            if(distance > 50 && distance < 100)
            {

            }

            if(distance < 50)
            {
                damage = damage / 2;
            }

            if(distance > 100)
            {
                damage = damage * 2;
            }

            return damage;
        }

        //Opdracht 3
        int Opdr3_ArrowDamageCalculator(int distance, int pull)
        {
            int damage = (distance * pull) / 2;

            return damage;
        }

        //Opdracht 4
        bool Opdr4_TargetHit(int damage, int distance)
        {
            if(damage > distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
