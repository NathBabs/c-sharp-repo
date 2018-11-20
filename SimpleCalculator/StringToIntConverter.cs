using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class StringToIntConverter
    {
        public int convert(String input)
        {
            try
            {
                int convertedNumber;
                bool isConvertedsuccesfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedsuccesfully)
                {
                    throw new Exception("Conversion was not successful.");
                }
                return convertedNumber;
            }
            
            catch (Exception ex)
            {

                throw new Exception("new message", ex);
            }
        }
    }
}
