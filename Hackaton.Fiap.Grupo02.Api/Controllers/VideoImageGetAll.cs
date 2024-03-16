namespace Hackaton.Fiap.Grupo02.Api.Controllers
{
    public class VideoImageGetAll
    {
        public static string Template => "/videoimage/getall";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;
        
        public static IResult Action(IUsuarioApp usuarioService, Guid id)
        {
            var userObj= usuarioService.Carregar(id);
        
            return Results.Ok(userObj);
        }
    }
}
