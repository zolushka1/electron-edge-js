using ECRT1000;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odko
{
    public class Wazzup
    {
        public async Task<object> AreBothEven(dynamic input = null) // Allow dynamic input
        {
            return true; // No parameters needed
        }

        public async Task<object> AddNumber(dynamic input) // Accept dynamic input
        {
            // Ensure the input is in the expected format
            if (input != null && input is object[] && input.Length == 2)
            {
                int num1 = Convert.ToInt32(input[0]); // Convert the first element
                int num2 = Convert.ToInt32(input[1]); // Convert the second element
                return num1 + num2; // Return the sum
            }
            throw new ArgumentException("Invalid input for AddNumber. Expected an array of two numbers.");
        }

        public async Task<object> AddNumber2(object[] input) // Accept input as an array
        {
            try
            {
                if (input.Length != 2)
                {
                    throw new ArgumentException("Expected exactly two parameters.");
                }

                // Convert the first and second elements to integers
                int number1 = Convert.ToInt32(input[0]);
                int number2 = Convert.ToInt32(input[1]);
                return number1 + number2; // Return the sum
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid input for AddNumber2. Expected two numbers.", ex);
            }
        }

        public async Task<object> helloworld(dynamic input)
        {
            Debug.WriteLine("Hello dll world");
            return "Hello from .NET world !!";
        }

        public int AddNumbers3(int num1, int num2) // Non-async method
        {
            return num1 + num2; // Return the sum directly
        }

        public object helloObject(dynamic input)
        {
            Debug.WriteLine("Hello dll world");
            return "Hello from .NET object";
        }

        public object helloString(dynamic input)
        {
            return "Hello from .NET Strig";
        }

        public async Task<object> connectToMbank(dynamic input)
        {
            ECRLib ecr = new ECRLib();
            string portName = Convert.ToString(input[0]);
            if (!string.IsNullOrEmpty(portName))
                ecr.Connect(portName);

            if (ecr.isConnected())
            {
                Dictionary<ECRField, object> fields = ecr.Sale(Convert.ToDouble(100), "1421321");
                return true;
            }
            else
            {
                return false;
            }
        }

        //public async Task<object> payment(dynamic input)
        //{
        //    ECRLib ecr = new ECRLib();
        //    string portName = Convert.ToString(input[0]);
        //    if (!string.IsNullOrEmpty(portName))
        //        ecr.Connect(portName);

        //    if (ecr.isConnected())
        //    {
        //        Dictionary<ECRField, object> fields = ecr.Sale(Convert.ToDouble(100), input[1]);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
