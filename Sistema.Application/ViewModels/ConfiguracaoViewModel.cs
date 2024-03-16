using Flunt.Notifications;

namespace Hackaton.Fiap.Grupo02.Application.ViewModels
{
    public class ConfiguracaoViewModel : Notifiable<Notification>
    {
        public string Variavel { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
        public Guid Id { get; set; }
    }
}
