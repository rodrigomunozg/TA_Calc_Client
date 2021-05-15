/*
 Developed by Rodrigo Muñoz for Rockstar Games interview process. May2021.
 */

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

/// <summary>
/// Code adapted from the Microsoft Documentation of Synchronous Client Socket.
/// This is the class that will manage the socket connection.
/// This is the only class that has relation with the server side of the solution.
/// </summary>
public class ClientConnMgr
{
    public static string operationStringToSend = ""; //This string is modified from the GUI and store the math operation, once modified is sent to the server via socket.
    public static string resultReceived = ""; //This string store the response from the server (the result of the math operation), once received is shown in the GUI display.
    
    //next 5 variables: necessary for the implementation and execution of the synchronous client socket
    public static IPHostEntry host;
    public static IPAddress ipAddress;
    public static IPEndPoint remoteEP;
    public static Socket sender;
    public static byte[] bytes;
    
    /// <summary>
    /// This function establish the connection, send the math op and receive the result from the server side of the Calc solution.
    /// </summary>
    public static void ConectClient()
    {
        bytes = new byte[1024];
        try
        {
            host = Dns.GetHostEntry(Dns.GetHostName());
            ipAddress = host.AddressList[0];
            remoteEP = new IPEndPoint(ipAddress, 11000); sender = new Socket(ipAddress.AddressFamily,SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sender.Connect(remoteEP);
                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                byte[] msg = Encoding.ASCII.GetBytes($"{operationStringToSend}<EOF>");  //Mathematic operation elaborated in the GUI sent to the server
                int bytesSent = sender.Send(msg);
                int bytesRec = sender.Receive(bytes);
                Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                resultReceived = Encoding.ASCII.GetString(bytes, 0, bytesRec);          //Result of the mathematic operation received from the server
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    /// <summary>
    /// This function is invoked when the GUI window of the calculator is closed and closes the connection.
    /// </summary>
    public static void CloseSocket()
    { 
        sender.Shutdown(SocketShutdown.Both);
        sender.Close();
    }
}