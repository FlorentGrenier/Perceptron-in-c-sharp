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
       
        public Double TotalError { get; set; }
        public Double Bias { get; set; }

        public int LenghtArrayInput { get; set; }

        public int Iterations { get; set; }
        public Double LearningRate { get; set; }




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
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Double Sigmoid(Double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Double SigmoidDeriv(Double x)
        {
            return Math.Exp((-x) / Math.Pow((1 + Math.Exp(-x)), 2));
        }



        /// <summary>
        /// LengthDimensionArray()
        /// Obtient le nombre d'élèments dans une dimension d'un tableau multidimensionnel 
        /// </summary>
        /// <param name="array">Tableau attendus</param>
        /// <param name="dimension">Dimension du tableau</param>
        /// <returns>Retourne le nombre d'élèments dans une dimension</returns>
        public int LengthDimensionArray(Array array, int dimension)
        {
            int lenght = 0;

            lenght = array.GetLength(dimension);

            return lenght;

        }

        /// <summary>
        /// SynaspseWeights()
        /// Attribue un poids à chaque synapse
        /// </summary>
        /// <param name="numbSynapse">Nombre de synapse</param>
        public void SynaspseWeights(int numbSynapse)
        {
            Random r = new Random();

            for (int i = 0; i < numbSynapse; i++)
            {
                Weights[i] = r.NextDouble();
            }

        }

        /// <summary>
        /// CalculOutput()
        /// Cacul la sortie du neuronne
        /// </summary>
        /// <returns></returns>
        public Double CalculOutput()
        {
            Double output = 0;

            for (int i = 0; i < Inputs.Length; i++)
            {
                for (int j = 0; j < Inputs.Length; j++)
                {
                    for (int k = 0; k < Weights.Length; k++)
                    {
                        output += ( Weights[k] * Inputs[i, j]);
                    }
                }
            }

            return output;
        }

        /// <summary>
        /// Train()
        /// Entraine le neuronne.
        /// </summary>
        /// <param name="its">Nombre d'iterations à parcourir</param>
        /// <param name="lr">Taux d'apprentissage</param>
        public void Train(int its, Double lr)
        {
            Double activation = 0;
            

            for (int iteration = 0; iteration < its; iteration++)
            {
                // Forward Pass
                activation = Sigmoid(CalculOutput());

                // Backward Pass
                for (int i = 0; i < 7; i++)
                {


                }

            }




        }



        //public void LearningRule()
        //{
        //    List<double> correctedWeight = new List<double>(); 

        //    for (int i = 0; i < Weights.Count(); i++)
        //    {
        //        correctedWeight.Add(Weights[i] + LearningRate * (ExcepetedOutputs[i] - ObservedOutputs[i]) *  // Entrée du poids i pour la sortie attentue);
        //    }
        //}
    }
}
