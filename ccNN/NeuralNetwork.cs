using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN
{
    class NeuralNetwork
    {
        nnNode[] inputNodes;
        nnNode[] hiddenNodes;
        nnNode[] outputNodes;

        double inputWeights;
        double outputWeights;
        double hiddenWeights;

        Random ran = new Random();

        public NeuralNetwork(int numInputs, int numHidden, int numOutput)
        {
            inputNodes = new nnNode[numInputs];
            hiddenNodes = new nnNode[numHidden];
            outputNodes = new nnNode[numOutput];

            makeNetwork();
        }

        public void go(double[] input)
        {
            for (int i = 0; i < inputNodes.Length; i++)
            {
                inputNodes[i].value = input[i];
            }
            foreach (nnNode n in inputNodes)
            {
                //n.feedForwardandActivation();
            }
            foreach (nnNode n in hiddenNodes)
            {
                n.feedForwardandActivation();
            }
            foreach (nnNode n in outputNodes)
            {
                n.feedForwardandActivation();
            }
        }

        public void go(double[] input, double[] output)
        {
            for (int i = 0; i < inputNodes.Length; i++)
            {
                inputNodes[i].value = input[i];
            }
            foreach (nnNode n in inputNodes)
            {
                //n.feedForwardandActivation();
            }
            foreach (nnNode n in hiddenNodes)
            {
                n.feedForwardandActivation();
            }

            foreach (nnNode n in outputNodes)
            {
                n.feedForwardandActivation();

            }
            double err = 0.0;
            for (int i = 0; i < outputNodes.Length; i++)
            {
                double diff = output[i] - outputNodes[i].value;
                err += diff * diff;
                Console.WriteLine("Predict :" + outputNodes[i].value + " : " + diff);
            }
            Console.WriteLine("Error: " + err + "\n");
            backProb(err);
        }

        public void backProb(double err)
        {
            foreach (nnNode n in inputNodes)
            {
                n.weight = n.weight / inputWeights * err;
            }
            foreach (nnNode n in hiddenNodes)
            {
                n.weight = n.weight / hiddenWeights * err;
            }

           

        }

        public void makeNetwork()
        {
            int i = 0;
            for (int x = 0; x < inputNodes.Length; x++)
            {
                inputNodes[x] = new nnNode();
            }
            for (int x = 0; x < hiddenNodes.Length; x++)
            {
                hiddenNodes[x] = new nnNode();
            }
            for (int x = 0; x < outputNodes.Length; x++)
            {
                outputNodes[x] = new nnNode();
            }
            foreach (nnNode n in inputNodes)
            {
                
                n.weight = ran.NextDouble();
                inputWeights += n.weight;
                Console.WriteLine("Input Node Weight: " + n.weight);
                n.id = i;
                i++;
            }
            foreach (nnNode n in hiddenNodes)
            {
                n.setConnectionNodesLayer(inputNodes);
                n.weight = ran.NextDouble();
                Console.WriteLine("Hidden Node Weight: " + n.weight);
                hiddenWeights += n.weight;
                n.id = i;
                i++;
            }
            foreach (nnNode n in outputNodes)
            {
                n.setConnectionNodesLayer(hiddenNodes);
                n.weight = ran.NextDouble();
                Console.WriteLine("output Node Weight: " + n.weight);
                outputWeights += n.weight;
                n.id = i;
                i++;
            }
           
        }

    }
}
