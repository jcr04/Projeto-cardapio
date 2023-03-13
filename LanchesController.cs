[Route("api/[controller]")]
[ApiController]
public class LanchesController : ControllerBase
{
    private readonly List<Lanche> _lanches = new List<Lanche>
    {
        new Lanche { Id = 1, Nome = "X-Burger", Descricao = "Pão, carne, queijo, alface e tomate", Preco = 8.99m, ImagemUrl = "https://www.example.com/images/x-burger.jpg" },
        new Lanche { Id = 2, Nome = "X-Salada", Descricao = "Pão, carne, queijo, alface, tomate e maionese", Preco = 10.99m, ImagemUrl = "https://www.example.com/images/x-salada.jpg" },
        new Lanche { Id = 3, Nome = "X-Tudo", Descricao = "Pão, carne, queijo, alface, tomate, maionese, presunto e ovo", Preco = 12.99m, ImagemUrl = "https://www.example.com/images/x-tudo.jpg" },
    };

    // GET api/lanches
    [HttpGet]
    public ActionResult<IEnumerable<Lanche>> Get()
    {
        return _lanches;
    }

    // GET api/lanches/5
    [HttpGet("{id}")]
    public ActionResult<Lanche> Get(int id)
    {
        var lanche = _lanches.FirstOrDefault(l => l.Id == id);
        if (lanche == null)
        {
            return NotFound();
        }
        return lanche;
    }
}
