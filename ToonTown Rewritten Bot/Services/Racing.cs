using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace ToonTown_Rewritten_Bot.Services
{
    class Racing
    {
        public static void startRacing()
        {
            makeFirstBendScrewball();//first bend

            makeSecondBendScrewball();//second bend

            makeThirdBendScrewball();//third bend
        }

        private static void makeFirstBendScrewball()
        {
            //straight away
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(6000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(800);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(1000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //short turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(1000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //short turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(450);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //straight away
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(7000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);
        }

        private static void makeSecondBendScrewball()
        {
            //straight away
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(6000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(800);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(800);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(600);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(800);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(1000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            /*//short turn left
            robot.keyPress(KeyEvent.VK_LEFT);
            robot.delay(500);
            robot.keyRelease(KeyEvent.VK_LEFT);*/

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(500);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //short turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(100);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //straight away
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(7000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);
        }

        private static void makeThirdBendScrewball()
        {
            Thread.Sleep(1300);
            //short turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(700);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //straight away
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(1000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);

            //turn left
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(700);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_A);

            //go straight more
            InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
            Thread.Sleep(2000);
            InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);
        }
    }
}
