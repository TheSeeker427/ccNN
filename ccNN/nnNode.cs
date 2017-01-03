using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN
{
    class nnNode
    {
        public int id;
        public double weight;
        public double value;
        public double bias;
        public double output;

        nnNode[] inConnectNodes;
        
        public void setConnectionNodesLayer(nnNode[] layer)
        {
            inConnectNodes = layer;
        }

        public void feedForwardandActivation()
        {
            double sum = 0.0;
            foreach(nnNode n in inConnectNodes)
            {
                sum += n.weight * n.value;
            }
            
            value = nnMath.sigmoid(sum);
            Console.WriteLine(id+" : " +value);
        }
    }
}
