using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FGR_Perceptron
{

    public class MyPerceptron
    {
        public int[,] Inputs { get; set; }
        // Sortie observés
        public int[] ObservedOutputs { get; set; }
        // Sortie attendues
        public int[] ExcepetedOutputs { get; set; }
        public Double[] Weights { get;  set; }
        public double LearningRate { get; set; }
        public double TotalError { get; set; }
        public double Bias { get; set; }

        public int LenghtArrayInput { get; set; }


        public void Perceptron(int[,] inputs, int[,] excepetedoutputs)
        {
            
            Inputs = inputs;

            // HyperParameters
            LearningRate = 1;
            TotalError = 1;
            Bias = 1;

            LenghtArrayInput = LengthDimensionArray(Inputs, 1);

            SynaspseWeights(LenghtArrayInput);
       
        }

        /// <summary>
        /// Obtient le nombre d'élèments dans une dimension d'un tableau multidimensionnel 
        /// </summary>
        /// <param name="array">Tableau attendus</param>
        /// <returns>Retourne le nombre d'élèments dans une dimension</returns>
        public  int LengthDimensionArray(Array array, int dimension)
        {
            int lenght = 0;

            lenght = array.GetLength(dimension);

            return lenght;

        }

        public void SynaspseWeights(int numbSynaspse)
        {
            Random r = new Random();

            for (int i = 0; i < numbSynaspse; i++)
            {
                Weights[i] = r.NextDouble();
            }

        }

        public Double CalculOutput()
        {
            Double output = 0;

            for (int i = 0; i < Inputs.Length; i++)
            {
                for (int j = 0; j < Inputs.Length; j++)
                {
                    for (int k = 0; k < Weights.Length; k++)
                    {
                        output += (Inputs[i, j] * Weights[k]);
                    }
                }
            }

            return output
        }

        public void LearningRule()
        {
            List<double> correctedWeight = new List<double>(); 

            for (int i = 0; i < Weights.Count(); i++)
            {
                correctedWeight.Add(Weights[i] + LearningRate * (ExcepetedOutputs[i] - ObservedOutputs[i]) *  // Entrée du poids i pour la sortie attentue);
            }
        }
    }
}
