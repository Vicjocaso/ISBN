using System;
namespace ISBN
{
    public class EmptyClass
    {
        public static bool Visbn(int[] number)
        {
            int multiply = 0;
            int sum = 0;

            if (number.Length == 10)
            {
                int position = 10;

                for (int i = 0; i < number.Length; i++)
                {
                    multiply = number[i] * position;
                    sum += multiply;
                    position--;
                    multiply = 0;
                }

                if (sum % 11 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (number.Length == 13)
            {

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        multiply = number[i] * 1;
                    }
                    else
                    {
                        multiply = number[i] * 3;
                    }
                    sum += multiply;
                    multiply = 0;
                }

                if (sum % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
