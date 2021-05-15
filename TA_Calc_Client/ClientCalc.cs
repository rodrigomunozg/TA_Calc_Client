/*
 Developed by Rodrigo Muñoz for Rockstar Games interview process. May2021.
 */

using System;
using System.Windows;
using System.ComponentModel;

namespace TA_Calc_Client
{
    /// <summary>
    /// This is the client GUI, the only interaction point between the user and the Server side of the Calc solution.
    /// </summary>
    public partial class ClientCalc : Window
    {
        /// <summary>
        /// When the GUI starts initiate the connection via socket with the Calc_Server.
        /// </summary>
        public ClientCalc()
        {
            InitializeComponent();
            ClientConnMgr.operationStringToSend = "Client_Calc connected";
            ClientConnMgr.ConectClient();
        }

        /// <summary>
        /// When the window is about to close the function that closes the connection is invoked.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        void ClientCalc_Closing(object sender, CancelEventArgs e)
        {
            ClientConnMgr.CloseSocket();
        }

        /// <summary>
        /// Sends to the server mathematic operation when the "=" button or key is pressed on the GUI.
        /// This mathematic operation is located as a string in the display of the GUI.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            ClientConnMgr.operationStringToSend = textdisplay.Text;
            ClientConnMgr.ConectClient();
            textdisplay.Text = ClientConnMgr.resultReceived;
        }

        /// <summary>
        /// Appends a "1" character to the display on the GUI when the "1" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem")||
                textdisplay.Text.Contains("Mem")||
                textdisplay.Text=="0")
            {
                textdisplay.Text = ""; 
            }
            textdisplay.Text += "1";
        }

        /// <summary>
        /// Appends a "2" character to the display on the GUI when the "2" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "2";
        }

        /// <summary>
        /// Appends a "3" character to the display on the GUI when the "3" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "3";
        }

        /// <summary>
        /// Appends a "1" character to the display on the GUI when the "4" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "4";
        }

        /// <summary>
        /// Appends a "5" character to the display on the GUI when the "5" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "5";
        }

        /// <summary>
        /// Appends a "6" character to the display on the GUI when the "6" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "6";
        }

        /// <summary>
        /// Appends a "7" character to the display on the GUI when the "7" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "7";
        }

        /// <summary>
        /// Appends a "8" character to the display on the GUI when the "8" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "8";
        }

        /// <summary>
        /// Appends a "9" character to the display on the GUI when the "9" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "9";
        }

        /// <summary>
        /// Appends a "0" character to the display on the GUI when the "0" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "0";
        }

        /// <summary>
        /// Appends a "+" character to the display on the GUI when the "+" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "+";
        }

        /// <summary>
        /// Appends a "-" character to the display on the GUI when the "-" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "-";
        }

        /// <summary>
        /// Appends a "*" character to the display on the GUI when the "*" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonTimes_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "*";
        }

        /// <summary>
        /// Appends a "/" character to the display on the GUI when the "/" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "/";
        }

        /// <summary>
        /// Appends a "." character to the display on the GUI when the "." button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// I used "," and not "."  (as usual in calculators) because i use Double.Convert(string) on the server side and it uses "," as decimal separator and not "."
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            textdisplay.Text += ",";
        }

        /// <summary>
        /// Appends a "^" character to the display on the GUI when the "^" button on the GUI (or key on the keyboard )is pressed.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonExpo_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += "^";
        }

        /// <summary>
        /// Appends a "√" character to the display on the GUI when the "√" button is pressed on the GUI.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text = "Sqrt("+textdisplay.Text+")";
        }

        /// <summary>
        /// Appends a "π" character to the display on the GUI when the "π" button is pressed on the GUI.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonPi_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text += ""+Math.PI;
        }

        /// <summary>
        /// Appends (or erases) a "-" character to the display on the GUI when the "+/-" button is pressed on the GUI.
        /// If the number on the display is positive the "-" will be appended at the left to the number in the display, if the number is negative the "-" will be erased.
        /// This is used for construct the mathematic operation before send it to the server.
        /// </summary>
        /// <param name="sender">System parameter for detect actions of the GUI</param>
        /// <param name="e">System parameter for detect events of the GUI</param>
        private void buttonToggle_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            if (textdisplay.Text.Contains("-"))
            {
                textdisplay.Text = textdisplay.Text.Replace("-", "");
            }
            else
            {
                textdisplay.Text = "-"+textdisplay.Text;
            }
        }

        /// <summary>
        /// Sends a message to the server for executing a function that will add the number on the screen to a list of doubles.
        /// This will emulate the memory of the calculator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMemPlus_Click(object sender, RoutedEventArgs e)
        {
            if (textdisplay.Text.Contains("mem") ||
                textdisplay.Text.Contains("Mem") ||
                textdisplay.Text == "0")
            {
                textdisplay.Text = "";
            }
            textdisplay.Text = "Result added to memory";
            ClientConnMgr.operationStringToSend = textdisplay.Text;
            ClientConnMgr.ConectClient();
            textdisplay.Text = ClientConnMgr.resultReceived;
        }

        /// <summary>
        /// Sends a message to the server for executing a function that will remove the last number stored in the memory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMemMinus_Click(object sender, RoutedEventArgs e)
        {
            textdisplay.Text = "Last result removed from memory";
            ClientConnMgr.operationStringToSend = textdisplay.Text;
            ClientConnMgr.ConectClient();
            textdisplay.Text = ClientConnMgr.resultReceived;
        }

        /// <summary>
        /// Sends a message to the server for executing a function that will calculate the average of the numbers in the memory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMemAvg_Click(object sender, RoutedEventArgs e)
        {
            textdisplay.Text = "Calculating average of memory";
            ClientConnMgr.operationStringToSend = textdisplay.Text;
            ClientConnMgr.ConectClient();
            textdisplay.Text = ClientConnMgr.resultReceived;
        }

        /// <summary>
        /// Sends a message to the server for executing a function that will clear the memory of the calculator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMemClear_Click(object sender, RoutedEventArgs e)
        {
            textdisplay.Text = "Memory cleared";
            ClientConnMgr.operationStringToSend = textdisplay.Text;
            ClientConnMgr.ConectClient();
            textdisplay.Text = ClientConnMgr.resultReceived;
        }

        /// <summary>
        /// Clears the display of the GUI Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearDisplay_Click(object sender, RoutedEventArgs e)
        {
            textdisplay.Text = "";
        }
    }
}
