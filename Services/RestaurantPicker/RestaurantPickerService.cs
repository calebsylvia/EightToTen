using _8to10.Services.GuessIt;

namespace _8to10.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string RestPick(string asianIndianOrMexican)
    {
        if(asianIndianOrMexican.ToLower() == "asian")
        {
            string[] asianPlaces = { "Shomi", "Komachi", "Bonchon", "Dave Wong's", "Dynasty", "Manila Express", "Saigon Bay", "Pho Lucky", "Sherman's Buffet", "Shangri La" };
            Random asianPick = new Random();
            var asianPlacePick = asianPick.Next(0, asianPlaces.Length);
            return $"{asianPlaces[asianPlacePick]} is the place to go!";
        }
        else if(asianIndianOrMexican.ToLower() == "indian")
        {
            string[] indianPlaces = { "Tandoori Nights", "Swagat", "Shan-E-Punjab", "Royal Inida Cuisine", "Curry on Wheels", "Maharaja", "Little Lahore", "Nyla's Kitchen", "Indian Express Rasoi", "Dhaba Indian Cuisine" };
            Random indianPick = new Random();
            var indianPlacePick = indianPick.Next(0, indianPlaces.Length);
            return $"{indianPlaces[indianPlacePick]} is the place to go!";
        }
        else if(asianIndianOrMexican.ToLower() == "mexican")
        {
            string[] mexicanPlaces = { "Tacos la Chapala", "Xochimilco", "La Mayita", "Tacos la Palmita", "Unica", "Nena's", "Casa Flores", "Las Palmas", "La Cantina", "Tepa's Taqueria" };
            Random mexicanPick = new Random();
            var mexicanPlacePick = mexicanPick.Next(0, mexicanPlaces.Length);
            return $"{mexicanPlaces[mexicanPlacePick]} is the place to go!";
        }
        else
        {
            return "Please pick from Asian, Indian, or Mexican.";
        }
    }
}
