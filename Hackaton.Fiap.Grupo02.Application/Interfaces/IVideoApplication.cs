using Hackaton.Fiap.Grupo02.Application.ViewModels;

namespace Hackaton.Fiap.Grupo02.Application.Interfaces;

public interface IVideoApplication
{
    Task Processa(InboundFileViewModel file);
}