using _8to10.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace _8to10.Controllers;

    public class RestaurantPickerController : ControllerBase
    {
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route("RestaurantPicker")]

    public string RestPick(string asianIndianOrMexican)
    {
        return _restaurantPickerService.RestPick(asianIndianOrMexican);
    }
}
