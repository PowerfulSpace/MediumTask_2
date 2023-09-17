﻿using System.Net.Sockets;

var port = 80;
var url = "www.google.com";

using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try
{
    // пытаемся подключиться используя URL-адрес и порт
    await socket.ConnectAsync(url, port);
    Console.WriteLine($"Подключение к {url} установлено");
}
catch (SocketException)
{
    Console.WriteLine($"Не удалось установить подключение к {url}");
}
Console.ReadLine();

