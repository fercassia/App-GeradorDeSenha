using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGeradorSenhaDesktop
{
  public class GeradorSenha
  {
    private const int _senhaTamanho = 16;
    private const string charactersPermitidosParaSenha = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!?@#$%&*()-_><[]{}";
    public string GerarSenha()
    {
      var random = new Random();      

      var senhaConjunto = new char[_senhaTamanho];

      for(int i = 0; i < _senhaTamanho; i++)
      {
        senhaConjunto[i] = charactersPermitidosParaSenha[random.Next(0, charactersPermitidosParaSenha.Length)];
      }
      var senhaGerada = new string(senhaConjunto);

      return senhaGerada;
    }
  }
}
