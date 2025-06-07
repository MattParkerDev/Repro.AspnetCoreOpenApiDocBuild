using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace ClassLibContainingEndpoint;

public static class Endpoints
{
	public static void MapEndpoints(this RouteGroupBuilder builder)
	{
		// increment the number and notice that the generated openapi document does not change without a rebuild
		builder.MapGet("MyClassLibEndpoint1", () => "Hello, World!").WithName("MyClassLibEndpoint");
	}
}
