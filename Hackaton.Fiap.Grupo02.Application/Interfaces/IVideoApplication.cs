﻿namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task ProcessReceivedMessage(string url);
}