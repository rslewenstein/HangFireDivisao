using System;
using System.Collections.Generic;
using System.Text;

namespace HangFireDivisao.Domain
{
    public class Division
    {
        public void DivisionRandom()
        {
            try
            {
                var num1 = new Random().Next(0, 10);
                var num2 = new Random().Next(0, 10);

                var result = num1 / num2;

            }catch(DivideByZeroException ex)
            {
                throw new Exception($"Divisão por zero {ex.Message}");
            }
        }
    }
}
