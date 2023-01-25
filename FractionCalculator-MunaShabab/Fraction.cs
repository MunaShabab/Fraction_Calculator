using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator_MunaShabab
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        //Read-only property that simply returns the value of the numerator backing field.
        public int Numerator { get =>numerator; } 

        //Read-only property that simply returns the value of the denominator backing field.
        public int Denominator { get=>denominator; }

        //Parameterless constructor, initializes this Fraction to 1.

        //Allows consumer to create an "empty" fraction object, but

        //one that in reality creates a legitimate fraction (1/1).
        public Fraction() : this(1, 1) 
        { 

        }

        //Parameterized constructor that initializes the numerator

        //and denominator to the incoming values.
        public Fraction(int theNumerator, int theDenominator)
        {
            this.numerator = theNumerator;
            this.denominator = theDenominator;
            this.Reduce();
            
        }

        //Instance method that adds two Fractions.  Returns a new Fraction

        //object that is the "answer".  rightFrac here implies the Fraction

        //you want to add to the current Fraction (the one on the "right").
        public Fraction Add(Fraction rightFrac)
        {
            int answrerDenomintor= this.Denominator * rightFrac.Denominator;
            int answerNumerirator = (this.Numerator * rightFrac.Denominator) + (rightFrac.Numerator * this.Denominator);
            Fraction answer = new Fraction(answerNumerirator,answrerDenomintor);
            return answer;
        }

        //Instance method that subtracts two Fractions.  Returns a new Fraction

        //object that is the "answer".  rightFrac here implies the Fraction

        //you want to subtract from the current Fraction (the one on the "right").
        public Fraction Subtract(Fraction rightFrac)
        {
            int answrerDenomintor = this.Denominator * rightFrac.Denominator;
            int answerNumerirator = (this.Numerator * rightFrac.Denominator) - (rightFrac.Numerator * this.Denominator);
            Fraction answer = new Fraction(answerNumerirator, answrerDenomintor);
            return answer;
        }

        //Instance method that multiplies two Fractions.  Returns a new Fraction

        //object that is the "answer".  rightFrac here implies the Fraction

        //you want to multiply the current Fraction by (the one on the "right").
        public Fraction Multiply(Fraction rightFrac)
        {
            int answrerDenomintor = this.Denominator * rightFrac.Denominator;
            int answerNumerirator = this.Numerator *  rightFrac.Numerator;
            Fraction answer = new Fraction(answerNumerirator, answrerDenomintor);
            return answer;
        }

        //Instance method that divides two Fractions.  Returns a new Fraction

        //object that is the "answer".  rightFrac here implies the Fraction

        //you want to divide the current Fraction by (the one on the "right").
        public Fraction Divide(Fraction rightFrac)
        {
            int answrerDenomintor = this.Denominator * rightFrac.Numerator;
            int answerNumerirator = this.Numerator * rightFrac.Denominator;
            Fraction answer = new Fraction(answerNumerirator, answrerDenomintor);
            return answer;
        }

        //PRIVATE method used internally by the Fraction class (called by the

        //constructor) to reduce the numerator and denominator of the fraction

        //to lowest terms.
        private void Reduce()
        {
            int numeratorToReduce = numerator;
            int denominatorToReduce = denominator;
            if(denominatorToReduce==0)
            {
                throw new DivideByZeroException("Zero Denominator Not Permitted - Program Has Been Terminated");
            }

            int GCF;

            if (Math.Abs(numeratorToReduce) < Math.Abs(denominatorToReduce))
            {
                GCF = Math.Abs(numeratorToReduce);
            }
            else
            {
                GCF = Math.Abs(denominatorToReduce);
            }
            //loop through the numbers to find the GCF
            for (int i = GCF; i > 1; --i)
            {
                if ((numeratorToReduce % i == 0) && (denominatorToReduce % i == 0))
                {
                    GCF = i;
                    
                    //reduuce the fraction
                    numerator /= GCF;
                    denominator/= GCF;
                    break;

                }

            }
            if((numerator<0 && denominator<0)||(numerator>0 &&denominator>0))
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            else
            {
                numerator = -(Math.Abs(numerator));
                denominator = Math.Abs(denominator);
            }

        }

        //Instance method that returns the decimal representation (as a type double)

        //of a Fraction object.
        public double ToDouble()
        {
            double result = Numerator / (double)Denominator;
            return result;
        }

        //Overrides the base class ToString method to return a string representation

        //of a Fraction object.
        public override string ToString() =>
        $"{Numerator}/{Denominator}";

        //Instance method that returns a decimal string representation of

        //a Fraction object.
        public string ToDecimalString(int numOfDigitsToRight)
        {
           
            double result = this.ToDouble();
            return result.ToString($"f{numOfDigitsToRight}");
        }
            

        //Instance method that returns a string representation of a Fraction object

        //as a proper fraction or mixed number, depending on the fraction itself.
        public string ToMixedNumberString()
        {
            if (Numerator / Denominator == 0)
            {
                return $"{Numerator}/{Denominator}";
            }
            else
            {
                return $"{Numerator / Denominator} {Numerator % Denominator} / {Denominator}";
            }
        }
            
    }
}
