//struct /// Metodos privados

var endereco = new Endereco("Rua Amanari", "420", "São Paulo", "SP");

Console.WriteLine(endereco.EnderecoCompleto());
Console.WriteLine(endereco.Valido);

struct Endereco{

	public string Rua;

	public string Numero;

	public string Cidade;

	public string Estado;

	public bool Valido;

	
	public Endereco(string rua, string numero, string cidade, string estado) {
		Rua = rua;
		Numero = numero;
		Cidade = cidade;
		Estado = estado;
		Valido = false;
		Validar();
		
	}

	// metodos privados

	private void Validar() {
		if(!string.IsNullOrEmpty(Rua) && !string.IsNullOrEmpty(Numero) && !string.IsNullOrEmpty(Cidade) && !string.IsNullOrEmpty(Estado))
			Valido = true;
			
	}

	
	public string EnderecoCompleto() {
		return $"{Rua}, {Numero}, {Cidade}, {Estado}";
	}
	

}
