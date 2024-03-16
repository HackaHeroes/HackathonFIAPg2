using Hackaton.Fiap.Grupo02.Application.Interfaces;

namespace Hackaton.Fiap.Grupo02.Api.Controllers
{
    public class VideoImageGetAll
    {
        public static string Template => "/videoimage";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;
        
        
        public static IResult Action(IVideoApplication videoApp)
        {
            return Results.Ok(videoApp.GetAll());
        }
    }
}
