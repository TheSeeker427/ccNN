using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN
{
    class drawBrain
    {
        Graphics graphics;
        Network network;
        Font font;
        int displacement = 50;
        int synapseLength = 60;
        int neuronSize = 45;
        int defaultNeuronSize = 10;
        int defaultDisplacementSize = 10;
        float synapseMuliplier = 1.5f;
        int startPosX = 10;

       public drawBrain(Graphics g, Network n)
        {
            graphics = g;
            network = n;
            font = new Font(FontFamily.GenericSansSerif, 10);
        }

        public drawBrain(int dis,Graphics g, Network n)
        {
            graphics = g;
            network = n;
            font = new Font(FontFamily.GenericSansSerif, 10);
            startPosX += dis;
        }

        public void update(int scaler)
        {

            int startX =startPosX * scaler;
            int startY = 10;
            neuronSize = defaultNeuronSize * scaler;
            displacement = defaultDisplacementSize * scaler;
            int inputPushDown =  network.HiddenLayer.Count/3 * displacement;
            startY += inputPushDown;
            foreach (Neuron n in network.InputLayer)
            {
                graphics.FillEllipse(Brushes.Red, new Rectangle(startX, startY, neuronSize, neuronSize));
                graphics.DrawString(n.Value +"", font, Brushes.Black, new Point(startX, startY + 1));
                
                for(int i =0; i < n.OutputSynapses.Count; i++)
                {
                    Pen pen = new Pen(Color.Green,(float) n.OutputSynapses[i].Weight * synapseMuliplier);
                    graphics.DrawLine(pen, new Point(startX + neuronSize, startY + neuronSize/2), new Point(startX + displacement + synapseLength, 10  + neuronSize/2 + displacement* i));
                }
                startY += displacement;
            }
            startY -= inputPushDown;
            startX += displacement + synapseLength;
            startY = 10;
            foreach (Neuron n in network.HiddenLayer)
            {
                graphics.FillEllipse(Brushes.DimGray, new Rectangle(startX, startY, neuronSize, neuronSize));
                //graphics.DrawString(n.Value + "", font, Brushes.Black, new Point(11, startY + 1));
                

                for (int i = 0; i < n.OutputSynapses.Count; i++)
                {
                    Pen pen = new Pen(Color.Green, (float)n.OutputSynapses[i].Weight * synapseMuliplier);
                    graphics.DrawLine(pen, new Point(startX + neuronSize, startY + neuronSize / 2), new Point(startX + displacement + synapseLength, 10 + inputPushDown + neuronSize / 2 + displacement * i));
                }

                startY += displacement;

            }
            startX += displacement + synapseLength;
            
            startY = 10;
            startY += inputPushDown;
            foreach (Neuron n in network.OutputLayer)
            {
                graphics.FillEllipse(Brushes.DarkCyan, new Rectangle(startX, startY, neuronSize, neuronSize));
                graphics.DrawString(Math.Round(n.Value,2) + "", font, Brushes.Black, new Point(startX, startY + 1));

                for (int i = 0; i < n.OutputSynapses.Count; i++)
                {
                    Pen pen = new Pen(Color.Green, (float)n.OutputSynapses[i].Weight * synapseMuliplier);
                    graphics.DrawLine(pen, new Point(startX + neuronSize, startY + neuronSize / 2), new Point(startX + displacement + synapseLength, 10 + neuronSize / 2 + displacement * i));
                }

                startY += displacement;
            }

        }
    }
}
