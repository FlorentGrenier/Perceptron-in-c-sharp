using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGR_Perceptron
{
    class TestPerceptron
    {

        private MyPerceptron monPerceptron;

        static void Main(string[] args)
        {
            #region OtherPerceptron
            //    int[,] input = new int[,] { { 1, 0 }, { 1, 1 }, { 0, 1 }, { 0, 0 } };
            //    int[] outputs = { 0, 1, 0, 0 };

            //    Random r = new Random();

            //    double[] weights = { r.NextDouble(), r.NextDouble(), r.NextDouble() };

            //    double learningRate = 1;
            //    double totalError = 1;
            //    double bias = 1;

            //    while (totalError > 0.2)
            //    {
            //        totalError = 0;

            //        for (int i = 0; i < 4; i++)
            //        {
            //            int output = CalculateOutput(input[i, 0], input[i, 1], weights);

            //            int error = outputs[i] - output;

            //            weights[0] += learningRate * error * input[i, 0];
            //            weights[1] += learningRate * error * input[i, 1];
            //            weights[2] += learningRate * error * bias;

            //            totalError += Math.Abs(error);

            //        }
            //    }

            //    Console.WriteLine("Results :");
            //    for (int i = 0; i < 4; i++)
            //    {
            //        Console.WriteLine(totalError);

            //        Console.ReadLine();
            //    }
            //}

            //private static int CalculateOutput(double input1, double input2, double[] weights)
            //{
            //    double bias = 1;

            //    double sum = input1 * weights[0] + input2 * weights[1] + bias * weights[2];

            //    return (sum >= 0) ? 1 : 0;
            //}
            #endregion

            int[,] Inputs = new int[,] { { 0, 0, 1, 0 }, { 1, 1, 1, 0 }, { 1, 0, 1, 1 }, { 0, 1, 1, 1 }, { 0, 1, 0, 1 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 } };
            int[,] ExcepetedOutputs = new int[,] { { 0, 1, 1, 0, 0, 1, 0 } };
        }
    }
}
