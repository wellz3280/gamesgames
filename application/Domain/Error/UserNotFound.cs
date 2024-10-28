namespace Domain.Error;

public class UserNotFound : Exception
{
     public static IResult NotFound(string message)
    {

    //  var teste =  {      statusCode: StatusCodes.Status404NotFound,
    //         extensions: new Dictionary<string, object>{
    //             {"errors", new {Message = message} }
    //         }
    // var error =
        return Results.NotFound(new Dictionary<string, Object> {
            {"error", new {Message = message }}
        });
    }
}
