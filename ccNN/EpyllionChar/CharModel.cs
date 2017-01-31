using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN.EpyllionChar
{
    class CharModel
    {
        public Head head;
        public Body body;

        public Graphics g;

        public states state = states.idle;

        int idleMaxY = 0;
        int idleMinY = -3;
        int idleX = 5;
        bool idleYUp = false;
        bool idleWaiting = false;
        int idleWait = 1;
        int idleWaitMax = 5;
        int Y = 0;

        public CharModel()
        {
            head = new Head();
            body = new Body();
        }

        public enum states
        {
            idle,
            bored,
            talking
        }


        internal void update()
        {
            switch (state)
            {
                case states.idle:
                        idle();
                    break;

            }
            
            
            if (blinkTimer <= 0)
            {
                isblinking = true;
                blinkwait = 1;
                blinkTimer = r.Next(10,50);
            }
            blinkTimer--;
            if (isblinking)
                blink();
        }
Random r = new Random();
        int blinkwait = 2;
        int blinkTimer = 0;
        bool isblinking = false;
        private void blink()
        {
            if (blinkwait <= 0)
            {
                head.img = head.EyeOpenImg;
                isblinking = false;
            }else
            {
                head.img = head.EyeClosedImg;
                blinkwait--;
            }
           
        }

        private void idle()
        {
            if (!idleWaiting)
            {
                if (idleYUp)
                {
                    head.location.Y = head.location.Y + 1;
                    Y++;
                }
                else
                {
                    head.location.Y = head.location.Y - 1;
                    Y--;
                }

                if (Y >= idleMaxY)
                {
                    idleYUp = false;
                    idleWaiting = true;
                }
                if (Y <= idleMinY)
                {
                    idleYUp = true;
                    
                }
            }
            else
            {
                if(idleWait == idleWaitMax)
                {
                    idleWait = 0;
                    idleWaiting = false;
                }
                idleWait++;
            }
        }
    }
}
