using CP2.Architecture;
using CP2.Architecture.Providers;
using CP2.COR;
using CP2.Data.Global;
using CP2.Data.Models;
using System.Text.Json;
using System.Linq;  

namespace CP2.Core;

public interface IRoomsBusiness
{
    Task<bool> SolutionIndexAsync(string code);
    Task<bool> SolutionRoom1Async(int num);
    Task<bool> SolutionRoom2Async(string code);
    Task<bool> SolutionRoom3Async(string code);
    Task<bool> SolutionRoom4Async(string code);
    Task<bool> SolutionRoom5Async();
    Task<bool> SolutionRoom6Async(int num);
    Task<bool> SolutionRoom7Async(string code);
    Task<bool> SolutionRoom8Async();
    Task<bool> SolutionRoom9Async(string code);
    Task<bool> SolutionRoom10Async(string code);
    Task<bool> SolutionRoom11Async(string code);
    Task<bool> SolutionRoom12Async(string code);
    Task<bool> SolutionRoom13Async(string code);
    Task<bool> SolutionRoom14Async(string code);
    Task<bool> CanExitTheRoomsAsync(string code);
}

public class RoomsBusiness(
    IRestProvider restProvider,
    SecureHashService secureHashService,
    FoodbankContext db,
    IReadOnlyDictionary<int, string> roomConfigs) : RoomsBase(restProvider, secureHashService, roomConfigs), IRoomsBusiness
{
    private readonly IRestProvider _restProvider = restProvider;
    private readonly FoodbankContext db = db;
    public async Task<bool> SolutionTestAsync(string code)
    {
        // solucion aqui
        code = "Test";


        // codiguito aqui
        // lalalala lalalala
        // code = resultado de lalalal

        var resultHash = Evaluate(0, code);
        var resultApi = await CallApiAsync("test", code);
        return (resultHash && resultApi);
    }

   public async Task<bool> SolutionIndexAsync(string code)
        //EGRZKVQ
{

  var chars = code.ToCharArray();

  Array.Sort(chars);


  string? validCandidate = null;


  while (true)

  {

    var candidate = new string(chars);


    if (Evaluate(0, candidate))

    {

      validCandidate = candidate;

      break;

    }


    int i = chars.Length - 2;

    while (i >= 0 && chars[i] >= chars[i + 1])
      i--;
    if (i < 0)
      break;
    int j = chars.Length - 1;

    while (chars[j] <= chars[i])
                 
      j--;


    (chars[i], chars[j]) = (chars[j], chars[i]);

    Array.Reverse(chars, i + 1, chars.Length - (i + 1));

  }


  if (validCandidate == null)

    return false;


        //var resultApi = await CallApiAsync("0", validCandidate);
   return Evaluate(0, validCandidate);

        //return true;

}

    public async Task<bool> SolutionRoom1Async(int x)
    {
        // resuelven 
       // 74921343
        var resultHash = Evaluate(1, "x");
       // var resultApi = await CallApiAsync("test", "x");
        return Evaluate(1, x.ToString()); 
    }

    public async Task<bool> SolutionRoom2Async(string code)
    {  
        // SOLID
        return Evaluate(2, code); // Placeholder logic
    }

    public async Task<bool> SolutionRoom3Async(string code)
    {
        // Alvaro Miranda
        //var key = Environment.GetEnvironmentVariable("SECRET_KEY");
        var key = "E4A1F9B7C32D8F64A9F1C0D3B7E2A6CC4F18B92ED0C4A7F1D3B89C6A5F2E1D44";
        var service = new SecureHashService(key);
        var result = service.Hash(code);
        var final = Evaluate(3, result);
        //var final = true;
        return final;
    }

    public async Task<bool> SolutionRoom4Async(string code)
    {
        //ABSTRACCION N15X15
        //ENCAPSULAMIENTO Y1L14
        //HERENCIA X6X13
        //POLIMORFISMO A1L12

        //var puzzle = await JsonProvider.DeserializeAsync<PuzzleViewModel>(code);
        var options = new JsonSerializerOptions

        {
            PropertyNameCaseInsensitive = true
        };

        PuzzleViewModel puzzle = JsonSerializer.Deserialize<PuzzleViewModel>(code, options);
        return Evaluate(4, puzzle.ToString()); // Placeholder logic
    }

    public async Task<bool> SolutionRoom5Async()
    {
        //linq
        var result =  db.FoodItems
        .Where(item =>
            item.Ingredients.Contains("game") &&
            item.Price >= 6.5m &&
            item.Price <= 7m &&
            (item.IsPerishable ?? false))
        .Select(item => item.Ingredients)
        .FirstOrDefault();
    
        return Evaluate(5, result);
    }

    public async Task<bool> SolutionRoom6Async(int num)
    {
        var service = new ValueService();
        var handlerA = new MultiplyAHandler(service);
        var handlerB = new MultiplyBHandler(service);
        var handlerC = new MultiplyCHandler(service);
        var final = new FinalComparisonHandler(service);

        handlerA.SetNext(handlerB).SetNext(handlerC).SetNext(final);

        double initialValue = 1;
        var result = handlerA.Handle(initialValue);

        var code = result.ToString();
        var resultHash = Evaluate(6, code);
        return resultHash;
    }

    public async Task<bool> SolutionRoom7Async(string code)
    {
        // lalala 
        return Evaluate(7, code); // Placeholder logic
    }

    public static int SingleNumber(int[] nums)
    {
        int ones = 0, twos = 0;

        foreach (int num in nums)
        {
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }

        return ones;
    }

    public async Task<bool> SolutionRoom8Async()
    {
        //2
        int[] arr = new int[] { 3, 3, 6, 22, 9, 7, 1, 6, 4, 9, 3, 6, 4, 1, 1, 2, 4, 22, 22, 7, 7, 9 };

       var result = SingleNumber(arr);
       var final  = Evaluate(8, $"{result}");

        return final;
    }

    public async Task<bool> SolutionRoom9Async(string code)
    {
        // dependency injection
        return Evaluate(9, code);
    }

    public async Task<bool> SolutionRoom10Async(string code)
    {
        // "el profe"
        var result = Evaluate(11, code);
        return result; // Placeholder logic
    }
    public async Task<bool> SolutionRoom11Async(string code)
    {
        // N0T_S0_WH1TE
        return Evaluate(12, code); // Placeholder logic
    }
    public async Task<bool> SolutionRoom12Async(string code)
    {
        // api , json, title
        // at nam consequ.....
        return Evaluate(13, code); // Placeholder logic
    }
    public async Task<bool> SolutionRoom13Async(string code)
    {
        // binarios IP 192.178.50.46
        // google.com
        return Evaluate(14, code); // Placeholder logic
    }
    public async Task<bool> SolutionRoom14Async(string code)
    {
        // principio de solid
        // liskov
        return Evaluate(15, code); // Placeholder logic
    }

    public async Task<bool> CanExitTheRoomsAsync(string code)
    {
        // solucion aqui 
        //exit
        return Evaluate(10, code); // Placeholder logic
    }
}
