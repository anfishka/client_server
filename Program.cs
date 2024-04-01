using System.Net.Sockets;
using System.Text;

const string IP_SERVER_ADR = "127.0.0.1";
const int PORT_SERVER_ADDR = 4000;

using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
await socket.ConnectAsync(IP_SERVER_ADR, PORT_SERVER_ADDR);

Console.WriteLine("Client");
Console.WriteLine("Client connected to server");

socket.Send(Encoding.Unicode.GetBytes(Console.ReadLine()));
