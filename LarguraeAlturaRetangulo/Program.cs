/* Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
como mostrado no projeto ao lado */
using LarguraeAlturaRetangulo;
using System.Globalization;

namespace MyNamespace {
	class MyClass {
		static	void Main(string[] args) {

			Retangulo ret = new Retangulo();

			Console.WriteLine("Digite os valores Para lagura e Altura:");
			ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("AREA " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("PERIMETRO " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("DIAGONAL " + ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));


			
		}

	}

}
