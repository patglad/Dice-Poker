using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker_Dice
{
    public class Dice
    {
        static readonly int numberOfDice = 5;
        public SingleDice[] tab = new SingleDice[numberOfDice];
        
        public Dice()
        {
            for (int i = 0; i < numberOfDice; i++)
            { 
                tab[i].value = 0;
            }
        }

        public void DrawDiceRandomly()
        {
            int number = 0;
            Random r = new Random();
            for (int i = 0; i<numberOfDice; i++)
            {
                if (tab[i].image == "../../0.png")
                {
                    number = r.Next(1, 6);
                    tab[i].value = number;
                    tab[i].image = "../../" + number + ".png";
                    tab[i].pictureBox.Image = Image.FromFile(tab[i].image);
                }
            }
        }

        public void ZeroDice()
        {
            for (int i = 0; i <numberOfDice; i++)
            {
                tab[i].image = "../../0.png";
                tab[i].pictureBox.Image = Image.FromFile(tab[i].image);
            }
        }

        public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void SortDice(Dice dice, Dice sortDice)
        {
            for (int i=0; i< numberOfDice; i++)
            {
                sortDice.tab[i].value = dice.tab[i].value;
            }
            int numberOfSwap = 0;
            do
            {
                numberOfSwap = 0;
                for (int i = 0; i < numberOfDice - 1; i++)
                {
                    if (sortDice.tab[i].value > sortDice.tab[i+1].value)
                    {
                        Swap(ref sortDice.tab[i].value, ref sortDice.tab[i + 1].value);
                        numberOfSwap++;
                    }
                }
            } while (numberOfSwap != 0);
        }

        // Method returns a value (number) of dice configuration. 
        public int Value(Dice dice)
        {
            int value = 0;
            if (Five_of_a_Kind(dice, ref value)) { }
            else if (Four_of_a_Kind(dice, ref value)) { }
            else if (Full_House(dice, ref value)) { }
            else if (Six_High_Straight(dice, ref value)) { }
            else if (Five_High_Straight(dice, ref value)) { }
            else if (Three_of_a_Kind(dice, ref value)) { }
            else if (Two_Pairs(dice, ref value)) { }
            else if (Pair(dice, ref value)) { }
            else if (Nothing(dice, ref value)) { }

            return value;
        }

        // 9xxx - for example 5x6 is 9006 (9000 + 6), 5x1 is 9001 (9000 + 1).
        public bool Five_of_a_Kind(Dice dice, ref int value)
        {
            if (dice.tab[0].value==dice.tab[1].value && dice.tab[1].value==dice.tab[2].value && dice.tab[2].value==dice.tab[3].value && dice.tab[3].value==dice.tab[4].value)
            {
                value = 9000 + dice.tab[0].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 8xxx - for example 44445 is 8405 (8000 + 4*100 + 5).
        public bool Four_of_a_Kind(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            // Type XXXXY.
            if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)  
            {
                // The number hundreds means the number of points being repeated.
                // The unity number is a different number of stitches rolled out.
                value = 8000 + diceSort.tab[0].value * 100 + diceSort.tab[4].value;           
                return true;                                
            }
            // Type YXXXX.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                    && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)   
            {
                value = 8000 + diceSort.tab[1].value * 100 + diceSort.tab[0].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 7xxx - for example 11122 is 7104 (7000 + 1*100 + 2 + 2).
        bool Full_House(Dice dice, ref int value)
        {
            // Stores sorted dice.
            Dice diceSort = new Dice();     

            SortDice(dice, diceSort);

            // Type XXXYY.
            if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)  
            {
                // The number hundreds is the number XXX.
                // We add YY to distinguish for example 22255 from 22211.
                value = 7000 + diceSort.tab[0].value * 100 + diceSort.tab[3].value + diceSort.tab[4].value;   
                return true;                                    
            }
            // Type XXYYY.
            else if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value
                    && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)  	
            {
                value = 7000 + diceSort.tab[2].value * 100 + diceSort.tab[0].value + diceSort.tab[1].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 6000 - value 6000.
        bool Six_High_Straight(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            if (diceSort.tab[0].value == 2 && diceSort.tab[1].value == 3 && diceSort.tab[2].value == 4 
                && diceSort.tab[3].value == 5 && diceSort.tab[4].value == 6)
            {
                value = 6000;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 5000 - value 5000.
        bool Five_High_Straight(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            if (diceSort.tab[0].value == 1 && diceSort.tab[1].value == 2 && diceSort.tab[2].value == 3 
                    && diceSort.tab[3].value == 4 && diceSort.tab[4].value == 5)
            {
                value = 5000;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 4xxx - for example 33356 is 4311 (4000 + 3*100 + 5 + 6).
        bool Three_of_a_Kind(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            // Type XXXYZ.
            if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)   
            {
                value = 4000 + diceSort.tab[0].value * 100 + diceSort.tab[3].value + diceSort.tab[4].value;
                return true;
            }
            // Type YXXXZ.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                    && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)   
            {
                value = 4000 + diceSort.tab[1].value * 100 + diceSort.tab[0].value + diceSort.tab[4].value;
                return true;
            }
            // Type YZXXX.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value 
                    && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)   
            {
                value = 4000 + diceSort.tab[2].value * 100 + diceSort.tab[0].value + diceSort.tab[1].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 3xxx - for examle 11336 is 3086 (3000 + (2*1 + 2*3)*10 + 6).
        bool Two_Pairs(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            // Type XXYYZ.
            if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value 
                && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)   
            {
                value = 3000 + (diceSort.tab[0].value * 2 + diceSort.tab[1].value * 2) * 10 + diceSort.tab[4].value;
                return true;
            }
            // Type XYYZZ.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                    && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)   
            {
                value = 3000 + (diceSort.tab[1].value * 2 + diceSort.tab[3].value * 2) * 10 + diceSort.tab[0].value;
                return true;
            }
            // pary typu: XXYZZ
            else if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value
                    && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)   
            {
                value = 3000 + (diceSort.tab[0].value * 2 + diceSort.tab[3].value * 2) * 10 + diceSort.tab[2].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 2xxx - for example 11456 is 2115 (2000 + 1*100 + 4 + 5 + 6).
        bool Pair(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            // Type XXABC.
            if (diceSort.tab[0].value == diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value 
                && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)   
            {
                value = 2000 + diceSort.tab[0].value * 100 + diceSort.tab[2].value + diceSort.tab[3].value + diceSort.tab[4].value;
                return true;
            }
            // Type AXXBC.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value == diceSort.tab[2].value 
                    && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)   
            {
                value = 2000 + diceSort.tab[1].value * 100 + diceSort.tab[0].value + diceSort.tab[3].value + diceSort.tab[4].value;
                return true;
            }
            // Type ABXXC.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value 
                    && diceSort.tab[2].value == diceSort.tab[3].value && diceSort.tab[3].value != diceSort.tab[4].value)   
            {
                value = 2000 + diceSort.tab[2].value * 100 + diceSort.tab[0].value + diceSort.tab[1].value + diceSort.tab[4].value;
                return true;
            }
            // Type ABCXX.
            else if (diceSort.tab[0].value != diceSort.tab[1].value && diceSort.tab[1].value != diceSort.tab[2].value 
                && diceSort.tab[2].value != diceSort.tab[3].value && diceSort.tab[3].value == diceSort.tab[4].value)   
            {
                value = 2000 + diceSort.tab[3].value * 100 + diceSort.tab[0].value + diceSort.tab[1].value + diceSort.tab[2].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        // 1xxx - for example 13456 is 1019 (1000 + 1 + 3 + 4 + 5 + 6).
        bool Nothing(Dice dice, ref int value)
        {
            Dice diceSort = new Dice();

            SortDice(dice, diceSort);

            // 1 2 3 4 6
            if ((diceSort.tab[0].value == 1 && diceSort.tab[1].value == 2 && diceSort.tab[2].value == 3 && diceSort.tab[3].value == 4 && diceSort.tab[4].value == 6)
            // 1 2 3 5 6
            || (diceSort.tab[0].value == 1 && diceSort.tab[1].value == 2 && diceSort.tab[2].value == 3 && diceSort.tab[3].value == 5 && diceSort.tab[4].value == 6)
            // 1 2 4 5 6
            || (diceSort.tab[0].value == 1 && diceSort.tab[1].value == 2 && diceSort.tab[2].value == 4 && diceSort.tab[3].value == 5 && diceSort.tab[4].value == 6)
            // 1 3 4 5 6
            || (diceSort.tab[0].value == 1 && diceSort.tab[1].value == 3 && diceSort.tab[2].value == 4 && diceSort.tab[3].value == 5 && diceSort.tab[4].value == 6))    
            {
                value = 1000 + diceSort.tab[0].value + diceSort.tab[1].value + diceSort.tab[2].value + diceSort.tab[3].value + diceSort.tab[4].value;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }

        public string ConfigurationName(Dice dice)
        {
            int score;
            score = Value(dice);       
            score = score / 1000;

            switch (score)
            {
                case 9:
                    return "Five-of-a-Kind";
                case 8:
                    return "Four-of-a-Kind";
                case 7:
                    return "Full House";
                case 6:
                    return "Six High Straight";
                case 5:
                    return "Five High Straight";
                case 4:
                    return "Three-of-a-Kind";
                case 3:
                    return "Two Pairs";
                case 2:
                    return "Pair";
                default:
                    return "Nothing";
            }
        }
    }
}
